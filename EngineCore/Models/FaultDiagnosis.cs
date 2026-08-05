using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class FaultDiagnosis
    {
        public int Id { get; set; }

        public int FaultCode { get; set; }

        public DateTime BeginTime { get; set; }


        public DateTime EndTime { get; set; }

        public string Source { get; set; }
    }
}
