using DCSCommon;

namespace FunctionCode
{
	public partial class HSVALVE5
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
				ZLRT.Command = this.Command;
				LT_39.Command = this.Command;
				GT_40.Command = this.Command;
				OR_41.Command = this.Command;
				SEL_43.Command = this.Command;
				OR_95.Command = this.Command;
				TOFZH.Command = this.Command;
				REAL_TO_TIME_373.Command = this.Command;
				LT_374.Command = this.Command;
				AND_375.Command = this.Command;
				REAL_TO_TIME_376.Command = this.Command;
				TP31.Command = this.Command;
				SUB_378.Command = this.Command;
				LE_379.Command = this.Command;
				AND_380.Command = this.Command;
				OR_381.Command = this.Command;
				TP11.Command = this.Command;
				LE_383.Command = this.Command;
				OR_384.Command = this.Command;
				MUL_385.Command = this.Command;
				LE_386.Command = this.Command;
				GT_387.Command = this.Command;
				AND_388.Command = this.Command;
				REAL_TO_TIME_389.Command = this.Command;
				TP32.Command = this.Command;
				MUL_391.Command = this.Command;
				LE_392.Command = this.Command;
				AND_393.Command = this.Command;
				OR_394.Command = this.Command;
				REAL_TO_TIME_395.Command = this.Command;
				TP12.Command = this.Command;
				OR_397.Command = this.Command;
				AND_398.Command = this.Command;
				AND_400.Command = this.Command;
				OR_405.Command = this.Command;
				REAL_TO_TIME_406.Command = this.Command;
				TP22.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			ZLRT.IN[0] = ZT;
			ZLRT.Implement(cmd);
			
			LT_39.IN1[0] = OT;
			LT_39.IN2[0] = ZT;
			LT_39.Implement(cmd);
			
			GT_40.IN1[0] = OB;
			GT_40.IN2[0] = ZT;
			GT_40.Implement(cmd);
			
			OR_41.IN1[0] = ZLRT.DV;
			OR_41.IN2[0] = LT_39.OUT;
			OR_41.IN3[0] = AMZH;
			OR_41.IN4[0] = QC;
			OR_41.IN5[0] = GT_40.OUT;
			OR_41.Implement(cmd);
			
			SEL_43.G[0] = OR_41.OUT;
			SEL_43.IN0[0] = MS;
			SEL_43.IN1[0] = ZT;
			SEL_43.Implement(cmd);
			
			MS = SEL_43.OUT;
			OR_95.IN1[0] = AO;
			OR_95.IN2[0] = AC;
			OR_95.IN3[0] = MO;
			OR_95.IN4[0] = MC;
			OR_95.IN5[0] = M1;
			OR_95.IN6[0] = M2;
			OR_95.Implement(cmd);
			
			TOFZH.IN[0] = OR_95.OUT;
			TOFZH.PT[0] = 2;
			TOFZH.Implement(cmd);
			
			AMZH = TOFZH.Q;
			REAL_TO_TIME_373.IN[0] = T1;
			REAL_TO_TIME_373.Implement(cmd);
			
			LT_374.IN1[0] = ZT;
			LT_374.IN2[0] = 92;
			LT_374.Implement(cmd);
			
			AND_375.IN1[0] = LT_374.OUT;
			AND_375.IN2[0] = M1;
			AND_375.Implement(cmd);
			
			REAL_TO_TIME_376.IN[0] = T3;
			REAL_TO_TIME_376.Implement(cmd);
			
			TP31.IN[0] = AND_375.OUT;
			TP31.PT[0] = REAL_TO_TIME_376.OUT;
			TP31.Implement(cmd);
			
			SUB_378.IN1[0] = MS;
			SUB_378.IN2[0] = ZT;
			SUB_378.Implement(cmd);
			
			LE_379.IN1[0] = DB;
			LE_379.IN2[0] = SUB_378.OUT;
			LE_379.Implement(cmd);
			
