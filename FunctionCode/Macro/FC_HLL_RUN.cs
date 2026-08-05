using DCSCommon;

namespace FunctionCode
{
	public partial class HLL
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
				SEL_1.Command = this.Command;
				GT_2.Command = this.Command;
				SEL_3.Command = this.Command;
				LT_4.Command = this.Command;
				SEL_5.Command = this.Command;
				GT_6.Command = this.Command;
				SEL_7.Command = this.Command;
				GT_8.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GT_2.IN1[0] = IN;
			GT_2.IN2[0] = HL;
			GT_2.Implement(cmd);
			
			SEL_1.G[0] = GT_2.OUT;
			LT_4.IN1[0] = IN;
			GT_6.IN1[0] = LL;
			GT_6.IN2[0] = HL;
			GT_6.Implement(cmd);
			
			SEL_5.G[0] = GT_6.OUT;
			SEL_5.IN0[0] = LL;
			SEL_5.IN1[0] = HL;
			SEL_5.Implement(cmd);
			
			LT_4.IN2[0] = SEL_5.OUT;
			LT_4.Implement(cmd);
			
			SEL_3.G[0] = LT_4.OUT;
			SEL_3.IN0[0] = IN;
			GT_8.IN1[0] = LL;
			GT_8.IN2[0] = HL;
			GT_8.Implement(cmd);
			
			SEL_7.G[0] = GT_8.OUT;
			SEL_7.IN0[0] = LL;
			SEL_7.IN1[0] = HL;
			SEL_7.Implement(cmd);
			
			SEL_3.IN1[0] = SEL_7.OUT;
			SEL_3.Implement(cmd);
			
			SEL_1.IN0[0] = SEL_3.OUT;
			SEL_1.IN1[0] = HL;
			SEL_1.Implement(cmd);
			
			OUT[0] = SEL_1.OUT;
		}
	}
}
