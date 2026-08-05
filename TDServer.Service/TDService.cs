using DBServer.Model;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using static TDServer.Service.TDService;

namespace TDServer.Service
{
    public class TDService
    {
        /// <summary>
        ///  初始化数据库信息
        /// </summary>
        /// <param name="host">数据库服务端地址 192.168.0.1</param>
        /// <param name="database">数据库名称</param>
        public TDService(ConfigInfo config)
        {
            ExcuteEngine.configInfo = config;
            InfluxDBHelp.InitInfluxDB(config.InfluxDBUrl, config.InfluxDBToken);
            ExcuteEngine.Initial();
            ExcuteEngine.Start();
        }
    }
}
