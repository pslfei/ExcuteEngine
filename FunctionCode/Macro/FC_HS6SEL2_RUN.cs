using DCSCommon;

namespace FunctionCode
{
	public partial class HS6SEL2
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
				BOOL_TO_INT_50.Command = this.Command;
				BOOL_TO_INT_54.Command = this.Command;
				BOOL_TO_INT_55.Command = this.Command;
				BOOL_TO_INT_53.Command = this.Command;
				BOOL_TO_INT_52.Command = this.Command;
				BOOL_TO_INT_51.Command = this.Command;
				ADD_68.Command = this.Command;
				GE_97.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			BOOL_TO_INT_50.IN[0] = B1;
			BOOL_TO_INT_50.Implement(cmd);
			
			BOOL_TO_INT_54.IN[0] = B2;
			BOOL_TO_INT_54.Implement(cmd);
			
			BOOL_TO_INT_55.IN[0] = B3;
			BOOL_TO_INT_55.Implement(cmd);
			
			BOOL_TO_INT_53.IN[0] = B4;
			BOOL_TO_INT_53.Implement(cmd);
			
			BOOL_TO_INT_52.IN[0] = B5;
			BOOL_TO_INT_52.Implement(cmd);
			
			BOOL_TO_INT_51.IN[0] = B6;
			BOOL_TO_INT_51.Implement(cmd);
			
			ADD_68.IN1[0] = BOOL_TO_INT_50.OUT;
			ADD_68.IN2[0] = BOOL_TO_INT_54.OUT;
			ADD_68.IN3[0] = BOOL_TO_INT_55.OUT;
			ADD_68.IN4[0] = BOOL_TO_INT_53.OUT;
			ADD_68.IN5[0] = BOOL_TO_INT_52.OUT;
			ADD_68.IN6[0] = BOOL_TO_INT_51.OUT;
			ADD_68.Implement(cmd);
			
			GE_97.IN1[0] = ADD_68.OUT;
			GE_97.IN2[0] = 2;
			GE_97.Implement(cmd);
			
			DV[0] = GE_97.OUT;
		}
	}
}
