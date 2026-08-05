using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDServer.Service
{
    internal class InfluxDBResponseModel
    {
        public List<InflxDBResultModel> Results { get; set; }
    }
}
