using DCSCommon;

namespace FunctionCode
{
	public partial class P1FM
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
				GT_35.Command = this.Command;
				LT_37.Command = this.Command;
				OR_38.Command = this.Command;
				SUB_41.Command = this.Command;
				ABS_42.Command = this.Command;
				GT_43.Command = this.Command;
				OR_44.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GT_35.IN1[0] = PID1.PV;
			GT_35.IN2[0] = PID1.PU;
			GT_35.Implement(cmd);
			
			LT_37.IN1[0] = PID1.PV;
			LT_37.IN2[0] = PID1.PD;
			LT_37.Implement(cmd);
			
			OR_38.IN1[0] = GT_35.OUT;
			OR_38.IN2[0] = LT_37.OUT;
			OR_38.Implement(cmd);
			
			SUB_41.IN1[0] = MAN.AV;
			SUB_41.IN2[0] = MAN.TP;
			SUB_41.Implement(cmd);
			
			ABS_42.IN[0] = SUB_41.OUT;
			ABS_42.Implement(cmd);
			
			GT_43.IN1[0] = ABS_42.OUT;
			GT_43.IN2[0] = DV;
			GT_43.Implement(cmd);
			
			OR_44.IN1[0] = OR_38.OUT;
			OR_44.IN2[0] = GT_43.OUT;
			OR_44.IN3[0] = PID1.DA;
			OR_44.IN4[0] = FM1;
			OR_44.Implement(cmd);
			
			FM[0] = OR_44.OUT;
		}
	}
}
