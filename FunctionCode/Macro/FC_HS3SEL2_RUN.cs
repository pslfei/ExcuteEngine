using DCSCommon;

namespace FunctionCode
{
	public partial class HS3SEL2
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
				AND_20.Command = this.Command;
				AND_21.Command = this.Command;
				AND_22.Command = this.Command;
				OR_23.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AND_20.IN1[0] = B1;
			AND_20.IN2[0] = B2;
			AND_20.Implement(cmd);
			
			AND_21.IN1[0] = B2;
			AND_21.IN2[0] = B3;
			AND_21.Implement(cmd);
			
			AND_22.IN1[0] = B1;
			AND_22.IN2[0] = B3;
			AND_22.Implement(cmd);
			
			OR_23.IN1[0] = AND_20.OUT;
			OR_23.IN2[0] = AND_21.OUT;
			OR_23.IN3[0] = AND_22.OUT;
			OR_23.Implement(cmd);
			
			DV[0] = OR_23.OUT;
		}
	}
}
