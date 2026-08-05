using DCSCommon;

namespace FunctionCode
{
	public partial class SLC1
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
				OR_7.Command = this.Command;
				AND_25.Command = this.Command;
				RS1.Command = this.Command;
				TP1.Command = this.Command;
				RS3.Command = this.Command;
				OR_23.Command = this.Command;
				AND_18.Command = this.Command;
				TOF1.Command = this.Command;
				TON2.Command = this.Command;
				OR_9.Command = this.Command;
				AND_26.Command = this.Command;
				RS2.Command = this.Command;
				TON1.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			OR_7.IN1[0] = MON;
			OR_7.IN2[0] = AON;
			OR_7.Implement(cmd);
			
			AND_25.IN1[0] = OR_7.OUT;
			AND_25.IN2[0] = !OR_23.OUT;
			AND_25.Implement(cmd);
			
			RS1.SET[0] = AND_25.OUT;
			RS1.RESET1[0] = AND_26.OUT;
			RS1.Implement(cmd);
			
			ON[0] = RS1.Q1;
			TP1.IN[0] = MBL;
			TP1.PT[0] = 1;
			TP1.Implement(cmd);
			
			RS3.SET[0] = TP1.Q;
			RS3.RESET1[0] = TOF1.Q;
			RS3.Implement(cmd);
			
			OR_23.IN1[0] = TON1.Q;
			OR_23.IN2[0] = RS3.Q1;
			OR_23.Implement(cmd);
			
			AND_18.IN1[0] = TP1.Q;
			AND_18.IN2[0] = TON2.Q;
			AND_18.Implement(cmd);
			
			TOF1.IN[0] = AND_18.OUT;
			TOF1.PT[0] = 2;
			TOF1.Implement(cmd);
			
			TON2.IN[0] = RS3.Q1;
			TON2.PT[0] = 2;
			TON2.Implement(cmd);
			
			OR_9.IN1[0] = MOFF;
			OR_9.IN2[0] = AOFF;
			OR_9.Implement(cmd);
			
			AND_26.IN1[0] = OR_9.OUT;
			AND_26.IN2[0] = !OR_23.OUT;
			AND_26.Implement(cmd);
			
			RS2.SET[0] = AND_26.OUT;
			RS2.RESET1[0] = AND_25.OUT;
			RS2.Implement(cmd);
			
			OFF[0] = RS2.Q1;
			TON1.IN[0] = BL;
			TON1.PT[0] = 1;
			TON1.Implement(cmd);
			
		}
	}
}
