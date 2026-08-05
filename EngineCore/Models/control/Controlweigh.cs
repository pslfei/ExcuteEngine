using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public partial class Controlweigh
    {
        public int Id { get; set; }

        public double runweigh { get; set; }
        public double kpiweigh { get; set; }
        public double performanceweigh { get; set; }
        public double decayrateweigh { get; set; }
        public double absweigh { get; set; }
        public double timeweigh { get; set; }
        public double resweigh { get; set; }
        public string unit { get; set; }
    }
}
