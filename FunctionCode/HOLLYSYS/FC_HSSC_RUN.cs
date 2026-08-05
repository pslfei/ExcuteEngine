using DCSType;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSSC
    {
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            bool[] OLD_IN = { OLD_I1, OLD_I2, OLD_I3, OLD_I4, OLD_I5, OLD_I6, OLD_I7};
            LD[] IN = { I1, I2, I3, I4, I5, I6, I7};

            for (int i = 0; i < 7; i++)
            {
                if (OLD_IN[i] == false && IN[i] == true && O8 == false)
                {
                    switch (i)
                    {
                        case 0:
                            O1[0] = true;
                            break;
                        case 1:
                            O2[0] = true;
                            break;
                        case 2:
                            O3[0] = true;
                            break;
                        case 3:
                            O4[0] = true;
                            break;
                        case 4:
                            O5[0] = true;
                            break;
                        case 5:
                            O6[0] = true;
                            break;
                        case 6:
                            O7[0] = true;
                            break;
                    }
                    O8[0] = true;
                }
            }

            if (I8)
            {
                O1[0] = false;
                O2[0] = false;
                O3[0] = false;
                O4[0] = false;
                O5[0] = false;
                O6[0] = false;
                O7[0] = false;
                O8[0] = false;
            }

            OLD_I1 = I1;
            OLD_I2 = I2;
            OLD_I3 = I3;
            OLD_I4 = I4;
            OLD_I5 = I5;
            OLD_I6 = I6;
            OLD_I7 = I7;
            OLD_I8 = I8;
        }
    }
}
