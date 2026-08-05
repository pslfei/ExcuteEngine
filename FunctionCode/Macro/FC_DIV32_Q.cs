using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("DIV32_Q")]
	[FCDisplay("模入平均值，根据品质来去除坏值")]
	public partial class DIV32_Q : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "模入平均值，根据品质来去除坏值";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第一点信号")]
		public LA A1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二点信号")]
		public LA A2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三点信号")]
		public LA A3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第四点信号")]
		public LA A4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第五点信号")]
		public LA A5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第六点信号")]
		public LA A6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第七点信号")]
		public LA A7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第八点信号")]
		public LA A8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第九点信号")]
		public LA A9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十点信号")]
		public LA A10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十一点信号")]
		public LA A11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十二点信号")]
		public LA A12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十三点信号")]
		public LA A13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十四点信号")]
		public LA A14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十五点信号")]
		public LA A15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十六点信号")]
		public LA A16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十七点信号")]
		public LA A17 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十八点信号")]
		public LA A18 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十九点信号")]
		public LA A19 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十点信号")]
		public LA A20 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十一点信号")]
		public LA A21 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十二点信号")]
		public LA A22 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十三点信号")]
		public LA A23 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十四点信号")]
		public LA A24 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十五点信号")]
		public LA A25 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十六点信号")]
		public LA A26 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十七点信号")]
		public LA A27 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十八点信号")]
		public LA A28 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十九点信号")]
		public LA A29 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十点信号")]
		public LA A30 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十一点信号")]
		public LA A31 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十二点信号")]
		public LA A32 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第一点信号品质坏")]
		public LD B1;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二点信号品质坏")]
		public LD B2;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三点信号品质坏")]
		public LD B3;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第四点信号品质坏")]
		public LD B4;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第五点信号品质坏")]
		public LD B5;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第六点信号品质坏")]
		public LD B6;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第七点信号品质坏")]
		public LD B7;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第八点信号品质坏")]
		public LD B8;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第九点信号品质坏")]
		public LD B9;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十点信号品质坏")]
		public LD B10;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十一点信号品质坏")]
		public LD B11;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十二点信号品质坏")]
		public LD B12;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十三点信号品质坏")]
		public LD B13;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十四点信号品质坏")]
		public LD B14;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十五点信号品质坏")]
		public LD B15;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十六点信号品质坏")]
		public LD B16;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十七点信号品质坏")]
		public LD B17;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十八点信号品质坏")]
		public LD B18;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第十九点信号品质坏")]
		public LD B19;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十点信号品质坏")]
		public LD B20;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十一点信号品质坏")]
		public LD B21;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十二点信号品质坏")]
		public LD B22;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十三点信号品质坏")]
		public LD B23;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十四点信号品质坏")]
		public LD B24;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十五点信号品质坏")]
		public LD B25;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十六点信号品质坏")]
		public LD B26;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十七点信号品质坏")]
		public LD B27;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十八点信号品质坏")]
		public LD B28;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第二十九点信号品质坏")]
		public LD B29;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十点信号品质坏")]
		public LD B30;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十一点信号品质坏")]
		public LD B31;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，第三十二点信号品质坏")]
		public LD B32;


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，平均输出")]
		public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float BCS;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float CS;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_46 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_49 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_52 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_47 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_50 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_55 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_53 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_82 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_57 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_84 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_87 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_89 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_58 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public MAX MAX_79 = new MAX();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_104 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_105 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_106 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_107 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_110 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public ADD ADD_56 = new ADD();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public DIV DIV_59 = new DIV();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_113 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_176 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_177 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_178 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_179 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_182 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_185 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_200 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_201 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_202 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_203 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_206 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_209 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_224 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_225 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_226 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_227 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_230 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_233 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_248 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SEL SEL_249 = new SEL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_272 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_273 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_274 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_275 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_276 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_277 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_284 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_285 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_286 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_287 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_288 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_289 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_296 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_297 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_298 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_299 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_300 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_301 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_308 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_309 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_310 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_311 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_312 = new BOOL_TO_REAL();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public BOOL_TO_REAL BOOL_TO_REAL_313 = new BOOL_TO_REAL();
	}
}
