using System.Collections;
using System.Diagnostics;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.Serialization;
using DCSCommon;
using EngineCore;
using EngineCore.Models;
using FunctionCode;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TDServer.Service;
using AlarmController = TDServer.Service.Controller;

// 不启动生产执行引擎、不读取本地配置、不连接真实数据库。
// 反射仅用于访问事件队列和纯事件处理方法，避免扩大产品公共API。
var flags = BindingFlags.NonPublic | BindingFlags.Instance;
var queueField = typeof(AlarmController).GetField("pendingFaultEvents", flags)!;
var eventType = typeof(AlarmController).GetNestedType("FaultEvent", BindingFlags.NonPublic)!;
var scanMethod = typeof(AlarmController).GetMethod("ProcessFaultInfoList", flags)!;
var resumedMethod = typeof(AlarmController).GetMethod("OnFaultResumed", flags)!;
var applyMethod = typeof(AlarmController).GetMethod("ApplyFaultEvents", BindingFlags.Static | BindingFlags.NonPublic)!;
var cacheField = typeof(ExcuteEngine).GetField("suspendedFaultCodes", BindingFlags.Static | BindingFlags.NonPublic)!;
var commitMethod = typeof(AlarmController).GetMethod("CommitPendingFaultEvents", flags)!;
var changeMethod = typeof(ExcuteEngine).GetMethod("ChangeFaultSuspension", BindingFlags.Static | BindingFlags.NonPublic)!;
int assertions = 0;

void Check(bool condition, string message)
{
    Interlocked.Increment(ref assertions);
    if (!condition) throw new InvalidOperationException(message);
}

AlarmController CreateController(Function block, string name, int code)
{
    var controller = (AlarmController)FormatterServices.GetUninitializedObject(typeof(AlarmController));
    block.InstanceName = name;
    controller.FunctionInstanceDict = new() { [name] = block };
    controller.FaultInfoList = new()
    {
        [name] = new AlarmController.FaultInfo { Code = code, Source = name }
    };
    queueField.SetValue(controller, Activator.CreateInstance(queueField.FieldType));
    foreach (var nameToInitialize in new[] { "runSync", "faultCommitSync" })
        typeof(AlarmController).GetField(nameToInitialize, flags)!.SetValue(controller, new object());
    ExcuteEngine.controllerList = new() { controller };
    cacheField.SetValue(null, new HashSet<int>());
    return controller;
}

IList Queue(AlarmController controller) => (IList)queueField.GetValue(controller)!;
void Scan(AlarmController controller) => scanMethod.Invoke(controller, null);
void Suspend(int code) => ((HashSet<int>)cacheField.GetValue(null)!).Add(code);
void Resume(AlarmController controller, int code)
{
    ((HashSet<int>)cacheField.GetValue(null)!).Remove(code);
    resumedMethod.Invoke(controller, new object[] { code });
}
List<FaultDiagnosis> Apply(List<FaultDiagnosis> records, object events) =>
    (List<FaultDiagnosis>)applyMethod.Invoke(null, new[] { records, events })!;
object Events(params (int Code, string Source, bool Active, DateTime Time)[] values)
{
    var array = Array.CreateInstance(eventType, values.Length);
    for (int i = 0; i < values.Length; i++)
    {
        var value = values[i];
        array.SetValue(Activator.CreateInstance(eventType,
            value.Code, value.Source, value.Active, value.Time), i);
    }
    return array;
}

void Commit(AlarmController target, Action<object> persist)
{
    var delegateType = commitMethod.GetParameters()[0].ParameterType;
    var parameter = Expression.Parameter(delegateType.GenericTypeArguments[0]);
    var callback = Expression.Lambda(delegateType,
        Expression.Invoke(Expression.Constant(persist), Expression.Convert(parameter, typeof(object))), parameter).Compile();
    commitMethod.Invoke(target, new object[] { callback });
}

bool Change(int code, int status, Func<bool> persist) =>
    (bool)changeMethod.Invoke(null, new object[] { code, status, persist })!;

Task Dedicated(Action action) => Task.Factory.StartNew(action,
    CancellationToken.None, TaskCreationOptions.LongRunning, TaskScheduler.Default);

