using DCSCommon;

namespace FunctionCode
{
	public partial class CHQ
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
				AND_12.Command = this.Command;
				UP01.Command = this.Command;
				AND_3.Command = this.Command;
				OR_13.Command = this.Command;
				R1.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AND_12.IN1[0] = SE;
			AND_12.IN2[0] = CK;
			AND_12.Implement(cmd);
			
			UP01.IN[0] = V2;
			UP01.Implement(cmd);
			
			AND_3.IN1[0] = UP01.OUT;
			AND_3.IN2[0] = CK;
			AND_3.Implement(cmd);
			
			OR_13.IN1[0] = AND_12.OUT;
			OR_13.IN2[0] = AND_3.OUT;
			OR_13.Implement(cmd);
			
			R1.SET[0] = OR_13.OUT;
			R1.RESET1[0] = !CK;
			R1.Implement(cmd);
			
			SO[0] = R1.Q1;
		}
	}
}
