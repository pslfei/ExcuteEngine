using DCSCommon;

namespace FunctionCode
{
	public partial class TSTQ
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
				SUB_12.Command = this.Command;
				ABS_13.Command = this.Command;
				MUL_14.Command = this.Command;
				ADD_18.Command = this.Command;
				GT_1.Command = this.Command;
				SUB_20.Command = this.Command;
				LT_7.Command = this.Command;
				OR_4.Command = this.Command;
				TON1.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			SUB_12.IN1[0] = MU;
			SUB_12.IN2[0] = MD;
			SUB_12.Implement(cmd);
			
			ABS_13.IN[0] = SUB_12.OUT;
			ABS_13.Implement(cmd);
			
			MUL_14.IN1[0] = ABS_13.OUT;
			MUL_14.IN2[0] = P5;
			MUL_14.Implement(cmd);
			
			A5 = MUL_14.OUT;
			ADD_18.IN1[0] = MU;
			ADD_18.IN2[0] = A5;
			ADD_18.Implement(cmd);
			
			GT_1.IN1[0] = I1;
			GT_1.IN2[0] = ADD_18.OUT;
			GT_1.Implement(cmd);
			
			SUB_20.IN1[0] = MD;
			SUB_20.IN2[0] = A5;
			SUB_20.Implement(cmd);
			
			LT_7.IN1[0] = I1;
			LT_7.IN2[0] = SUB_20.OUT;
			LT_7.Implement(cmd);
			
			OR_4.IN1[0] = GT_1.OUT;
			OR_4.IN2[0] = LT_7.OUT;
			OR_4.Implement(cmd);
			
			TON1.IN[0] = OR_4.OUT;
			TON1.PT[0] = 6;
			TON1.Implement(cmd);
			
			DV[0] = TON1.Q;
		}
	}
}
