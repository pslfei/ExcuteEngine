using DCSCommon;
namespace FunctionCode
{
	public partial class HS4SEL3_42
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
				AND_30.Command = this.Command;
				AND_31.Command = this.Command;
				AND_32.Command = this.Command;
				AND_33.Command = this.Command;
				OR_34.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AND_30.IN1[0] = A;
			AND_30.IN2[0] = B;
			AND_30.IN3[0] = C;
			AND_30.Implement(cmd);
			
			AND_31.IN1[0] = A;
			AND_31.IN2[0] = B;
			AND_31.IN3[0] = D;
			AND_31.Implement(cmd);
			
			AND_32.IN1[0] = B;
			AND_32.IN2[0] = C;
			AND_32.IN3[0] = D;
			AND_32.Implement(cmd);
			
			AND_33.IN1[0] = A;
			AND_33.IN2[0] = C;
			AND_33.IN3[0] = D;
			AND_33.Implement(cmd);
			
			OR_34.IN1[0] = AND_30.OUT;
			OR_34.IN2[0] = AND_31.OUT;
			OR_34.IN3[0] = AND_32.OUT;
			OR_34.IN4[0] = AND_33.OUT;
			OR_34.Implement(cmd);
			
			E[0] = OR_34.OUT;
		}
	}
}
