using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSC")]
	[FCDisplay("首出记忆")]
	public partial class HSSC : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I3 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I4 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I5 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I6 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I7 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I8 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O1 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O2 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O3 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O4 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O5 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O6 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O7 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O8 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I1值")]
        private bool OLD_I1;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I2值")]
        private bool OLD_I2;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I3值")]
        private bool OLD_I3;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I4值")]
        private bool OLD_I4;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I5值")]
        private bool OLD_I5;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I6值")]
        private bool OLD_I6;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I7值")]
        private bool OLD_I7;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I8值")]
        private bool OLD_I8;
	}
}
