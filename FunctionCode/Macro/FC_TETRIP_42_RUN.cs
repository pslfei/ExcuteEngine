using DCSCommon;

namespace FunctionCode
{
	public partial class TETRIP_42
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
				OR_64.Command = this.Command;
				GE_66.Command = this.Command;
				B.Command = this.Command;
				LT_68.Command = this.Command;
				TP.Command = this.Command;
				A.Command = this.Command;
				SUB_71.Command = this.Command;
				GT_72.Command = this.Command;
				OR_73.Command = this.Command;
				AND_74.Command = this.Command;
				RS01.Command = this.Command;
				CTE_RT.Command = this.Command;
				SUB_77.Command = this.Command;
				LT_78.Command = this.Command;
				TP01.Command = this.Command;
				RS02.Command = this.Command;
				AND_81.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			OR_64.IN1[0] = TP01.Q;
			OR_64.IN2[0] = SY;
			OR_64.Implement(cmd);
			
			GE_66.IN1[0] = TE;
			GE_66.IN2[0] = SP;
			GE_66.Implement(cmd);
			
			B.IN[0] = GE_66.OUT;
			B.PT[0] = 0.5;
			B.Implement(cmd);
			
			LT_68.IN1[0] = TE;
			LT_68.IN2[0] = SP;
			LT_68.Implement(cmd);
			
			TP.IN[0] = LT_68.OUT;
			TP.PT[0] = DW;
			TP.Implement(cmd);
			
			A.IN[0] = TE;
			A.HL[0] = 1.5;
			A.LL[0] = 50;
			A.Implement(cmd);
			
			SUB_71.IN1[0] = TE;
			SUB_71.IN2[0] = A.AV;
			SUB_71.Implement(cmd);
			
			GT_72.IN1[0] = SUB_71.OUT;
			GT_72.IN2[0] = 1.5;
			GT_72.Implement(cmd);
			
			OR_73.IN1[0] = B.Q;
			OR_73.IN2[0] = GT_72.OUT;
			OR_73.Implement(cmd);
			
			AND_74.IN1[0] = GE_66.OUT;
			AND_74.IN2[0] = !OR_73.OUT;
			AND_74.Implement(cmd);
			
			RS01.SET[0] = AND_74.OUT;
			RS01.RESET1[0] = TP.Q;
			RS01.Implement(cmd);
			
			CTE_RT.IN[0] = TE;
			CTE_RT.Implement(cmd);
			
			SUB_77.IN1[0] = SP;
			SUB_77.IN2[0] = 10;
			SUB_77.Implement(cmd);
			
			LT_78.IN1[0] = TE;
			LT_78.IN2[0] = SUB_77.OUT;
			LT_78.Implement(cmd);
			
			TP01.IN[0] = LT_78.OUT;
			TP01.PT[0] = 1;
			TP01.Implement(cmd);
			
			RS02.SET[0] = CTE_RT.DV;
			RS02.RESET1[0] = OR_64.OUT;
			RS02.Implement(cmd);
			
			AND_81.IN1[0] = RS01.Q1;
			AND_81.IN2[0] = !RS02.Q1;
			AND_81.Implement(cmd);
			
			TRIP[0] = AND_81.OUT;
		}
	}
}
