using DCSCommon;

namespace FunctionCode
{
	public partial class LGC
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
				A.Command = this.Command;
				GE_2.Command = this.Command;
				LE_3.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			GE_2.IN1[0] = IN;
			GE_2.IN2[0] = H;
			GE_2.Implement(cmd);
			
			A.SET[0] = GE_2.OUT;
			LE_3.IN1[0] = IN;
			LE_3.IN2[0] = L;
			LE_3.Implement(cmd);
			
			A.RESET1[0] = LE_3.OUT;
			A.Implement(cmd);
			
			OUT1[0] = A.Q1;
		}
	}
}
