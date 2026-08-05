using DCSCommon;
namespace FunctionCode
{
	public partial class ECFV
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
				MUL_49.Command = this.Command;
				ADD_50.Command = this.Command;
				MUL_51.Command = this.Command;
				SQRT_52.Command = this.Command;
				MUL_53.Command = this.Command;
				DIV_54.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			MUL_49.IN1[0] = FT;
			MUL_49.IN2[0] = 1;
			MUL_49.Implement(cmd);
			
			ADD_50.IN1[0] = TE;
			ADD_50.IN2[0] = 273;
			ADD_50.Implement(cmd);
			
			MUL_51.IN1[0] = MUL_49.OUT;
			MUL_51.IN2[0] = ADD_50.OUT;
			MUL_51.Implement(cmd);
			
			SQRT_52.IN[0] = MUL_51.OUT;
			SQRT_52.Implement(cmd);
			
			MUL_53.IN1[0] = SQRT_52.OUT;
			MUL_53.IN2[0] = CV;
			MUL_53.IN3[0] = 1;
			MUL_53.Implement(cmd);
			
			DIV_54.IN1[0] = MUL_53.OUT;
			DIV_54.IN2[0] = AV;
			DIV_54.Implement(cmd);
			
			V[0] = DIV_54.OUT;
		}
	}
}
