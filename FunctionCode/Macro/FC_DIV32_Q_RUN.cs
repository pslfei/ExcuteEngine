using DCSCommon;

namespace FunctionCode
{
	public partial class DIV32_Q
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
				SEL_46.Command = this.Command;
				SEL_49.Command = this.Command;
				SEL_52.Command = this.Command;
				BOOL_TO_REAL_47.Command = this.Command;
				BOOL_TO_REAL_50.Command = this.Command;
				SEL_55.Command = this.Command;
				BOOL_TO_REAL_53.Command = this.Command;
				SEL_82.Command = this.Command;
				BOOL_TO_REAL_57.Command = this.Command;
				BOOL_TO_REAL_84.Command = this.Command;
				SEL_87.Command = this.Command;
				BOOL_TO_REAL_89.Command = this.Command;
				ADD_58.Command = this.Command;
				MAX_79.Command = this.Command;
				SEL_104.Command = this.Command;
				SEL_105.Command = this.Command;
				SEL_106.Command = this.Command;
				SEL_107.Command = this.Command;
				SEL_110.Command = this.Command;
				ADD_56.Command = this.Command;
				DIV_59.Command = this.Command;
				SEL_113.Command = this.Command;
				SEL_176.Command = this.Command;
				SEL_177.Command = this.Command;
				SEL_178.Command = this.Command;
				SEL_179.Command = this.Command;
				SEL_182.Command = this.Command;
				SEL_185.Command = this.Command;
				SEL_200.Command = this.Command;
				SEL_201.Command = this.Command;
				SEL_202.Command = this.Command;
				SEL_203.Command = this.Command;
				SEL_206.Command = this.Command;
				SEL_209.Command = this.Command;
				SEL_224.Command = this.Command;
				SEL_225.Command = this.Command;
				SEL_226.Command = this.Command;
				SEL_227.Command = this.Command;
				SEL_230.Command = this.Command;
				SEL_233.Command = this.Command;
				SEL_248.Command = this.Command;
				SEL_249.Command = this.Command;
				BOOL_TO_REAL_272.Command = this.Command;
				BOOL_TO_REAL_273.Command = this.Command;
				BOOL_TO_REAL_274.Command = this.Command;
				BOOL_TO_REAL_275.Command = this.Command;
				BOOL_TO_REAL_276.Command = this.Command;
				BOOL_TO_REAL_277.Command = this.Command;
				BOOL_TO_REAL_284.Command = this.Command;
				BOOL_TO_REAL_285.Command = this.Command;
				BOOL_TO_REAL_286.Command = this.Command;
				BOOL_TO_REAL_287.Command = this.Command;
				BOOL_TO_REAL_288.Command = this.Command;
				BOOL_TO_REAL_289.Command = this.Command;
				BOOL_TO_REAL_296.Command = this.Command;
				BOOL_TO_REAL_297.Command = this.Command;
				BOOL_TO_REAL_298.Command = this.Command;
				BOOL_TO_REAL_299.Command = this.Command;
				BOOL_TO_REAL_300.Command = this.Command;
				BOOL_TO_REAL_301.Command = this.Command;
				BOOL_TO_REAL_308.Command = this.Command;
				BOOL_TO_REAL_309.Command = this.Command;
				BOOL_TO_REAL_310.Command = this.Command;
				BOOL_TO_REAL_311.Command = this.Command;
				BOOL_TO_REAL_312.Command = this.Command;
				BOOL_TO_REAL_313.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			CS = MAX_79.OUT;
			SEL_46.G[0] = B1;
			SEL_46.IN0[0] = A1;
			SEL_46.IN1[0] = 0;
			SEL_46.Implement(cmd);
			
			SEL_49.G[0] = B2;
			SEL_49.IN0[0] = A2;
			SEL_49.IN1[0] = 0;
			SEL_49.Implement(cmd);
			
			SEL_52.G[0] = B3;
			SEL_52.IN0[0] = A3;
			SEL_52.IN1[0] = 0;
			SEL_52.Implement(cmd);
			
			BOOL_TO_REAL_47.IN[0] = !B1;
			BOOL_TO_REAL_47.Implement(cmd);
			
			BOOL_TO_REAL_50.IN[0] = !B2;
			BOOL_TO_REAL_50.Implement(cmd);
			
			SEL_55.G[0] = B4;
			SEL_55.IN0[0] = A4;
			SEL_55.IN1[0] = 0;
			SEL_55.Implement(cmd);
			
			BOOL_TO_REAL_53.IN[0] = !B3;
			BOOL_TO_REAL_53.Implement(cmd);
			
