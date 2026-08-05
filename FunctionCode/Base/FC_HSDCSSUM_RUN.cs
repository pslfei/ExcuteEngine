using DCSCommon;
namespace FunctionCode
{
	public partial class HSDCSSUM
	{
		protected override void Run(ICommand cmd) 
        {
            if (RS)
            {
                AV[0] = 0;
            }
            else
            {
                if (I1 != OLD_I1)
                {
                    if (SL == 0)//上升沿
                    {
                        if (OLD_I1 == false && I1 == true)
                        {
                            AV[0] = AV + 1;
                        }
                    }
                    else if (SL == 1)//下降沿
                    {
                        if (OLD_I1 == true && I1 == false)
                        {
                            AV[0] = AV + 1;
                        }
                    }
                    else if (SL == 2)//全统计
                    {
                        AV[0] = AV + 1;
                    }
                }
            }

            OLD_I1 = I1;
		}
	}
}
