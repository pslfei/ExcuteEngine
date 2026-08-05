using DCSCommon;
namespace FunctionCode
{
	public partial class HSCSLAVE5_45
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
				TPMS.Command = this.Command;
				ZLRT.Command = this.Command;
				LT_295.Command = this.Command;
				GT_296.Command = this.Command;
				OR_297.Command = this.Command;
				OR_299.Command = this.Command;
				OR_300.Command = this.Command;
				SEL_301.Command = this.Command;
				SEL_303.Command = this.Command;
				SEL_304.Command = this.Command;
				SEL_309.Command = this.Command;
				SEL_310.Command = this.Command;
				SEL_311.Command = this.Command;
				OR_306.Command = this.Command;
				SEL_307.Command = this.Command;
				OR_313.Command = this.Command;
				TOFZH.Command = this.Command;
				REAL_TO_TIME_316.Command = this.Command;
				LT_454.Command = this.Command;
				AND_456.Command = this.Command;
				REAL_TO_TIME_445.Command = this.Command;
				TP31.Command = this.Command;
				SUB_328.Command = this.Command;
				LE_324.Command = this.Command;
				AND_319.Command = this.Command;
				OR_421.Command = this.Command;
				TP11.Command = this.Command;
				LE_325.Command = this.Command;
				OR_323.Command = this.Command;
				MUL_334.Command = this.Command;
				LE_329.Command = this.Command;
				GT_448.Command = this.Command;
				AND_451.Command = this.Command;
				REAL_TO_TIME_447.Command = this.Command;
				TP32.Command = this.Command;
				MUL_317.Command = this.Command;
				LE_331.Command = this.Command;
				AND_332.Command = this.Command;
				OR_423.Command = this.Command;
				REAL_TO_TIME_318.Command = this.Command;
				TP12.Command = this.Command;
				OR_330.Command = this.Command;
				AND_321.Command = this.Command;
				AND_326.Command = this.Command;
				OR_335.Command = this.Command;
				REAL_TO_TIME_336.Command = this.Command;
				TP22.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			TPMS.IN[0] = !AM;
			TPMS.Implement(cmd);
			
			ZLRT.IN[0] = ZT;
			ZLRT.Implement(cmd);
			
			LT_295.IN1[0] = OT;
			LT_295.IN2[0] = ZT;
			LT_295.Implement(cmd);
			
			GT_296.IN1[0] = OB;
			GT_296.IN2[0] = ZT;
			GT_296.Implement(cmd);
			
			OR_297.IN1[0] = ZLRT.DV;
			OR_297.IN2[0] = LT_295.OUT;
			OR_297.IN3[0] = GT_296.OUT;
			OR_297.Implement(cmd);
			
			GZ[0] = OR_297.OUT;
			OR_299.IN1[0] = TPMS.Q;
			OR_299.IN2[0] = AMZH;
			OR_299.IN3[0] = QC;
			OR_299.IN4[0] = OR_297.OUT;
			OR_299.Implement(cmd);
			
			OR_300.IN1[0] = FM;
			OR_300.IN2[0] = !AM;
			OR_300.IN3[0] = OR_299.OUT;
			OR_300.Implement(cmd);
			
			SEL_301.IN0[0] = OR_300.OUT;
			SEL_301.IN1[0] = SP;
			SEL_301.G[0] = PV;
			SEL_301.Implement(cmd);
			
			SP[0] = SEL_301.OUT;
			SEL_303.IN0[0] = AM;
			SEL_303.IN1[0] = MS;
			SEL_303.G[0] = IN;
			SEL_303.Implement(cmd);
			
			SEL_304.IN0[0] = OR_299.OUT;
			SEL_304.IN1[0] = SEL_303.OUT;
			SEL_304.G[0] = ZT;
			SEL_304.Implement(cmd);
			
			MS[0] = SEL_304.OUT;
			SEL_309.IN0[0] = AM;
			SEL_309.IN1[0] = 0;
			SEL_309.G[0] = 1;
			SEL_309.Implement(cmd);
			
			SEL_310.IN0[0] = FM;
			SEL_310.IN1[0] = SEL_309.OUT;
			SEL_310.G[0] = 3;
			SEL_310.Implement(cmd);
			
			SEL_311.IN0[0] = GZ;
			SEL_311.IN1[0] = SEL_310.OUT;
			SEL_311.G[0] = 4;
			SEL_311.Implement(cmd);
			
			RM = (byte)SEL_311.OUT;
			OR_306.IN1[0] = GZ;
			OR_306.IN2[0] = FM;
			OR_306.Implement(cmd);
			
			SEL_307.IN0[0] = OR_306.OUT;
			SEL_307.IN1[0] = AM;
			SEL_307.G[0] = 0;
			SEL_307.Implement(cmd);
			
			AM[0] = SEL_307.OUT;
			OR_313.IN1[0] = AO;
			OR_313.IN2[0] = AC;
			OR_313.IN3[0] = MO;
			OR_313.IN4[0] = MC;
			OR_313.IN5[0] = M1;
			OR_313.IN6[0] = M2;
			OR_313.Implement(cmd);
			
