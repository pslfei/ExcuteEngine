using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
    public partial class HSAMEMORY
	{
        protected override void Run(ICommand cmd) 
        {
            if (SW)
            {
                AV[0] = IN;
                V1 = 0;
            }
            else
            {
                if (IC == DC)
                {
                    V1 = 0;
                }
                else
                {
                    if (IC | DC)
                    {
                        V1 += 1;

                        float Rate = SR;
                        if (V1 < IV)
                        {
                            Rate = SR * V1 / IV;
                        }

                        if (IC)
                        {
                            AV[0] = AV + Rate * ExcuteEngine.cycle / 1000;
                        }

                        if (DC)
                        {
                            AV[0] = AV - Rate * ExcuteEngine.cycle / 1000;
                        }
                    }
                }
            }

            if (AV > OT)
            {
                AV[0] = OT;
            }

            if (AV < OB)
            {
                AV[0] = OB;
            }
        }
	}
}
