using DCSCommon;
namespace FunctionCode
{
	public partial class HS4SEL3_38
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
				BOOL_TO_INT_41.Command = this.Command;
				BOOL_TO_INT_42.Command = this.Command;
				BOOL_TO_INT_43.Command = this.Command;
				BOOL_TO_INT_44.Command = this.Command;
				ADD_45.Command = this.Command;
				GE_46.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			BOOL_TO_INT_41.IN[0] = B1;
			BOOL_TO_INT_41.Implement(cmd);
			
			BOOL_TO_INT_42.IN[0] = B2;
			BOOL_TO_INT_42.Implement(cmd);
			
			BOOL_TO_INT_43.IN[0] = B3;
			BOOL_TO_INT_43.Implement(cmd);
			
			BOOL_TO_INT_44.IN[0] = B4;
			BOOL_TO_INT_44.Implement(cmd);
			
			ADD_45.IN1[0] = BOOL_TO_INT_41.OUT;
			ADD_45.IN2[0] = BOOL_TO_INT_42.OUT;
			ADD_45.IN3[0] = BOOL_TO_INT_43.OUT;
			ADD_45.IN4[0] = BOOL_TO_INT_44.OUT;
			ADD_45.Implement(cmd);
			
			GE_46.IN1[0] = ADD_45.OUT;
			GE_46.IN2[0] = 3;
			GE_46.Implement(cmd);
			
			DV[0] = GE_46.OUT;
		}
	}
}
