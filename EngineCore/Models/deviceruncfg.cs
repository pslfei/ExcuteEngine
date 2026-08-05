using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class deviceruncfg
    {
        public int Id { get; set; }

        public string? devicename { get; set; }

        public string? pointname { get; set; }

        public string? monthcfg { get; set; }

        public string? daycfg { get; set; }

        public string? teamcfg { get; set; }

        public long? targetPage { get; set; }

        public long? dcsidx { get; set; }

        public string? operation { get; set; }

        public long? flash { get; set; }
    }
}
