using DCSCommon;

namespace FunctionCode
{
	public partial class DIV_X
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
				GT_45.Command = this.Command;
				SEL_46.Command = this.Command;
				BOOL_TO_REAL_47.Command = this.Command;
				GT_48.Command = this.Command;
				SEL_49.Command = this.Command;
				BOOL_TO_REAL_50.Command = this.Command;
				GT_51.Command = this.Command;
				SEL_52.Command = this.Command;
				BOOL_TO_REAL_53.Command = this.Command;
				GT_54.Command = this.Command;
				SEL_55.Command = this.Command;
				ADD_56.Command = this.Command;
				BOOL_TO_REAL_57.Command = this.Command;
				ADD_58.Command = this.Command;
				DIV_59.Command = this.Command;
				MAX_79.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GT_45.IN1[0] = A1;
			GT_45.IN2[0] = AM;
			GT_45.Implement(cmd);
			
			SEL_46.G[0] = GT_45.OUT;
			SEL_46.IN0[0] = 0;
			SEL_46.IN1[0] = A1;
			SEL_46.Implement(cmd);
			
			BOOL_TO_REAL_47.IN[0] = GT_45.OUT;
			BOOL_TO_REAL_47.Implement(cmd);
			
			GT_48.IN1[0] = A2;
			GT_48.IN2[0] = AM;
			GT_48.Implement(cmd);
			
			SEL_49.G[0] = GT_48.OUT;
			SEL_49.IN0[0] = 0;
			SEL_49.IN1[0] = A2;
			SEL_49.Implement(cmd);
			
			BOOL_TO_REAL_50.IN[0] = GT_48.OUT;
			BOOL_TO_REAL_50.Implement(cmd);
			
			GT_51.IN1[0] = A3;
			GT_51.IN2[0] = AM;
			GT_51.Implement(cmd);
			
			SEL_52.G[0] = GT_51.OUT;
			SEL_52.IN0[0] = 0;
			SEL_52.IN1[0] = A3;
			SEL_52.Implement(cmd);
			
			BOOL_TO_REAL_53.IN[0] = GT_51.OUT;
			BOOL_TO_REAL_53.Implement(cmd);
			
			GT_54.IN1[0] = A4;
			GT_54.IN2[0] = AM;
			GT_54.Implement(cmd);
			
			SEL_55.G[0] = GT_54.OUT;
			SEL_55.IN0[0] = 0;
			SEL_55.IN1[0] = A4;
			SEL_55.Implement(cmd);
			
			ADD_56.IN1[0] = SEL_46.OUT;
			ADD_56.IN2[0] = SEL_49.OUT;
			ADD_56.IN3[0] = SEL_52.OUT;
			ADD_56.IN4[0] = SEL_55.OUT;
			ADD_56.Implement(cmd);
			
			BOOL_TO_REAL_57.IN[0] = GT_54.OUT;
			BOOL_TO_REAL_57.Implement(cmd);
			
			ADD_58.IN1[0] = BOOL_TO_REAL_47.OUT;
			ADD_58.IN2[0] = BOOL_TO_REAL_50.OUT;
			ADD_58.IN3[0] = BOOL_TO_REAL_53.OUT;
			ADD_58.IN4[0] = BOOL_TO_REAL_57.OUT;
			ADD_58.Implement(cmd);
			
			DIV_59.IN1[0] = ADD_56.OUT;
			DIV_59.IN2[0] = MAX_79.OUT;
			DIV_59.Implement(cmd);
			
			AV[0] = DIV_59.OUT;
			MAX_79.IN1[0] = ADD_58.OUT;
			MAX_79.IN2[0] = 1;
			MAX_79.Implement(cmd);
			
		}
	}
}
