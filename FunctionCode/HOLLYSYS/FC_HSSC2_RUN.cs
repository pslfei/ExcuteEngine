using DCSType;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSSC2
    {
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            bool[] OLD_IN = { OLD_I1, OLD_I2, OLD_I3, OLD_I4, OLD_I5, OLD_I6, OLD_I7, OLD_I8, OLD_I9, OLD_I10, OLD_I11, OLD_I12, OLD_I13, OLD_I14, OLD_I15, OLD_I16, OLD_I17, OLD_I18, OLD_I19, OLD_I20, OLD_I21, OLD_I22, OLD_I23, OLD_I24, OLD_I25, OLD_I26, OLD_I27, OLD_I28, OLD_I29, OLD_I30, OLD_I31 };
            LD[] IN = { I1, I2, I3, I4, I5, I6, I7, I8, I9, I10, I11, I12, I13, I14, I15, I16, I17, I18, I19, I20, I21, I22, I23, I24, I25, I26, I27, I28, I29, I30, I31 };

            for (int i = 0; i < 31; i++)
            {
                if (OLD_IN[i] == false && IN[i] == true && O32 == false)
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
                        case 15:
                            O16[0] = true;
                            break;
                        case 16:
                            O17[0] = true;
                            break;
                        case 17:
                            O18[0] = true;
                            break;
                        case 18:
                            O19[0] = true;
                            break;
                        case 19:
                            O20[0] = true;
                            break;
                        case 20:
                            O21[0] = true;
                            break;
                        case 21:
                            O22[0] = true;
                            break;
                        case 22:
                            O23[0] = true;
                            break;
                        case 23:
                            O24[0] = true;
                            break;
                        case 24:
                            O25[0] = true;
                            break;
                        case 25:
                            O26[0] = true;
                            break;
                        case 26:
                            O27[0] = true;
                            break;
                        case 27:
                            O28[0] = true;
                            break;
                        case 28:
                            O29[0] = true;
                            break;
                        case 29:
                            O30[0] = true;
                            break;
                        case 30:
                            O31[0] = true;
                            break;
                    }

                    O32[0] = true;
                }
            }

            if (I32)
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
                O17[0] = false;
                O18[0] = false;
                O19[0] = false;
                O20[0] = false;
                O21[0] = false;
                O22[0] = false;
                O23[0] = false;
                O24[0] = false;
                O25[0] = false;
                O26[0] = false;
                O27[0] = false;
                O28[0] = false;
                O29[0] = false;
                O30[0] = false;
                O31[0] = false;
                O32[0] = false;
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
            OLD_I17 = I17;
            OLD_I18 = I18;
            OLD_I19 = I19;
            OLD_I20 = I20;
            OLD_I21 = I21;
            OLD_I22 = I22;
            OLD_I23 = I23;
            OLD_I24 = I24;
            OLD_I25 = I25;
            OLD_I26 = I26;
            OLD_I27 = I27;
            OLD_I28 = I28;
            OLD_I29 = I29;
            OLD_I30 = I30;
            OLD_I31 = I31;
            OLD_I32 = I32;
        }
    }
}
