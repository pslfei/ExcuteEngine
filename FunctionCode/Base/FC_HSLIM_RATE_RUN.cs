using DCSCommon;
namespace FunctionCode
{
	public partial class HSLIM_RATE
	{
		protected override void Run(ICommand cmd) 
        {
            if (HL < 0)
            {
                HL[0] = -HL;
            }

            if (LL < 0)
            {
                LL[0] = -LL;
            }

            if ((IN - AV) > HL)
            {
                AV[0] = AV + HL;
            }
            else if ((IN - AV) < -LL)
            {
                AV[0] = AV - LL;
            }
            else
            {
                AV[0] = IN;
            }
		}
	}
}
