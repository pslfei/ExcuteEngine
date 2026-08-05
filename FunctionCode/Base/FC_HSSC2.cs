using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSSC2")]
	[FCDisplay("首出记忆")]
	public partial class HSSC2 : Function 
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

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I9 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I10 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I11 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I12 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I13 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I14 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I15 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I16 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I17 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I18 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I19 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I20 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I21 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I22 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I23 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I24 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I25 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I26 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I27 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I28 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I29 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I30 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*故障源输入*)")]
		public LD I31 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
		[PinDisplay("(*复位*)")]
		public LD I32 = new LD(QualityTypes.Good, false, false, false, 0, false);

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

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O9 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O10 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O11 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O12 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O13 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O14 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O15 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O16 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O17 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O18 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O19 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O20 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O21 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O22 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O23 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O24 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O25 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O26 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O27 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O28 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O29 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O30 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*故障提示输出*)")]
		public LD O31 = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Output)]
		[PinDisplay("(*总故障提示输出*)")]
		public LD O32 = new LD(QualityTypes.Good, false, false, false, 0, false);



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

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I9值")]
        private bool OLD_I9;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I10值")]
        private bool OLD_I10;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I11值")]
        private bool OLD_I11;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I12值")]
        private bool OLD_I12;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I13值")]
        private bool OLD_I13;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I14值")]
        private bool OLD_I14;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I15值")]
        private bool OLD_I15;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I16值")]
        private bool OLD_I16;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I17值")]
        private bool OLD_I17;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I18值")]
        private bool OLD_I18;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I19值")]
        private bool OLD_I19;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I20值")]
        private bool OLD_I20;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I21值")]
        private bool OLD_I21;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I22值")]
        private bool OLD_I22;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I23值")]
        private bool OLD_I23;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I24值")]
        private bool OLD_I24;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I25值")]
        private bool OLD_I25;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I26值")]
        private bool OLD_I26;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I27值")]
        private bool OLD_I27;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I28值")]
        private bool OLD_I28;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I29值")]
        private bool OLD_I29;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I30值")]
        private bool OLD_I30;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I31值")]
        private bool OLD_I31;

        [PinType(PinTypes.Internal)]
        [PinDisplay("上一次的I32值")]
        private bool OLD_I32;
	}
}
