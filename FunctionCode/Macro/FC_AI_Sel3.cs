using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("AI_Sel3")]
	[FCDisplay("模入信号三选一算法")]
	public partial class AI_Sel3 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "模入信号三选一算法";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入1")]
		public LA AI1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入2")]
		public LA AI2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，输入3")]
		public LA AI3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择，0-自动选择，1-手动选择")]
		public LD MAN;


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择AI1")]
		public LD SD1 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择AI2")]
		public LD SD2 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，手动选择AI3")]
		public LD SD3 = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，输出")]
		public LA O = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，故障提示，0---正常，1---故障，2---手动选择")]
		public LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，自动选择工作模式，可选：(auto select mode :0平均、1低选、2高选、3中值)0 average , 1 select low , 2 select hign,3 select middle")]
		public byte MD;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，点1所在板号")]
		public ushort BD1 = 2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，点2所在板号")]
		public ushort BD2 = 2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，点3所在板号")]
		public ushort BD3 = 2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，点1,2,3 的相对误差限")]
		public float error = 0.1f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，量程上限")]
		public float UP = 100f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，量程下限")]
		public float LO = 0f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，报警上限")]
		public float AlarmUP = 0f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，报警下限")]
		public float AlarmLO = 0f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1---正常，0---故障")]
		public bool b;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1---正常，0---故障")]
		public bool b1;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1---正常，0---故障")]
		public bool b2;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1---正常，0---故障")]
		public bool b3;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b4;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b5;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b6;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b7;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b8;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，0---正常，1---故障")]
		public bool b9;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，1---正常，0---故障")]
		public bool b10;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSDPGetSlaveState FM_01_STATE = new HSDPGetSlaveState();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSDPGetSlaveState FM_02_STATE = new HSDPGetSlaveState();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public HSDPGetSlaveState FM_03_STATE = new HSDPGetSlaveState();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float A12;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float A13;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public float A23;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，前周期正确值")]
		public float O_1 = 0f;

	}
}
