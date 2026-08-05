using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EngineCore.Models
{
    public class WarnAlarm
    {
        public int Id { get; set; }

        public string PointName { get; set; }


        public int SysID { get; set; }

        public int ModelID { get; set; }


        public DateTime BeginTime { get; set; }


        public DateTime EndTime { get; set; }


        public double Duration { get; set; }


        public double? UpUpLimitDuration {  get; set; }

        public double? ExceedLimitMaximum { get; set; }


        public byte UnAck { get; set; }
        public int? Level { get; set; }

        public int? AlarmType { get; set; }

        public int? LimitAlarmType { get; set; }
    }
}
