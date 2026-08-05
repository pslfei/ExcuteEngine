using DCSCommon;
namespace FunctionCode
{
	public partial class SLC_45
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
				OR_7.Command = this.Command;
				AND_25.Command = this.Command;
				OR_9.Command = this.Command;
				AND_26.Command = this.Command;
				RS1.Command = this.Command;
				OR_23.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			OR_7.IN1[0] = DV;
			OR_7.IN2[0] = AO;
			OR_7.Implement(cmd);
			
			AND_25.IN1[0] = OR_7.OUT;
			AND_25.IN2[0] = DM001;
			AND_25.Implement(cmd);
			
			OR_9.IN1[0] = !OR_7.OUT;
			OR_9.IN2[0] = AF;
			OR_9.Implement(cmd);
			
			AND_26.IN1[0] = DM001;
			AND_26.IN2[0] = OR_9.OUT;
			AND_26.Implement(cmd);
			
			RS1.SET[0] = AND_25.OUT;
			RS1.RESET1[0] = AND_26.OUT;
			RS1.Implement(cmd);
			
			DV[0] = RS1.Q1;
			OR_23.IN1[0] = BL;
			OR_23.IN2[0] = MB;
			OR_23.Implement(cmd);
			
			DM001 = OR_23.OUT;
		}
	}
}
