using DCSCommon;
namespace FunctionCode
{
    public partial class HSAMEMORY
	{
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

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
                            AV[0] = AV + Rate * cmd.Dpu.Cycle;
                        }

                        if (DC)
                        {
                            AV[0] = AV - Rate * cmd.Dpu.Cycle;
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
