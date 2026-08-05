using EngineCore;
using EngineCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDServer.Service
{
    public class DeviceRunCfgService
    {
        private static System.Timers.Timer deviceRunTimer;
        private static System.Timers.Timer flashResetTimer;
        private static DateTime lastFlashResetTime = DateTime.MinValue;

        // 全局变量：存储定时任务的最新执行结果
        public static ApiResponse LatestResult = new ApiResponse
        {
            Code = 200,
            Message = "尚未执行任务",
            Data = new List<ResultItem>()
        };

        /// <summary>
        /// 启动定时任务服务
        /// </summary>
        public static void Start()
        {
            Console.WriteLine("初次调用");

            //if (!ExcuteEngine.configInfo.enableDeviceRunCfg) return;

            // 1. 服务启动后立即执行一次计算，计算当前需要进行定期工作的设备
            _ = ExecuteRunStatuLogicAndUpdateGlobal();
            //ExecuteRunStatuLogicAndUpdateGlobal();

            // 2. 定时任务：每30分钟执行一次，每10分钟计算一次当前需要进行定期工作的设备，更新缓存
            deviceRunTimer = new System.Timers.Timer(10 * 60 * 1000); // 30分钟
            deviceRunTimer.Elapsed += async (sender, e) =>
            {
                await ExecuteRunStatuLogicAndUpdateGlobal();
            };
            deviceRunTimer.Start();

            // 3. 定时任务：每60分钟检查一次时间，在8点、16点、24点（交班时）执行flash置1
            flashResetTimer = new System.Timers.Timer(10 * 60 * 1000); // 10分钟
            flashResetTimer.Elapsed += async (sender, e) =>
            {
                await CheckAndResetFlash();
            };
            flashResetTimer.Start();
        }

        /// <summary>
        /// 停止定时任务服务
        /// </summary>
        public static void Stop()
        {
            deviceRunTimer?.Stop();
            deviceRunTimer?.Dispose();
            flashResetTimer?.Stop();
            flashResetTimer?.Dispose();
        }

        /// <summary>
        /// 执行业务逻辑并更新全局结果
        /// </summary>
        private static async Task ExecuteRunStatuLogicAndUpdateGlobal()
        {
            try
            {
                var result = CalculateRunStatu();
                LatestResult = result;//更新全局结果

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 完成计算，匹配到 {result.Total} 条数据");
            }
            catch (Exception ex)
            {
                var errorResult = new ApiResponse
                {
                    Code = 500,
                    Message = $"计算错误: {ex.Message}",
                    Data = new List<ResultItem>(),
                    Total = 0
                };
                LatestResult = errorResult;

                Console.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss} 计算出错: {ex.Message}");
            }
        }

        /// <summary>
        /// 检查时间并重置flash字段
        /// </summary>
        private static async Task CheckAndResetFlash()
        {
            var now = DateTime.Now;
            // 目标时间点：即0:00
            bool isTargetTime = (now.Hour == 0);

            // 避免同一小时内重复执行
            if (isTargetTime && (now - lastFlashResetTime).TotalMinutes >= 60)
            {
                try
                {
                    bool result = ResetAllFlash();

                    if (result)
                    {
                        // 记录执行时间
                        lastFlashResetTime = now;
                        Console.WriteLine($"{now:yyyy-MM-dd HH:mm:ss} 已完成flash字段重置");
                    }
                    else
                    {
                        Console.WriteLine($"{now:yyyy-MM-dd HH:mm:ss} flash重置失败");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"{now:yyyy-MM-dd HH:mm:ss} flash重置失败: {ex.Message}");
                }
            }
        }


        /// <summary>
        /// 获取最新的定时任务结果（从缓存获取）
        /// </summary>
        /// <returns></returns>
        public static ApiResponse GetRunStatus()
        {
            return LatestResult;
        }

        /// <summary>
        /// 计算当前需要进行定期工作的设备（内部方法）
        /// </summary>
        /// <returns></returns>
        private static ApiResponse CalculateRunStatu()
        {
            try
            {
                using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    var now = DateTime.Now;

                    // 判断单双月
                    var currentMonth = now.Month;
                    string currentMonth12 = currentMonth % 2 == 0 ? "双月" : "单月";

                    // 判断几日
                    var currentDay = now.Day;
                    string currentDay12 = $"{currentDay}";

                    // 判断周几
                    var currentDayOfWeek = (int)now.DayOfWeek;
                    string currentDayOfWeek12 = currentDayOfWeek switch
                    {
                        0 => "周日",
                        1 => "周一",
                        2 => "周二",
                        3 => "周三",
                        4 => "周四",
                        5 => "周五",
                        6 => "周六",
                        _ => "未知"
                    };

                    // 判断当前班次
                    string currentTeam;
                    int hour = now.Hour;
                    if (hour >= 0 && hour < 8)
                        currentTeam = "白班";
                    else if (hour >= 8 && hour < 16)
                        currentTeam = "中班";
                    else
                        currentTeam = "夜班";

                    // 查询设备配置
                    var devices = warnContext.deviceruncfg.ToList();

                    var result = new List<ResultItem>();

                    // 规则匹配
                    foreach (var device in devices.Where(d => d != null))
                    {
                        // 月规则匹配
                        bool monthMatch = (device.monthcfg == "每月") || (currentMonth12 == device.monthcfg);

                        // 日规则匹配
                        bool dayMatch = (device.daycfg == "每天") ||
                                    (currentDay12 == device.daycfg) ||
                                    (currentDayOfWeek12 == device.daycfg);

                        // 班组规则匹配
                        bool teamMatch = currentTeam == device.teamcfg;

                        // 筛选匹配项
                        if (monthMatch && dayMatch && teamMatch)
                        {
                            // 设置flash
                            //warnContext.Database.ExecuteSqlInterpolated($@"
                            //     UPDATE deviceruncfg 
                            //     SET flash = 1 
                            //     WHERE devicename = {device.devicename} AND dcsidx = {device.dcsidx}
                            // ");
                            result.Add(new ResultItem
                            {
                                DeviceName = device.devicename,
                                Operation = device.operation,
                                Dcsidx = device.dcsidx ?? 0,
                                Flash = device.flash ?? 0,
                                TargetPage = device.targetPage ?? 0
                            });
                        }
                    }

                    return new ApiResponse
                    {
                        Code = 200,
                        Data = result,
                        Total = result.Count,
                        Message = "执行成功"
                    };
                }
            }
            catch (Exception ex)
            {
                return new ApiResponse
                {
                    Code = 500,
                    Message = $"业务逻辑错误: {ex.Message}",
                    Data = new List<ResultItem>(),
                    Total = 0
                };
            }
        }

        /// <summary>
        /// 获取定时工作时间配置
        /// </summary>
        /// <returns></returns>
        public static List<TimeConfigItem> GetTimeCfg()
        {
            try
            {
                using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    var devices = warnContext.deviceruncfg.ToList();

                    var result = devices.Select(device => new TimeConfigItem
                    {
                        DeviceName = device.devicename,
                        Dcsidx = device.dcsidx?.ToString() ?? "0",
                        Operation = device.operation,
                        Month = device.monthcfg,
                        Day = device.daycfg,
                        Team = device.teamcfg,
                    }).ToList();

                    return result;
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"获取时间配置失败: {ex.Message}");
            }
        }

        /// <summary>
        /// 更新时间配置
        /// </summary>
        /// <param name="request">时间配置请求</param>
        /// <returns></returns>
        public static TimeConfigResponse UpdateTimeCfg(TimeConfigRequest request)
        {
            try
            {
                if (request?.Data == null || request.Data.Count == 0)
                {
                    return new TimeConfigResponse
                    {
                        Status = "error",
                        Message = "No data provided in request"
                    };
                }

                using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    foreach (var item in request.Data)
                    {
                        // 验证必填参数
                        if (string.IsNullOrEmpty(item.DeviceName) || string.IsNullOrEmpty(item.Month) ||
                            string.IsNullOrEmpty(item.Day) || string.IsNullOrEmpty(item.Team))
                        {
                            return new TimeConfigResponse
                            {
                                Status = "error",
                                Message = $"Missing required parameters for device: {item.DeviceName}"
                            };
                        }

                        // 查找并更新设备配置
                        var deviceConfig = warnContext.deviceruncfg
                            .FirstOrDefault(d => d.devicename == item.DeviceName &&
                                                d.dcsidx.ToString() == item.Dcsidx &&
                                                d.operation == item.Operation);

                        if (deviceConfig != null)
                        {
                            deviceConfig.monthcfg = item.Month;
                            deviceConfig.daycfg = item.Day;
                            deviceConfig.teamcfg = item.Team;
                            warnContext.deviceruncfg.Update(deviceConfig);
                        }
                    }

                    warnContext.SaveChanges();
                }

                // 更新配置后重新计算缓存
                _ = ExecuteRunStatuLogicAndUpdateGlobal();

                return new TimeConfigResponse
                {
                    Status = "success",
                    Message = "Data saved successfully"
                };
            }
            catch (Exception ex)
            {
                return new TimeConfigResponse
                {
                    Status = "error",
                    Message = $"Server error: {ex.Message}"
                };
            }
        }

        /// <summary>
        /// 更新flash状态
        /// </summary>
        /// <param name="request">flash更新请求</param>
        /// <returns></returns>
        public static TimeConfigResponse UpdateFlash(FlashUpdateRequest request)
        {
            try
            {
                if (request?.Data == null || request.Data.Count == 0)
                {
                    return new TimeConfigResponse
                    {
                        Status = "error",
                        Message = "No JSON data provided"
                    };
                }

                using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    foreach (var item in request.Data)
                    {
                        // 查找并更新设备flash状态
                        var deviceConfig = warnContext.deviceruncfg
                            .FirstOrDefault(d => d.devicename == item.DeviceName &&
                                                d.dcsidx == item.Dcsidx &&
                                                d.operation == item.Operation);

                        if (deviceConfig != null)
                        {
                            deviceConfig.flash = item.Flash;
                            warnContext.deviceruncfg.Update(deviceConfig);
                        }
                    }

                    warnContext.SaveChanges();
                }

                // 更新配置后重新计算缓存
                _ = ExecuteRunStatuLogicAndUpdateGlobal();

                return new TimeConfigResponse
                {
                    Status = "success",
                    Message = "Data saved successfully"
                };
            }
            catch (Exception ex)
            {
                return new TimeConfigResponse
                {
                    Status = "error",
                    Message = $"Server error: {ex.Message}"
                };
            }
        }

        /// <summary>
        /// 重置所有设备的flash状态为1（交班时调用）
        /// </summary>
        /// <returns></returns>
        public static bool ResetAllFlash()
        {
            try
            {
                using (var warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    var devices = warnContext.deviceruncfg.ToList();
                    foreach (var device in devices)
                    {
                        device.flash = 1;
                        warnContext.deviceruncfg.Update(device);
                    }
                    warnContext.SaveChanges();
                    // 更新配置后重新计算缓存
                    _ = ExecuteRunStatuLogicAndUpdateGlobal();
                    return true;
                }

            }
            catch (Exception)
            {
                return false;
            }
        }
    }

    #region 数据模型

    public class ResultItem
    {
        public string DeviceName { get; set; }
        public string Operation { get; set; }
        public long Dcsidx { get; set; }
        public long Flash { get; set; }
        public long TargetPage { get; set; }
    }

    // 定义响应模型
    public class ApiResponse
    {
        public int Code { get; set; }
        public List<ResultItem> Data { get; set; } = new List<ResultItem>();
        public int Total { get; set; }
        public string Message { get; set; }
    }

    // 时间配置请求
    public class TimeConfigRequest
    {
        public List<TimeConfigItem> Data { get; set; }
    }

    public class TimeConfigResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
    }

    // 设备定期执行的时间配置
    public class TimeConfigItem
    {
        public string DeviceName { get; set; }
        public string Month { get; set; }
        public string Day { get; set; }
        public string Team { get; set; }
        public string Dcsidx { get; set; }
        public string Operation { get; set; }
    }

    // Flash更新请求
    public class FlashUpdateRequest
    {
        public List<ResultItem> Data { get; set; }
    }

    #endregion
}
