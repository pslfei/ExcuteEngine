using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("SCTIME_38")]
	[FCDisplay("首出时间记录")]
    public partial class SCTIME_38 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "首出时间记录";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD EN;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD Q;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，首出时间")]
		public LA SC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，首出复位时间")]
		public LA RC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RTC AAAA = new RTC();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DT_TO_DWORD DT_TO_DWORD_9 = new DT_TO_DWORD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_10 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_11 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_12 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_13 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DT_TO_DWORD DT_TO_DWORD_1 = new DT_TO_DWORD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_2 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MUL MUL_3 = new MUL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SUB SUB_4 = new SUB();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_5 = new ADD();
	}
}
