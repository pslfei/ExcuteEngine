using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class Troubleshooting
    {
        public int Id { get; set; }

        public string TroubleName { get; set; }

        public string? Major { get; set; }

        public int? MajorId { get; set; }

        public string? SubSystem { get; set; }

        public int? SubSystemId { get; set; }

        public string? OperationGuide { get; set; }

        public bool? IsWriteBack { get; set; }

        public string? WriteBackPointName { get; set; }

        public string? WebPageName { get; set; }

        public int? Code { get; set; }

        public string? position { get; set; }
        public string? command { get; set; }
    }
}
