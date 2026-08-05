using DCSCommon;

namespace FunctionCode
{
	public partial class FL
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
				LT_26.Command = this.Command;
				SQRT_27.Command = this.Command;
				SEL_28.Command = this.Command;
				MUL_29.Command = this.Command;
				DIV_31.Command = this.Command;
				MUL_32.Command = this.Command;
				ADD_33.Command = this.Command;
				MUL_35.Command = this.Command;
				ADD_36.Command = this.Command;
				LT_48.Command = this.Command;
				SEL_49.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			LT_26.IN1[0] = IN;
			LT_26.IN2[0] = 0.02;
			LT_26.Implement(cmd);
			
			SQRT_27.IN[0] = DIV_31.OUT;
			SQRT_27.Implement(cmd);
			
			SEL_28.G[0] = LT_26.OUT;
			SEL_28.IN0[0] = IN;
			SEL_28.IN1[0] = 0;
			SEL_28.Implement(cmd);
			
			MUL_29.IN1[0] = SEL_28.OUT;
			MUL_29.IN2[0] = MUL_35.OUT;
			MUL_29.Implement(cmd);
			
			DIV_31.IN1[0] = MUL_29.OUT;
			DIV_31.IN2[0] = ADD_33.OUT;
			DIV_31.Implement(cmd);
			
			MUL_32.IN1[0] = SQRT_27.OUT;
			MUL_32.IN2[0] = KT;
			MUL_32.Implement(cmd);
			
			ADD_33.IN1[0] = TE;
			ADD_33.IN2[0] = 273.15;
			ADD_33.Implement(cmd);
			
			FT[0] = MUL_32.OUT;
			MUL_35.IN1[0] = ADD_36.OUT;
			MUL_35.IN2[0] = 1000;
			MUL_35.Implement(cmd);
			
			ADD_36.IN1[0] = SEL_49.OUT;
			ADD_36.IN2[0] = DDDQY;
			ADD_36.Implement(cmd);
			
			LT_48.IN1[0] = PT;
			LT_48.IN2[0] = 0.02;
			LT_48.Implement(cmd);
			
			SEL_49.G[0] = LT_48.OUT;
			SEL_49.IN0[0] = PT;
			SEL_49.IN1[0] = 0;
			SEL_49.Implement(cmd);
			
		}
	}
}
