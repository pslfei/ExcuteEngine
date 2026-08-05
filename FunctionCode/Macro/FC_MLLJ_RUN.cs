using DCSCommon;
namespace FunctionCode
{
	public partial class MLLJ
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
				GT_8.Command = this.Command;
				OR_9.Command = this.Command;
				HSUP01.Command = this.Command;
				BOOL_TO_REAL_11.Command = this.Command;
				MUL_12.Command = this.Command;
				ADD_13.Command = this.Command;
				SEL_14.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			GT_8.IN1[0] = AV;
			GT_8.IN2[0] = IN3;
			GT_8.Implement(cmd);
			
			OR_9.IN1[0] = GT_8.OUT;
			OR_9.IN2[0] = RS;
			OR_9.Implement(cmd);
			
			HSUP01.IN[0] = IN1;
			HSUP01.Implement(cmd);
			
			BOOL_TO_REAL_11.IN[0] = HSUP01.OUT;
			BOOL_TO_REAL_11.Implement(cmd);
			
			MUL_12.IN1[0] = BOOL_TO_REAL_11.OUT;
			MUL_12.IN2[0] = IN2;
			MUL_12.Implement(cmd);
			
			ADD_13.IN1[0] = MUL_12.OUT;
			ADD_13.IN2[0] = AV;
			ADD_13.Implement(cmd);
			
			SEL_14.IN0[0] = OR_9.OUT;
			SEL_14.IN1[0] = ADD_13.OUT;
			SEL_14.G[0] = 0;
			SEL_14.Implement(cmd);
			
			AV[0] = SEL_14.OUT;
		}
	}
}
