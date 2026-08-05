using DCSCommon;

namespace FunctionCode
{
	public partial class P2FM
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
				GT_4.Command = this.Command;
				GT_11.Command = this.Command;
				LT_6.Command = this.Command;
				OR_8.Command = this.Command;
				LT_16.Command = this.Command;
				OR_13.Command = this.Command;
				SUB_20.Command = this.Command;
				ABS_21.Command = this.Command;
				GT_22.Command = this.Command;
				OR_30.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GT_4.IN1[0] = PID1.PV;
			GT_4.IN2[0] = PID1.PU;
			GT_4.Implement(cmd);
			
			GT_11.IN1[0] = PID2.PV;
			GT_11.IN2[0] = PID2.PU;
			GT_11.Implement(cmd);
			
			LT_6.IN1[0] = PID1.PV;
			LT_6.IN2[0] = PID1.PD;
			LT_6.Implement(cmd);
			
			OR_8.IN1[0] = GT_4.OUT;
			OR_8.IN2[0] = LT_6.OUT;
			OR_8.Implement(cmd);
			
			LT_16.IN1[0] = PID2.PV;
			LT_16.IN2[0] = PID2.PD;
			LT_16.Implement(cmd);
			
			OR_13.IN1[0] = GT_11.OUT;
			OR_13.IN2[0] = LT_16.OUT;
			OR_13.Implement(cmd);
			
			SUB_20.IN1[0] = MAN.AV;
			SUB_20.IN2[0] = MAN.TP;
			SUB_20.Implement(cmd);
			
			ABS_21.IN[0] = SUB_20.OUT;
			ABS_21.Implement(cmd);
			
			GT_22.IN1[0] = ABS_21.OUT;
			GT_22.IN2[0] = DV;
			GT_22.Implement(cmd);
			
			OR_30.IN1[0] = OR_13.OUT;
			OR_30.IN2[0] = OR_8.OUT;
			OR_30.IN3[0] = GT_22.OUT;
			OR_30.IN4[0] = PID1.DA;
			OR_30.IN5[0] = PID2.DA;
			OR_30.IN6[0] = FM1;
			OR_30.IN7[0] = FM2;
			OR_30.Implement(cmd);
			
			FM[0] = OR_30.OUT;
		}
	}
}
