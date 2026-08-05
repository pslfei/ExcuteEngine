using DCSCommon;
namespace FunctionCode
{
	public partial class HS3SEL2_YX
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
				AND_12.Command = this.Command;
				AND_17.Command = this.Command;
				AND_7.Command = this.Command;
				OR_40.Command = this.Command;
				AND_38.Command = this.Command;
				OR_45.Command = this.Command;
				AND_46.Command = this.Command;
				OR_52.Command = this.Command;
				AND_53.Command = this.Command;
				AND_60.Command = this.Command;
				AND_65.Command = this.Command;
				AND_70.Command = this.Command;
				OR_10.Command = this.Command;
				AND_86.Command = this.Command;
				AND_87.Command = this.Command;
				AND_88.Command = this.Command;
				AND_95.Command = this.Command;
				AND_96.Command = this.Command;
				AND_97.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AND_12.IN1[0] = B1;
			AND_12.IN2[0] = B2;
			AND_12.Implement(cmd);
			
			AND_17.IN1[0] = !DQ1;
			AND_17.IN2[0] = !DQ2;
			AND_17.IN3[0] = !DQ3;
			AND_17.Implement(cmd);
			
			AND_7.IN1[0] = AND_12.OUT;
			AND_7.IN2[0] = AND_17.OUT;
			AND_7.Implement(cmd);
			
			OR_40.IN1[0] = B1;
			OR_40.IN2[0] = B3;
			OR_40.Implement(cmd);
			
			AND_38.IN1[0] = OR_40.OUT;
			AND_38.IN2[0] = !DQ1;
			AND_38.IN3[0] = DQ2;
			AND_38.IN4[0] = !DQ3;
			AND_38.Implement(cmd);
			
			OR_45.IN1[0] = B2;
			OR_45.IN2[0] = B3;
			OR_45.Implement(cmd);
			
			AND_46.IN1[0] = OR_45.OUT;
			AND_46.IN2[0] = DQ1;
			AND_46.IN3[0] = !DQ2;
			AND_46.IN4[0] = !DQ3;
			AND_46.Implement(cmd);
			
			OR_52.IN1[0] = B1;
			OR_52.IN2[0] = B2;
			OR_52.Implement(cmd);
			
			AND_53.IN1[0] = OR_52.OUT;
			AND_53.IN2[0] = !DQ1;
			AND_53.IN3[0] = !DQ2;
			AND_53.IN4[0] = DQ3;
			AND_53.Implement(cmd);
			
			AND_60.IN1[0] = B1;
			AND_60.IN2[0] = !DQ1;
			AND_60.IN3[0] = DQ2;
			AND_60.IN4[0] = DQ3;
			AND_60.Implement(cmd);
			
			AND_65.IN1[0] = B2;
			AND_65.IN2[0] = DQ1;
			AND_65.IN3[0] = !DQ2;
			AND_65.IN4[0] = DQ3;
			AND_65.Implement(cmd);
			
			AND_70.IN1[0] = B3;
			AND_70.IN2[0] = DQ1;
			AND_70.IN3[0] = DQ2;
			AND_70.IN4[0] = !DQ3;
			AND_70.Implement(cmd);
			
			OR_10.IN1[0] = AND_7.OUT;
			OR_10.IN2[0] = AND_88.OUT;
			OR_10.IN3[0] = AND_97.OUT;
			OR_10.IN4[0] = AND_38.OUT;
			OR_10.IN5[0] = AND_46.OUT;
			OR_10.IN6[0] = AND_53.OUT;
			OR_10.IN7[0] = AND_60.OUT;
			OR_10.IN8[0] = AND_65.OUT;
			OR_10.IN9[0] = AND_70.OUT;
			OR_10.Implement(cmd);
			
			DV[0] = OR_10.OUT;
			AND_86.IN1[0] = B1;
			AND_86.IN2[0] = B3;
			AND_86.Implement(cmd);
			
			AND_87.IN1[0] = !DQ1;
			AND_87.IN2[0] = !DQ2;
			AND_87.IN3[0] = !DQ3;
			AND_87.Implement(cmd);
			
			AND_88.IN1[0] = AND_86.OUT;
			AND_88.IN2[0] = AND_87.OUT;
			AND_88.Implement(cmd);
			
			AND_95.IN1[0] = B2;
			AND_95.IN2[0] = B3;
			AND_95.Implement(cmd);
			
			AND_96.IN1[0] = !DQ1;
			AND_96.IN2[0] = !DQ2;
			AND_96.IN3[0] = !DQ3;
			AND_96.Implement(cmd);
			
			AND_97.IN1[0] = AND_95.OUT;
			AND_97.IN2[0] = AND_96.OUT;
			AND_97.Implement(cmd);
			
		}
	}
}
