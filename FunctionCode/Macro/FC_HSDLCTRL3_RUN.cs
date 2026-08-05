using DCSCommon;
namespace FunctionCode
{
	public partial class HSDLCTRL3
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
				OR_4.Command = this.Command;
				RS1.Command = this.Command;
				AND_126.Command = this.Command;
				OR_155.Command = this.Command;
				AND_130.Command = this.Command;
				OR_131.Command = this.Command;
				OR_15.Command = this.Command;
				AND_135.Command = this.Command;
				OR_156.Command = this.Command;
				AND_142.Command = this.Command;
				OR_136.Command = this.Command;
				OR_23.Command = this.Command;
				RS2.Command = this.Command;
				RS6.Command = this.Command;
				AND_31.Command = this.Command;
				OR_38.Command = this.Command;
				AND_42.Command = this.Command;
				OR_32.Command = this.Command;
				OR_49.Command = this.Command;
				AND_50.Command = this.Command;
				OR_51.Command = this.Command;
				T4.Command = this.Command;
				RS4.Command = this.Command;
				AND_148.Command = this.Command;
				AND_152.Command = this.Command;
				AND_159.Command = this.Command;
				T6.Command = this.Command;
				T3_1.Command = this.Command;
				AND_55.Command = this.Command;
				OR_61.Command = this.Command;
				AND_62.Command = this.Command;
				OR_56.Command = this.Command;
				OR_70.Command = this.Command;
				AND_71.Command = this.Command;
				OR_68.Command = this.Command;
				T5.Command = this.Command;
				RS5.Command = this.Command;
				AND_168.Command = this.Command;
				T8.Command = this.Command;
				RS8.Command = this.Command;
				AND_78.Command = this.Command;
				OR_79.Command = this.Command;
				AND_81.Command = this.Command;
				T1_1.Command = this.Command;
				OR_87.Command = this.Command;
				AND_107.Command = this.Command;
				OR_108.Command = this.Command;
				AND_109.Command = this.Command;
				T2_1.Command = this.Command;
				OR_113.Command = this.Command;
				T9.Command = this.Command;
				T10.Command = this.Command;
				OR_205.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			OR_4.IN1[0] = HH;
			OR_4.IN2[0] = Z3;
			OR_4.IN3[0] = IP_RS;
			OR_4.IN4[0] = VAR01;
			OR_4.Implement(cmd);
			
			RS1.SET[0] = Z1;
			RS1.RESET1[0] = OR_4.OUT;
			RS1.Implement(cmd);
			
			YH = RS1.Q1;
			AND_126.IN1[0] = !YH;
			AND_126.IN2[0] = !HH;
			AND_126.IN3[0] = !FH;
			AND_126.IN4[0] = I2;
			AND_126.Implement(cmd);
			
			OR_155.IN1[0] = YH;
			OR_155.IN2[0] = HH;
			OR_155.Implement(cmd);
			
			AND_130.IN1[0] = I2;
			AND_130.IN2[0] = OR_155.OUT;
			AND_130.Implement(cmd);
			
			OR_131.IN1[0] = AND_126.OUT;
			OR_131.IN2[0] = AND_130.OUT;
			OR_131.Implement(cmd);
			
			LS = OR_131.OUT;
			OR_15.IN1[0] = ZH;
			OR_15.IN2[0] = ZF;
			OR_15.IN3[0] = BH;
			OR_15.IN4[0] = BF;
			OR_15.Implement(cmd);
			
			VAR01 = OR_15.OUT;
			AND_135.IN1[0] = !FH;
			AND_135.IN2[0] = !YF;
			AND_135.IN3[0] = !HH;
			AND_135.IN4[0] = I1;
			AND_135.Implement(cmd);
			
			OR_156.IN1[0] = YF;
			OR_156.IN2[0] = FH;
			OR_156.Implement(cmd);
			
			AND_142.IN1[0] = I1;
			AND_142.IN2[0] = OR_156.OUT;
			AND_142.Implement(cmd);
			
			OR_136.IN1[0] = AND_135.OUT;
			OR_136.IN2[0] = AND_142.OUT;
			OR_136.Implement(cmd);
			
			HS = OR_136.OUT;
			OR_23.IN1[0] = FH;
			OR_23.IN2[0] = Z1;
			OR_23.IN3[0] = IP_RS;
			OR_23.IN4[0] = VAR01;
			OR_23.Implement(cmd);
			
			RS2.SET[0] = Z3;
			RS2.RESET1[0] = OR_23.OUT;
			RS2.Implement(cmd);
			
			YF = RS2.Q1;
			RS6.SET[0] = T6.Q;
			RS6.RESET1[0] = IP_RS;
			RS6.Implement(cmd);
			
			AND_31.IN1[0] = YH;
			AND_31.IN2[0] = Z2;
			AND_31.Implement(cmd);
			
			OR_38.IN1[0] = IP_RS;
			OR_38.IN2[0] = ZH;
			OR_38.IN3[0] = BH;
			OR_38.Implement(cmd);
			
			AND_42.IN1[0] = OR_38.OUT;
			AND_42.IN2[0] = I1;
			AND_42.IN3[0] = !I2;
			AND_42.Implement(cmd);
			
			OR_32.IN1[0] = AND_31.OUT;
			OR_32.IN2[0] = AND_42.OUT;
			OR_32.Implement(cmd);
			
			OR_49.IN1[0] = IP_RS;
			OR_49.IN2[0] = VAR01;
			OR_49.Implement(cmd);
			
