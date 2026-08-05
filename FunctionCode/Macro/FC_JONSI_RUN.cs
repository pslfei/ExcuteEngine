using DCSCommon;

namespace FunctionCode
{
	public partial class JONSI
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
				GT_8.Command = this.Command;
				AND_11.Command = this.Command;
				LT_10.Command = this.Command;
				AND_15.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			DQ_1.IN[0] = IN;
			DQ_1.RL[0] = RL;
			DQ_1.H[0] = H;
			DQ_1.L[0] = L;
			DQ_1.BD[0] = true;
			DQ_1.Implement(cmd);
			
			OL[0] = AND_15.OUT;
			GT_8.IN1[0] = DQ_1.AV;
			GT_8.IN2[0] = HH;
			GT_8.Implement(cmd);
			
			AND_11.IN1[0] = GT_8.OUT;
			AND_11.IN2[0] = !DQ_1.DQ;
			AND_11.Implement(cmd);
			
			OH[0] = AND_11.OUT;
			AO[0] = DQ_1.AV;
			DQ[0] = DQ_1.DQ;
			LT_10.IN1[0] = DQ_1.AV;
			LT_10.IN2[0] = LL;
			LT_10.Implement(cmd);
			
			AND_15.IN1[0] = LT_10.OUT;
			AND_15.IN2[0] = !DQ_1.DQ;
			AND_15.Implement(cmd);
			
		}
	}
}
