using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class parawarns
    {
        public int Id { get; set; }

        public string PointName { get; set; }

        public string? Description { get; set; }

        public string? SysName { get; set; }

        public string? Major { get; set; }

        public bool? IsWriteBack { get; set; }

        public string? WriteBackPointName { get; set; }

        public string? WebPageName { get; set; }

        public long? TroubleShootingID { get; set; }
    }
}