			AND_380.IN1[0] = !TP22.Q;
			AND_380.IN2[0] = LE_379.OUT;
			AND_380.Implement(cmd);
			
			OR_381.IN1[0] = MO;
			OR_381.IN2[0] = AND_380.OUT;
			OR_381.Implement(cmd);
			
			TP11.IN[0] = OR_381.OUT;
			TP11.PT[0] = REAL_TO_TIME_373.OUT;
			TP11.Implement(cmd);
			
			LE_383.IN1[0] = DL;
			LE_383.IN2[0] = SUB_378.OUT;
			LE_383.Implement(cmd);
			
			OR_384.IN1[0] = TP11.Q;
			OR_384.IN2[0] = AO;
			OR_384.IN3[0] = LE_383.OUT;
			OR_384.IN4[0] = TP31.Q;
			OR_384.Implement(cmd);
			
			MUL_385.IN1[0] = -1;
			MUL_385.IN2[0] = DL;
			MUL_385.Implement(cmd);
			
			LE_386.IN1[0] = SUB_378.OUT;
			LE_386.IN2[0] = MUL_385.OUT;
			LE_386.Implement(cmd);
			
			GT_387.IN1[0] = ZT;
			GT_387.IN2[0] = 8;
			GT_387.Implement(cmd);
			
			AND_388.IN1[0] = GT_387.OUT;
			AND_388.IN2[0] = M2;
			AND_388.Implement(cmd);
			
			REAL_TO_TIME_389.IN[0] = T3;
			REAL_TO_TIME_389.Implement(cmd);
			
			TP32.IN[0] = AND_388.OUT;
			TP32.PT[0] = REAL_TO_TIME_389.OUT;
			TP32.Implement(cmd);
			
			MUL_391.IN1[0] = -1;
			MUL_391.IN2[0] = DB;
			MUL_391.Implement(cmd);
			
			LE_392.IN1[0] = SUB_378.OUT;
			LE_392.IN2[0] = MUL_391.OUT;
			LE_392.Implement(cmd);
			
			AND_393.IN1[0] = LE_392.OUT;
			AND_393.IN2[0] = !TP22.Q;
			AND_393.Implement(cmd);
			
			OR_394.IN1[0] = AND_393.OUT;
			OR_394.IN2[0] = MC;
			OR_394.Implement(cmd);
			
			REAL_TO_TIME_395.IN[0] = T1;
			REAL_TO_TIME_395.Implement(cmd);
			
			TP12.IN[0] = OR_394.OUT;
			TP12.PT[0] = REAL_TO_TIME_395.OUT;
			TP12.Implement(cmd);
			
			OR_397.IN1[0] = AC;
			OR_397.IN2[0] = LE_386.OUT;
			OR_397.IN3[0] = TP32.Q;
			OR_397.IN4[0] = TP12.Q;
			OR_397.Implement(cmd);
			
			AND_398.IN1[0] = OR_384.OUT;
			AND_398.IN2[0] = !OR_397.OUT;
			AND_398.IN3[0] = !JC;
			AND_398.Implement(cmd);
			
			DV[0] = AND_398.OUT;
			AND_400.IN1[0] = !OR_384.OUT;
			AND_400.IN2[0] = OR_397.OUT;
			AND_400.IN3[0] = !JC;
			AND_400.Implement(cmd);
			
			RV[0] = AND_400.OUT;
			OR_405.IN1[0] = TP11.Q;
			OR_405.IN2[0] = TP12.Q;
			OR_405.Implement(cmd);
			
			REAL_TO_TIME_406.IN[0] = T2;
			REAL_TO_TIME_406.Implement(cmd);
			
			TP22.IN[0] = OR_405.OUT;
			TP22.PT[0] = REAL_TO_TIME_406.OUT;
			TP22.Implement(cmd);
			
		}
	}
}
