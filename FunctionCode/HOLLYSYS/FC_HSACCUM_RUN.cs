using DCSCommon;
namespace FunctionCode
{
	public partial class HSACCUM
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (!RS)
            {
                if (bPositiveAccum)
                {
                    if (OLD_AV < MS && I1 > 0)
                    {
                        AV[0] = AV + I1 * MC;
                        SS[0] = false;
                    }
                    else if (OLD_AV > MS && I1 > 0)
                    {
                        AV[0] = AV + I1 * MC - MS;
                        SS[0] = true;
                    }
                }
                else
                {
                    if (OLD_AV < MS)
                    {
                        AV[0] = AV + I1 * MC;
                        SS[0] = false;
                    }
                    else if (OLD_AV > MS)
                    {
                        AV[0] = AV + I1 * MC;
                        SS[0] = true;
                    }
                }
            }
            else if (OLD_RS == false && RS == true)
            {
                //OLD_AV = AV;
                AV[0] = IV;
                SS[0] = false;
            }
		}
	}
}
