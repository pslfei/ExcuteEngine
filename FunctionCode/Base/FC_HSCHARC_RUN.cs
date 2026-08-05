using DCSCommon;
namespace FunctionCode
{
    public partial class HSCHARC
    {
        protected override void Run(ICommand cmd)
        {
            if (float.IsInfinity(I1))
            {
                eRR[0] = 3;
            }
            else if (PS < 2 || PS > 11)
            {
                eRR[0] = 1;
            }
            else
            {
                for (int i = 1; i < PS; i++)
                {
                    if (XX[i] < XX[i - 1])
                    {
                        eRR[0] = 2;
                        break;
                    }
                }
            }

            if (eRR > 0)
            {
                return;
            }


            if (I1 >= XX[PS - 1])
            {
                AV[0] = YY[PS - 1];
            }
            else if (I1 <= XX[0])
            {
                AV[0] = YY[0];
            }
            else
            {
                for (int i = 0; i < PS - 1; i++)
                {
                    if (I1 >= XX[i] && I1 < XX[i + 1])
                    {
                        AV[0] = (I1 - XX[i]) * ((YY[i] - YY[i + 1]) / (XX[i] - XX[i + 1])) + YY[i];
                    }
                }
            }
        }
    }
}
