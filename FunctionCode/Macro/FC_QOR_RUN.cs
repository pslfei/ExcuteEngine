using DCSCommon;
namespace FunctionCode
{
	public partial class QOR
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
				OR_2.Command = this.Command;
				AND_6.Command = this.Command;
				AND_9.Command = this.Command;
				AND_11.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			OR_2.IN1[0] = AND_11.OUT;
			OR_2.IN2[0] = AND_6.OUT;
			OR_2.IN3[0] = AND_9.OUT;
			OR_2.Implement(cmd);
			
			DV[0] = OR_2.OUT;
			AND_6.IN1[0] = DI1;
			AND_6.IN2[0] = DI3;
			AND_6.Implement(cmd);
			
			AND_9.IN1[0] = DI2;
			AND_9.IN2[0] = DI3;
			AND_9.Implement(cmd);
			
			AND_11.IN1[0] = DI1;
			AND_11.IN2[0] = DI2;
			AND_11.Implement(cmd);
			
		}
	}
}
