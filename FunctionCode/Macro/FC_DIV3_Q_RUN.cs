using DCSCommon;

namespace FunctionCode
{
	public partial class DIV3_Q
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
				SEL_1.Command = this.Command;
				SEL_3.Command = this.Command;
				SEL_5.Command = this.Command;
				ADD_7.Command = this.Command;
				BOOL_TO_REAL_10.Command = this.Command;
				BOOL_TO_REAL_11.Command = this.Command;
				BOOL_TO_REAL_12.Command = this.Command;
				ADD_19.Command = this.Command;
				MAX_20.Command = this.Command;
				DIV_22.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			SEL_1.G[0] = B1;
			SEL_1.IN0[0] = A1;
			SEL_1.IN1[0] = 0;
			SEL_1.Implement(cmd);
			
			SEL_3.G[0] = B2;
			SEL_3.IN0[0] = A2;
			SEL_3.IN1[0] = 0;
			SEL_3.Implement(cmd);
			
			SEL_5.G[0] = B3;
			SEL_5.IN0[0] = A3;
			SEL_5.IN1[0] = 0;
			SEL_5.Implement(cmd);
			
			ADD_7.IN1[0] = SEL_1.OUT;
			ADD_7.IN2[0] = SEL_3.OUT;
			ADD_7.IN3[0] = SEL_5.OUT;
			ADD_7.Implement(cmd);
			
			BOOL_TO_REAL_10.IN[0] = !B1;
			BOOL_TO_REAL_10.Implement(cmd);
			
			BOOL_TO_REAL_11.IN[0] = !B2;
			BOOL_TO_REAL_11.Implement(cmd);
			
			BOOL_TO_REAL_12.IN[0] = !B3;
			BOOL_TO_REAL_12.Implement(cmd);
			
			ADD_19.IN1[0] = BOOL_TO_REAL_10.OUT;
			ADD_19.IN2[0] = BOOL_TO_REAL_11.OUT;
			ADD_19.IN3[0] = BOOL_TO_REAL_12.OUT;
			ADD_19.Implement(cmd);
			
			MAX_20.IN1[0] = ADD_19.OUT;
			MAX_20.IN2[0] = 1;
			MAX_20.Implement(cmd);
			
			DIV_22.IN1[0] = ADD_7.OUT;
			DIV_22.IN2[0] = MAX_20.OUT;
			DIV_22.Implement(cmd);
			
			AV[0] = DIV_22.OUT;
		}
	}
}
