using DCSCommon;

namespace FunctionCode
{
	public partial class DXDQ
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
				GE_21.Command = this.Command;
				LE_22.Command = this.Command;
				OR_23.Command = this.Command;
				AND_26.Command = this.Command;
				DXDQTON01.Command = this.Command;
				DXDQRS01.Command = this.Command;
				GT_74.Command = this.Command;
				LT_75.Command = this.Command;
				GT_37.Command = this.Command;
				LT_38.Command = this.Command;
				DXDQRS02.Command = this.Command;
				SEL_58.Command = this.Command;
				DXDQFOP01.Command = this.Command;
				SEL_90.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			ZLRT.IN[0] = IN;
			ZLRT.Implement(cmd);
			
			GE_21.IN1[0] = IN;
			GE_21.IN2[0] = MU;
			GE_21.Implement(cmd);
			
			LE_22.IN1[0] = IN;
			LE_22.IN2[0] = MD;
			LE_22.Implement(cmd);
			
			OR_23.IN1[0] = ZLRT.DV;
			OR_23.IN2[0] = GE_21.OUT;
			OR_23.IN3[0] = LE_22.OUT;
			OR_23.Implement(cmd);
			
			AND_26.IN1[0] = !GE_21.OUT;
			AND_26.IN2[0] = !LE_22.OUT;
			AND_26.IN3[0] = !ZLRT.DV;
			AND_26.Implement(cmd);
			
			DXDQTON01.IN[0] = AND_26.OUT;
			DXDQTON01.PT[0] = 60;
			DXDQTON01.Implement(cmd);
			
			DXDQRS01.SET[0] = OR_23.OUT;
			DXDQRS01.RESET1[0] = DXDQTON01.Q;
			DXDQRS01.Implement(cmd);
			
			DQ[0] = DXDQRS01.Q1;
			GT_74.IN1[0] = SEL_90.OUT;
			GT_74.IN2[0] = H;
			GT_74.Implement(cmd);
			
			BJH[0] = GT_74.OUT;
			LT_75.IN1[0] = SEL_90.OUT;
			LT_75.IN2[0] = L;
			LT_75.Implement(cmd);
			
			BJL[0] = LT_75.OUT;
			GT_37.IN1[0] = SEL_90.OUT;
			GT_37.IN2[0] = HH;
			GT_37.Implement(cmd);
			
			BHHH[0] = GT_37.OUT;
			LT_38.IN1[0] = SEL_90.OUT;
			LT_38.IN2[0] = LL;
			LT_38.Implement(cmd);
			
			BHLL[0] = LT_38.OUT;
			DXDQRS02.SET[0] = OR_23.OUT;
			DXDQRS02.RESET1[0] = AND_26.OUT;
			DXDQRS02.Implement(cmd);
			
			SEL_58.G[0] = DXDQRS02.Q1;
			SEL_58.IN0[0] = IN;
			SEL_58.IN1[0] = SEL_58.OUT;
			SEL_58.Implement(cmd);
			
			DXDQFOP01.IN[0] = SEL_58.OUT;
			DXDQFOP01.Implement(cmd);
			
			AV[0] = DXDQFOP01.AV;
			SEL_90.G[0] = DXDQRS01.Q1;
			SEL_90.IN0[0] = IN;
			SEL_90.IN1[0] = A;
			SEL_90.Implement(cmd);
			
		}
	}
}
