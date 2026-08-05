using DCSCommon;
using System;
namespace FunctionCode
{
    public partial class AI_Red_Sel
    {
        protected override void Run(ICommand cmd)
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (X1 > UP)
                X1[0] = UP;

            if (X1 < LO)
                X1[0] = LO;

            if (X2 > UP)
                X2[0] = UP;

            if (X2 < LO)
                X2[0] = LO;

            bool b1 = (X1.Quality == QualityTypes.Good);
            bool b2 = (X2.Quality == QualityTypes.Good);
            bool b3 = (X1 < AL || X1 > AU);
            bool b4 = (X2 < AL || X2 > AU);
            bool b5 = (Math.Abs(X1 - X2) < DB * (UP - LO));
            bool b6 = (b3 || (Math.Abs(X1 - AV) > DB * (UP - LO)) || (!b1));//(*信号1可疑*)
            bool b7 = (b4 || (Math.Abs(X1 - AV) > DB * (UP - LO)) || (!b2));//(*信号2可疑*)

            if (AU == 0)
                AU = UP;

            if (AL == 0)
                AL = LO;

            if (M1 == false)
            {
                //俩路信号都正常
                if (b1 && b2 && (!b3) && (!b4) && b5)
                {
                    if (b6)
                        X1 = AV;

                    if (b7)
                        X2 = AV;

                    if (MD == 0)
                        AV[0] = (X1 + X2) / 2;
                    else if (MD == 1)
                        AV[0] = Math.Min(X1, X2);
                    else if (MD == 2)
                        AV[0] = Math.Max(X1, X2);
                    ER[0] = 0;
                }
                else if (b1 && (!b3) && (!b2) || b4 )
                {
                    AV[0] = X1;
                    ER[0] = 0;
                }
                else if (b2 && (!b4) && (!b1) || b3)
                {
                    AV[0] = X2;
                    ER[0] = 0;
                }
                else
                    ER[0] = 1;
            }
            else
            {
                if (M2 == false)
                    AV[0] = X1;
                else
                    AV[0] = X2;

                ER[0] = 2;
            }
        }
    }
}
