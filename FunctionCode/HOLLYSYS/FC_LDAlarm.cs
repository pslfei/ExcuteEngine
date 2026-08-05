using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("LDAlarm")]
    [FCDisplay("数字量报警")]
    public partial class LDAlarm : Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("数字量点描述")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 100)]
        public string Description = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("Binary Input 1")]
        private LD BoolPin = new LD(QualityTypes.Good, false, false, false, 0, false);

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private int AlarmPriority;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数2")]
        private int StatusChecking;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数3")]
        private byte AlarmType;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数4")]
        private byte State;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数5")]
        private byte Quality;

        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数6")]
        private Int64 Time;

        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private byte StateCommand;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        private bool Old_IN;
    }
}
