using DCSCommon;

namespace FunctionCode
{
	public partial class DIV6_Q
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
				SEL_46.Command = this.Command;
				SEL_49.Command = this.Command;
				SEL_52.Command = this.Command;
				SEL_55.Command = this.Command;
				SEL_82.Command = this.Command;
				SEL_87.Command = this.Command;
				ADD_56.Command = this.Command;
				BOOL_TO_REAL_47.Command = this.Command;
				BOOL_TO_REAL_50.Command = this.Command;
				BOOL_TO_REAL_53.Command = this.Command;
				BOOL_TO_REAL_57.Command = this.Command;
				BOOL_TO_REAL_84.Command = this.Command;
				BOOL_TO_REAL_89.Command = this.Command;
				ADD_58.Command = this.Command;
				MAX_79.Command = this.Command;
				DIV_59.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			SEL_46.G[0] = B1;
			SEL_46.IN0[0] = A1;
			SEL_46.IN1[0] = 0;
			SEL_46.Implement(cmd);
			
			SEL_49.G[0] = B2;
			SEL_49.IN0[0] = A2;
			SEL_49.IN1[0] = 0;
			SEL_49.Implement(cmd);
			
			SEL_52.G[0] = B3;
			SEL_52.IN0[0] = A3;
			SEL_52.IN1[0] = 0;
			SEL_52.Implement(cmd);
			
			SEL_55.G[0] = B4;
			SEL_55.IN0[0] = A4;
			SEL_55.IN1[0] = 0;
			SEL_55.Implement(cmd);
			
			SEL_82.G[0] = B5;
			SEL_82.IN0[0] = A5;
			SEL_82.IN1[0] = 0;
			SEL_82.Implement(cmd);
			
			SEL_87.G[0] = B6;
			SEL_87.IN0[0] = A6;
			SEL_87.IN1[0] = 0;
			SEL_87.Implement(cmd);
			
			ADD_56.IN1[0] = SEL_46.OUT;
			ADD_56.IN2[0] = SEL_49.OUT;
			ADD_56.IN3[0] = SEL_52.OUT;
			ADD_56.IN4[0] = SEL_55.OUT;
			ADD_56.IN5[0] = SEL_82.OUT;
			ADD_56.IN6[0] = SEL_87.OUT;
			ADD_56.Implement(cmd);
			
			BOOL_TO_REAL_47.IN[0] = !B1;
			BOOL_TO_REAL_47.Implement(cmd);
			
			BOOL_TO_REAL_50.IN[0] = !B2;
			BOOL_TO_REAL_50.Implement(cmd);
			
			BOOL_TO_REAL_53.IN[0] = !B3;
			BOOL_TO_REAL_53.Implement(cmd);
			
			BOOL_TO_REAL_57.IN[0] = !B4;
			BOOL_TO_REAL_57.Implement(cmd);
			
			BOOL_TO_REAL_84.IN[0] = !B5;
			BOOL_TO_REAL_84.Implement(cmd);
			
			BOOL_TO_REAL_89.IN[0] = !B6;
			BOOL_TO_REAL_89.Implement(cmd);
			
			ADD_58.IN1[0] = BOOL_TO_REAL_47.OUT;
			ADD_58.IN2[0] = BOOL_TO_REAL_50.OUT;
			ADD_58.IN3[0] = BOOL_TO_REAL_53.OUT;
			ADD_58.IN4[0] = BOOL_TO_REAL_57.OUT;
			ADD_58.IN5[0] = BOOL_TO_REAL_84.OUT;
			ADD_58.IN6[0] = BOOL_TO_REAL_89.OUT;
			ADD_58.Implement(cmd);
			
			MAX_79.IN1[0] = ADD_58.OUT;
			MAX_79.IN2[0] = 1;
			MAX_79.Implement(cmd);
			
			DIV_59.IN1[0] = ADD_56.OUT;
			DIV_59.IN2[0] = MAX_79.OUT;
			DIV_59.Implement(cmd);
			
			AV[0] = DIV_59.OUT;
		}
	}
}
