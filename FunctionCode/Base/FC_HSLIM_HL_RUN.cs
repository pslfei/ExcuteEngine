using DCSCommon;
namespace FunctionCode
{
	public partial class HSLIM_HL
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN > HL)
            {
                AV[0] = HL;
            }
            else if (IN < LL)
            {
                AV[0] = LL;
            }
            else
            {
                AV[0] = IN;
            }
		}
	}
}
