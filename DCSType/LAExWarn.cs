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
using DBServer.LogServer;
using DCSCommon;
using Microsoft.Extensions.Logging;
using System.Runtime.InteropServices;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LAExWarn : LA, IWarnModel
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


        public bool unAck;
        public bool UnAck { get => unAck; set => unAck = value; }

        public bool active;
        public bool Active { get => active; set => active = value; }


        private bool active2;
        public bool Active2 { get => active2; set => active2 = value; }

        private byte needRecord = 0;
        public byte NeedRecord { get => needRecord; set => needRecord = value; }

        private int sysID = -1;
        public int SysID { get => sysID; set => sysID = value; }

        private int modelID;
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



        private string limitAlarmName = "";
        /// <summary>
        /// 限值报警名称
        /// </summary>
        public string LimitAlarmName { get => limitAlarmName; set => limitAlarmName = value; }


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


        private float? warnUpUpLimit;
        /// <summary>
        /// 预警上上限
        /// </summary>
        public float? WarnUpUpLimit { get => warnUpUpLimit; set => warnUpUpLimit = value; }



        private float? warnUpUpMaxLimit;
        /// <summary>
        /// 预警上上限最大值
        /// </summary>
        public float? WarnUpUpMaxLimit { get => warnUpUpMaxLimit; set => warnUpUpMaxLimit = value; }



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

        private DateTime? modelAlarmStartTime;

        /// <summary>
        /// 设置模型首次连续越限的时间。LAExWarn.Run 在报警上升沿优先使用该时间，
        /// 未设置时仍兼容原有的“当前时间减延时”计算方式。
        /// </summary>
        public void SetModelAlarmStartTime(DateTime startTime)
        {
            modelAlarmStartTime = startTime;
        }


        private float upUpLimitDurTime = 0;
        public float UpUpLimitDurTime { get => upUpLimitDurTime; set => upUpLimitDurTime = value; }

        public List<double> ExceedUpUpLimitList = new List<double>();


        private Dictionary<int, AlarmLevelInfo> alarmLevels = new Dictionary<int, AlarmLevelInfo>();
        /// <summary>
        /// 获取所有报警级别信息
        /// </summary>
        public Dictionary<int, AlarmLevelInfo> AlarmLevels => alarmLevels;


        private float? up3Limit;
        /// <summary>
        /// 预警高3限
        /// </summary>
        public float? Up3Limit { get => up3Limit; set => up3Limit = value; }


        private float? lowLowLimit;
        /// <summary>
        /// 预警下下限
        /// </summary>
        public float? LowLowLimit { get => lowLowLimit; set => lowLowLimit = value; }

        private float? low3Limit;
        /// <summary>
        /// 预警低3限
        /// </summary>
        public float? Low3Limit { get => low3Limit; set => low3Limit = value; }

        public LAExWarn(QualityTypes Quality, bool isRun, string Unit, float? upLimit, float? lowLimit, int delayTime, int alarmType, int sid, int mid, int alarmLevel, bool IsTrace, bool MaxReached, bool MinReached, bool IsHighalarm, bool IsLowalarm, float MaxValue, float MinValue, float ForceValue, byte IsForced, float Value) : base(Quality, IsTrace, MaxReached, MinReached, IsHighalarm, IsLowalarm, MaxValue, MinValue, ForceValue, IsForced, Value)
        {
            this.Runable = isRun;
            this.Unit = Unit;
            this.Quality = Quality;
            this.WarnUpLimit = upLimit;
            this.WarnLowLimit = lowLimit;
            this.DelayTime = delayTime;
            this.AlarmType = alarmType;

            this.SysID = sid;
            this.ModelID = mid;
            this.AlarmLevel = alarmLevel;
            this.IsTrace = IsTrace;
            this.IsAlarm = IsHighalarm | IsLowalarm;
            this.ForceValue = ForceValue;
            this.IsForced = IsForced;
            this.Value = Value;

            this.MaxReached = MaxReached;
            this.MinReached = MinReached;
            this.IsHighalarm = IsHighalarm;
            this.IsLowalarm = IsLowalarm;
            this.MaxValue = MaxValue;
            this.MinValue = MinValue;
            this.Connected = false;

            DataReceiveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            //// 初始化报警级别
            //InitializeAlarmLevels();
        }


        public LAExWarn(QualityTypes Quality, bool isRun, string Unit, float? upLimit, float? lowLimit, float? up2Limit, float? low2Limit, float? up3Limit, float? low3Limit, int delayTime, int alarmType, int sid, int mid, int alarmLevel, bool IsTrace, bool MaxReached, bool MinReached, bool IsHighalarm, bool IsLowalarm, float MaxValue, float MinValue, float ForceValue, byte IsForced, float Value) : base(Quality, IsTrace, MaxReached, MinReached, IsHighalarm, IsLowalarm, MaxValue, MinValue, ForceValue, IsForced, Value)
        {
            this.Runable = isRun;
            this.Unit = Unit;
            this.Quality = Quality;
            this.WarnUpLimit = upLimit;
            this.WarnLowLimit = lowLimit;
            this.WarnUpUpLimit = up2Limit;
            this.LowLowLimit = low2Limit;
            this.Up3Limit = up3Limit;
            this.Low3Limit = low3Limit;
            this.DelayTime = delayTime;
            this.AlarmType = alarmType;

            this.SysID = sid;
            this.ModelID = mid;
            this.AlarmLevel = alarmLevel;
            this.IsTrace = IsTrace;
            this.IsAlarm = IsHighalarm | IsLowalarm;
            this.ForceValue = ForceValue;
            this.IsForced = IsForced;
            this.Value = Value;

            this.MaxReached = MaxReached;
            this.MinReached = MinReached;
            this.IsHighalarm = IsHighalarm;
            this.IsLowalarm = IsLowalarm;
            this.MaxValue = MaxValue;
            this.MinValue = MinValue;
            this.Connected = false;

            DataReceiveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

            // 初始化报警级别
            InitializeAlarmLevels();
        }

        private static LoggerService<LAExWarn> logger = new LoggerService<LAExWarn>();

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
            if (!Runable || hasConstraint)
            {
                ResetAllAlarmLevels();
                Active = false;
                UnAck = false;
                WarnState = 1;
                if (OldActive)
                {
                    NeedRecord = 1;
                    OldActive = false;
                }
                return;
            }

            // ========== 处理高报警（如果配置了） ==========

            // 高1报警
            if (alarmLevels.ContainsKey(1))
            {
                ProcessAlarmLevel(1, buffer > WarnUpLimit, cycle, cycleCount);
            }

            // 高2报警
            if (alarmLevels.ContainsKey(2))
            {
                bool high2Condition = buffer > WarnUpUpLimit &&
                                 (!WarnUpUpMaxLimit.HasValue || buffer <= WarnUpUpMaxLimit);

                ProcessAlarmLevel(2, high2Condition, cycle, cycleCount);

                // 保留高2的特殊逻辑：记录超限时间和值（仅当配置了WarnUpUpMaxLimit时）
                if (WarnUpUpMaxLimit.HasValue)
                {
                    var level2 = alarmLevels[2];
                    if (level2.Active || level2.StartTime >= 0)
                    {
                        if (high2Condition)
                        {
                            upUpLimitDurTime += cycle / 1000.0f;
                            ExceedUpUpLimitList.Add(buffer);
                        }
                    }
                    else
                    {
                        // 高2未激活且之前激活过，重置
                        if (!level2.Active && level2.OldActive)
                        {
                            upUpLimitDurTime = 0;
                            ExceedUpUpLimitList.Clear();
                        }
                    }
                }
            }

            // 高3报警
            if (alarmLevels.ContainsKey(3))
            {
                ProcessAlarmLevel(3, buffer > Up3Limit, cycle, cycleCount);
            }

            // ========== 处理低报警（如果配置了） ==========
            // 低1报警
            if (alarmLevels.ContainsKey(4))
            {
                ProcessAlarmLevel(4, buffer < WarnLowLimit, cycle, cycleCount);
            }

            // 低2报警
            if (alarmLevels.ContainsKey(5))
            {
                ProcessAlarmLevel(5, buffer < LowLowLimit, cycle, cycleCount);
            }

            // 低3报警
            if (alarmLevels.ContainsKey(6))
            {
                ProcessAlarmLevel(6, buffer < Low3Limit, cycle, cycleCount);
            }

            // 更新总体报警状态（兼容现有逻辑）
            UpdateOverallStatus();
        }

        public void Run()
        {

            if (!Runable || hasConstraint)
            {
                Active = false;
                UnAck = false;
                WarnState = 1;
                modelAlarmStartTime = null;

                if (OldActive)
                {
                    NeedRecord = 1;
                    OldActive = false;
                }
                return;
            }

            if (!OldActive && Active)
            {
                //warnAlarmStartTime = modelAlarmStartTime ?? DateTime.Now.AddSeconds(-delayTime);
                warnAlarmStartTime = (DateTime)modelAlarmStartTime;
                modelAlarmStartTime = null;
                NeedRecord = 1;
                unAck = true;
            }

            if (OldActive && !Active)
            {
                modelAlarmStartTime = null;
                NeedRecord = 1;
            }

            WarnState = (Active, UnAck) switch
            {
                (false, false) => 1,
                (false, true) => 2,
                (true, false) => 4,
                (true, true) => 8
            };

            OldActive = Active;
        }

        /// <summary>
        /// 初始化报警级别（带层级依赖验证）
        /// </summary>
        public void InitializeAlarmLevels()
        {
            // ============ 高报警初始化（从高到低检查） ============
            if (Up3Limit.HasValue)
            {
                alarmLevels[3] = new AlarmLevelInfo { LimitAlarmType = 3 };
                alarmLevels[2] = new AlarmLevelInfo { LimitAlarmType = 2 };
                alarmLevels[1] = new AlarmLevelInfo { LimitAlarmType = 1 };
            }
            else if (WarnUpUpLimit.HasValue)
            {
                alarmLevels[2] = new AlarmLevelInfo { LimitAlarmType = 2 };
                alarmLevels[1] = new AlarmLevelInfo { LimitAlarmType = 1 };
            }
            // 只设置了高1
            else if (WarnUpLimit.HasValue)
            {
                alarmLevels[1] = new AlarmLevelInfo { LimitAlarmType = 1 };
            }

            // ============ 低报警初始化（从低到高检查） ============
            if (Low3Limit.HasValue)
            {
                alarmLevels[6] = new AlarmLevelInfo { LimitAlarmType = 6 };
                alarmLevels[5] = new AlarmLevelInfo { LimitAlarmType = 5 };
                alarmLevels[4] = new AlarmLevelInfo { LimitAlarmType = 4 };
            }
            // 检查低2：如果设置了低2，必须设置低1
            else if (LowLowLimit.HasValue)
            {
                alarmLevels[5] = new AlarmLevelInfo { LimitAlarmType = 5 };
                alarmLevels[4] = new AlarmLevelInfo { LimitAlarmType = 4 };
            }
            // 只设置了低1
            else if (WarnLowLimit.HasValue)
            {
                alarmLevels[4] = new AlarmLevelInfo { LimitAlarmType = 4 };
            }
        }

        /// <summary>
        /// 处理单个报警级别
        /// </summary>
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

                    // 高2报警特殊处理：重置累计数据
                    if (alarmType2 == 2)
                    {
                        upUpLimitDurTime = 0;
                        ExceedUpUpLimitList.Clear();
                    }
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
