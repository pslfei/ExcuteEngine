using DCSCommon;
namespace FunctionCode
{
	public partial class DQFOP_38
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
				GE_2.Command = this.Command;
				LE_3.Command = this.Command;
				OR_5.Command = this.Command;
				INFOP.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			GE_2.IN1[0] = IN;
			GE_2.IN2[0] = H;
			GE_2.Implement(cmd);
			
			LE_3.IN1[0] = IN;
			LE_3.IN2[0] = L;
			LE_3.Implement(cmd);
			
			OR_5.IN1[0] = GE_2.OUT;
			OR_5.IN2[0] = LE_3.OUT;
			OR_5.Implement(cmd);
			
			DQ[0] = OR_5.OUT;
			INFOP.IN[0] = IN;
			INFOP.Implement(cmd);
			
			AV[0] = INFOP.AV;
		}
	}
}