			AND_50.IN1[0] = OR_49.OUT;
			AND_50.IN2[0] = !I1;
			AND_50.IN3[0] = I2;
			AND_50.Implement(cmd);
			
			OR_51.IN1[0] = Z3;
			OR_51.IN2[0] = AND_50.OUT;
			OR_51.Implement(cmd);
			
			T4.IN[0] = OR_32.OUT;
			T4.Implement(cmd);
			
			RS4.SET[0] = T4.Q;
			RS4.RESET1[0] = OR_51.OUT;
			RS4.Implement(cmd);
			
			HH = RS4.Q1;
			AND_148.IN1[0] = I2;
			AND_148.IN2[0] = FH;
			AND_148.Implement(cmd);
			
			LP = AND_148.OUT;
			AND_152.IN1[0] = I1;
			AND_152.IN2[0] = HH;
			AND_152.Implement(cmd);
			
			HP = AND_152.OUT;
			AND_159.IN1[0] = I2;
			AND_159.IN2[0] = HH;
			AND_159.Implement(cmd);
			
			T6.IN[0] = AND_159.OUT;
			T6.Implement(cmd);
			
			C1[0] = RS6.Q1;
			T3_1.SS[0] = T6.Q;
			T3_1.RS[0] = IP_RS;
			T3_1.TC[0] = T3;
			T3_1.Implement(cmd);
			
			C2[0] = T3_1.DV;
			AND_55.IN1[0] = YF;
			AND_55.IN2[0] = Z4;
			AND_55.Implement(cmd);
			
			OR_61.IN1[0] = IP_RS;
			OR_61.IN2[0] = ZF;
			OR_61.IN3[0] = BF;
			OR_61.Implement(cmd);
			
			AND_62.IN1[0] = OR_61.OUT;
			AND_62.IN2[0] = !I1;
			AND_62.IN3[0] = I2;
			AND_62.Implement(cmd);
			
			OR_56.IN1[0] = AND_55.OUT;
			OR_56.IN2[0] = AND_62.OUT;
			OR_56.Implement(cmd);
			
			OR_70.IN1[0] = IP_RS;
			OR_70.IN2[0] = VAR01;
			OR_70.Implement(cmd);
			
			AND_71.IN1[0] = OR_70.OUT;
			AND_71.IN2[0] = I1;
			AND_71.IN3[0] = !I2;
			AND_71.Implement(cmd);
			
			OR_68.IN1[0] = Z1;
			OR_68.IN2[0] = AND_71.OUT;
			OR_68.Implement(cmd);
			
			T5.IN[0] = OR_56.OUT;
			T5.Implement(cmd);
			
			RS5.SET[0] = T5.Q;
			RS5.RESET1[0] = OR_68.OUT;
			RS5.Implement(cmd);
			
			FH = RS5.Q1;
			AND_168.IN1[0] = I1;
			AND_168.IN2[0] = FH;
			AND_168.Implement(cmd);
			
			T8.IN[0] = AND_168.OUT;
			T8.Implement(cmd);
			
			RS8.SET[0] = T8.Q;
			RS8.RESET1[0] = IP_RS;
			RS8.Implement(cmd);
			
			C3[0] = RS8.Q1;
			AND_78.IN1[0] = YH;
			AND_78.IN2[0] = Z2;
			AND_78.Implement(cmd);
			
			OR_79.IN1[0] = AND_78.OUT;
			OR_79.IN2[0] = ZH;
			OR_79.Implement(cmd);
			
			AND_81.IN1[0] = OR_79.OUT;
			AND_81.IN2[0] = !I1;
			AND_81.IN3[0] = I2;
			AND_81.IN4[0] = HX;
			AND_81.IN5[0] = I4;
			AND_81.IN6[0] = !JC;
			AND_81.Implement(cmd);
			
			T1_1.SS[0] = AND_81.OUT;
			T1_1.RS[0] = IP_RS;
			T1_1.TC[0] = T1;
			T1_1.Implement(cmd);
			
			OR_87.IN1[0] = T1_1.DV;
			OR_87.IN2[0] = BH;
			OR_87.Implement(cmd);
			
			DV[0] = OR_87.OUT;
			AND_107.IN1[0] = YF;
			AND_107.IN2[0] = Z4;
			AND_107.Implement(cmd);
			
			OR_108.IN1[0] = AND_107.OUT;
			OR_108.IN2[0] = ZF;
			OR_108.Implement(cmd);
			
			AND_109.IN1[0] = OR_108.OUT;
			AND_109.IN2[0] = I1;
			AND_109.IN3[0] = !I2;
			AND_109.IN4[0] = FX;
			AND_109.IN5[0] = I4;
			AND_109.IN6[0] = !JC;
			AND_109.Implement(cmd);
			
			T2_1.SS[0] = AND_109.OUT;
			T2_1.RS[0] = IP_RS;
			T2_1.TC[0] = T2;
			T2_1.Implement(cmd);
			
			OR_113.IN1[0] = T2_1.DV;
			OR_113.IN2[0] = BF;
			OR_113.Implement(cmd);
			
			RV[0] = OR_113.OUT;
			T9.IN[0] = true;
			T9.Implement(cmd);
			
			T10.IN[0] = T9.Q;
			T10.Implement(cmd);
			
			OR_205.IN1[0] = T10.Q;
			OR_205.IN2[0] = IP;
			OR_205.Implement(cmd);
			
			IP_RS = OR_205.OUT;
		}
	}
}
