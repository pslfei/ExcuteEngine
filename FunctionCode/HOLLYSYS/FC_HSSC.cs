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
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

        [PinType(PinTypes.Input)]
        [PinDisplay("算法块是否可用")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("_ENO=_EN")]
        private LD _ENO = new LD(QualityTypes.Good, false, false, false, 0, false);

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I1;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I2;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I3;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I4;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I5;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I6;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I7;

		[PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I8;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O1;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O2;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O3;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O4;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O5;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O6;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O7;

		[PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O8;

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
