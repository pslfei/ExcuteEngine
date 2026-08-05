using DCSCommon;

namespace FunctionCode
{
	public partial class DQ1
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
				OR_35.Command = this.Command;
				OR_36.Command = this.Command;
				AND_37.Command = this.Command;
				OR_38.Command = this.Command;
				SR1.Command = this.Command;
				SEL_41.Command = this.Command;
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
			OR_35.IN1[0] = RT1.DV;
			OR_35.IN2[0] = RT1.FI;
			OR_35.IN3[0] = !BD;
			OR_35.Implement(cmd);
			
			OR_36.IN1[0] = OR_35.OUT;
			OR_36.IN2[0] = ZL_1;
			OR_36.IN3[0] = ZL_2;
			OR_36.IN4[0] = MR;
			OR_36.Implement(cmd);
			
			AND_37.IN1[0] = MR;
			AND_37.IN2[0] = RS;
			AND_37.Implement(cmd);
			
			OR_38.IN1[0] = !OR_36.OUT;
			OR_38.IN2[0] = AND_37.OUT;
			OR_38.Implement(cmd);
			
			SR1.SET1[0] = OR_35.OUT;
			SR1.RESET[0] = OR_38.OUT;
			SR1.Implement(cmd);
			
			DQ[0] = SR1.Q1;
			SEL_41.G[0] = SR1.Q1;
			SEL_41.IN0[0] = IN;
			SEL_41.IN1[0] = SEL_41.OUT;
			SEL_41.Implement(cmd);
			
			AV[0] = SEL_41.OUT;
		}
	}
}