// 用受控阻塞替代数据库/慢算法，证明查询和确认能在阻塞释放前完成。
void AssertResponsive(Action action, string description)
{
    var elapsed = Stopwatch.StartNew();
    var operation = Dedicated(action);
    Check(operation.Wait(TimeSpan.FromSeconds(2)), description + "不应等待慢操作释放");
    operation.GetAwaiter().GetResult();
    Console.WriteLine($"RESPONSIVE: {description}: {elapsed.Elapsed.TotalMilliseconds:F1}ms");
}

var block = new FaultOut { FaultCode = 11 };
var controller = CreateController(block, "fault-11", 11);
block.Implement(null);
Scan(controller);
Check(block.AlarmState == 1 && ExcuteEngine.GetFaultList().Count == 0, "初始状态应正常");
block.IN[0] = true;
block.Implement(null);
Scan(controller);
Check(block.AlarmState == 8 && Queue(controller).Count == 1, "报警应未确认并产生一个事件");
Check(ExcuteEngine.SetFaultOutFcAck("fault-11") && block.AlarmState == 4, "确认应立即更新状态");
Check(ExcuteEngine.GetFaultList().Single().AlarmState == 4, "列表应立即反映确认");
block.IN[0] = false;
block.Implement(null);
Scan(controller);
Check(block.AlarmState == 1 && ExcuteEngine.GetFaultList().Count == 0, "已确认报警恢复后应消失");
block.IN[0] = true;
block.Implement(null);
Scan(controller);
Check(block.AlarmState == 8, "再次发生必须重新未确认");
block.IN[0] = false;
block.Implement(null);
Scan(controller);
block.Runable = false;
Check(block.AlarmState == 2, "未确认报警恢复后应保留");
Check(ExcuteEngine.SetFaultOutFcAck("fault-11") && ExcuteEngine.GetFaultList().Count == 0,
    "停用块确认后也必须立即从列表消失");
Check(!ExcuteEngine.SetFaultOutFcAck("missing"), "不存在目标不能确认成功");

var dev = new DevAlarm { FaultCode = 22 };
controller = CreateController(dev, "dev-22", 22);
dev.faultOut.IN[0] = true;
dev.faultOut.Implement(null);
dev.OUT[0] = dev.faultOut.OUT;
Scan(controller);
Check(ExcuteEngine.GetFaultList().Single().AlarmState == 8, "DevAlarm应暴露内部未确认状态");
Check(ExcuteEngine.SetFaultOutFcAck("dev-22") && dev.faultOut.AlarmState == 4,
    "DevAlarm确认应传递到内部块");
var snapshot = ExcuteEngine.GetFaultList();
controller.FaultInfoList["dev-22"].AlarmState = 1;
Check(snapshot.Single().AlarmState == 4, "列表必须返回独立快照");
controller.FunctionInstanceDict["unsupported"] = new UnsupportedBlock();
Check(!ExcuteEngine.SetFaultOutFcAck("unsupported"), "不支持确认的块必须失败");

block = new FaultOut { FaultCode = 33 };
controller = CreateController(block, "fault-33", 33);
Suspend(33);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
Check(Queue(controller).Count == 0 && !block.NeedOut, "挂起报警应抑制并消费事件");
Check(controller.FaultInfoList["fault-33"].Status == 1 && ExcuteEngine.GetFaultList().Count == 0,
    "挂起仍跟踪真实状态但不返回");
block.IN[0] = false;
block.Implement(null);
Scan(controller);
Check(Apply(new(), Queue(controller)).Count == 0, "挂起期间发生恢复不得新增记录");
Queue(controller).Clear();
Resume(controller, 33);
Check(Queue(controller).Count == 0, "已恢复时解除挂起不得补录");

Suspend(33);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
var resumedAfter = DateTime.Now;
Resume(controller, 33);
var resumedRecords = Apply(new(), Queue(controller));
Check(resumedRecords.Count == 1 && resumedRecords[0].BeginTime >= resumedAfter,
    "解除挂起仍活动应从解除时间开始记录");
Check(ExcuteEngine.GetFaultList().Count == 1, "解除挂起应恢复实时展示");

block = new FaultOut { FaultCode = 34 };
controller = CreateController(block, "fault-34", 34);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
var recordedBeforeSuspension = Apply(new(), Queue(controller));
Queue(controller).Clear();
Suspend(34);
block.IN[0] = false;
block.Implement(null);
Scan(controller);
Check(Apply(recordedBeforeSuspension, Queue(controller)).Count == 0
    && recordedBeforeSuspension.Single().EndTime != DateTime.MinValue,
    "挂起前已入库报警必须在挂起期间恢复时正常结束");

