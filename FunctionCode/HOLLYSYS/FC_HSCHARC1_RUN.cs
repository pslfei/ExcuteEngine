using DCSCommon;
namespace FunctionCode
{
    public partial class HSCHARC1
    {
        protected override void Run(ICommand cmd)
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            float[] XX = { X1, X2, X3, X4, X5, X6, X7, X8, X9, X10, X11 };
            float[] YY = { Y1, Y2, Y3, Y4, Y5, Y6, Y7, Y8, Y9, Y10, Y11 };


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
