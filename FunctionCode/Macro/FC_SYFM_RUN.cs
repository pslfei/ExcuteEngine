using DCSCommon;

namespace FunctionCode
{
	public partial class SYFM
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
				AND_49.Command = this.Command;
				AND_56.Command = this.Command;
				RS01.Command = this.Command;
				AND_51.Command = this.Command;
				AND_53.Command = this.Command;
				AND_69.Command = this.Command;
				TON01.Command = this.Command;
				RS02.Command = this.Command;
				AND_66.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AND_49.IN1[0] = DI1;
			AND_49.IN2[0] = DI2;
			AND_49.Implement(cmd);
			
			AND_56.IN1[0] = DI3;
			AND_56.IN2[0] = DI4;
			AND_56.Implement(cmd);
			
			RS01.SET[0] = AND_49.OUT;
			RS01.RESET1[0] = AND_56.OUT;
			RS01.Implement(cmd);
			
			AND_51.IN1[0] = !AND_49.OUT;
			AND_51.IN2[0] = RS01.Q1;
			AND_51.Implement(cmd);
			
			AND_53.IN1[0] = DI3;
			AND_53.IN2[0] = AND_51.OUT;
			AND_53.Implement(cmd);
			
			DO1[0] = AND_53.OUT;
			AND_69.IN1[0] = AND_51.OUT;
			AND_69.IN2[0] = DI4;
			AND_69.Implement(cmd);
			
			DO2[0] = AND_69.OUT;
			TON01.IN[0] = RS01.RESET1;
			TON01.PT[0] = TI;
			TON01.Implement(cmd);
			
			RS02.SET[0] = RS01.Q1;
			RS02.RESET1[0] = TON01.Q;
			RS02.Implement(cmd);
			
			AND_66.IN1[0] = RS02.Q1;
			AND_66.IN2[0] = RS01.RESET1;
			AND_66.Implement(cmd);
			
			DO3[0] = AND_66.OUT;
		}
	}
}
