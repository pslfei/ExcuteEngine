using DCSCommon;
namespace FunctionCode
{
	public partial class DQ_11
	{
		public override ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
				GT_110.Command = this.Command;
				LT_111.Command = this.Command;
				OR_10.Command = this.Command;
				OR_67.Command = this.Command;
				RS1.Command = this.Command;
				HSHLLIM01.Command = this.Command;
				INFOP.Command = this.Command;
				SEL_6.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			GT_110.IN1[0] = IN;
			GT_110.IN2[0] = H;
			GT_110.Implement(cmd);
			
			LT_111.IN1[0] = IN;
			LT_111.IN2[0] = L;
			LT_111.Implement(cmd);
			
			OR_10.IN1[0] = GT_110.OUT;
			OR_10.IN2[0] = LT_111.OUT;
			OR_10.IN3[0] = !BD;
			OR_10.Implement(cmd);
			
			OR_67.IN1[0] = !OR_10.OUT;
			OR_67.IN2[0] = RS;
			OR_67.Implement(cmd);
			
			RS1.SET[0] = OR_10.OUT;
			RS1.RESET1[0] = OR_67.OUT;
			RS1.Implement(cmd);
			
			DQ[0] = RS1.Q1;
			HSHLLIM01.IN[0] = IN;
			HSHLLIM01.HL[0] = H;
			HSHLLIM01.LL[0] = L;
			HSHLLIM01.Implement(cmd);
			
			INFOP.IN[0] = HSHLLIM01.AV;
			INFOP.Implement(cmd);
			
			SEL_6.IN0[0] = RS1.Q1;
			SEL_6.IN1[0] = INFOP.AV;
			SEL_6.G[0] = SEL_6.OUT;
			SEL_6.Implement(cmd);
			
			AV[0] = SEL_6.OUT;
		}
	}
}
