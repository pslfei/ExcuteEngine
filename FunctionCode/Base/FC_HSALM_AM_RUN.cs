using DCSCommon;
namespace FunctionCode
{
    public partial class HSALM_AM
    {
        protected override void Run(ICommand cmd) 
        {
            if (IN >= HH)//上上限报警
            {
                DV[0] = true;
                AM[0] = 1;
                AMHH[0] = true;
                AMH[0] = false;
                AMLL[0] = false;
                AML[0] = false;
            }
            else if (IN >= AH && IN < HH)//上限报警
            {
                DV[0] = true;
                AM[0] = 2;
                AMHH[0] = false;
                AMH[0] = true;
                AMLL[0] = false;
                AML[0] = false;
            }
            else if (IN > LL && IN <= AL)//下限报警
            {
                DV[0] = true;
                AM[0] = 3;
                AMHH[0] = false;
                AMH[0] = false;
                AMLL[0] = false;
                AML[0] = true;
            }
            else if (IN <= LL)//下下限报警
            {
                DV[0] = true;
                AM[0] = 4;
                AMHH[0] = false;
                AMH[0] = false;
                AMLL[0] = true;
                AML[0] = false;
            }
            else if (IN > AL && IN < AH)//无报警
            {
                DV[0] = false;
                AM[0] = 0;
                AMHH[0] = false;
                AMH[0] = false;
                AMLL[0] = false;
                AML[0] = false;
            }

            if (IN < (HH - DI))//上上限报警消失
            {
                AMHH[0] = false;
            }

            if (IN < (AH - DI))//上限报警消失
            {
                AMH[0] = false;
            }

            if (IN > (AL + DI))//下限报警消失
            {
                AML[0] = false;
            }

            if (IN > (LL + DI))//下下限报警消失
            {
                AMLL[0] = false;
            }
        }
    }
}
