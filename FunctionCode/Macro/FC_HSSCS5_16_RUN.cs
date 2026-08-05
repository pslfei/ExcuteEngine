using DCSCommon;

namespace FunctionCode
{
	public partial class HSSCS5_16
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
				TP_TP.Command = this.Command;
				AND_436.Command = this.Command;
				SEL_437.Command = this.Command;
				TP_TC.Command = this.Command;
				AND_440.Command = this.Command;
				SEL_441.Command = this.Command;
				AND_174.Command = this.Command;
				AND_667.Command = this.Command;
				AND_651.Command = this.Command;
				AND_654.Command = this.Command;
				AND_663.Command = this.Command;
				AND_671.Command = this.Command;
				EQ_688.Command = this.Command;
				AND_690.Command = this.Command;
				OR_444.Command = this.Command;
				OR_628.Command = this.Command;
				AND_707.Command = this.Command;
				OR_629.Command = this.Command;
				AND_446.Command = this.Command;
				OR_635.Command = this.Command;
				OR_702.Command = this.Command;
				AND_705.Command = this.Command;
				OR_447.Command = this.Command;
				AAAA.Command = this.Command;
				AND_622.Command = this.Command;
				AND_624.Command = this.Command;
				OR_626.Command = this.Command;
				AND_449.Command = this.Command;
				AND_618.Command = this.Command;
				AND_615.Command = this.Command;
				OR_617.Command = this.Command;
				AND_633.Command = this.Command;
				AND_454.Command = this.Command;
				OR_455.Command = this.Command;
				SEL_456.Command = this.Command;
				SEL_457.Command = this.Command;
				SEL_458.Command = this.Command;
				SEL_459.Command = this.Command;
				SEL_460.Command = this.Command;
				SEL_461.Command = this.Command;
				SEL_462.Command = this.Command;
				SEL_638.Command = this.Command;
				GE_464.Command = this.Command;
				AND_465.Command = this.Command;
				OR_466.Command = this.Command;
				SEL_467.Command = this.Command;
				SEL_468.Command = this.Command;
				SEL_469.Command = this.Command;
				SEL_470.Command = this.Command;
				SEL_471.Command = this.Command;
				SEL_642.Command = this.Command;
				OR_473.Command = this.Command;
				OR_474.Command = this.Command;
				OR_477.Command = this.Command;
				OR_475.Command = this.Command;
				AND_476.Command = this.Command;
				SEL_478.Command = this.Command;
				SEL_479.Command = this.Command;
				SEL_480.Command = this.Command;
				AND_482.Command = this.Command;
				SEL_483.Command = this.Command;
				SEL_484.Command = this.Command;
				SEL_485.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			TP_TP.IN[0] = TP;
			TP_TP.PT[0] = T1;
			TP_TP.Implement(cmd);
			
			AND_436.IN1[0] = RP;
			AND_436.IN2[0] = TP_TP.Q;
			AND_436.IN3[0] = !TC;
			AND_436.Implement(cmd);
			
			SEL_437.G[0] = QR;
			SEL_437.IN0[0] = TP;
			SEL_437.IN1[0] = AND_436.OUT;
			SEL_437.Implement(cmd);
			
			AAAA.TP[0] = SEL_437.OUT;
			TP_TC.IN[0] = TC;
			TP_TC.PT[0] = T1;
			TP_TC.Implement(cmd);
			
			AND_440.IN1[0] = RP;
			AND_440.IN2[0] = TP_TC.Q;
			AND_440.Implement(cmd);
			
			SEL_441.G[0] = QR;
			SEL_441.IN0[0] = TC;
			SEL_441.IN1[0] = AND_440.OUT;
			SEL_441.Implement(cmd);
			
			AAAA.TC[0] = SEL_441.OUT;
			AND_174.IN1[0] = L2;
			AND_174.IN2[0] = !SD;
			AND_174.IN3[0] = !SY;
			AND_174.Implement(cmd);
			
			AAAA.L2[0] = AND_174.OUT;
			AND_667.IN1[0] = L6;
			AND_667.IN2[0] = !SY;
			AND_667.Implement(cmd);
			
			AAAA.L6[0] = AND_667.OUT;
			AND_651.IN1[0] = L0;
			AND_651.IN2[0] = !SY;
			AND_651.Implement(cmd);
			
			AAAA.L0[0] = AND_651.OUT;
			AND_654.IN1[0] = L1;
			AND_654.IN2[0] = !SY;
			AND_654.Implement(cmd);
			
			AAAA.L1[0] = AND_654.OUT;
			AND_663.IN1[0] = L3;
			AND_663.IN2[0] = !SY;
			AND_663.Implement(cmd);
			
			AAAA.L3[0] = AND_663.OUT;
			AND_671.IN1[0] = L7;
			AND_671.IN2[0] = !SY;
			AND_671.Implement(cmd);
			
			AAAA.L7[0] = AND_671.OUT;
			SP[0] = TS;
			EQ_688.IN1[0] = DE;
			EQ_688.IN2[0] = 2;
			EQ_688.Implement(cmd);
			
