using DCSCommon;

namespace FunctionCode
{
	public partial class MIN_8
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
				MIN_2.Command = this.Command;
				MIN_10.Command = this.Command;
				MIN_13.Command = this.Command;
				MIN_14.Command = this.Command;
				MIN_15.Command = this.Command;
				MIN_11.Command = this.Command;
				MIN_12.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			MIN_2.IN1[0] = NI1;
			MIN_2.IN2[0] = NI2;
			MIN_2.Implement(cmd);
			
			MIN_10.IN1[0] = NI3;
			MIN_10.IN2[0] = NI4;
			MIN_10.Implement(cmd);
			
			MIN_13.IN1[0] = MIN_2.OUT;
			MIN_13.IN2[0] = MIN_10.OUT;
			MIN_13.Implement(cmd);
			
			MIN_14.IN1[0] = MIN_11.OUT;
			MIN_14.IN2[0] = MIN_12.OUT;
			MIN_14.Implement(cmd);
			
			MIN_15.IN1[0] = MIN_13.OUT;
			MIN_15.IN2[0] = MIN_14.OUT;
			MIN_15.Implement(cmd);
			
			OUT[0] = MIN_15.OUT;
			MIN_11.IN1[0] = NI5;
			MIN_11.IN2[0] = NI6;
			MIN_11.Implement(cmd);
			
			MIN_12.IN1[0] = NI7;
			MIN_12.IN2[0] = NI8;
			MIN_12.Implement(cmd);
			
		}
	}
}
