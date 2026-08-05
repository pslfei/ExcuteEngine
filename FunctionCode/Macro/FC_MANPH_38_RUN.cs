using DCSCommon;
namespace FunctionCode
{
	public partial class MANPH_38
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
				SUB_8.Command = this.Command;
				SEL_36.Command = this.Command;
				ADD_10.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			SUB_8.IN1[0] = PV;
			SUB_8.IN2[0] = IN;
			SUB_8.Implement(cmd);
			
			SEL_36.IN0[0] = AM;
			SEL_36.IN1[0] = BS;
			SEL_36.G[0] = SUB_8.OUT;
			SEL_36.Implement(cmd);
			
			BS[0] = SEL_36.OUT;
			ADD_10.IN1[0] = IN;
			ADD_10.IN2[0] = SEL_36.OUT;
			ADD_10.Implement(cmd);
			
			AV[0] = ADD_10.OUT;
		}
	}
}