			SEL_82.G[0] = B5;
			SEL_82.IN0[0] = A5;
			SEL_82.IN1[0] = 0;
			SEL_82.Implement(cmd);
			
			BOOL_TO_REAL_57.IN[0] = !B4;
			BOOL_TO_REAL_57.Implement(cmd);
			
			BOOL_TO_REAL_84.IN[0] = !B5;
			BOOL_TO_REAL_84.Implement(cmd);
			
			SEL_87.G[0] = B6;
			SEL_87.IN0[0] = A6;
			SEL_87.IN1[0] = 0;
			SEL_87.Implement(cmd);
			
			BOOL_TO_REAL_89.IN[0] = !B6;
			BOOL_TO_REAL_89.Implement(cmd);
			
			ADD_58.IN1[0] = BOOL_TO_REAL_47.OUT;
			ADD_58.IN2[0] = BOOL_TO_REAL_50.OUT;
			ADD_58.IN3[0] = BOOL_TO_REAL_53.OUT;
			ADD_58.IN4[0] = BOOL_TO_REAL_57.OUT;
			ADD_58.IN5[0] = BOOL_TO_REAL_84.OUT;
			ADD_58.IN6[0] = BOOL_TO_REAL_89.OUT;
			ADD_58.IN7[0] = BOOL_TO_REAL_272.OUT;
			ADD_58.IN8[0] = BOOL_TO_REAL_273.OUT;
			ADD_58.IN9[0] = BOOL_TO_REAL_274.OUT;
			ADD_58.IN10[0] = BOOL_TO_REAL_275.OUT;
			ADD_58.IN11[0] = BOOL_TO_REAL_276.OUT;
			ADD_58.IN12[0] = BOOL_TO_REAL_275.OUT;
			ADD_58.IN13[0] = BOOL_TO_REAL_277.OUT;
			ADD_58.IN14[0] = BOOL_TO_REAL_284.OUT;
			ADD_58.IN15[0] = BOOL_TO_REAL_277.OUT;
			ADD_58.IN16[0] = BOOL_TO_REAL_285.OUT;
			ADD_58.IN17[0] = BOOL_TO_REAL_286.OUT;
			ADD_58.IN18[0] = BOOL_TO_REAL_287.OUT;
			ADD_58.IN19[0] = BOOL_TO_REAL_288.OUT;
			ADD_58.IN20[0] = BOOL_TO_REAL_289.OUT;
			ADD_58.IN21[0] = BOOL_TO_REAL_296.OUT;
			ADD_58.IN22[0] = BOOL_TO_REAL_297.OUT;
			ADD_58.IN23[0] = BOOL_TO_REAL_298.OUT;
			ADD_58.IN24[0] = BOOL_TO_REAL_299.OUT;
			ADD_58.IN25[0] = BOOL_TO_REAL_300.OUT;
			ADD_58.IN26[0] = BOOL_TO_REAL_301.OUT;
			ADD_58.IN27[0] = BOOL_TO_REAL_308.OUT;
			ADD_58.IN28[0] = BOOL_TO_REAL_301.OUT;
			ADD_58.IN29[0] = BOOL_TO_REAL_309.OUT;
			ADD_58.IN30[0] = BOOL_TO_REAL_310.OUT;
			ADD_58.IN31[0] = BOOL_TO_REAL_309.OUT;
			ADD_58.IN32[0] = BOOL_TO_REAL_311.OUT;
			ADD_58.IN33[0] = BOOL_TO_REAL_312.OUT;
			ADD_58.IN34[0] = BOOL_TO_REAL_313.OUT;
			ADD_58.Implement(cmd);
			
			MAX_79.IN1[0] = ADD_58.OUT;
			MAX_79.IN2[0] = 1;
			MAX_79.Implement(cmd);
			
			SEL_104.G[0] = B7;
			SEL_104.IN0[0] = A7;
			SEL_104.IN1[0] = 0;
			SEL_104.Implement(cmd);
			
			SEL_105.G[0] = B8;
			SEL_105.IN0[0] = A8;
			SEL_105.IN1[0] = 0;
			SEL_105.Implement(cmd);
			
			SEL_106.G[0] = B9;
			SEL_106.IN0[0] = A9;
			SEL_106.IN1[0] = 0;
			SEL_106.Implement(cmd);
			
			SEL_107.G[0] = B10;
			SEL_107.IN0[0] = A10;
			SEL_107.IN1[0] = 0;
			SEL_107.Implement(cmd);
			
			SEL_110.G[0] = B11;
			SEL_110.IN0[0] = A11;
			SEL_110.IN1[0] = 0;
			SEL_110.Implement(cmd);
			
