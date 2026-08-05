using DCSCommon;

namespace FunctionCode
{
	public partial class TWO_SEL
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
				TWO.Command = this.Command;
				ADD_43.Command = this.Command;
				OR_46.Command = this.Command;
				DIV_48.Command = this.Command;
				DIV_59.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TWO.X1[0] = DIV_48.OUT;
			TWO.A1[0] = OR_46.OUT;
			TWO.X2[0] = S1;
			TWO.A2[0] = C1;
			TWO.X3[0] = S2;
			TWO.A3[0] = C2;
			TWO.MD[0] = 0;
			TWO.DB[0] = DIV_59.OUT;
			TWO.Implement(cmd);
			
			S_OUT[0] = TWO.AV;
			ADD_43.IN1[0] = S1;
			ADD_43.IN2[0] = S2;
			ADD_43.Implement(cmd);
			
			OR_46.IN1[0] = C1;
			OR_46.IN2[0] = C2;
			OR_46.Implement(cmd);
			
			DIV_48.IN1[0] = ADD_43.OUT;
			DIV_48.IN2[0] = 2;
			DIV_48.Implement(cmd);
			
			S_Q[0] = TWO.Q0;
			DIV_59.IN1[0] = DB;
			DIV_59.IN2[0] = 2;
			DIV_59.Implement(cmd);
			
		}
	}
}
