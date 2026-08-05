using DBServer.LogServer;
using DBServer.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Text;
using TDServer.Service;

namespace ConsoleApp1
{
    public class Common
    {

        private static LoggerService<Common> logger = new LoggerService<Common>();
        private static AbstractDBHelp tdengineService = null;
        public static ConfigInfo? configInfo;



        public static AbstractDBHelp CreateTdServer(ConfigInfo config)
        {
            try
            {
                configInfo = config;
                if (tdengineService == null)
                {
                    tdengineService = new TDService(configInfo);
                }
            }
            catch (Exception ex)
            {

                throw;
            }

            return tdengineService;
        }

    }
}
