using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDServer.Service
{
    internal class InfluxDBSeriesModel
    {
        public string Name { get; set; }

        public List<List<object>> Values { get; set; }
    }
}
