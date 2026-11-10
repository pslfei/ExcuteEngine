using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Reflection;
using TDServer.Service.AgentV2;


namespace TDServer.Service
{
    public class InitServer : IInitServer
    {
        private const string CorsOrigins = "_myAllowSpecificOrigins"; // 定义 跨域
        private static readonly string? AssemblyName = typeof(InitServer).Assembly.GetName().Name;

        private readonly IConfiguration _agentConfiguration;

        /// <summary>复用主程序加载的 Config.json；冻结新版接口配置，避免运行中机组标识漂移。</summary>
        public InitServer(IConfiguration configuration)
        {
            _agentConfiguration = AgentApiConfiguration.CreateSnapshot(configuration, out var error);
            if (error != null)
                Console.Error.WriteLine($"新版智能体接口未启用：{error} 原接口和计算引擎不受此开关影响。");
        }

        public void Init(int port)
        {
            var builder = WebApplication.CreateBuilder();
            // 只覆盖 AgentApi 配置，不改变旧 API 的宿主配置、端口和数据库连接。
            builder.Configuration.AddConfiguration(_agentConfiguration);
            // 独立开关默认关闭；关闭时不注册任何 v2 控制器。
            bool agentEnabled = bool.TryParse(builder.Configuration["AgentApi:Enabled"], out var configuredEnabled) && configuredEnabled;
            // 添加日志记录器
            builder.Services.AddControllers()
                .AddApplicationPart(Assembly.Load(new AssemblyName(AssemblyName!)))
                .ConfigureApplicationPartManager(manager => manager.FeatureProviders.Add(new AgentControllerFeatureProvider(agentEnabled)));

            // 添加Swagger
            builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "性能计算API接口文档", Version = "v1" });
                if (agentEnabled)
                {

                    // 新旧接口合并到原文档，通过URL区分；开关关闭时仍移除新增控制器。
                    c.DocInclusionPredicate((documentName, api) => documentName == "v1");
                    string xmlPath = Path.Combine(AppContext.BaseDirectory, "TDServer.Service.xml");
                    if (File.Exists(xmlPath)) c.IncludeXmlComments(xmlPath, includeControllerXmlComments: true);
                }

                //   c.IncludeXmlComments(
                //    $"{Path.Combine(AppContext.BaseDirectory, $"{Assembly.GetExecutingAssembly().GetName().Name}.xml")}",
                //    true
                //);
            });

            //builder.Services.AddCorsSetup(CorsOrigins); // 跨域
            builder.Services.AddHttpClient(); //注入 httpclinet 用于调用外部API


            var app = builder.Build();

            app.UseSwagger(c =>
            {
                c.PreSerializeFilters.Add((swagger, httpReq) =>
                {
                    var host = httpReq.Host.Value;
                    var scheme = httpReq.Scheme;

                    // 1. 判断协议（https/http）
                    if (httpReq.Headers.TryGetValue("X-Forwarded-Proto", out var protoValues))
                    {
                        scheme = protoValues.FirstOrDefault() ?? scheme;
                    }

                    // 2. 【新增】判断是否经过 Nginx 代理
                    string pathBase = "";
                    if (httpReq.Headers.TryGetValue("X-Forwarded-Prefix", out var prefixValues))
                    {
                        // 如果有 X-Forwarded-Prefix 头，说明经过了 Nginx
                        pathBase = prefixValues.FirstOrDefault() ?? "";
                    }

                    // 3. 动态生成 Server URL
                    swagger.Servers = new List<OpenApiServer>
                    {
                        new OpenApiServer { Url = $"{scheme}://{host}{pathBase}" }
                    };
                });
            });



            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "PerformanceCalcInspection v1");
            });

            // 跨域
            app.UseCors(x => x
                .AllowAnyMethod()
                .AllowAnyHeader()
                .SetIsOriginAllowed(origin => true) // allow any origin
                .AllowCredentials()); // allow credentials

            // 配置异常中间件
            app.ConfigureExceptionHandler();
            app.UseRouting();

            //// 设置 指定目录的文件 可以被访问 start
            //var staticfile = new StaticFileOptions();
            //var cpath = Directory.GetCurrentDirectory();
            //staticfile.FileProvider = new PhysicalFileProvider(cpath + @"/runtime/"); // 指定目录，这里指的是C盘，也可以指定其他目录
            ////staticfile.FileProvider = new PhysicalFileProvider(@"E:/fuxa/runtime/"); // 指定目录，这里指的是C盘，也可以指定其他目录
            //app.UseStaticFiles(staticfile);

            app.UseEndpoints(endpoints => { endpoints.MapDefaultControllerRoute(); });
            app.Run("http://*:" + port.ToString());
            //app.Run("http://*:5002");
        }
    }

    public interface IInitServer
    {
        void Init(int port);
    }
}
