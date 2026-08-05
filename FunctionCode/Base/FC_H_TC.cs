using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("H_TC")]
	[FCDisplay("将16进制数据 转换成 温度数据(热电偶)")]
	public partial class H_TC : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("IO模块类型")]
		private LA MT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出温度值")]
		private LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("热电偶类型")]
		private LA TP = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("错误代码,0-正确，2-WG错误，6-TC类型错误..")]
		private LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("冷端温度,0-不需冷端补偿")]
		private LA CT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("16进制数据")]
		private LA WH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Input)]
		[PinDisplay("数据点的增益")]
		private LA WG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float value = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tlu = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tld = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float index = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("零点电压")]
        private float zeroE = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("滤波后的冷端温度")]
        private float CT_F = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("初始化下装标志")]
        private bool CT_FLAG = false;

        [PinType(PinTypes.Internal)]
        [PinDisplay("冷端滤波时间，单位：秒")]
        private float FILTERTIME = 600.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("滤波因子，由FILTERTIME和cycle计算得出")]
        private float K = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("运算周期，单位：秒")]
        private float cycle = 0.3f;
	}
}
