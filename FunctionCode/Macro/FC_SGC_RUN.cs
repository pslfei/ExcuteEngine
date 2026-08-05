using DCSCommon;

namespace FunctionCode
{
	public partial class SGC
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
				TP1.Command = this.Command;
				AND_11.Command = this.Command;
				OR_12.Command = this.Command;
				AND_15.Command = this.Command;
				OTTON.Command = this.Command;
				OR_70.Command = this.Command;
				RS1.Command = this.Command;
				VOPTP.Command = this.Command;
				OR_26.Command = this.Command;
				RS3.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TP1.IN[0] = AO;
			TP1.PT[0] = 5;
			TP1.Implement(cmd);
			
			AND_11.IN1[0] = MO;
			AND_11.IN2[0] = !TP1.Q;
			AND_11.Implement(cmd);
			
			OR_12.IN1[0] = AND_11.OUT;
			OR_12.IN2[0] = TP1.Q;
			OR_12.Implement(cmd);
			
			AND_15.IN1[0] = !OT;
			AND_15.IN2[0] = OP;
			AND_15.IN3[0] = !RS3.Q1;
			AND_15.IN4[0] = !FI;
			AND_15.IN5[0] = !VO;
			AND_15.IN6[0] = OR_12.OUT;
			AND_15.Implement(cmd);
			
			OTTON.IN[0] = OT;
			OTTON.PT[0] = 10;
			OTTON.Implement(cmd);
			
			OR_70.IN1[0] = OTTON.Q;
			OR_70.IN2[0] = MP;
			OR_70.IN3[0] = SP;
			OR_70.Implement(cmd);
			
			RS1.SET[0] = AND_15.OUT;
			RS1.RESET1[0] = OR_70.OUT;
			RS1.Implement(cmd);
			
			VO[0] = RS1.Q1;
			VOPTP.IN[0] = RS1.Q1;
			VOPTP.PT[0] = 1;
			VOPTP.Implement(cmd);
			
			VOP[0] = VOPTP.Q;
			OR_26.IN1[0] = OR_12.OUT;
			OR_26.IN2[0] = OR_70.OUT;
			OR_26.IN3[0] = TP1.Q;
			OR_26.Implement(cmd);
			
			RS3.SET[0] = FI;
			RS3.RESET1[0] = OR_26.OUT;
			RS3.Implement(cmd);
			
			FO[0] = RS3.Q1;
		}
	}
}
