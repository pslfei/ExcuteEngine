using DCSType;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSSC1
    {
        protected override void Run(ICommand cmd) 
        {
            bool[] OLD_IN = { OLD_I1, OLD_I2, OLD_I3, OLD_I4, OLD_I5, OLD_I6, OLD_I7, OLD_I8, OLD_I9, OLD_I10, OLD_I11, OLD_I12, OLD_I13, OLD_I14, OLD_I15 };
            LD[] IN = { I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15 };

            for (int i = 0; i < 15; i++)
            {
                if (OLD_IN[i] == false && IN[i] == true && O16 == false)
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
                        case 7:
                            O8[0] = true;
                            break;
                        case 8:
                            O9[0] = true;
                            break;
                        case 9:
                            O10[0] = true;
                            break;
                        case 10:
                            O11[0] = true;
                            break;
                        case 11:
                            O12[0] = true;
                            break;
                        case 12:
                            O13[0] = true;
                            break;
                        case 13:
                            O14[0] = true;
                            break;
                        case 14:
                            O15[0] = true;
                            break;
                    }
                    O16[0] = true;
                }
            }

            if (I16)
            {
                O1[0] = false;
                O2[0] = false;
                O3[0] = false;
                O4[0] = false;
                O5[0] = false;
                O6[0] = false;
                O7[0] = false;
                O8[0] = false;
                O9[0] = false;
                O10[0] = false;
                O11[0] = false;
                O12[0] = false;
                O13[0] = false;
                O14[0] = false;
                O15[0] = false;
                O16[0] = false;
            }

            OLD_I1 = I1;
            OLD_I2 = I2;
            OLD_I3 = I3;
            OLD_I4 = I4;
            OLD_I5 = I5;
            OLD_I6 = I6;
            OLD_I7 = I7;
            OLD_I8 = I8;
            OLD_I9 = I9;
            OLD_I10 = I10;
            OLD_I11 = I11;
            OLD_I12 = I12;
            OLD_I13 = I13;
            OLD_I14 = I14;
            OLD_I15 = I15;
            OLD_I16 = I16;
        }
    }
}
