using DCSCommon;

namespace FunctionCode
{
	public partial class HSLS
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
				TP01.Command = this.Command;
				TP02.Command = this.Command;
				OR_16.Command = this.Command;
				LS01.Command = this.Command;
				NOT_19.Command = this.Command;
				TP03.Command = this.Command;
				AND_21.Command = this.Command;
				TON05.Command = this.Command;
				OR_23.Command = this.Command;
				AND_24.Command = this.Command;
				AND_26.Command = this.Command;
				TON06.Command = this.Command;
				NOT_28.Command = this.Command;
				TP04.Command = this.Command;
				OR_30.Command = this.Command;
				AND_31.Command = this.Command;
				OR_33.Command = this.Command;
				AND_34.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TP01.IN[0] = INA;
			TP01.PT[0] = 3;
			TP01.Implement(cmd);
			
			TP02.IN[0] = INB;
			TP02.PT[0] = 3;
			TP02.Implement(cmd);
			
			OR_16.IN1[0] = TP01.Q;
			OR_16.IN2[0] = TP02.Q;
			OR_16.Implement(cmd);
			
			LS01.IN[0] = AND_34.OUT;
			LS01.RS[0] = OR_16.OUT;
			LS01.Implement(cmd);
			
			OUT[0] = LS01.OUT;
			NOT_19.IN[0] = INB;
			NOT_19.Implement(cmd);
			
			TP03.IN[0] = NOT_19.OUT;
			TP03.PT[0] = 3;
			TP03.Implement(cmd);
			
			AND_21.IN1[0] = INB;
			AND_21.IN2[0] = IN2;
			AND_21.Implement(cmd);
			
			TON05.IN[0] = AND_21.OUT;
			TON05.PT[0] = 3;
			TON05.Implement(cmd);
			
			OR_23.IN1[0] = TP03.Q;
			OR_23.IN2[0] = TON05.Q;
			OR_23.Implement(cmd);
			
			AND_24.IN1[0] = LS01.OUT;
			AND_24.IN2[0] = OR_23.OUT;
			AND_24.Implement(cmd);
			
			OUTA[0] = AND_24.OUT;
			AND_26.IN1[0] = IN2;
			AND_26.IN2[0] = INA;
			AND_26.Implement(cmd);
			
			TON06.IN[0] = AND_26.OUT;
			TON06.PT[0] = 3;
			TON06.Implement(cmd);
			
			NOT_28.IN[0] = INA;
			NOT_28.Implement(cmd);
			
			TP04.IN[0] = NOT_28.OUT;
			TP04.PT[0] = 3;
			TP04.Implement(cmd);
			
			OR_30.IN1[0] = TON06.Q;
			OR_30.IN2[0] = TP04.Q;
			OR_30.Implement(cmd);
			
			AND_31.IN1[0] = LS01.OUT;
			AND_31.IN2[0] = OR_30.OUT;
			AND_31.Implement(cmd);
			
			OUTB[0] = AND_31.OUT;
			OR_33.IN1[0] = INA;
			OR_33.IN2[0] = INB;
			OR_33.Implement(cmd);
			
			AND_34.IN1[0] = IN1;
			AND_34.IN2[0] = OR_33.OUT;
			AND_34.Implement(cmd);
			
		}
	}
}
