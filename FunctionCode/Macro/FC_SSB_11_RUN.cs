using DCSCommon;
namespace FunctionCode
{
	public partial class SSB_11
	{
		public override ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
				AND_77.Command = this.Command;
				AND_9.Command = this.Command;
				AND_12.Command = this.Command;
				OR_17.Command = this.Command;
				RS1.Command = this.Command;
				TON1.Command = this.Command;
				AND_79.Command = this.Command;
				TIME_TO_DWORD_81.Command = this.Command;
				DIV_86.Command = this.Command;
				OR_89.Command = this.Command;
				OR_33.Command = this.Command;
				RS2.Command = this.Command;
				AND_29.Command = this.Command;
				AND_101.Command = this.Command;
				AND_69.Command = this.Command;
				OR_50.Command = this.Command;
				OR_96.Command = this.Command;
				RS3.Command = this.Command;
				AND_105.Command = this.Command;
				OR_100.Command = this.Command;
				SEL_91.Command = this.Command;
				AND_115.Command = this.Command;
				AND_108.Command = this.Command;
				RS4.Command = this.Command;
				TOF01.Command = this.Command;
				OR_117.Command = this.Command;
				RS5.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AND_77.IN1[0] = IN;
			AND_77.IN2[0] = RU;
			AND_77.Implement(cmd);
			
			AND_9.IN1[0] = !JT;
			AND_9.IN2[0] = AND_77.OUT;
			AND_9.Implement(cmd);
			
			AND_12.IN1[0] = !SC1;
			AND_12.IN2[0] = AND_9.OUT;
			AND_12.Implement(cmd);
			
			OR_17.IN1[0] = !RU;
			OR_17.IN2[0] = JT;
			OR_17.IN3[0] = SC1;
			OR_17.IN4[0] = DR;
			OR_17.Implement(cmd);
			
			RS1.SET[0] = AND_12.OUT;
			RS1.RESET1[0] = OR_17.OUT;
			RS1.Implement(cmd);
			
			TON1.IN[0] = RS1.Q1;
			TON1.PT[0] = T1;
			TON1.Implement(cmd);
			
			AND_79.IN1[0] = RS1.Q1;
			AND_79.IN2[0] = !TON1.Q;
			AND_79.Implement(cmd);
			
			OT[0] = AND_79.OUT;
			SF[0] = TON1.Q;
			TIME_TO_DWORD_81.IN[0] = TON1.ET;
			TIME_TO_DWORD_81.Implement(cmd);
			
			DIV_86.IN1[0] = TIME_TO_DWORD_81.OUT;
			DIV_86.IN2[0] = 1;
			DIV_86.Implement(cmd);
			
			ET = (uint)DIV_86.OUT;
			OR_89.IN1[0] = SC1;
			OR_89.IN2[0] = JT;
			OR_89.Implement(cmd);
			
			OR_33.IN1[0] = FI;
			OR_33.IN2[0] = DR;
			OR_33.IN3[0] = !RU;
			OR_33.Implement(cmd);
			
			RS2.SET[0] = AND_9.OUT;
			RS2.RESET1[0] = OR_33.OUT;
			RS2.Implement(cmd);
			
			AND_29.IN1[0] = OR_89.OUT;
			AND_29.IN2[0] = RS2.Q1;
			AND_29.Implement(cmd);
			
			AND_101.IN1[0] = AND_29.OUT;
			AND_101.IN2[0] = !WT;
			AND_101.Implement(cmd);
			
			SO[0] = AND_101.OUT;
			AND_69.IN1[0] = IN;
			AND_69.IN2[0] = !RS1.Q1;
			AND_69.IN3[0] = JT;
			AND_69.Implement(cmd);
			
			OR_50.IN1[0] = AND_29.OUT;
			OR_50.IN2[0] = AND_69.OUT;
			OR_50.Implement(cmd);
			
			OR_96.IN1[0] = DR;
			OR_96.IN2[0] = !RU;
			OR_96.Implement(cmd);
			
			RS3.SET[0] = OR_50.OUT;
			RS3.RESET1[0] = OR_96.OUT;
			RS3.Implement(cmd);
			
			AND_105.IN1[0] = !WT;
			AND_105.IN2[0] = RS3.Q1;
			AND_105.Implement(cmd);
			
			JP[0] = AND_105.OUT;
			UR[0] = IN;
			OR_100.IN1[0] = OT;
			OR_100.IN2[0] = JP;
			OR_100.Implement(cmd);
			
			SEL_91.IN0[0] = RS5.Q1;
			SEL_91.IN1[0] = 0;
			SEL_91.G[0] = BB;
			SEL_91.Implement(cmd);
			
			B1[0] = SEL_91.OUT;
			AND_115.IN1[0] = OR_100.OUT;
			AND_115.IN2[0] = RU;
			AND_115.Implement(cmd);
			
			AND_108.IN1[0] = SC1;
			AND_108.IN2[0] = OR_117.OUT;
			AND_108.Implement(cmd);
			
			RS4.SET[0] = AND_108.OUT;
			RS4.RESET1[0] = !RU;
			RS4.Implement(cmd);
			
			SC = RS4.Q1;
			TOF01.IN[0] = OT;
			TOF01.Implement(cmd);
			
			OR_117.IN1[0] = TOF01.Q;
			OR_117.IN2[0] = SO;
			OR_117.Implement(cmd);
			
			RS5.SET[0] = AND_115.OUT;
			RS5.RESET1[0] = !RU;
			RS5.Implement(cmd);
			
		}
	}
}