var start = new DateTime(2026, 10, 9, 10, 0, 0);
var old = new FaultDiagnosis { FaultCode = 44, Source = "f", BeginTime = start.AddHours(-1), EndTime = start.AddMinutes(-30) };
var open = new FaultDiagnosis { FaultCode = 44, Source = "f", BeginTime = start };
var records = new List<FaultDiagnosis> { old, open };
Apply(records, Events((44, "f", false, start.AddMinutes(1))));
Check(open.EndTime == start.AddMinutes(1) && old.EndTime == start.AddMinutes(-30),
    "恢复只关闭未结束记录，不能修改历史记录");
Check(Apply(records, Events((44, "f", false, start.AddMinutes(2)))).Count == 0
    && open.EndTime == start.AddMinutes(1), "重复恢复不得篡改已结束记录");
var otherSource = new FaultDiagnosis { FaultCode = 44, Source = "other", BeginTime = start };
Apply(new() { otherSource }, Events((44, "f", false, start.AddMinutes(1))));
Check(otherSource.EndTime == DateTime.MinValue, "同码其他来源不能误关闭");
var recoveredBatch = Apply(new(), Events(
    (55, "f", true, start), (55, "f", false, start.AddSeconds(1)),
    (55, "f", true, start.AddSeconds(2)), (55, "f", false, start.AddSeconds(3))));
Check(recoveredBatch.Count == 2 && recoveredBatch[0].EndTime == start.AddSeconds(1)
    && recoveredBatch[1].EndTime == start.AddSeconds(3), "积压事件需按顺序保留多个报警区间");
var dedupOpen = new FaultDiagnosis { FaultCode = 55, Source = "f", BeginTime = start };
Check(Apply(new() { dedupOpen }, Events((55, "f", true, start.AddSeconds(2)))).Count == 0,
    "已有活动记录时解除挂起不得重复创建");

block = new FaultOut { FaultCode = 66 };
controller = CreateController(block, "fault-66", 66);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
ExcuteEngine.configInfo = new ConfigInfo { mysqlConn = "invalid-connection-string" };
for (int attempt = 0; attempt < 2; attempt++)
{
    bool failed = false;
    try { controller.InsertFaultData(); }
    catch (ArgumentException) { failed = true; }
    Check(failed && Queue(controller).Count == 1, "存储失败必须保留事件且不重复追加");
}
block.IN[0] = false;
block.Implement(null);
Scan(controller);
var retryRecords = Apply(new(), Queue(controller));
Check(retryRecords.Count == 1 && retryRecords[0].EndTime != DateTime.MinValue,
    "开始写入失败后恢复也必须保留完整区间");

// 验证参数错误在访问数据库前被拒绝。
var api = new HomeController();
Check(api.SetFaultSuspended(66, 2) is BadRequestObjectResult, "非法挂起状态必须400");
Check(api.SetFaultOutFcAck("missing") is NotFoundObjectResult, "不存在的确认目标必须404");
Check(api.SetFaultOutFcAck(" ") is BadRequestObjectResult, "空目标必须400");
Check(api.SetFaultSuspended(66, 1) is ObjectResult { StatusCode: 500 },
    "保存挂起状态失败不能返回成功");
Check(!((HashSet<int>)cacheField.GetValue(null)!).Contains(66),
    "保存失败不能改变挂起缓存");
Check(api.GetSuspendedFaultCode() is ObjectResult { StatusCode: 500 },
    "挂起清单查询失败不能伪装成空列表");

using (var context = new WarnContext("Server=localhost;Database=offline_model;User ID=unused;Password=unused"))
{
    var entity = context.Model.FindEntityType(typeof(Troubleshooting))!;
    Check(entity.FindProperty(nameof(Troubleshooting.IsAlarmSuspended))!.GetDefaultValue() is 0,
        "挂起字段模型默认值应为0");
}

