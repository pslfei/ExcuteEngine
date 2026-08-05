using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace DataCommSisKaT
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            //double timestamp = 1765704944.8812022;

            //// 1. 定义 Unix 纪元时间 (1970-01-01 UTC)
            //DateTime epoch = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            //// 2. 加上秒数
            //DateTime utcDate = epoch.AddSeconds(timestamp);

            //// 3. (可选) 转换为本地时间
            //DateTime localDate = utcDate.ToLocalTime();

            // 使用通用主机创建器来构建和运行应用
            await CreateHostBuilder(args).Build().RunAsync();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                // 步骤 1: 配置应用程序的配置文件来源
                .ConfigureAppConfiguration((hostingContext, config) =>
                {
                    config.SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                          .AddJsonFile("Config.json", optional: false, reloadOnChange: true);
                })
                // 步骤 2: 配置所有需要依赖注入的服务
                .ConfigureServices((hostContext, services) =>
                {
                    // 从主机上下文中获取已经加载好的配置
                    IConfiguration configuration = hostContext.Configuration;

                    // 将整个配置读取并绑定到 ConfigInfo 类的实例上
                    var configInfo = configuration.Get<ConfigInfo>();
                    if (configInfo == null)
                    {
                        // 如果绑定失败，最好是直接抛出异常让程序启动失败，以便及早发现问题
                        throw new InvalidOperationException("无法从 Config.json 绑定配置，请检查文件是否存在或格式是否正确。");
                    }
                    else
                    {
                        string runSystem = "";
                        if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
                        {
                            runSystem = "WindowsX64";
                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.X64)
                        {
                            runSystem = "Linux64";
                            configInfo.mysqlConn = configInfo.mysqlConn.TrimEnd(';') + ";AllowPublicKeyRetrieval=True";
                            configInfo.mysqlConnWay = configInfo.mysqlConnWay.TrimEnd(';') + ";AllowPublicKeyRetrieval=True";
                            configInfo.mysqlEnergyanalySis = configInfo.mysqlEnergyanalySis.TrimEnd(';') + ";AllowPublicKeyRetrieval=True";

                        }
                        else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux) && RuntimeInformation.ProcessArchitecture == Architecture.Arm64)
                        {
                            runSystem = "LinuxArm64";
                            configInfo.mysqlConn = configInfo.mysqlConn.Replace("sslMode=None", "sslMode=Required");
                            configInfo.mysqlConnWay = configInfo.mysqlConnWay.Replace("sslMode=None", "sslMode=Required");
                            configInfo.mysqlEnergyanalySis = configInfo.mysqlEnergyanalySis.Replace("sslMode=None", "sslMode=Required");
                        }

                        Console.WriteLine($"运行平台：{runSystem}");
                    }
                    //// 添加调试日志，检查配置是否成功绑定
                    //Console.WriteLine($"配置成功加载，TpriServer端口: {configInfo.TpriServer?.Port ?? "未配置"}");
                    //Console.WriteLine($"TpriServer启用状态: {configInfo.enableTpriServer}");

                    // 将这个配置实例注册为单例，这样整个应用都可以注入和使用它
                    services.AddSingleton(configInfo);

                    // 将 ExcuteEngine 注册为单例。
                    // 它的实例将在第一次被请求时创建（即在创建 ApiServerHostedService 时）
                    services.AddSingleton<ExcuteEngine>();

                    // 注册其他服务
                    services.AddTransient<IInitServer, InitServer>();

                    // 将你的后台 API 服务注册为托管服务。
                    // 主机启动时会自动创建并启动这个服务的实例。
                    services.AddHostedService<ApiServerHostedService>();

                    //// 根据配置决定是否注册 TpriServer Web API 托管服务
                    //if (configInfo.enableTpriServer)
                    //{
                    //    Console.WriteLine("TpriServer 已启用，正在注册托管服务...");
                    //    services.AddHostedService<TpriServerHostedService>();
                    //}
                    //else
                    //{
                    //    Console.WriteLine("TpriServer 已禁用，跳过注册托管服务。");
                    //}
                });
    }
}
