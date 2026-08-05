using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("H_E")]
	[FCDisplay("将 16进制数据   转换成  工程量数据  完全版")]
	public partial class H_E : Function 
	{
		[PinType(PinTypes.Input)]
		[PinDisplay("IO模块类型")]
		private LA MT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("16进制数据")]
        private LA WH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("数据点的增益")]
        private LA WG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("工程量量程上限")]
        private LA MU = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("工程量量程下限")]
        private LA MD = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("电信号类型,1-电压,0-电流")]
        private LD BV = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("输出工程量数据")]
		private LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("信息代码")]
		private LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("模入信号类型，analoginputtype")]
        private float emType = 20.0f;

        [PinType(PinTypes.Constant)]
        [PinDisplay("开方否，1--开方，0--不开方")]
        private bool SQ = false;

        [PinType(PinTypes.Constant)]
        [PinDisplay("小信号切除，信号值/全量程的百分比，必须为正数，lowsignalsqrtcutline,positive,initialized0.02当输入值<百分比*量程时，停止开方，缺省值0.02")]
        private float LC = 0.0f;

        [PinType(PinTypes.Constant)]
        [PinDisplay("小信号切除后的输出方式，TRUE--保持，缺省值FALSE--theoutputmethodofthelowsignalsqrtcut,TRUE--keep,initializedFALSE--输出为IVoutputtheSqrtOutPutInitValue")]
        private float OM = 0.0f;

        [PinType(PinTypes.Constant)]
        [PinDisplay("小信号切除后的输出初始值")]
        private float IV = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上周期输出工程量")]
        private float prerEng = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float valE = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tlu = 0.0f;

        [PinType(PinTypes.Internal)]
        [PinDisplay("")]
        private float tld = 0.0f;
	}
}
