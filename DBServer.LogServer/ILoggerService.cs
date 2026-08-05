using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBServer.LogServer
{
    public interface ILogerService<T>
    {
        //ILogger<SecondController> _logger;
        void InfoLog(string info);
        void ErrorLog(string info);
        void ErrorLog(string info, Exception ex);
        //void DebugLog(string info);

    }
}
