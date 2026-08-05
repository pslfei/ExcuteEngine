using DCSCommon;
namespace FunctionCode
{
	public partial class CLC_45
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
				OR_9.Command = this.Command;
				OR_10.Command = this.Command;
				OR_11.Command = this.Command;
				OR_12.Command = this.Command;
				OR_13.Command = this.Command;
				RSA.Command = this.Command;
				OR_20.Command = this.Command;
				RSB.Command = this.Command;
				OR_21.Command = this.Command;
				RSC.Command = this.Command;
				OR_22.Command = this.Command;
				RSD.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			OR_9.IN1[0] = MA;
			OR_9.IN2[0] = CLA;
			OR_9.Implement(cmd);
			
			OR_10.IN1[0] = MB;
			OR_10.IN2[0] = CLB;
			OR_10.Implement(cmd);
			
			OR_11.IN1[0] = MC;
			OR_11.IN2[0] = CLC;
			OR_11.Implement(cmd);
			
			OR_12.IN1[0] = MD;
			OR_12.IN2[0] = CLOF;
			OR_12.Implement(cmd);
			
			OR_13.IN1[0] = OR_10.OUT;
			OR_13.IN2[0] = OR_11.OUT;
			OR_13.IN3[0] = OR_12.OUT;
			OR_13.Implement(cmd);
			
			RSA.SET[0] = OR_9.OUT;
			RSA.RESET1[0] = OR_13.OUT;
			RSA.Implement(cmd);
			
			AON[0] = RSA.Q1;
			OR_20.IN1[0] = OR_9.OUT;
			OR_20.IN2[0] = OR_11.OUT;
			OR_20.IN3[0] = OR_12.OUT;
			OR_20.Implement(cmd);
			
			RSB.SET[0] = OR_10.OUT;
			RSB.RESET1[0] = OR_20.OUT;
			RSB.Implement(cmd);
			
			BON[0] = RSB.Q1;
			OR_21.IN1[0] = OR_9.OUT;
			OR_21.IN2[0] = OR_10.OUT;
			OR_21.IN3[0] = OR_12.OUT;
			OR_21.Implement(cmd);
			
			RSC.SET[0] = OR_11.OUT;
			RSC.RESET1[0] = OR_21.OUT;
			RSC.Implement(cmd);
			
			CON[0] = RSC.Q1;
			OR_22.IN1[0] = OR_9.OUT;
			OR_22.IN2[0] = OR_10.OUT;
			OR_22.IN3[0] = OR_11.OUT;
			OR_22.Implement(cmd);
			
			RSD.SET[0] = OR_12.OUT;
			RSD.RESET1[0] = OR_22.OUT;
			RSD.Implement(cmd);
			
			OFF[0] = RSD.Q1;
		}
	}
}
