using DCSCommon;

namespace FunctionCode
{
	public partial class DQFOP
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
				INFOP.Command = this.Command;
				RT_1.Command = this.Command;
				OR_27.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			INFOP.IN[0] = IN;
			INFOP.Implement(cmd);
			
			AV[0] = INFOP.AV;
			RT_1.IN[0] = IN;
			RT_1.RL[0] = RL;
			RT_1.H[0] = H;
			RT_1.L[0] = L;
			RT_1.Implement(cmd);
			
			OR_27.IN1[0] = RT_1.DV;
			OR_27.IN2[0] = RT_1.FI;
			OR_27.Implement(cmd);
			
			DQ[0] = OR_27.OUT;
		}
	}
}
