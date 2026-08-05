using DCSCommon;
namespace FunctionCode
{
	public partial class RATELIMTR
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
				SEL_9.Command = this.Command;
				SEL_10.Command = this.Command;
				HSRATELIM.Command = this.Command;
				SEL_7.Command = this.Command;
			}
		}

        protected override void Run(ICommand cmd) 
		{
			SEL_9.IN0[0] = OFF;
			SEL_9.IN1[0] = HL;
			SEL_9.G[0] = 20000000;
			SEL_9.Implement(cmd);
			
			SEL_10.IN0[0] = OFF;
			SEL_10.IN1[0] = LL;
			SEL_10.G[0] = 20000000;
            SEL_10.Implement(cmd);
			
			HSRATELIM.IN[0] = IN;
			HSRATELIM.HL[0] = SEL_9.OUT;
			HSRATELIM.LL[0] = SEL_10.OUT;
            HSRATELIM.Implement(cmd);
			
			SEL_7.IN0[0] = OFF;
			SEL_7.IN1[0] = HSRATELIM.AV;
			SEL_7.G[0] = IN;
            SEL_7.Implement(cmd);
			
			AV[0] = SEL_7.OUT;
		}
	}
}
