using DCSCommon;

namespace FunctionCode
{
	public partial class TETRIP
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
				TP.Command = this.Command;
				LT_22.Command = this.Command;
				GT_6.Command = this.Command;
				A.Command = this.Command;
				SUB_11.Command = this.Command;
				GT_12.Command = this.Command;
				B.Command = this.Command;
				OR_14.Command = this.Command;
				AND_8.Command = this.Command;
				RS01.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TP.IN[0] = LT_22.OUT;
			TP.PT[0] = DW;
			TP.Implement(cmd);
			
			LT_22.IN1[0] = TE;
			LT_22.IN2[0] = SP;
			LT_22.Implement(cmd);
			
			GT_6.IN1[0] = TE;
			GT_6.IN2[0] = SP;
			GT_6.Implement(cmd);
			
			A.IN[0] = TE;
			A.HL[0] = 2;
			A.LL[0] = 50;
			A.Implement(cmd);
			
			SUB_11.IN1[0] = TE;
			SUB_11.IN2[0] = A.AV;
			SUB_11.Implement(cmd);
			
			GT_12.IN1[0] = SUB_11.OUT;
			GT_12.IN2[0] = SP1;
			GT_12.Implement(cmd);
			
			B.IN[0] = GT_6.OUT;
			B.PT[0] = 0.5;
			B.Implement(cmd);
			
			OR_14.IN1[0] = B.Q;
			OR_14.IN2[0] = GT_12.OUT;
			OR_14.Implement(cmd);
			
			AND_8.IN1[0] = GT_6.OUT;
			AND_8.IN2[0] = !OR_14.OUT;
			AND_8.Implement(cmd);
			
			RS01.SET[0] = AND_8.OUT;
			RS01.RESET1[0] = TP.Q;
			RS01.Implement(cmd);
			
			TRIP[0] = RS01.Q1;
		}
	}
}
