using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;


namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("AckWarn")]
	[FCDisplay("报警确认")]
	public partial class AckWarn : Function 
	{
        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LD IN = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
        public LD OUT1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT3 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT4 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT5 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT6 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT7 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
        [PinDisplay("输出")]
        public LD OUT8 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool Oldin = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        public bool NeedAck = false;

        public AckWarn()
        {
            FcName = "AckWarn";
            FcType = enumType.Ack;
        }

        protected override void Run(ICommand cmd)
        {
            if (Oldin == false && IN == true)
            {
                NeedAck = true;
            }

            Oldin = IN;
        }
    }
}
