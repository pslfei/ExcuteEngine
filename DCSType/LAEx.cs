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
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LAEx : LA
    {
        private int ackMode = 0;
        public int AckMode { get => ackMode; set => ackMode = value; }

        private string? unit;
        public string? Unit { get => unit; set => unit = value; }


        private int lowAlarm1Priority;
        public int LowAlarm1Priority { get => lowAlarm1Priority; set => lowAlarm1Priority = value; }


        private int lowAlarm2Priority;
        public int LowAlarm2Priority { get => lowAlarm2Priority; set => lowAlarm2Priority = value; }


        private int highAlarm1Priority;
        public int HighAlarm1Priority { get => highAlarm1Priority; set => highAlarm1Priority = value; }
        

        private int highAlarm2Priority;
        public int HighAlarm2Priority { get => highAlarm2Priority; set => highAlarm2Priority = value; }

   
        private float lowAlarmLimit1Value;
        public float LowAlarmLimit1Value { get => lowAlarmLimit1Value; set => lowAlarmLimit1Value = value; }


        private float lowAlarmLimit2Value;
        public float LowAlarmLimit2Value { get => lowAlarmLimit2Value; set => lowAlarmLimit2Value = value; }


        private float highAlarmLimit1Value;
        public float HighAlarmLimit1Value { get => highAlarmLimit1Value; set => highAlarmLimit1Value = value; }


        private float highAlarmLimit2Value;
        public float HighAlarmLimit2Value { get => highAlarmLimit2Value; set => highAlarmLimit2Value = value; }


        private byte alarmType;
        public byte AlarmType { get => alarmType; set => alarmType = value; }


        private byte state;
        public byte State { get => state; set => state = value; }


        private long time;
        public long Time { get => time; set => time = value; }

        private string dataReceiveTime;
        public string DataReceiveTime { get => dataReceiveTime; set => dataReceiveTime = value; }


        private byte stateCommand;
        public byte StateCommand { get => stateCommand; set => stateCommand = value; }


        public byte NeedRecord = 1;


        public LAEx(QualityTypes Quality,string Unit, bool IsTrace, bool MaxReached, bool MinReached, bool IsHighalarm, bool IsLowalarm, float MaxValue, float MinValue, float ForceValue, byte IsForced, float Value, int lowAlarm1Priority, int lowAlarm2Priority, int highAlarm1Priority, int highAlarm2Priority, float lowAlarmLimit1Value, float lowAlarmLimit2Value, float highAlarmLimit1Value, float highAlarmLimit2Value) : base(Quality, IsTrace, MaxReached, MinReached, IsHighalarm, IsLowalarm, MaxValue, MinValue, ForceValue, IsForced, Value)
        {
            this.Unit = Unit;
            this.Quality = Quality;
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

            LowAlarm1Priority = lowAlarm1Priority;
            LowAlarm2Priority = lowAlarm2Priority;
            HighAlarm1Priority = highAlarm1Priority;
            HighAlarm2Priority = highAlarm2Priority;
            LowAlarmLimit1Value = lowAlarmLimit1Value;
            LowAlarmLimit2Value = lowAlarmLimit2Value;
            HighAlarmLimit1Value = highAlarmLimit1Value;
            HighAlarmLimit2Value = highAlarmLimit2Value;

            DataReceiveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public override string ToString()
        {
            return Value.ToString();
        }

        public void Run()
        {
            byte unack = 1;
            byte reset = 0;
            byte ack = 2;
            byte alarmType = 0;
           
            if (buffer < LowAlarmLimit1Value)
            {
                IsAlarm = true;
                alarmType = 2;
                if (buffer < LowAlarmLimit2Value)
                {
                    alarmType = 3;
                }
            }
            else if (buffer > HighAlarmLimit1Value)
            {
                IsAlarm = true;
                alarmType = 7;
                if (buffer > HighAlarmLimit2Value)
                {
                    alarmType = 8;
                }
            }
            else
            {
                IsAlarm = false;
            }

            //if state is not unack, and alarmtype is changed to alarm, state should be changed to unack.
            if (State != unack)
            {
                //if alarmtype is changed, and is changed to alarm
                if ((alarmType != AlarmType) && (alarmType != 0))
                    State = unack;
            }
            if (alarmType != AlarmType)
            {
                AlarmType = alarmType;
                Time = DateTime.Now.ToBinary();
                NeedRecord = 1;
            }

            if (StateCommand == 1 && State == unack)
            {
                //if state is unack, and point is acked, state should be changed to ack
                State = ack;
                Time = DateTime.Now.ToBinary();
            }
            else if (StateCommand == 2 && State == ack && AlarmType == 0)
            {
                //if state is reseted, and point is in returntype, and state is in ack, state should be changed to reset state.
                State = reset;
                Time = DateTime.Now.ToBinary();
            }
        }
    }
}
