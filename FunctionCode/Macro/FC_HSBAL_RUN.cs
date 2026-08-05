using DCSCommon;
namespace FunctionCode
{
	public partial class HSBAL
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
				SUB_19.Command = this.Command;
				OR_46.Command = this.Command;
				SEL_43.Command = this.Command;
				OR_34.Command = this.Command;
				SEL_37.Command = this.Command;
				DIV_26.Command = this.Command;
				DIV_29.Command = this.Command;
				SUB_32.Command = this.Command;
				OR_5.Command = this.Command;
				SEL_2.Command = this.Command;
				BAL.Command = this.Command;
				SUB_8.Command = this.Command;
				ADD_9.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			SUB_19.IN1[0] = Z2;
			SUB_19.IN2[0] = Z1;
			SUB_19.Implement(cmd);
			
			OR_46.IN1[0] = D1;
			OR_46.IN2[0] = D2;
			OR_46.Implement(cmd);
			
			SEL_43.IN0[0] = OR_46.OUT;
			SEL_43.IN1[0] = DVO;
			SEL_43.G[0] = SUB_19.OUT;
			SEL_43.Implement(cmd);
			
			DVO = SEL_43.OUT;
			OR_34.IN1[0] = D1;
			OR_34.IN2[0] = D2;
			OR_34.Implement(cmd);
			
			SEL_37.IN0[0] = OR_34.OUT;
			SEL_37.IN1[0] = IOF;
			SEL_37.G[0] = DVO;
			SEL_37.Implement(cmd);
			
			IOF[0] = SEL_37.OUT;
			DIV_26.IN1[0] = IOF;
			DIV_26.IN2[0] = 2;
			DIV_26.Implement(cmd);
			
			DIV_29.IN1[0] = DVO;
			DIV_29.IN2[0] = 2;
			DIV_29.Implement(cmd);
			
			SUB_32.IN1[0] = DIV_26.OUT;
			SUB_32.IN2[0] = DIV_29.OUT;
			SUB_32.Implement(cmd);
			
			OR_5.IN1[0] = D1;
			OR_5.IN2[0] = D2;
			OR_5.Implement(cmd);
			
			SEL_2.IN0[0] = OR_5.OUT;
			SEL_2.IN1[0] = SUB_32.OUT;
			SEL_2.G[0] = 0;
			SEL_2.Implement(cmd);
			
			DV = SEL_2.OUT;
			BAL.IN[0] = IN;
			BAL.Z1[0] = Z1;
			BAL.Z2[0] = Z2;
			BAL.D1[0] = D1;
			BAL.D2[0] = D2;
			BAL.Implement(cmd);
			
			SUB_8.IN1[0] = BAL.O1;
			SUB_8.IN2[0] = DV;
			SUB_8.Implement(cmd);
			
			O1[0] = SUB_8.OUT;
			ADD_9.IN1[0] = BAL.O2;
			ADD_9.IN2[0] = DV;
			ADD_9.Implement(cmd);
			
			O2[0] = ADD_9.OUT;
		}
	}
}
