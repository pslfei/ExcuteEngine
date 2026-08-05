using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("MUL")]
	[FCDisplay("乘法")]
	public partial class MUL : Function 
	{
        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入2")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入3")]
        public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入4")]
        public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入5")]
        public LA IN5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入6")]
        public LA IN6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入7")]
        public LA IN7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入8")]
        public LA IN8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入9")]
        public LA IN9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入10")]
        public LA IN10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入11")]
        public LA IN11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入12")]
        public LA IN12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入13")]
        public LA IN13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入14")]
        public LA IN14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入15")]
        public LA IN15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入16")]
        public LA IN16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入17")]
        public LA IN17 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入18")]
        public LA IN18 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入19")]
        public LA IN19 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入20")]
        public LA IN20 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入12")]
        public LA IN21 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入22")]
        public LA IN22 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入23")]
        public LA IN23 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入24")]
        public LA IN24 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入25")]
        public LA IN25 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入26")]
        public LA IN26 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入27")]
        public LA IN27 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入28")]
        public LA IN28 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入29")]
        public LA IN29 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入30")]
        public LA IN30 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入31")]
        public LA IN31 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入32")]
        public LA IN32 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 1.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

	}
}
