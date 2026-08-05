using DCSCommon;

namespace FunctionCode
{
	public partial class DQ_10
	{
		public override DCSCommon.ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
				RT1.Command = this.Command;
				OR_10.Command = this.Command;
				OR_67.Command = this.Command;
				AND_31.Command = this.Command;
				OR_68.Command = this.Command;
				SR1.Command = this.Command;
				SEL_6.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			ZL_2 = ZL_1;
			ZL_1 = ZL;
			RT1.IN[0] = IN;
			RT1.RL[0] = RL;
			RT1.H[0] = H;
			RT1.L[0] = L;
			RT1.Implement(cmd);
			
			ZR = RT1.DV;
			ZL = RT1.FI;
			OR_10.IN1[0] = RT1.DV;
			OR_10.IN2[0] = RT1.FI;
			OR_10.IN3[0] = !BD;
			OR_10.Implement(cmd);
			
			OR_67.IN1[0] = OR_10.OUT;
			OR_67.IN2[0] = ZL_1;
			OR_67.IN3[0] = ZL_2;
			OR_67.IN4[0] = MR;
			OR_67.Implement(cmd);
			
			AND_31.IN1[0] = MR;
			AND_31.IN2[0] = RS;
			AND_31.Implement(cmd);
			
			OR_68.IN1[0] = !OR_67.OUT;
			OR_68.IN2[0] = AND_31.OUT;
			OR_68.Implement(cmd);
			
			SR1.SET1[0] = OR_10.OUT;
			SR1.RESET[0] = OR_68.OUT;
			SR1.Implement(cmd);
			
			DQ[0] = SR1.Q1;
			SEL_6.IN0[0] = SR1.Q1;
			SEL_6.IN1[0] = IN;
			SEL_6.G[0] = SEL_6.OUT;
			SEL_6.Implement(cmd);
			
			AV[0] = SEL_6.OUT;
		}
	}
}
