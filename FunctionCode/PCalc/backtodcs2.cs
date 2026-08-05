using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using FunctionCode;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("backtodcs2")]
	[FCDisplay("backtodcs2")]
	public partial class backtodcs2 : Function
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("backtodcs2")]
		[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
		public string Description = "backtodcs2";

		[PinType(PinTypes.Input)]
		[PinDisplay("输入")]
		public LD _EN = new LD(QualityTypes.Good, false, false, false,0, true);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，故障信号")]
		public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，复位信号")]
		public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，置1则强制不报警")]
		public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Input)]
		[PinDisplay("输入，强制输出值")]
		public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LD _ENO = new LD(QualityTypes.Good, false, false, false,0, false);


		[PinType(PinTypes.Output)]
		[PinDisplay("输出")]
		public LA OUT2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AI_Red_Sel AI_Red_Sel_150 = new AI_Red_Sel();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_151 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AI_Red_Sel AI_Red_Sel_152 = new AI_Red_Sel();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_153 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SR SR_154 = new SR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AND AND_155 = new AND();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP_156 = new TP();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public NOT NOT_157 = new NOT();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public TP TP_158 = new TP();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public SR SR_159 = new SR();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AI_Red_Sel AI_Red_Sel_160 = new AI_Red_Sel();

		[PinType(PinTypes.Internal)]
		[PinDisplay("变量")]
		public AI_Red_Sel AI_Red_Sel_165 = new AI_Red_Sel();

		public override DCSCommon.ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
				AI_Red_Sel_150.Command = this.Command;
				AND_151.Command = this.Command;
				AI_Red_Sel_152.Command = this.Command;
				AND_153.Command = this.Command;
				SR_154.Command = this.Command;
				AND_155.Command = this.Command;
				TP_156.Command = this.Command;
				NOT_157.Command = this.Command;
				TP_158.Command = this.Command;
				SR_159.Command = this.Command;
				AI_Red_Sel_160.Command = this.Command;
				AI_Red_Sel_165.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AI_Red_Sel_150.X1[0] = 1;
			AI_Red_Sel_150.X2[0] = 4;
			AI_Red_Sel_150.M1[0] = true;
			AI_Red_Sel_150.M2[0] = AND_153.OUT;
			AI_Red_Sel_150.Implement(cmd);
			
			AND_151.IN1[0] = IN1;
			AND_151.IN2[0] = 1;
			AND_151.Implement(cmd);
			
			AI_Red_Sel_152.X1[0] = AI_Red_Sel_160.AV;
			AI_Red_Sel_152.X2[0] = 8;
			AI_Red_Sel_152.M1[0] = true;
			AI_Red_Sel_152.M2[0] = AND_155.OUT;
			AI_Red_Sel_152.Implement(cmd);
			
			AND_153.IN1[0] = SR_159.Q1;
			AND_153.IN3[0] = AND_151.OUT;
			AND_153.Implement(cmd);
			
			SR_154.SET1[0] = TP_158.Q;
			SR_154.RESET[0] = IN2;
			SR_154.Implement(cmd);
			
			AND_155.IN1[0] = AND_151.OUT;
			AND_155.IN2[0] = SR_154.Q1;
			AND_155.Implement(cmd);
			
			TP_156.IN[0] = NOT_157.OUT;
			TP_156.PT[0] = 10;
			TP_156.Implement(cmd);
			
			NOT_157.IN[0] = IN1;
			NOT_157.Implement(cmd);
			
			TP_158.IN[0] = AND_151.OUT;
			TP_158.Implement(cmd);
			
			SR_159.SET1[0] = IN2;
			SR_159.RESET[0] = TP_156.Q;
			SR_159.Implement(cmd);
			
			AI_Red_Sel_160.X1[0] = AI_Red_Sel_150.AV;
			AI_Red_Sel_160.X2[0] = 2;
			AI_Red_Sel_160.M1[0] = true;
			AI_Red_Sel_160.M2[0] = SR_154.Q1;
			AI_Red_Sel_160.Implement(cmd);
			
			AI_Red_Sel_165.X1[0] = AI_Red_Sel_152.AV;
			AI_Red_Sel_165.X2[0] = IN4;
			AI_Red_Sel_165.M1[0] = true;
			AI_Red_Sel_165.M2[0] = IN3;
			OUT2[0] = AI_Red_Sel_165.AV;
			AI_Red_Sel_165.Implement(cmd);
			
		}
	}
}
