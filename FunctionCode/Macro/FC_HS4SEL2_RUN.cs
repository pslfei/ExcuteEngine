using DCSCommon;

namespace FunctionCode
{
	public partial class HS4SEL2
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
				AND_50.Command = this.Command;
				AND_54.Command = this.Command;
				AND_55.Command = this.Command;
				AND_53.Command = this.Command;
				AND_52.Command = this.Command;
				AND_51.Command = this.Command;
				OR_68.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AND_50.IN1[0] = B1;
			AND_50.IN2[0] = B2;
			AND_50.Implement(cmd);
			
			AND_54.IN1[0] = B1;
			AND_54.IN2[0] = B3;
			AND_54.Implement(cmd);
			
			AND_55.IN1[0] = B1;
			AND_55.IN2[0] = B4;
			AND_55.Implement(cmd);
			
			AND_53.IN1[0] = B2;
			AND_53.IN2[0] = B3;
			AND_53.Implement(cmd);
			
			AND_52.IN1[0] = B2;
			AND_52.IN2[0] = B4;
			AND_52.Implement(cmd);
			
			AND_51.IN1[0] = B3;
			AND_51.IN2[0] = B4;
			AND_51.Implement(cmd);
			
			OR_68.IN1[0] = AND_50.OUT;
			OR_68.IN2[0] = AND_54.OUT;
			OR_68.IN3[0] = AND_55.OUT;
			OR_68.IN4[0] = AND_53.OUT;
			OR_68.IN5[0] = AND_52.OUT;
			OR_68.IN6[0] = AND_51.OUT;
			OR_68.Implement(cmd);
			
			DV[0] = OR_68.OUT;
		}
	}
}
