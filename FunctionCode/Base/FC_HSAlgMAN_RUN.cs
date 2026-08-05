using System;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSAlgMAN
    {
        protected override void Run(ICommand cmd) 
        {
            if (TS)//跟踪开关
            {
                if (FE)//跟踪允许
                {
                    RM[0] = 2;
                }
            }
            else
            {
				if(OLD_TS == true && TS == false)//跟踪开关由1变为0时，手操器切换为跟踪前的模式
				{
					RM[0] = OLD_RM;
				}

                if (FM)//强制手动开关
                {
                    RM[0] = 3;//强制手动
                }
                else
                {
                    if (OLD_PA == false && PA == true)
                    {
                        RM[0] = 1;//自动
                    }

					if(OLD_FM == true && FM == false)
					{
						RM[0] = 0;//手动
					}
                }
            }

            if (OLD_C0 == false && C0 == true)
            {
                C0_AV = AV;
            }

            if (OLD_C1 == false && C1 == true)
            {
                C1_AV = AV;
            }

            if (RM == 0)//MAN手动
            {
                if (C2)//程控增
                {
                    AV[0] = AV + MR * (MU - MD);
                }

                if (C3)//程控减
                {
                    AV[0] = AV - MR * (MU - MD);
                }

                SP[0] = PV;
                AM[0] = true;
            }
            else if (RM == 1)//AUTO自动
            {
                float TempOut = IN + BS;
                if (OU == 0)
                {
                    AV[0] = TempOut;
                }
                else
                {
                    if (AV > TempOut)
                    {
                        AV[0] = AV - OU;
                        if (AV < TempOut)
                        {
                            AV[0] = TempOut;
                        }
                    }
                    else if (AV < TempOut)
                    {
                        AV[0] = AV + OU;
                        if (AV > TempOut)
                        {
                            AV[0] = TempOut;
                        }
                    }
                }
                AM[0] = false;
            }
            else if (RM == 2)//TRACK跟踪
            {
                AV[0] = TP;

                AM[0] = true;
                SP[0] = PV;
            }
            else if (RM == 3 && FM == true)//FORCEMAN强制手动
            {
                if (C2)//程控增
                {
                    AV[0] = AV + MR * (MU - MD);
                }

                if (C3)//程控减
                {
                    AV[0] = AV - MR * (MU - MD);
                }

                AM[0] = true;
                SP[0] = PV;
            }

            //float ChangeRange = AV - OLD_AV;
            //if (Math.Abs(ChangeRange) > OU && OU > 0)
            //{
            //    if (ChangeRange > 0)
            //    {
            //        AV[0] = OLD_AV + OU;
            //    }
            //    else
            //    {
            //        AV[0] = OLD_AV - OU;
            //    }
            //}

            //增闭锁
            if (C0)
            {
                if (AV > C0_AV)
                    AV[0] = C0_AV;
            }

            //减闭锁
            if (C1)
            {
                if (AV < C1_AV)
                    AV[0] = C1_AV;
            }

            if (AV > OT)
                AV[0] = OT;

            if (AV < OB)
                AV[0] = OB;

            OLD_AV = AV;
            OLD_RM = RM;
            OLD_FM = FM;
            OLD_PA = PA;
            OLD_TS = TS;
            OLD_C0 = C0;
            OLD_C1 = C1;

            //if (ExcuteEngine.cycleCount % 20 < 10)
            //{
            //    AM[0] = false;

            //}
            //else
            //    AM[0] = true;
     // AM[0] = true;
        }
    }
}
