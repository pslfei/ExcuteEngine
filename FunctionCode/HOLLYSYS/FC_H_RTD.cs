using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("H_RTD")]
	[FCDisplay("将16进制数据 转换成 温度数据(热电阻)")]
	public partial class H_RTD : Function 
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

		[PinType(PinTypes.Input)]
		[PinDisplay("IO模块类型")]
		private LA MT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出温度值")]
		private LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("热电阻类型")]
		private LA TP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("错误代码,0-正确，2-WG错误，5-RTD类型错误.")]
		private LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("16进制数据")]
		private LA WH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("数据点的增益")]
		private LA WG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 8.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("线路电阻A")]
        private float LA = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("线路电阻B")]
        private float LB = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("线路电阻C")]
        private float LC = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("THEelectricalbridgerisistance,canbeassignedbalueininiatializations1）")]
        private float LG = 50.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float value = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("addbyDJ")]
        private float tR = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float VREF = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float LineA = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float LineB = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float LineC = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float R1 = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float R2 = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float R3 = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float R4 = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float RB = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float RC = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float RA = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("addbyDJ")]
        private float VOUT = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tlu = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tld = 0.0f;
	}
}
