using DCSCommon;

namespace FunctionCode
{
	public partial class HSSC3
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
				RS1.Command = this.Command;
				AND_5.Command = this.Command;
				OR_85.Command = this.Command;
				AND_7.Command = this.Command;
				AND_9.Command = this.Command;
				AND_11.Command = this.Command;
				AND_13.Command = this.Command;
				AND_15.Command = this.Command;
				AND_17.Command = this.Command;
				AND_19.Command = this.Command;
				AND_21.Command = this.Command;
				AND_23.Command = this.Command;
				AND_25.Command = this.Command;
				AND_27.Command = this.Command;
				AND_29.Command = this.Command;
				AND_31.Command = this.Command;
				AND_33.Command = this.Command;
				RS2.Command = this.Command;
				RS3.Command = this.Command;
				RS4.Command = this.Command;
				RS5.Command = this.Command;
				RS6.Command = this.Command;
				RS7.Command = this.Command;
				RS8.Command = this.Command;
				RS9.Command = this.Command;
				RS10.Command = this.Command;
				RS11.Command = this.Command;
				RS12.Command = this.Command;
				RS13.Command = this.Command;
				RS14.Command = this.Command;
				RS15.Command = this.Command;
				OR_124.Command = this.Command;
				AND_140.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			RS1.SET[0] = AND_5.OUT;
			RS1.RESET1[0] = I17;
			RS1.Implement(cmd);
			
			AND_5.IN1[0] = I1;
			AND_5.IN2[0] = !O16;
			AND_5.Implement(cmd);
			
			O1[0] = RS1.Q1;
			O16[0] = OR_85.OUT;
			OR_85.IN1[0] = O1;
			OR_85.IN2[0] = O2;
			OR_85.IN3[0] = O3;
			OR_85.IN4[0] = O4;
			OR_85.IN5[0] = O5;
			OR_85.IN6[0] = O6;
			OR_85.IN7[0] = O7;
			OR_85.IN8[0] = O8;
			OR_85.IN9[0] = O9;
			OR_85.IN10[0] = O10;
			OR_85.IN11[0] = O11;
			OR_85.IN12[0] = O12;
			OR_85.IN13[0] = O13;
			OR_85.IN14[0] = O14;
			OR_85.IN15[0] = O15;
			OR_85.Implement(cmd);
			
			AND_7.IN1[0] = I2;
			AND_7.IN2[0] = !O16;
			AND_7.Implement(cmd);
			
			AND_9.IN1[0] = I3;
			AND_9.IN2[0] = !O16;
			AND_9.Implement(cmd);
			
			AND_11.IN1[0] = I4;
			AND_11.IN2[0] = !O16;
			AND_11.Implement(cmd);
			
			AND_13.IN1[0] = I5;
			AND_13.IN2[0] = !O16;
			AND_13.Implement(cmd);
			
			AND_15.IN1[0] = I6;
			AND_15.IN2[0] = !O16;
			AND_15.Implement(cmd);
			
			AND_17.IN1[0] = I7;
			AND_17.IN2[0] = !O16;
			AND_17.Implement(cmd);
			
			AND_19.IN1[0] = I8;
			AND_19.IN2[0] = !O16;
			AND_19.Implement(cmd);
			
			AND_21.IN1[0] = I9;
			AND_21.IN2[0] = !O16;
			AND_21.Implement(cmd);
			
			AND_23.IN1[0] = I10;
			AND_23.IN2[0] = !O16;
			AND_23.Implement(cmd);
			
			AND_25.IN1[0] = I11;
			AND_25.IN2[0] = !O16;
			AND_25.Implement(cmd);
			
			AND_27.IN1[0] = I12;
			AND_27.IN2[0] = !O16;
			AND_27.Implement(cmd);
			
			AND_29.IN1[0] = I13;
			AND_29.IN2[0] = !O16;
			AND_29.Implement(cmd);
			
			AND_31.IN1[0] = I14;
			AND_31.IN2[0] = !O16;
			AND_31.Implement(cmd);
			
			AND_33.IN1[0] = I15;
			AND_33.IN2[0] = !O16;
			AND_33.Implement(cmd);
			
			RS2.SET[0] = AND_7.OUT;
			RS2.RESET1[0] = I17;
			RS2.Implement(cmd);
			
			RS3.SET[0] = AND_9.OUT;
			RS3.RESET1[0] = I17;
			RS3.Implement(cmd);
			
			RS4.SET[0] = AND_11.OUT;
			RS4.RESET1[0] = I17;
			RS4.Implement(cmd);
			
			RS5.SET[0] = AND_13.OUT;
			RS5.RESET1[0] = I17;
			RS5.Implement(cmd);
			
			RS6.SET[0] = AND_15.OUT;
			RS6.RESET1[0] = I17;
			RS6.Implement(cmd);
			
			RS7.SET[0] = AND_17.OUT;
			RS7.RESET1[0] = I17;
			RS7.Implement(cmd);
			
			RS8.SET[0] = AND_19.OUT;
			RS8.RESET1[0] = I17;
			RS8.Implement(cmd);
			
			RS9.SET[0] = AND_21.OUT;
			RS9.RESET1[0] = I17;
			RS9.Implement(cmd);
			
			RS10.SET[0] = AND_23.OUT;
			RS10.RESET1[0] = I17;
			RS10.Implement(cmd);
			
			RS11.SET[0] = AND_25.OUT;
			RS11.RESET1[0] = I17;
			RS11.Implement(cmd);
			
			RS12.SET[0] = AND_27.OUT;
			RS12.RESET1[0] = I17;
			RS12.Implement(cmd);
			
			RS13.SET[0] = AND_29.OUT;
			RS13.RESET1[0] = I17;
			RS13.Implement(cmd);
			
			RS14.SET[0] = AND_31.OUT;
			RS14.RESET1[0] = I17;
			RS14.Implement(cmd);
			
			RS15.SET[0] = AND_33.OUT;
			RS15.RESET1[0] = I17;
			RS15.Implement(cmd);
			
			O2[0] = RS2.Q1;
			O3[0] = RS3.Q1;
			O4[0] = RS4.Q1;
			O5[0] = RS5.Q1;
			O6[0] = RS6.Q1;
			O7[0] = RS7.Q1;
			O8[0] = RS8.Q1;
			O9[0] = RS9.Q1;
			O10[0] = RS10.Q1;
			O11[0] = RS11.Q1;
			O12[0] = RS12.Q1;
			O13[0] = RS13.Q1;
			O14[0] = RS14.Q1;
			O15[0] = RS15.Q1;
			OR_124.IN1[0] = I1;
			OR_124.IN2[0] = I2;
			OR_124.IN3[0] = I3;
			OR_124.IN4[0] = I4;
			OR_124.IN5[0] = I5;
			OR_124.IN6[0] = I6;
			OR_124.IN7[0] = I7;
			OR_124.IN8[0] = I8;
			OR_124.IN9[0] = I9;
			OR_124.IN10[0] = I10;
			OR_124.IN11[0] = I11;
			OR_124.IN12[0] = I12;
			OR_124.IN13[0] = I13;
			OR_124.IN14[0] = I14;
			OR_124.IN15[0] = I15;
			OR_124.Implement(cmd);
			
			AND_140.IN1[0] = !OR_124.OUT;
			AND_140.IN2[0] = I16;
			AND_140.Implement(cmd);
			
			I17 = AND_140.OUT;
		}
	}
}
