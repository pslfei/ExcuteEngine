using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDServer.Service
{
    internal class InflxDBResultModel
    {
        public List<InfluxDBSeriesModel> Series { get; set; }
    }
}
