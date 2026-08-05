using DCSCommon;

namespace FunctionCode
{
	public partial class LIM_RATE
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
			}
		}

		protected override void Run(ICommand cmd)
		{
            if (IN > float.MaxValue || IN < float.MinValue)
                return;

            if (HL <= 0)
                HL = 0;

            if (LL <= 0)
                LL = 0;

            if ((AV - IN) <= LL && (IN - AV) <= HL || SW == true)
            {
                AV[0] = IN;
            }
            else if ((AV - IN) > LL)
            {
                AV[0] = AV - LL;
            }
            else if ((IN - AV) > HL)
            {
                AV[0] = AV + HL;
            }
		}
	}
}