			AND_690.IN1[0] = EQ_688.OUT;
			AND_690.IN2[0] = JC;
			AND_690.Implement(cmd);
			
			OR_444.IN1[0] = L0;
			OR_444.IN2[0] = SD;
			OR_444.Implement(cmd);
			
			OR_628.IN1[0] = !OR_444.OUT;
			OR_628.IN2[0] = SY;
			OR_628.Implement(cmd);
			
			AND_707.IN1[0] = L4;
			AND_707.IN2[0] = !SD;
			AND_707.Implement(cmd);
			
			OR_629.IN1[0] = AND_707.OUT;
			OR_629.IN2[0] = SY;
			OR_629.Implement(cmd);
			
			AND_446.IN1[0] = L5;
			AND_446.IN2[0] = !SD;
			AND_446.Implement(cmd);
			
			OR_635.IN1[0] = SY;
			OR_635.IN2[0] = AND_446.OUT;
			OR_635.Implement(cmd);
			
			OR_702.IN1[0] = TP_TP.Q;
			OR_702.IN2[0] = TP_TC.Q;
			OR_702.Implement(cmd);
			
			AND_705.IN1[0] = RP;
			AND_705.IN2[0] = !OR_702.OUT;
			AND_705.Implement(cmd);
			
			OR_447.IN1[0] = L8;
			OR_447.IN2[0] = AND_705.OUT;
			OR_447.Implement(cmd);
			
			AAAA.V1[0] = V1;
			AAAA.V2[0] = V2;
			AAAA.L4[0] = OR_629.OUT;
			AAAA.L5[0] = OR_635.OUT;
			AAAA.L8[0] = OR_447.OUT;
			AAAA.TS[0] = TS;
			AAAA.Implement(cmd);
			
			AND_622.IN1[0] = V2;
			AND_622.IN2[0] = CD;
			AND_622.IN3[0] = AAAA.DV;
			AND_622.Implement(cmd);
			
			AND_624.IN1[0] = !CD;
			AND_624.IN2[0] = AAAA.DV;
			AND_624.Implement(cmd);
			
			OR_626.IN1[0] = AND_622.OUT;
			OR_626.IN2[0] = AND_624.OUT;
			OR_626.Implement(cmd);
			
			AND_449._EN[0] = !AND_690.OUT;
			AND_449.IN1[0] = OR_628.OUT;
			AND_449.IN2[0] = !JC;
			AND_449.IN3[0] = OR_626.OUT;
			AND_449.Implement(cmd);
			
			DV[0] = AND_449.OUT;
			AND_618.IN1[0] = AAAA.RV;
			AND_618.IN2[0] = V1;
			AND_618.IN3[0] = CD;
			AND_618.Implement(cmd);
			
			AND_615.IN1[0] = AAAA.RV;
			AND_615.IN2[0] = !CD;
			AND_615.Implement(cmd);
			
			OR_617.IN1[0] = AND_618.OUT;
			OR_617.IN2[0] = AND_615.OUT;
			OR_617.Implement(cmd);
			
			AND_633._EN[0] = !AND_690.OUT;
			AND_633.IN1[0] = OR_617.OUT;
			AND_633.IN2[0] = !JC;
			AND_633.Implement(cmd);
			
			RV[0] = AND_633.OUT;
			AND_454.IN1[0] = !V1;
			AND_454.IN2[0] = !V2;
			AND_454.IN3[0] = AAAA.OA;
			AND_454.IN4[0] = AAAA.CA;
			AND_454.Implement(cmd);
			
			OR_455.IN1[0] = AND_454.OUT;
			OR_455.IN2[0] = AAAA.SE;
			OR_455.Implement(cmd);
			
			SEL_456.G[0] = OR_455.OUT;
			SEL_456.IN0[0] = 0;
			SEL_456.IN1[0] = 5;
			SEL_456.Implement(cmd);
			
			SEL_457.G[0] = AAAA.OT;
			SEL_457.IN0[0] = SEL_456.OUT;
			SEL_457.IN1[0] = 1;
			SEL_457.Implement(cmd);
			
			SEL_458.G[0] = AAAA.CT;
			SEL_458.IN0[0] = SEL_457.OUT;
			SEL_458.IN1[0] = 2;
			SEL_458.Implement(cmd);
			
			SEL_459.G[0] = AAAA.OC;
			SEL_459.IN0[0] = SEL_458.OUT;
			SEL_459.IN1[0] = 3;
			SEL_459.Implement(cmd);
			
			SEL_460.G[0] = AAAA.CO;
			SEL_460.IN0[0] = SEL_459.OUT;
			SEL_460.IN1[0] = 4;
			SEL_460.Implement(cmd);
			
			SEL_461.G[0] = L0;
			SEL_461.IN0[0] = SEL_460.OUT;
			SEL_461.IN1[0] = 6;
			SEL_461.Implement(cmd);
			
