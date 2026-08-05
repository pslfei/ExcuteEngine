using DCSCommon;

namespace FunctionCode
{
	public partial class JONSI1
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
				DQ_1.Command = this.Command;
				GT_12.Command = this.Command;
				AND_16.Command = this.Command;
				LT_25.Command = this.Command;
				AND_27.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			DQ_1.IN[0] = IN;
			DQ_1.BD[0] = BD;
			DQ_1.RL[0] = RL;
			DQ_1.H[0] = H;
			DQ_1.L[0] = L;
			DQ_1.Implement(cmd);
			
			OL[0] = AND_27.OUT;
			GT_12.IN1[0] = DQ_1.AV;
			GT_12.IN2[0] = HH;
			GT_12.Implement(cmd);
			
			AND_16.IN1[0] = GT_12.OUT;
			AND_16.IN2[0] = !DQ_1.DQ;
			AND_16.Implement(cmd);
			
			OH[0] = AND_16.OUT;
			AO[0] = DQ_1.AV;
			DQ[0] = DQ_1.DQ;
			LT_25.IN1[0] = DQ_1.AV;
			LT_25.IN2[0] = LL;
			LT_25.Implement(cmd);
			
			AND_27.IN1[0] = LT_25.OUT;
			AND_27.IN2[0] = !DQ_1.DQ;
			AND_27.Implement(cmd);
			
		}
	}
}