var controllerForHttp = controller;
var blockForHttp = block;
var slowBlock = new SlowBlock();
var slowController = CreateController(slowBlock, "slow", 70);
var calculationsField = typeof(AlarmController).GetField("calculatedLAList", flags)!;
calculationsField.SetValue(slowController, Activator.CreateInstance(calculationsField.FieldType));
slowController.AlarmWarnInfoDict = new();
ExcuteEngine.modelWarnPoint = new();
ExcuteEngine.warnRValueDict = new();
var fastFault = new FaultOut { FaultCode = 71, InstanceName = "fast" };
slowController.FunctionInstanceDict["fast"] = fastFault;
slowController.FaultInfoList["fast"] = new() { Code = 71, Source = "fast" };
var running = Dedicated(slowController.Run);
try
{
    Check(slowBlock.Entered.Wait(TimeSpan.FromSeconds(2)), "慢算法必须已经占用控制器周期");
    AssertResponsive(() => ExcuteEngine.GetFaultList(), "慢算法期间读取实时列表");
    AssertResponsive(() => Check(ExcuteEngine.SetFaultOutFcAck("fast"), "其他块确认应成功"),
        "慢算法期间确认其他故障块");
    AssertResponsive(() => Check(Change(71, 1, () => true), "挂起应发布成功"), "慢算法期间发布挂起状态");
    Check(!running.IsCompleted, "响应完成时慢算法应仍处于阻塞状态");
}
finally
{
    slowBlock.Release.Set();
    Check(running.Wait(TimeSpan.FromSeconds(2)), "慢算法释放后控制器应完成");
}

block = new FaultOut { FaultCode = 72 };
controller = CreateController(block, "fault-72", 72);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
using (var entered = new ManualResetEventSlim())
using (var release = new ManualResetEventSlim())
{
    var rows = new List<FaultDiagnosis>();
    var saving = Dedicated(() => Commit(controller, batch =>
    {
        entered.Set();
        if (!release.Wait(TimeSpan.FromSeconds(10))) throw new TimeoutException("测试提交未释放");
        Apply(rows, batch);
    }));
    try
    {
        Check(entered.Wait(TimeSpan.FromSeconds(2)), "提交必须已进入锁外持久化阶段");
        AssertResponsive(() => ExcuteEngine.GetFaultList(), "慢提交期间读取实时列表");
        AssertResponsive(() => Check(ExcuteEngine.SetFaultOutFcAck("fault-72"), "提交期间可确认"),
            "慢提交期间确认报警");
        block.IN[0] = false;
        block.Implement(null);
        Scan(controller);
        block.IN[0] = true;
        block.Implement(null);
        Scan(controller);
        Check(Queue(controller).Count == 3 && !saving.IsCompleted, "提交期间应继续接收后续事件");
    }
    finally { release.Set(); }
    Check(saving.Wait(TimeSpan.FromSeconds(2)), "提交释放后应完成");
    Check(Queue(controller).Count == 2 && rows.Count == 1, "提交成功只能移除原批次，保留新增事件");
    bool failed = false;
    try { Commit(controller, _ => throw new InvalidOperationException("模拟存储失败")); }
    catch (TargetInvocationException ex) when (ex.InnerException is InvalidOperationException) { failed = true; }
    Check(failed && Queue(controller).Count == 2, "批次失败应完整保留，不能清空队列");
    Commit(controller, batch => Apply(rows, batch));
    Check(Queue(controller).Count == 0 && rows.Count == 2 && rows[0].EndTime != DateTime.MinValue,
        "重试应按序关闭旧记录并创建新活动记录");
}

using (var entered = new ManualResetEventSlim())
using (var release = new ManualResetEventSlim())
{
    var updating = Dedicated(() => Change(72, 1, () =>
    {
        entered.Set();
        Thread.Sleep(500); // 模拟截图中的500ms数据库等待，验证其不占用状态锁。
        if (!release.Wait(TimeSpan.FromSeconds(10))) throw new TimeoutException("测试挂起写入未释放");
        return true;
    }));
    try
    {
        Check(entered.Wait(TimeSpan.FromSeconds(2)), "挂起写入必须已进入数据库阶段");
        AssertResponsive(() => Check(ExcuteEngine.GetFaultList().Count == 1, "保存前旧状态仍生效"),
            "慢挂起写入期间读取实时列表");
        AssertResponsive(() => ExcuteEngine.SetFaultOutFcAck("fault-72"), "慢挂起写入期间确认报警");
        Check(!updating.IsCompleted, "保存完成前不能提前发布挂起状态");
    }
    finally { release.Set(); }
    Check(updating.Wait(TimeSpan.FromSeconds(2)) && ExcuteEngine.GetFaultList().Count == 0,
        "保存成功后应原子发布挂起状态");
}