			SEL_462.G[0] = SD;
			SEL_462.IN0[0] = SEL_461.OUT;
			SEL_462.IN1[0] = 7;
			SEL_462.Implement(cmd);
			
			SEL_638.G[0] = SY;
			SEL_638.IN0[0] = SEL_462.OUT;
			SEL_638.IN1[0] = 8;
			SEL_638.Implement(cmd);
			
			FN = (byte)SEL_638.OUT;
			GE_464.IN1[0] = AAAA.DE;
			GE_464.IN2[0] = 0;
			GE_464.Implement(cmd);
			
			AND_465.IN1[0] = !V1;
			AND_465.IN2[0] = !V2;
			AND_465.IN3[0] = !GE_464.OUT;
			AND_465.Implement(cmd);
			
			OR_466.IN1[0] = AND_465.OUT;
			OR_466.IN2[0] = AAAA.AL;
			OR_466.IN3[0] = AAAA.AF;
			OR_466.IN4[0] = L0;
			OR_466.Implement(cmd);
			
			SEL_467.G[0] = AAAA.OL;
			SEL_467.IN0[0] = 0;
			SEL_467.IN1[0] = 1;
			SEL_467.Implement(cmd);
			
			SEL_468.G[0] = AAAA.CL;
			SEL_468.IN0[0] = SEL_467.OUT;
			SEL_468.IN1[0] = 3;
			SEL_468.Implement(cmd);
			
			SEL_469.G[0] = OR_466.OUT;
			SEL_469.IN0[0] = SEL_468.OUT;
			SEL_469.IN1[0] = 5;
			SEL_469.Implement(cmd);
			
			SEL_470.G[0] = AAAA.OA;
			SEL_470.IN0[0] = SEL_469.OUT;
			SEL_470.IN1[0] = 2;
			SEL_470.Implement(cmd);
			
			SEL_471.G[0] = AAAA.CA;
			SEL_471.IN0[0] = SEL_470.OUT;
			SEL_471.IN1[0] = 4;
			SEL_471.Implement(cmd);
			
			SEL_642.G[0] = SY;
			SEL_642.IN0[0] = SEL_471.OUT;
			SEL_642.IN1[0] = 6;
			SEL_642.Implement(cmd);
			
			ZT = (byte)SEL_642.OUT;
			OR_473.IN1[0] = AAAA.L1;
			OR_473.IN2[0] = AAAA.L3;
			OR_473.IN3[0] = AAAA.L7;
			OR_473.Implement(cmd);
			
			OR_474.IN1[0] = AAAA.L2;
			OR_474.IN2[0] = AAAA.L6;
			OR_474.Implement(cmd);
			
			OR_477.IN1[0] = AAAA.L1;
			OR_477.IN2[0] = AAAA.L3;
			OR_477.IN3[0] = AAAA.L7;
			OR_477.Implement(cmd);
			
			OR_475.IN1[0] = AAAA.L2;
			OR_475.IN2[0] = AAAA.L6;
			OR_475.Implement(cmd);
			
			AND_476.IN1[0] = OR_473.OUT;
			AND_476.IN2[0] = OR_475.OUT;
			AND_476.Implement(cmd);
			
			SEL_478.G[0] = OR_477.OUT;
			SEL_478.IN0[0] = 0;
			SEL_478.IN1[0] = 2;
			SEL_478.Implement(cmd);
			
			SEL_479.G[0] = OR_474.OUT;
			SEL_479.IN0[0] = SEL_478.OUT;
			SEL_479.IN1[0] = 1;
			SEL_479.Implement(cmd);
			
			SEL_480.G[0] = AND_476.OUT;
			SEL_480.IN0[0] = SEL_479.OUT;
			SEL_480.IN1[0] = 3;
			SEL_480.Implement(cmd);
			
			CE = (byte)SEL_480.OUT;
			AND_482.IN1[0] = V1;
			AND_482.IN2[0] = V2;
			AND_482.Implement(cmd);
			
			SEL_483.G[0] = V1;
			SEL_483.IN0[0] = 0;
			SEL_483.IN1[0] = 1;
			SEL_483.Implement(cmd);
			
			SEL_484.G[0] = V2;
			SEL_484.IN0[0] = SEL_483.OUT;
			SEL_484.IN1[0] = 2;
			SEL_484.Implement(cmd);
			
			SEL_485.G[0] = AND_482.OUT;
			SEL_485.IN0[0] = SEL_484.OUT;
			SEL_485.IN1[0] = 3;
			SEL_485.Implement(cmd);
			
			SE = (byte)SEL_485.OUT;
			SC = AAAA.SC;
			DE = AAAA.DE;
			OC[0] = AAAA.OC;
			CO[0] = AAAA.CO;
			CM = AAAA.CM;
			OS = AAAA.OS;
			CS = AAAA.CS;
			OU = AAAA.OU;
			RT = AAAA.RT;
			OT[0] = AAAA.OT;
			CT[0] = AAAA.CT;
			L8[0] = IP1;
			IP1 = IP2;
			IP2 = IP3;
		}
	}
}
