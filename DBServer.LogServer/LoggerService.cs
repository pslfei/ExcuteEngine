using log4net.Config;
using log4net.Repository;
using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using log4net.Core;

namespace DBServer.LogServer
{
    public class LoggerService<T> : ILogerService<T>
    {
        // private static ILoggerRepository repository = null;
        /// <summary>
        /// /ILogger<SecondController>
        /// </summary>
        private readonly ILog log;
        //static LoggerService()
        //{
        //    repository = LogManager.CreateRepository("");
        //    XmlConfigurator.Configure(repository, new FileInfo("log4net.Config"));
        //}
        public LoggerService()
        {
            //if (repository == null)
            //{
            //    repository = LogManager.CreateRepository("");
            //    XmlConfigurator.Configure(repository, new FileInfo("log4net.Config"));
            //}          
            ILoggerRepository repository = LoggerCfg.GetRepository();

            log = LogManager.GetLogger(repository.Name, typeof(T));
        }

        public void ErrorLog(string info) => log.Error(info);
        public void ErrorLog(string info, Exception ex) => log.Error(info, ex);

        public void ErrorLog(Exception ex)
        {
            throw new NotImplementedException();
        }

        public void InfoLog(string info) => log.Info(info);


        //public void ErrorLog(string info) { }
        //public void ErrorLog(string info, Exception ex) { }

        //public void InfoLog(string info) { }

    }
}