			ADD_56.IN1[0] = SEL_46.OUT;
			ADD_56.IN2[0] = SEL_49.OUT;
			ADD_56.IN3[0] = SEL_52.OUT;
			ADD_56.IN4[0] = SEL_55.OUT;
			ADD_56.IN5[0] = SEL_82.OUT;
			ADD_56.IN6[0] = SEL_87.OUT;
			ADD_56.IN7[0] = SEL_104.OUT;
			ADD_56.IN8[0] = SEL_105.OUT;
			ADD_56.IN9[0] = SEL_106.OUT;
			ADD_56.IN10[0] = SEL_107.OUT;
			ADD_56.IN11[0] = SEL_110.OUT;
			ADD_56.IN12[0] = SEL_113.OUT;
			ADD_56.IN13[0] = SEL_176.OUT;
			ADD_56.IN14[0] = SEL_177.OUT;
			ADD_56.IN15[0] = SEL_178.OUT;
			ADD_56.IN16[0] = SEL_179.OUT;
			ADD_56.IN17[0] = SEL_182.OUT;
			ADD_56.IN18[0] = SEL_185.OUT;
			ADD_56.IN19[0] = SEL_200.OUT;
			ADD_56.IN20[0] = SEL_200.OUT;
			ADD_56.IN21[0] = SEL_201.OUT;
			ADD_56.IN22[0] = SEL_202.OUT;
			ADD_56.IN23[0] = SEL_203.OUT;
			ADD_56.IN24[0] = SEL_206.OUT;
			ADD_56.IN25[0] = SEL_209.OUT;
			ADD_56.IN26[0] = SEL_224.OUT;
			ADD_56.IN27[0] = SEL_225.OUT;
			ADD_56.IN28[0] = SEL_226.OUT;
			ADD_56.IN29[0] = SEL_227.OUT;
			ADD_56.IN30[0] = SEL_230.OUT;
			ADD_56.IN31[0] = SEL_233.OUT;
			ADD_56.IN32[0] = SEL_248.OUT;
			ADD_56.IN33[0] = SEL_249.OUT;
			ADD_56.Implement(cmd);
			
			DIV_59.IN1[0] = BCS;
			DIV_59.IN2[0] = CS;
			DIV_59.Implement(cmd);
			
			AV[0] = DIV_59.OUT;
			SEL_113.G[0] = B12;
			SEL_113.IN0[0] = A12;
			SEL_113.IN1[0] = 0;
			SEL_113.Implement(cmd);
			
			SEL_176.G[0] = B13;
			SEL_176.IN0[0] = A13;
			SEL_176.IN1[0] = 0;
			SEL_176.Implement(cmd);
			
			SEL_177.G[0] = B14;
			SEL_177.IN0[0] = A14;
			SEL_177.IN1[0] = 0;
			SEL_177.Implement(cmd);
			
			SEL_178.G[0] = B15;
			SEL_178.IN0[0] = A15;
			SEL_178.IN1[0] = 0;
			SEL_178.Implement(cmd);
			
			SEL_179.G[0] = B16;
			SEL_179.IN0[0] = A16;
			SEL_179.IN1[0] = 0;
			SEL_179.Implement(cmd);
			
			SEL_182.G[0] = B17;
			SEL_182.IN0[0] = A17;
			SEL_182.IN1[0] = 0;
			SEL_182.Implement(cmd);
			
			SEL_185.G[0] = B18;
			SEL_185.IN0[0] = A18;
			SEL_185.IN1[0] = 0;
			SEL_185.Implement(cmd);
			
			SEL_200.G[0] = B19;
			SEL_200.IN0[0] = A19;
			SEL_200.IN1[0] = 0;
			SEL_200.Implement(cmd);
			
			SEL_201.G[0] = B20;
			SEL_201.IN0[0] = A20;
			SEL_201.IN1[0] = 0;
			SEL_201.Implement(cmd);
			
			BCS = ADD_56.OUT;
			SEL_202.G[0] = B21;
			SEL_202.IN0[0] = A21;
			SEL_202.IN1[0] = 0;
			SEL_202.Implement(cmd);
			
			SEL_203.G[0] = B22;
			SEL_203.IN0[0] = A22;
			SEL_203.IN1[0] = 0;
			SEL_203.Implement(cmd);
			
			SEL_206.G[0] = B23;
			SEL_206.IN0[0] = A23;
			SEL_206.IN1[0] = 0;
			SEL_206.Implement(cmd);
			
			SEL_209.G[0] = B24;
			SEL_209.IN0[0] = A24;
			SEL_209.IN1[0] = 0;
			SEL_209.Implement(cmd);
			
