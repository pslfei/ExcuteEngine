using DCSCommon;

namespace FunctionCode
{
	public partial class LS
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
				TON01.Command = this.Command;
				AND_19.Command = this.Command;
				AND_9.Command = this.Command;
				TON02.Command = this.Command;
				AND_13.Command = this.Command;
				OR_11.Command = this.Command;
				RS01.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TON01.IN[0] = !OUT;
			TON01.PT[0] = 3;
			TON01.Implement(cmd);
			
			AND_19.IN1[0] = IN;
			AND_19.IN2[0] = TON01.Q;
			AND_19.Implement(cmd);
			
			AND_9.IN1[0] = RS;
			AND_9.IN2[0] = OUT;
			AND_9.Implement(cmd);
			
			TON02.IN[0] = OUT;
			TON02.PT[0] = 3;
			TON02.Implement(cmd);
			
			AND_13.IN1[0] = IN;
			AND_13.IN2[0] = TON02.Q;
			AND_13.Implement(cmd);
			
			OR_11.IN1[0] = AND_9.OUT;
			OR_11.IN2[0] = AND_13.OUT;
			OR_11.Implement(cmd);
			
			RS01.SET[0] = AND_19.OUT;
			RS01.RESET1[0] = OR_11.OUT;
			RS01.Implement(cmd);
			
			OUT[0] = RS01.Q1;
		}
	}
}
