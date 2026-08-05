using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;


namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("FaultOut")]
	[FCDisplay("故障输出")]
	public partial class FaultOut : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LD IN = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Constant)]
        [PinDisplay("故障码")]
        public int FaultCode = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("系统ID")]
        public int SysID = 0;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool OldIN = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool NeedOut = false;

        public FaultOut()
        {
            FcName = "FaultOut";
            FcType = enumType.FaultOut;
        }

        protected override void Run(ICommand cmd)
        {
            if (OldIN == false && IN == true)
            {
                NeedOut = true;
            }

            if (OldIN == true && IN == false)
            {
                NeedOut = true;
            }
            OldIN = IN;
            OUT[0] = IN;
        }
    }
}