block = new FaultOut { FaultCode = 73 };
controller = CreateController(block, "fault-73", 73);
block.IN[0] = true;
block.Implement(null);
Scan(controller);
using (var entered = new ManualResetEventSlim())
using (var secondStarted = new ManualResetEventSlim())
using (var release = new ManualResetEventSlim())
{
    int storeCalls = 0;
    Action<object> store = _ =>
    {
        Interlocked.Increment(ref storeCalls);
        entered.Set();
        if (!release.Wait(TimeSpan.FromSeconds(10))) throw new TimeoutException("并发提交测试未释放");
    };
    var first = Dedicated(() => Commit(controller, store));
    Check(entered.Wait(TimeSpan.FromSeconds(2)), "首个批次必须进入提交阶段");
    var second = Dedicated(() =>
    {
        secondStarted.Set();
        Commit(controller, store);
    });
    try
    {
        Check(secondStarted.Wait(TimeSpan.FromSeconds(2)), "第二提交线程必须已启动");
        Check(!second.Wait(TimeSpan.FromMilliseconds(100)), "同一控制器不能并发提交同一批次");
    }
    finally { release.Set(); }
    Check(Task.WaitAll(new[] { first, second }, TimeSpan.FromSeconds(2))
        && storeCalls == 1 && Queue(controller).Count == 0, "同一批次只能成功提交一次");
}

ExcuteEngine.controllerList = new() { controllerForHttp };
cacheField.SetValue(null, new HashSet<int>());
controller = controllerForHttp;
block = blockForHttp;

var builder = WebApplication.CreateBuilder(new WebApplicationOptions
{
    Args = Array.Empty<string>(),
    ContentRootPath = AppContext.BaseDirectory
});
builder.Logging.ClearProviders();
builder.WebHost.UseUrls("http://127.0.0.1:0");
builder.Services.AddControllers().AddApplicationPart(typeof(HomeController).Assembly);
await using (var app = builder.Build())
{
    app.MapControllers();
    await app.StartAsync();
    try
    {
        var address = app.Services.GetRequiredService<IServer>()
            .Features.Get<IServerAddressesFeature>()!.Addresses.Single();
        using var http = new HttpClient { BaseAddress = new Uri(address) };
        async Task Expect(string method, string path, int status)
        {
            using var request = new HttpRequestMessage(new HttpMethod(method), path);
            using var response = await http.SendAsync(request);
            Check((int)response.StatusCode == status, $"HTTP {method} {path} 应返回 {status}，实际 {(int)response.StatusCode}");
        }
        await Expect("GET", "/api/Home/GetFaultList", 200);
        await Expect("POST", "/api/Home/SetFaultSuspended?faultCode=66", 400);
        await Expect("POST", "/api/Home/SetFaultSuspended?status=1", 400);
        await Expect("POST", "/api/Home/SetFaultSuspended?faultCode=66&status=2", 400);
        await Expect("POST", "/api/Home/SetFaultOutFcAck?algName=missing", 404);
        await Expect("POST", "/api/Home/SetFaultOutFcAck?algName=fault-66", 200);
        await Expect("GET", "/api/Home/SetFaultOutFcAck?algName=fault-66", 405);
        await Expect("POST", "/api/Home/SetFaultSuspended?faultCode=66&status=1", 500);
        await Expect("GET", "/api/Home/SetFaultSuspended?faultCode=66&status=1", 405);
        await Expect("GET", "/api/Home/GetSuspendedFaultCode", 500);
    }
    finally
    {
        await app.StopAsync();
    }
}

Console.WriteLine($"PASS: {assertions} fault alarm regression assertions; isolated HTTP host stopped; no production engine or real database started.");

sealed class UnsupportedBlock : Function
{
    protected override void Run(ICommand cmd) { }
}

sealed class SlowBlock : Function
{
    public ManualResetEventSlim Entered { get; } = new();
    public ManualResetEventSlim Release { get; } = new();
    protected override void Run(ICommand cmd)
    {
        Entered.Set();
        if (!Release.Wait(TimeSpan.FromSeconds(10))) throw new TimeoutException("测试慢算法未释放");
    }
}
