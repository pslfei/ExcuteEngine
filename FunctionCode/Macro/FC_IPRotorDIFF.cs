using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("IPRotorDIFF")]
	[FCDisplay("")]
	public partial class IPRotorDIFF : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("算法块的描述")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入，汽室蒸汽温度、压力")]
		public LA tyl1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，汽室蒸汽温度、压力")]
		public LA pyl1  = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，汽缸内壁温度")]
		public LA tqg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，转速")]
		public LA rpM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，采样周期ms")]
		public LA dtime = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力")]
		public LA ipvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，最大热应力比率")]
		public LA ipstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力")]
		public LA ipfvstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，预测最大热应力比率")]
		public LA ipfstr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子表面温度")]
		public LA ipsurt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子中心孔温度")]
		public LA ipbort = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子体积平均温度")]
		public LA ipvolt = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Constant)]
		[PinDisplay("输出，转子温度场")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 16)]
		public float[] iptRotor = new float[16];


		[PinType(PinTypes.Output)]
		[PinDisplay("输出，转子应力计算无效")]
		public LD ipstrinv;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short i;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数")]
		public short j;


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，有限差分数学模型")]
		public CDIFF_Rotor IPRotor = new CDIFF_Rotor();


		[PinType(PinTypes.Internal)]
		[PinDisplay("变量，温度变化率")]
		public GetRation RT = new GetRation();


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，中心孔半径")]
		public float R1 = 75f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，转子外半径")]
		public float R2 = 495.9f;


		[PinType(PinTypes.Constant)]
		[PinDisplay("规格数，热应力集中系数")]
		public float Kth = 2.0f;

	}
}