			SEL_224.G[0] = B25;
			SEL_224.IN0[0] = A25;
			SEL_224.IN1[0] = 0;
			SEL_224.Implement(cmd);
			
			SEL_225.G[0] = B26;
			SEL_225.IN0[0] = A26;
			SEL_225.IN1[0] = 0;
			SEL_225.Implement(cmd);
			
			SEL_226.G[0] = B27;
			SEL_226.IN0[0] = A27;
			SEL_226.IN1[0] = 0;
			SEL_226.Implement(cmd);
			
			SEL_227.G[0] = B28;
			SEL_227.IN0[0] = A28;
			SEL_227.IN1[0] = 0;
			SEL_227.Implement(cmd);
			
			SEL_230.G[0] = B29;
			SEL_230.IN0[0] = A29;
			SEL_230.IN1[0] = 0;
			SEL_230.Implement(cmd);
			
			SEL_233.G[0] = B30;
			SEL_233.IN0[0] = A30;
			SEL_233.IN1[0] = 0;
			SEL_233.Implement(cmd);
			
			SEL_248.G[0] = B31;
			SEL_248.IN0[0] = A31;
			SEL_248.IN1[0] = 0;
			SEL_248.Implement(cmd);
			
			SEL_249.G[0] = B32;
			SEL_249.IN0[0] = A32;
			SEL_249.IN1[0] = 0;
			SEL_249.Implement(cmd);
			
			BOOL_TO_REAL_272.IN[0] = !B9;
			BOOL_TO_REAL_272.Implement(cmd);
			
			BOOL_TO_REAL_273.IN[0] = !B10;
			BOOL_TO_REAL_273.Implement(cmd);
			
			BOOL_TO_REAL_274.IN[0] = !B11;
			BOOL_TO_REAL_274.Implement(cmd);
			
			BOOL_TO_REAL_275.IN[0] = !B12;
			BOOL_TO_REAL_275.Implement(cmd);
			
			BOOL_TO_REAL_276.IN[0] = !B13;
			BOOL_TO_REAL_276.Implement(cmd);
			
			BOOL_TO_REAL_277.IN[0] = !B14;
			BOOL_TO_REAL_277.Implement(cmd);
			
			BOOL_TO_REAL_284.IN[0] = !B15;
			BOOL_TO_REAL_284.Implement(cmd);
			
			BOOL_TO_REAL_285.IN[0] = !B16;
			BOOL_TO_REAL_285.Implement(cmd);
			
			BOOL_TO_REAL_286.IN[0] = !B17;
			BOOL_TO_REAL_286.Implement(cmd);
			
			BOOL_TO_REAL_287.IN[0] = !B18;
			BOOL_TO_REAL_287.Implement(cmd);
			
			BOOL_TO_REAL_288.IN[0] = !B19;
			BOOL_TO_REAL_288.Implement(cmd);
			
			BOOL_TO_REAL_289.IN[0] = !B20;
			BOOL_TO_REAL_289.Implement(cmd);
			
			BOOL_TO_REAL_296.IN[0] = !B21;
			BOOL_TO_REAL_296.Implement(cmd);
			
			BOOL_TO_REAL_297.IN[0] = !B22;
			BOOL_TO_REAL_297.Implement(cmd);
			
			BOOL_TO_REAL_298.IN[0] = !B23;
			BOOL_TO_REAL_298.Implement(cmd);
			
			BOOL_TO_REAL_299.IN[0] = !B24;
			BOOL_TO_REAL_299.Implement(cmd);
			
			BOOL_TO_REAL_300.IN[0] = !B25;
			BOOL_TO_REAL_300.Implement(cmd);
			
			BOOL_TO_REAL_301.IN[0] = !B26;
			BOOL_TO_REAL_301.Implement(cmd);
			
			BOOL_TO_REAL_308.IN[0] = !B27;
			BOOL_TO_REAL_308.Implement(cmd);
			
			BOOL_TO_REAL_309.IN[0] = !B28;
			BOOL_TO_REAL_309.Implement(cmd);
			
			BOOL_TO_REAL_310.IN[0] = !B29;
			BOOL_TO_REAL_310.Implement(cmd);
			
			BOOL_TO_REAL_311.IN[0] = !B30;
			BOOL_TO_REAL_311.Implement(cmd);
			
			BOOL_TO_REAL_312.IN[0] = !B31;
			BOOL_TO_REAL_312.Implement(cmd);
			
			BOOL_TO_REAL_313.IN[0] = !B32;
			BOOL_TO_REAL_313.Implement(cmd);
			
		}
	}
}
