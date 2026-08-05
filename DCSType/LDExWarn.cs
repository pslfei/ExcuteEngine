/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LA.cs
// 文件功能描述：LA——点类型之一
// 
//
// 创建标识：赵明明200904
//
// 修改标识：
// 修改描述：
//
// 修改标识：
// 修改描述：
//----------------------------------------------------------------*/
using DCSCommon;
using System.Runtime.InteropServices;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LDExWarn : LD, IWarnModel
    {
        /// <summary>
        /// 报警级别信息类
        /// </summary>
        public class AlarmLevelInfo
        {
            public int LimitAlarmType { get; set; }           // 1-6
            public bool Active { get; set; }              // 是否激活
            public bool UnAck { get; set; }               // 是否未确认
            public bool OldActive { get; set; }           // 上一次状态
            public long StartTime { get; set; } = -1;     // 延时开始时间
            public DateTime? AlarmStartTime { get; set; } // 报警开始时间

            public DateTime? AlarmEndTime { get; set; } // 报警结束时间
            public bool NeedRecord { get; set; }          // 是否需要记录
            public bool Condition { get; set; }            // 条件

            public byte WarnState { get; set; }       // 报警状态
        }

        private string pointName;
        public string PointName { get => pointName; set => pointName = value; }

        private int ackMode = 0;
        public int AckMode { get => ackMode; set => ackMode = value; }

        private string? unit;
        public string? Unit { get => unit; set => unit = value; }

        private int alarmType;
        /// <summary>
        /// 报警类型0：模型报警；1：规则报警
        /// </summary>
        public int AlarmType { get => alarmType; set => alarmType = value; }


        private long time;
        public long Time { get => time; set => time = value; }

        private string dataReceiveTime;
        public string DataReceiveTime { get => dataReceiveTime; set => dataReceiveTime = value; }


        private byte stateCommand;
        public byte StateCommand { get => stateCommand; set => stateCommand = value; }


        private bool unAck;
        public bool UnAck { get => unAck; set => unAck = value; }

        private bool active;
        public bool Active { get => active; set => active = value; }


        private bool active2;
        public bool Active2 { get => active2; set => active2 = value; }

        private byte needRecord = 0;
        public byte NeedRecord { get => needRecord; set => needRecord = value; }

        private int sysID = -1;
        public int SysID { get => sysID; set => sysID = value; }

        private int modelID = -1;
        public int ModelID { get => modelID; set => modelID = value; }

        private int fcBlockID;
        public int FcBlockID { get => fcBlockID; set => fcBlockID = value; }


        private byte warnState = 1;
        public byte WarnState { get => warnState; set => warnState = value; }

        private string warnConstraint = "";
        public string WarnConstraint { get => warnConstraint; set => warnConstraint = value; }


        private bool hasConstraint = false;
        public bool HasConstraint { get => hasConstraint; set => hasConstraint = value; }


        private string limitAlarmCondition = "";
        /// <summary>
        /// 限值报警条件
        /// </summary>
        public string LimitAlarmCondition { get => limitAlarmCondition; set => limitAlarmCondition = value; }



        private bool limitAlarm = false;

        /// <summary>
        /// 限值报警
        /// </summary>
        public bool LimitAlarm { get => limitAlarm; set => limitAlarm = value; }

        private int limitAlarmType;
        /// <summary>
        /// 限值报警
        /// </summary>
        public int LimitAlarmType { get => limitAlarmType; set => limitAlarmType = value; }


        private float? warnUpLimit = 0;
        /// <summary>
        /// 预警上限
        /// </summary>
        public float? WarnUpLimit { get => warnUpLimit; set => warnUpLimit = value; }


        private float? warnLowLimit = 0;
        /// <summary>
        /// 预警下限
        /// </summary>
        public float? WarnLowLimit { get => warnLowLimit; set => warnLowLimit = value; }


        private int delayTime = 0;
        /// <summary>
        /// 延时时间
        /// </summary>
        public int DelayTime { get => delayTime; set => delayTime = value; }


        private int delayTimeAlarmLimit = 0;
        /// <summary>
        /// 延时时间
        /// </summary>
        public int DelayTimeLimitAlarm { get => delayTimeAlarmLimit; set => delayTimeAlarmLimit = value; }


        private int? alarmLevel = -1;
        /// <summary>
        /// 报警等级
        /// </summary>
        public int? AlarmLevel { get => alarmLevel; set => alarmLevel = value; }

        private int? alarmLevel2 = -1;
        /// <summary>
        /// 报警类型2
        /// </summary>
        public int? AlarmType2 { get => alarmLevel2; set => alarmLevel2 = value; }


        private bool isAlarmSuspended = false;
        /// <summary>
        /// 是否报警挂起
        /// </summary>
        public bool IsAlarmSuspended { get => isAlarmSuspended; set => isAlarmSuspended = value; }

        private bool oldActive;
        public bool OldActive { get => oldActive; set => oldActive = value; }

        private DateTime warnAlarmStartTime = DateTime.Now;
        public DateTime WarnAlarmStartTime
        {
            get { return warnAlarmStartTime; }
            set { warnAlarmStartTime = value; }
        }


        private Dictionary<int, AlarmLevelInfo> alarmLevels = new Dictionary<int, AlarmLevelInfo>();
        /// <summary>
        /// 获取所有报警级别信息
        /// </summary>
        public Dictionary<int, AlarmLevelInfo> AlarmLevels => alarmLevels;



        public LDExWarn(QualityTypes Quality, bool isRun, string Unit, float? upLimit, float? lowLimit, int delayTime, int alarmType, bool alarm, int alarmLevel, bool ForceValue, byte IsForced, bool IsTrace, bool Value) : base(Quality, IsTrace, alarm, ForceValue, IsForced, Value)
        {
            this.Runable = isRun;
            this.Unit = Unit;
            this.Quality = Quality;
            this.WarnUpLimit = upLimit;
            this.WarnLowLimit = lowLimit;


            this.DelayTime = delayTime;
            this.AlarmType = alarmType;


            this.AlarmLevel = alarmLevel;
            this.IsTrace = IsTrace;
            this.IsAlarm = alarm;

            this.IsForced = IsForced;
            this.Value = Value;


            this.Connected = false;

            InitializeAlarmLevels();
        }


        /// <summary>
        /// 初始化报警级别（带层级依赖验证）
        /// </summary>
        public void InitializeAlarmLevels()
        {
            // 设置了高1
            if (WarnUpLimit.HasValue)
            {
                alarmLevels[7] = new AlarmLevelInfo { LimitAlarmType = 7 };
            }

            // 设置了低1
            if (WarnLowLimit.HasValue)
            {
                alarmLevels[8] = new AlarmLevelInfo { LimitAlarmType = 8 };
            }
        }

        private void ProcessAlarmLevel(int alarmType2, bool condition, int cycle, long cycleCount)
        {
            if (!alarmLevels.ContainsKey(alarmType2)) return;

            var level = alarmLevels[alarmType2];

            if (condition)
            {
                // 刚触发，开始延时计时
                if (!level.Condition)
                {
                    level.StartTime = DateTimeOffset.Now.ToUnixTimeMilliseconds();
                }

                // 延时到达，激活报警
                if (level.StartTime >= 0 && DateTimeOffset.Now.ToUnixTimeMilliseconds() >= level.StartTime + delayTime * 1000L)
                {
                    level.StartTime = -1;
                    level.Active = true;
                    level.UnAck = true;
                }
            }
            else
            {
                // 条件不满足，重置
                level.StartTime = -1;
                level.Active = false;
            }

            level.Condition = condition;

            // 检测状态变化
            if (!level.OldActive && level.Active)
            {
                // 报警触发
                level.AlarmStartTime = DateTime.Now.AddSeconds(-delayTime);
                level.AlarmEndTime = null;
                level.NeedRecord = true;
                level.UnAck = true;
            }

            if (level.OldActive && !level.Active)
            {
                // 报警恢复
                level.NeedRecord = true;
                //level.AlarmStartTime = null;
                level.AlarmEndTime = DateTime.Now;
            }

            WarnState = (Active, UnAck) switch
            {
                (false, false) => 1,
                (false, true) => 2,
                (true, false) => 4,
                (true, true) => 8
            };

            level.OldActive = level.Active;
        }

        /// <summary>
        /// 重置所有报警级别
        /// </summary>
        private void ResetAllAlarmLevels()
        {
            foreach (var level in alarmLevels.Values)
            {
                level.Active = false;
                level.UnAck = false;
                level.StartTime = -1;
                level.WarnState = 1;

                if (level.OldActive)
                {
                    level.NeedRecord = true;
                    OldActive = false;
                }
            }
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        bool tempActive;
        bool oldTempActive;
        long startTime = -1;
        int _cycle = 0;
        int _cycleCount = 0;

        public void RuleWarnRun(int cycle, long cycleCount)
        {
            float convertValue = buffer ? 1 : 0;
            if (!Runable || hasConstraint)
            {
                ResetAllAlarmLevels();
                Active = false;
                UnAck = false;
                WarnState = 1;
                NeedRecord = 0;
                return;
            }

            // 高1报警
            if (alarmLevels.ContainsKey(7))
            {
                ProcessAlarmLevel(7, convertValue > WarnUpLimit, cycle, cycleCount);
            }

            // ========== 处理低报警（如果配置了） ==========
            // 低1报警
            if (alarmLevels.ContainsKey(8))
            {
                ProcessAlarmLevel(8, convertValue < WarnLowLimit, cycle, cycleCount);
            }

            // 更新总体报警状态（兼容现有逻辑）
            UpdateOverallStatus();
        }

        /// <summary>
        /// 更新总体报警状态
        /// </summary>
        private void UpdateOverallStatus()
        {
            Active = alarmLevels.Values.Any(x => x.Active);
            UnAck = alarmLevels.Values.Any(x => x.UnAck);

            // 有任何级别需要记录
            NeedRecord = (byte)(alarmLevels.Values.Any(x => x.NeedRecord) ? 1 : 0);

            if (NeedRecord == 1)
            {
                limitAlarmType = alarmLevels.Values.Where(x => x.NeedRecord).Max(x => x.LimitAlarmType);
            }

            // 更新 WarnState
            WarnState = (Active, UnAck) switch
            {
                (false, false) => 1,
                (false, true) => 2,
                (true, false) => 4,
                (true, true) => 8
            };

            // 更新总体 OldActive
            OldActive = Active;

            // 更新总体报警开始时间（取最早的）
            var activeAlarms = alarmLevels.Values
                .Where(x => x.Active && x.AlarmStartTime.HasValue)
                .ToList();

            if (activeAlarms.Any())
            {
                warnAlarmStartTime = activeAlarms.Min(x => x.AlarmStartTime.Value);
            }
        }

        public void Ack()
        {
            this.unAck = false;
            foreach (var item in this.AlarmLevels.Values)
            {
                item.UnAck = false;
            }
        }
    }
}
