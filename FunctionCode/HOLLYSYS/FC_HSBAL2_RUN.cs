using System;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSBAL2
    {
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            float ChangeIOF = IOF - OLD_IOF;//偏置变换

            if (ChangeIOF > HL && ChangeIOF > 0)//正向变换
            {
                IOF[0] = OLD_IOF + HL;
            }

            if (ChangeIOF > LL && ChangeIOF < 0)//反向变换
            {
                IOF[0] = OLD_IOF + LL;
            }

            if (D1 == true && D2 == true)//A、B俩阀均处于手动状态
            {
                O1[0] = Z1;
                O2[0] = Z2;
            }
            else if (D1 == false && D2 == true)//A阀自动、B阀手动
            {
                O1[0] = 2 * IN - Z2;
                O2[0] = Z2;
            }
            else if (D1 == true && D2 == false)//A阀手动、B阀自动
            {
                O1[0] = Z1;
                O2[0] = 2 * IN - Z1;
            }
            else if (D1 == false && D2 == false)//A、B俩阀均为自动
            {
                O1[0] = Z1 - IOF;
                O2[0] = Z2 + IOF;
            }

            float ChangeO1Value = Math.Abs(OUTR * (IOF - (IN - OLD_O1)));
            float ChangeO2Value = Math.Abs(OUTR * (IOF - (IN - OLD_O2)));

            if (Math.Abs(O1 - OLD_O1) > ChangeO1Value)
            {
                O1[0] = OLD_O1 + ChangeO1Value;
            }

            if (Math.Abs(O2 - OLD_O2) > ChangeO2Value)
            {
                O2[0] = OLD_O2 + ChangeO2Value;
            }

            OLD_O1 = O1;
            OLD_O2 = O2;
            OLD_IOF = IOF;
        }
    }
}
