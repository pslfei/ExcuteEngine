using DCSCommon;
namespace FunctionCode
{
	public partial class FTEX
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
				ADD_44.Command = this.Command;
				ADD_47.Command = this.Command;
				MUL_48.Command = this.Command;
				DIV_49.Command = this.Command;
				DIV_51.Command = this.Command;
				MAX_65.Command = this.Command;
				SQRT_52.Command = this.Command;
				MUL_53.Command = this.Command;
				MUL_24.Command = this.Command;
				MUL_55.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			SPEED[0] = MUL_53.OUT;
			ADD_44.IN1[0] = PD;
			ADD_44.IN2[0] = P0;
			ADD_44.Implement(cmd);
			
			ADD_47.IN1[0] = TE;
			ADD_47.IN2[0] = 273.15;
			ADD_47.Implement(cmd);
			
			MUL_48.IN1[0] = 288;
			MUL_48.IN2[0] = ADD_47.OUT;
			MUL_48.Implement(cmd);
			
			DIV_49.IN1[0] = ADD_44.OUT;
			DIV_49.IN2[0] = MUL_48.OUT;
			DIV_49.Implement(cmd);
			
			Q[0] = DIV_49.OUT;
			DIV_51.IN1[0] = dP;
			DIV_51.IN2[0] = DIV_49.OUT;
			DIV_51.Implement(cmd);
			
			MAX_65.IN1[0] = DIV_51.OUT;
			MAX_65.IN2[0] = 0;
			MAX_65.Implement(cmd);
			
			SQRT_52.IN[0] = MAX_65.OUT;
			SQRT_52.Implement(cmd);
			
			MUL_53.IN1[0] = K;
			MUL_53.IN2[0] = 1.4146;
			MUL_53.IN3[0] = SQRT_52.OUT;
			MUL_53.Implement(cmd);
			
			MUL_24.IN1[0] = Sg;
			MUL_24.IN2[0] = 3600;
			MUL_24.IN3[0] = MUL_53.OUT;
			MUL_24.Implement(cmd);
			
			V[0] = MUL_24.OUT;
			MUL_55.IN1[0] = MUL_24.OUT;
			MUL_55.IN2[0] = CM;
			MUL_55.IN3[0] = DIV_49.OUT;
			MUL_55.IN4[0] = 0.001;
			MUL_55.Implement(cmd);
			
			F[0] = MUL_55.OUT;
		}
	}
}
