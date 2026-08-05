using DCSCommon;

namespace FunctionCode
{
	public partial class DQHL
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
				AND_39.Command = this.Command;
				RT_1.Command = this.Command;
				LE_30.Command = this.Command;
				NOT_41.Command = this.Command;
				AND_33.Command = this.Command;
				GE_38.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			AND_39.IN1[0] = GE_38.OUT;
			AND_39.IN2[0] = NOT_41.OUT;
			AND_39.Implement(cmd);
			
			RT_1.IN[0] = IN;
			RT_1.Implement(cmd);
			
			LE_30.IN1[0] = IN;
			LE_30.IN2[0] = LL;
			LE_30.Implement(cmd);
			
			NOT_41.IN[0] = RT_1.DV;
			NOT_41.Implement(cmd);
			
			AND_33.IN1[0] = NOT_41.OUT;
			AND_33.IN2[0] = LE_30.OUT;
			AND_33.Implement(cmd);
			
			OL[0] = AND_33.OUT;
			OH[0] = AND_39.OUT;
			GE_38.IN1[0] = IN;
			GE_38.IN2[0] = HH;
			GE_38.Implement(cmd);
			
			HL = RT_1.HL;
		}
	}
}
