using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("LAAlarm")]
    [FCDisplay("模拟量报警")]
    public partial class LAAlarm : Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("模拟量点描述")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100)]
        public string Description = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("模拟量点单位")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 3)]
        public string Unit = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("Input value")]
        private LA AnalogPin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("AckMode")]
        private int AckMode = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("LowAlarm1Priority")]
        private byte LowAlarm1Priority;

        [PinType(PinTypes.Constant)]
        [PinDisplay("LowAlarm2Priority")]
        private byte LowAlarm2Priority;

        [PinType(PinTypes.Constant)]
        [PinDisplay("HighAlarm1Priority")]
        private byte HighAlarm1Priority;

        [PinType(PinTypes.Constant)]
        [PinDisplay("HighAlarm2Priority")]
        private byte HighAlarm2Priority;

        [PinType(PinTypes.Constant)]
        [PinDisplay("LowAlarmLimit1Value")]
        private float LowAlarmLimit1Value;

        [PinType(PinTypes.Constant)]
        [PinDisplay("LowAlarmLimit2Value")]
        private float LowAlarmLimit2Value;

        [PinType(PinTypes.Constant)]
        [PinDisplay("HighAlarmLimit1Value")]
        private float HighAlarmLimit1Value;

        [PinType(PinTypes.Constant)]
        [PinDisplay("HighAlarmLimit2Value")]
        private float HighAlarmLimit2Value;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数21")]
        private byte AlarmType;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数22")]
        private byte State;


        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数24")]
        private Int64 Time;

        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private byte StateCommand;
    }
}
