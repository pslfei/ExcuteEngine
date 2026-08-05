/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LD.cs
// 文件功能描述：LD——点类型之一
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
using System.Runtime.CompilerServices;
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LDEx : LD
    {
        private int alarmPriority;
        public int AlarmPriority { get => alarmPriority; set => alarmPriority = value; }


        private int statusChecking;
        public int StatusChecking { get => statusChecking; set => statusChecking = value; }


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


        private bool old_IN;
        public bool Old_IN { get => old_IN; set => old_IN = value; }

        public byte NeedRecord = 1;
        public LDEx(QualityTypes Quality, bool IsTrace, bool alarm, bool ForceValue, byte IsForced, bool Value, int alarmPriority, int statusChecking) : base(Quality, IsTrace, alarm, ForceValue, IsForced, Value)
        {
            this.Quality = Quality;
            this.IsTrace = IsTrace;
            this.IsAlarm = alarm;
            this.ForceValue = ForceValue;
            this.IsForced = IsForced;
            this.buffer = Value;

            this.Connected = false;
            AlarmPriority = alarmPriority;
            StatusChecking = statusChecking;
            DataReceiveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public void Run()
        {
            Byte unack = 1;
            Byte reset = 0;
            Byte ack = 2;

            bool oldValue = Old_IN;
            Old_IN = buffer;

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

            Byte isAlarm = 0;
            if (StatusChecking == 1)
            {
                //1:Alarm on zero
                if (buffer == false)
                    isAlarm = 1; // 11 means alarm
            }
            else if (StatusChecking == 2)
            {
                //2:Alarm on one
                if (buffer == true)
                    isAlarm = 1;
            }
            else if (StatusChecking == 3)
            {
                //3:State change
            }
            else if (StatusChecking == 4)
            {
                //4:Alarm on 0 To 1;
                if (buffer == true && oldValue == false)
                    isAlarm = 1;
                else
                    return;
            }
            else if (StatusChecking == 5)
            {
                //5:Alarm on 1 To 0
                if (buffer == false && oldValue == true)
                    isAlarm = 1;
                else
                    return;
            }

            //if state is not unack, and alarmtype is changed to alarm, state should be changed to unack.
            if (State != unack)
            {
                //if alarmtype is changed, and is changed to alarm
                if ((isAlarm != AlarmType) && (isAlarm != 0))
                    State = unack;
            }
            if (isAlarm != AlarmType)
            {
                AlarmType = isAlarm;
                Time = DateTime.Now.ToBinary();
                NeedRecord = 1;
    }
        }
    }
}
