using DCSCommon;
namespace FunctionCode
{
	public partial class ThreeSeLTwo
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
				AND_1.Command = this.Command;
				AND_5.Command = this.Command;
				AND_8.Command = this.Command;
				OR_12.Command = this.Command;
			}
		}

        protected override void Run(ICommand cmd)
        {
			AND_1.IN1[0] = IN1;
			AND_1.IN2[0] = IN2;
            AND_1.Implement(cmd);
			
			AND_5.IN1[0] = IN1;
			AND_5.IN2[0] = IN3;
            AND_5.Implement(cmd);
			
			AND_8.IN1[0] = IN2;
			AND_8.IN2[0] = IN3;
            AND_8.Implement(cmd);
			
			OR_12.IN1[0] = AND_1.OUT;
			OR_12.IN2[0] = AND_5.OUT;
			OR_12.IN3[0] = AND_8.OUT;
            OR_12.Implement(cmd);
			
			OUT[0] = OR_12.OUT;
		}
	}
}
