using DCSCommon;

namespace FunctionCode
{
	public partial class DQTZ
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
				RT_1.Command = this.Command;
				GE_12.Command = this.Command;
				OR_18.Command = this.Command;
				AND_13.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			RT_1.IN[0] = IN;
			RT_1.RL[0] = RL;
			RT_1.H[0] = H;
			RT_1.L[0] = L;
			RT_1.Implement(cmd);
			
			GE_12.IN1[0] = IN;
			GE_12.IN2[0] = HH;
			GE_12.Implement(cmd);
			
			OR_18.IN1[0] = RT_1.DV;
			OR_18.IN2[0] = RT_1.FI;
			OR_18.Implement(cmd);
			
			AND_13.IN1[0] = !OR_18.OUT;
			AND_13.IN2[0] = GE_12.OUT;
			AND_13.Implement(cmd);
			
			TZ[0] = AND_13.OUT;
		}
	}
}