			TOFZH.IN[0] = OR_313.OUT;
			TOFZH.Implement(cmd);
			
			AMZH = TOFZH.Q;
			REAL_TO_TIME_316.IN[0] = T1;
			REAL_TO_TIME_316.Implement(cmd);
			
			LT_454.IN1[0] = ZT;
			LT_454.IN2[0] = 92;
			LT_454.Implement(cmd);
			
			AND_456.IN1[0] = LT_454.OUT;
			AND_456.IN2[0] = M1;
			AND_456.Implement(cmd);
			
			REAL_TO_TIME_445.IN[0] = T3;
			REAL_TO_TIME_445.Implement(cmd);
			
			TP31.IN[0] = AND_456.OUT;
			TP31.PT[0] = REAL_TO_TIME_445.OUT;
			TP31.Implement(cmd);
			
			SUB_328.IN1[0] = MS;
			SUB_328.IN2[0] = ZT;
			SUB_328.Implement(cmd);
			
			LE_324.IN1[0] = DB;
			LE_324.IN2[0] = SUB_328.OUT;
			LE_324.Implement(cmd);
			
			AND_319.IN1[0] = !TP22.Q;
			AND_319.IN2[0] = LE_324.OUT;
			AND_319.Implement(cmd);
			
			OR_421.IN1[0] = MO;
			OR_421.IN2[0] = AND_319.OUT;
			OR_421.Implement(cmd);
			
			TP11.IN[0] = OR_421.OUT;
			TP11.PT[0] = REAL_TO_TIME_316.OUT;
			TP11.Implement(cmd);
			
			LE_325.IN1[0] = DL;
			LE_325.IN2[0] = SUB_328.OUT;
			LE_325.Implement(cmd);
			
			OR_323.IN1[0] = TP11.Q;
			OR_323.IN2[0] = AO;
			OR_323.IN3[0] = LE_325.OUT;
			OR_323.IN4[0] = TP31.Q;
			OR_323.Implement(cmd);
			
			MUL_334.IN1[0] = -1;
			MUL_334.IN2[0] = DL;
			MUL_334.Implement(cmd);
			
			LE_329.IN1[0] = SUB_328.OUT;
			LE_329.IN2[0] = MUL_334.OUT;
			LE_329.Implement(cmd);
			
			GT_448.IN1[0] = ZT;
			GT_448.IN2[0] = 8;
			GT_448.Implement(cmd);
			
			AND_451.IN1[0] = GT_448.OUT;
			AND_451.IN2[0] = M2;
			AND_451.Implement(cmd);
			
			REAL_TO_TIME_447.IN[0] = T3;
			REAL_TO_TIME_447.Implement(cmd);
			
			TP32.IN[0] = AND_451.OUT;
			TP32.PT[0] = REAL_TO_TIME_447.OUT;
			TP32.Implement(cmd);
			
			MUL_317.IN1[0] = -1;
			MUL_317.IN2[0] = DB;
			MUL_317.Implement(cmd);
			
			LE_331.IN1[0] = SUB_328.OUT;
			LE_331.IN2[0] = MUL_317.OUT;
			LE_331.Implement(cmd);
			
			AND_332.IN1[0] = LE_331.OUT;
			AND_332.IN2[0] = !TP22.Q;
			AND_332.Implement(cmd);
			
			OR_423.IN1[0] = AND_332.OUT;
			OR_423.IN2[0] = MC;
			OR_423.Implement(cmd);
			
			REAL_TO_TIME_318.IN[0] = T1;
			REAL_TO_TIME_318.Implement(cmd);
			
			TP12.IN[0] = OR_423.OUT;
			TP12.PT[0] = REAL_TO_TIME_318.OUT;
			TP12.Implement(cmd);
			
			OR_330.IN1[0] = AC;
			OR_330.IN2[0] = LE_329.OUT;
			OR_330.IN3[0] = TP32.Q;
			OR_330.IN4[0] = TP12.Q;
			OR_330.Implement(cmd);
			
			AND_321.IN1[0] = OR_323.OUT;
			AND_321.IN2[0] = !OR_330.OUT;
			AND_321.IN3[0] = !JC;
			AND_321.Implement(cmd);
			
			DV[0] = AND_321.OUT;
			AND_326.IN1[0] = !OR_323.OUT;
			AND_326.IN2[0] = OR_330.OUT;
			AND_326.IN3[0] = !JC;
			AND_326.Implement(cmd);
			
			RV[0] = AND_326.OUT;
			OR_335.IN1[0] = TP11.Q;
			OR_335.IN2[0] = TP12.Q;
			OR_335.Implement(cmd);
			
			REAL_TO_TIME_336.IN[0] = T2;
			REAL_TO_TIME_336.Implement(cmd);
			
			TP22.IN[0] = OR_335.OUT;
			TP22.PT[0] = REAL_TO_TIME_336.OUT;
			TP22.Implement(cmd);
			
		}
	}
}
