using DCSCommon;

namespace FunctionCode
{
	public partial class FTEX4
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
				GE_74.Command = this.Command;
				HSPOLY01.Command = this.Command;
				HSPOLY02.Command = this.Command;
				SEL_72.Command = this.Command;
				ADD_44.Command = this.Command;
				ADD_47.Command = this.Command;
				DIV_49.Command = this.Command;
				MUL_51.Command = this.Command;
				MAX_65.Command = this.Command;
				SQRT_52.Command = this.Command;
				MUL_53.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GE_74.IN1[0] = dP;
			GE_74.IN2[0] = 0.8;
			GE_74.Implement(cmd);
			
			HSPOLY01.IN[0] = dP;
			HSPOLY01.Implement(cmd);
			
			HSPOLY02.IN[0] = dP;
			HSPOLY02.Implement(cmd);
			
			SEL_72.G[0] = GE_74.OUT;
			SEL_72.IN0[0] = HSPOLY01.AV;
			SEL_72.IN1[0] = HSPOLY02.AV;
			SEL_72.Implement(cmd);
			
			fdp = SEL_72.OUT;
			ADD_44.IN1[0] = Pg;
			ADD_44.IN2[0] = Ph;
			ADD_44.Implement(cmd);
			
			ADD_47.IN1[0] = TE;
			ADD_47.IN2[0] = 273.15;
			ADD_47.Implement(cmd);
			
			DIV_49.IN1[0] = ADD_44.OUT;
			DIV_49.IN2[0] = ADD_47.OUT;
			DIV_49.Implement(cmd);
			
			MUL_51.IN1[0] = dP;
			MUL_51.IN2[0] = 3.483407;
			MUL_51.IN3[0] = DIV_49.OUT;
			MUL_51.Implement(cmd);
			
			MAX_65.IN1[0] = MUL_51.OUT;
			MAX_65.IN2[0] = 0;
			MAX_65.Implement(cmd);
			
			SQRT_52.IN[0] = MAX_65.OUT;
			SQRT_52.Implement(cmd);
			
			MUL_53.IN1[0] = Km;
			MUL_53.IN2[0] = fdp;
			MUL_53.IN3[0] = SQRT_52.OUT;
			MUL_53.Implement(cmd);
			
			F[0] = MUL_53.OUT;
		}
	}
}
