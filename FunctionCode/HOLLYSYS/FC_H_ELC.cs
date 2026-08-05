using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("H_ELC")]
	[FCDisplay("将 16进制数据   转换成  电信号数据")]
	public partial class H_ELC : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		private LD _ENO;

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
        private LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出电量程数据,单位mA或V")]
		private LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("IO模块类型")]
		private LA MT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("错误代码,0-正常，2-WG错误")]
		private LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("16进制数据")]
		private LA WH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("数据点的增益")]
		private LA WG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("电信号类型,1-电压,0-电流")]
		private LD BV;

        [PinType(PinTypes.Internal)]
        [PinDisplay("模入信号类型，analoginputtype")]
        private float TP = 20.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tlu = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tld = 0.0f;
	}
}
