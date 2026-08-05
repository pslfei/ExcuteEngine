using log4net.Config;
using log4net.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServer.LogServer
{
    public static class LoggerCfg
    {
        private static ILoggerRepository repository = null;
        /// <summary>
        /// /ILogger<SecondController>
        /// </summary>     
        static LoggerCfg()
        {
            // 确保日志目录存在 - 跨平台兼容
            try
            {
                string logBasePath = "Log";
                string infoPath = Path.Combine(logBasePath, "Info");
                string errorPath = Path.Combine(logBasePath, "Error");

                Directory.CreateDirectory(infoPath);
                Directory.CreateDirectory(errorPath);

                //Console.WriteLine($"日志目录创建成功:");
                //Console.WriteLine($"Info: {Path.GetFullPath(infoPath)}");
                //Console.WriteLine($"Error: {Path.GetFullPath(errorPath)}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"创建日志目录失败: {ex.Message}");
            }

            repository = LogManager.CreateRepository("");
            XmlConfigurator.Configure(repository, new FileInfo("log4net.Config"));
        }

        public static ILoggerRepository GetRepository()
        {
            return repository;
        }
    }
}
