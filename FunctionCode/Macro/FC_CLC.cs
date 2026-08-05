using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("CLC")]
	[FCDisplay("多设备选择")]
	public partial class CLC : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "多设备选择";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择A按钮")]
		public LD MA;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，外部选择A按钮")]
		public LD CLA;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择B按钮")]
		public LD MB;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，外部选择B按钮")]
		public LD CLB;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择C按钮")]
		public LD MC;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，外部选择C按钮")]
		public LD Clc;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动切除按钮")]
		public LD MD;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，自动切除按钮")]
		public LD CLOF;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，选择A输出")]
		public LD AON;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，选择B输出")]
		public LD BON;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，选择C输出")]
		public LD CON;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，切除选择输出")]
		public LD OFF;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSA = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSB = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSC = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public RS RSD = new RS();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_9 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_10 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_11 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_12 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_13 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_20 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_21 = new OR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public OR OR_22 = new OR();
	}
}
