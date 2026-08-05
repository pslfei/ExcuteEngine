using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class warnpointoperationguide
    {
        public int Id { get; set; }

        public string WarnPointName { get; set; }

        public int ModelOrRule { get; set; }

        public string OperationGuide { get; set; }
    }
}
