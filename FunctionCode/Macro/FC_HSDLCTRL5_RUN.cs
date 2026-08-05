using DCSCommon;

namespace FunctionCode
{
	public partial class HSDLCTRL5
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
				OR_19.Command = this.Command;
				AND_307.Command = this.Command;
				OR_309.Command = this.Command;
				AND_7.Command = this.Command;
				OR_9.Command = this.Command;
				RSYH.Command = this.Command;
				OR_136.Command = this.Command;
				AND_137.Command = this.Command;
				AND_24.Command = this.Command;
				AND_32.Command = this.Command;
				OR_25.Command = this.Command;
				AND_38.Command = this.Command;
				OR_40.Command = this.Command;
				RSHH.Command = this.Command;
				AND_46.Command = this.Command;
				AND_52.Command = this.Command;
				AND_258.Command = this.Command;
				OR_56.Command = this.Command;
				AND_57.Command = this.Command;
				OR_305.Command = this.Command;
				AND_306.Command = this.Command;
				REAL_TO_TIME_320.Command = this.Command;
				TIMEWH.Command = this.Command;
				AND_222.Command = this.Command;
				TRIGH.Command = this.Command;
				AND_161.Command = this.Command;
				OR_270.Command = this.Command;
				RSC1.Command = this.Command;
				AND_310.Command = this.Command;
				OR_311.Command = this.Command;
				AND_71.Command = this.Command;
				OR_79.Command = this.Command;
				RSYF.Command = this.Command;
				OR_142.Command = this.Command;
				AND_146.Command = this.Command;
				AND_82.Command = this.Command;
				AND_90.Command = this.Command;
				OR_83.Command = this.Command;
				AND_103.Command = this.Command;
				OR_95.Command = this.Command;
				RSFH.Command = this.Command;
				AND_98.Command = this.Command;
				AND_106.Command = this.Command;
				AND_266.Command = this.Command;
				OR_109.Command = this.Command;
				AND_313.Command = this.Command;
				OR_314.Command = this.Command;
				AND_110.Command = this.Command;
				REAL_TO_TIME_321.Command = this.Command;
				TIMEWF.Command = this.Command;
				AND_229.Command = this.Command;
				TRIGF.Command = this.Command;
				AND_158.Command = this.Command;
				OR_273.Command = this.Command;
				RSC2.Command = this.Command;
				RTRIG1.Command = this.Command;
				AND_183.Command = this.Command;
				RSC3.Command = this.Command;
				RTRIG2.Command = this.Command;
				AND_185.Command = this.Command;
				RSC4.Command = this.Command;
				XOR_216.Command = this.Command;
				SEL_189.Command = this.Command;
				SEL_193.Command = this.Command;
				SEL_200.Command = this.Command;
				SEL_205.Command = this.Command;
				SEL_209.Command = this.Command;
				SEL_212.Command = this.Command;
				SEL_265.Command = this.Command;
				SEL_197.Command = this.Command;
				SEL_324.Command = this.Command;
				AND_237.Command = this.Command;
				SEL_219.Command = this.Command;
				SEL_225.Command = this.Command;
				SEL_231.Command = this.Command;
				AND_243.Command = this.Command;
				SEL_245.Command = this.Command;
				SEL_250.Command = this.Command;
				SEL_244.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
        {
            //IP[0] = IP1;
            //IP1 = IP2;
            //IP2 = IP3;
            #region 将IP管脚的长指令改为脉冲指令 李飞 20120619

            if (OLD_IP == false && IP == true)
            {
                IP0To1 = true;
                SampleTime = cmd.Dpu.Cycle * cmd.Dpu.CycleCount;
            }
            OLD_IP = IP;

            if (IP0To1)
            {
                if (cmd.Dpu.Cycle * cmd.Dpu.CycleCount > (SampleTime + 2.0))
                {
                    IP[0] = false;
                    IP0To1 = false;
                }
            }      
     
            #endregion


            OR_19.IN1[0] = IP;
			OR_19.IN2[0] = MR;
			OR_19.Implement(cmd);

			RP = OR_19.OUT;
			AND_307.IN1[0] = !I3;
			AND_307.IN2[0] = !RL;
			AND_307.Implement(cmd);
			
			OR_309.IN1[0] = SY;
			OR_309.IN2[0] = AND_307.OUT;
			OR_309.Implement(cmd);
			
			AND_7.IN1[0] = Z1;
			AND_7.IN2[0] = !I1;
			AND_7.IN3[0] = I2;
			AND_7.IN4[0] = OR_309.OUT;
			AND_7.Implement(cmd);
			
			OR_9.IN1[0] = HH;
			OR_9.IN2[0] = RP;
			OR_9.Implement(cmd);
			
			RSYH.SET[0] = AND_7.OUT;
			RSYH.RESET1[0] = OR_9.OUT;
			RSYH.Implement(cmd);
			
			YH = RSYH.Q1;
			OR_136.IN1[0] = YH;
			OR_136.IN2[0] = HH;
			OR_136.Implement(cmd);
			
			AND_137.IN1[0] = OR_136.OUT;
			AND_137.IN2[0] = I2;
			AND_137.Implement(cmd);
			
			LS = AND_137.OUT;
			AND_24.IN1[0] = YH;
			AND_24.IN2[0] = Z2;
			AND_24.Implement(cmd);
			
			AND_32.IN1[0] = I1;
			AND_32.IN2[0] = !I2;
			AND_32.IN3[0] = RP;
			AND_32.Implement(cmd);
			
			OR_25.IN1[0] = AND_24.OUT;
			OR_25.IN2[0] = ZH;
			OR_25.IN3[0] = AND_32.OUT;
			OR_25.Implement(cmd);
			
			AND_38.IN1[0] = !I1;
			AND_38.IN2[0] = I2;
			AND_38.IN3[0] = RP;
			AND_38.Implement(cmd);
			
			OR_40.IN1[0] = Z3;
			OR_40.IN2[0] = ZF;
			OR_40.IN3[0] = AND_38.OUT;
			OR_40.Implement(cmd);
			
			RSHH.SET[0] = OR_25.OUT;
			RSHH.RESET1[0] = OR_40.OUT;
			RSHH.Implement(cmd);
			
			HH = RSHH.Q1;
			AND_46.IN1[0] = I1;
			AND_46.IN2[0] = HH;
			AND_46.Implement(cmd);
			
			HP = AND_46.OUT;
			AND_52.IN1[0] = YH;
			AND_52.IN2[0] = Z2;
			AND_52.Implement(cmd);
			
			AND_258.IN1[0] = ZH;
			AND_258.IN2[0] = !ZF;
			AND_258.IN3[0] = !SY;
			AND_258.Implement(cmd);
			
			OR_56.IN1[0] = AND_52.OUT;
			OR_56.IN2[0] = AND_258.OUT;
			OR_56.Implement(cmd);
			
			AND_57.IN1[0] = HX;
			AND_57.IN2[0] = !RL;
			AND_57.IN3[0] = !I3;
			AND_57.Implement(cmd);
			
			OR_305.IN1[0] = SY;
			OR_305.IN2[0] = AND_57.OUT;
			OR_305.Implement(cmd);
			
			AND_306.IN1[0] = OR_56.OUT;
			AND_306.IN2[0] = !I1;
			AND_306.IN3[0] = I2;
			AND_306.IN4[0] = OR_305.OUT;
			AND_306.Implement(cmd);
			
			REAL_TO_TIME_320.IN[0] = T1 / 1000;
			REAL_TO_TIME_320.Implement(cmd);
			
			TIMEWH.IN[0] = AND_306.OUT;
			TIMEWH.PT[0] = REAL_TO_TIME_320.OUT;
			TIMEWH.Implement(cmd);
			
			AND_222.IN1[0] = TIMEWH.Q;
			AND_222.IN2[0] = !I1;
			AND_222.Implement(cmd);
			
			DV[0] = AND_222.OUT;
			TRIGH.CLK[0] = DV;
			TRIGH.Implement(cmd);
			
			AND_161.IN1[0] = TRIGH.Q;
			AND_161.IN2[0] = !I1;
			AND_161.Implement(cmd);
			
			OR_270.IN1[0] = I1;
			OR_270.IN2[0] = MR;
			OR_270.Implement(cmd);
			
			RSC1.SET[0] = AND_161.OUT;
			RSC1.RESET1[0] = OR_270.OUT;
			RSC1.Implement(cmd);
			
			C1[0] = RSC1.Q1;
			AND_310.IN1[0] = !I3;
			AND_310.IN2[0] = !RL;
			AND_310.Implement(cmd);
			
			OR_311.IN1[0] = SY;
			OR_311.IN2[0] = AND_310.OUT;
			OR_311.Implement(cmd);
			
			AND_71.IN1[0] = Z3;
			AND_71.IN2[0] = I1;
			AND_71.IN3[0] = !I2;
			AND_71.IN4[0] = OR_311.OUT;
			AND_71.Implement(cmd);
			
			OR_79.IN1[0] = FH;
			OR_79.IN2[0] = RP;
			OR_79.Implement(cmd);
			
			RSYF.SET[0] = AND_71.OUT;
			RSYF.RESET1[0] = OR_79.OUT;
			RSYF.Implement(cmd);
			
			YF = RSYF.Q1;
			OR_142.IN1[0] = YF;
			OR_142.IN2[0] = FH;
			OR_142.Implement(cmd);
			
			AND_146.IN1[0] = OR_142.OUT;
			AND_146.IN2[0] = I1;
			AND_146.Implement(cmd);
			
			HS = AND_146.OUT;
			AND_82.IN1[0] = YF;
			AND_82.IN2[0] = Z4;
			AND_82.Implement(cmd);
			
			AND_90.IN1[0] = !I1;
			AND_90.IN2[0] = I2;
			AND_90.IN3[0] = RP;
			AND_90.Implement(cmd);
			
			OR_83.IN1[0] = AND_82.OUT;
			OR_83.IN2[0] = ZF;
			OR_83.IN3[0] = AND_90.OUT;
			OR_83.Implement(cmd);
			
			AND_103.IN1[0] = I1;
			AND_103.IN2[0] = !I2;
			AND_103.IN3[0] = RP;
			AND_103.Implement(cmd);
			
			OR_95.IN1[0] = Z1;
			OR_95.IN2[0] = ZH;
			OR_95.IN3[0] = AND_103.OUT;
			OR_95.Implement(cmd);
			
			RSFH.SET[0] = OR_83.OUT;
			RSFH.RESET1[0] = OR_95.OUT;
			RSFH.Implement(cmd);
			
			FH = RSFH.Q1;
			AND_98.IN1[0] = I2;
			AND_98.IN2[0] = FH;
			AND_98.Implement(cmd);
			
			LP = AND_98.OUT;
			AND_106.IN1[0] = YF;
			AND_106.IN2[0] = Z4;
			AND_106.Implement(cmd);
			
			AND_266.IN1[0] = ZF;
			AND_266.IN2[0] = !ZH;
			AND_266.IN3[0] = !SY;
			AND_266.Implement(cmd);
			
			OR_109.IN1[0] = AND_106.OUT;
			OR_109.IN2[0] = AND_266.OUT;
			OR_109.Implement(cmd);
			
			AND_313.IN1[0] = FX;
			AND_313.IN2[0] = !I3;
			AND_313.IN3[0] = !RL;
			AND_313.Implement(cmd);
			
			OR_314.IN1[0] = SY;
			OR_314.IN2[0] = AND_313.OUT;
			OR_314.Implement(cmd);
			
			AND_110.IN1[0] = OR_109.OUT;
			AND_110.IN2[0] = I1;
			AND_110.IN3[0] = !I2;
			AND_110.IN4[0] = OR_314.OUT;
			AND_110.Implement(cmd);
			
			REAL_TO_TIME_321.IN[0] = T2 / 1000;
			REAL_TO_TIME_321.Implement(cmd);
			
			TIMEWF.IN[0] = AND_110.OUT;
			TIMEWF.PT[0] = REAL_TO_TIME_321.OUT;
			TIMEWF.Implement(cmd);
			
			AND_229.IN1[0] = TIMEWF.Q;
			AND_229.IN2[0] = !I2;
			AND_229.Implement(cmd);
			
			RV[0] = AND_229.OUT;
			TRIGF.CLK[0] = RV;
			TRIGF.Implement(cmd);
			
			AND_158.IN1[0] = TRIGF.Q;
			AND_158.IN2[0] = !I2;
			AND_158.Implement(cmd);
			
			OR_273.IN1[0] = I2;
			OR_273.IN2[0] = MR;
			OR_273.Implement(cmd);
			
			RSC2.SET[0] = AND_158.OUT;
			RSC2.RESET1[0] = OR_273.OUT;
			RSC2.Implement(cmd);
			
			C2[0] = RSC2.Q1;
			RTRIG1.CLK[0] = I2;
			RTRIG1.Implement(cmd);
			
			AND_183.IN1[0] = HH;
			AND_183.IN2[0] = RTRIG1.Q;
			AND_183.Implement(cmd);
			
			RSC3.SET[0] = AND_183.OUT;
			RSC3.RESET1[0] = RP;
			RSC3.Implement(cmd);
			
			OC = RSC3.Q1;
			RTRIG2.CLK[0] = I1;
			RTRIG2.Implement(cmd);
			
			AND_185.IN1[0] = FH;
			AND_185.IN2[0] = RTRIG2.Q;
			AND_185.Implement(cmd);
			
			RSC4.SET[0] = AND_185.OUT;
			RSC4.RESET1[0] = RP;
			RSC4.Implement(cmd);
			
			CO = RSC4.Q1;
			XOR_216.IN1[0] = I1;
			XOR_216.IN2[0] = I2;
			XOR_216.Implement(cmd);
			
			SEL_189.G[0] = XOR_216.OUT;
			SEL_189.IN0[0] = 1;
			SEL_189.IN1[0] = 0;
			SEL_189.Implement(cmd);
			
			SEL_193.G[0] = RL;
			SEL_193.IN0[0] = SEL_189.OUT;
			SEL_193.IN1[0] = 2;
			SEL_193.Implement(cmd);
			
			SEL_200.G[0] = C1;
			SEL_200.IN0[0] = SEL_193.OUT;
			SEL_200.IN1[0] = 4;
			SEL_200.Implement(cmd);
			
			SEL_205.G[0] = C2;
			SEL_205.IN0[0] = SEL_200.OUT;
			SEL_205.IN1[0] = 5;
			SEL_205.Implement(cmd);
			
			SEL_209.G[0] = CO;
			SEL_209.IN0[0] = SEL_205.OUT;
			SEL_209.IN1[0] = 6;
			SEL_209.Implement(cmd);
			
			SEL_212.G[0] = OC;
			SEL_212.IN0[0] = SEL_209.OUT;
			SEL_212.IN1[0] = 7;
			SEL_212.Implement(cmd);
			
			SEL_265.G[0] = I3;
			SEL_265.IN0[0] = SEL_212.OUT;
			SEL_265.IN1[0] = 8;
			SEL_265.Implement(cmd);
			
			SEL_197.G[0] = SY;
			SEL_197.IN0[0] = SEL_265.OUT;
			SEL_197.IN1[0] = 9;
			SEL_197.Implement(cmd);
			
			SEL_324.G[0] = JC;
			SEL_324.IN0[0] = SEL_197.OUT;
			SEL_324.IN1[0] = 3;
			SEL_324.Implement(cmd);
			
			FN = (byte)SEL_324.OUT;
			AND_237.IN1[0] = ZH;
			AND_237.IN2[0] = ZF;
			AND_237.Implement(cmd);
			
			SEL_219.G[0] = ZH;
			SEL_219.IN0[0] = 0;
			SEL_219.IN1[0] = 1;
			SEL_219.Implement(cmd);
			
			SEL_225.G[0] = ZF;
			SEL_225.IN0[0] = SEL_219.OUT;
			SEL_225.IN1[0] = 2;
			SEL_225.Implement(cmd);
			
			SEL_231.G[0] = AND_237.OUT;
			SEL_231.IN0[0] = SEL_225.OUT;
			SEL_231.IN1[0] = 3;
			SEL_231.Implement(cmd);
			
			CE = (byte)SEL_231.OUT;
			AND_243.IN1[0] = I1;
			AND_243.IN2[0] = I2;
			AND_243.Implement(cmd);
			
			SEL_245.G[0] = I1;
			SEL_245.IN0[0] = 0;
			SEL_245.IN1[0] = 1;
			SEL_245.Implement(cmd);
			
			SEL_250.G[0] = I2;
			SEL_250.IN0[0] = SEL_245.OUT;
			SEL_250.IN1[0] = 2;
			SEL_250.Implement(cmd);
			
			SEL_244.G[0] = AND_243.OUT;
			SEL_244.IN0[0] = SEL_250.OUT;
			SEL_244.IN1[0] = 3;
			SEL_244.Implement(cmd);
			
			SE = (byte)SEL_244.OUT;
		}
	}
}
