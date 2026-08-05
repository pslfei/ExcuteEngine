using DCSCommon;
namespace FunctionCode
{
	public partial class SEL3_3
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
				AND_5.Command = this.Command;
				AND_7.Command = this.Command;
				OR_12.Command = this.Command;
				AND_10.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AND_5.IN1[0] = A;
			AND_5.IN2[0] = B;
			AND_5.Implement(cmd);
			
			D[0] = OR_12.OUT;
			AND_7.IN1[0] = A;
			AND_7.IN2[0] = C;
			AND_7.Implement(cmd);
			
			OR_12.IN1[0] = AND_5.OUT;
			OR_12.IN2[0] = AND_7.OUT;
			OR_12.IN3[0] = AND_10.OUT;
			OR_12.Implement(cmd);
			
			AND_10.IN1[0] = B;
			AND_10.IN2[0] = C;
			AND_10.Implement(cmd);
			
		}
	}
}
