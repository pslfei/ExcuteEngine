using System;
using DCSCommon;
using System.IO;
using TDServer.Service;
namespace FunctionCode
{
	public partial class HSPID
	{
		protected override void Run(ICommand cmd) 
        {       
            CP[0] = ExcuteEngine.cycle / 1000;
            float SPChangeRate = (PU - PD) * FA;//设定值变化率限制
            //float detalSP = SP - OLD_SP;//设定值变化值

            if (OLD_SP != SP)
            {
                Current_SP = SP;
                SP[0] = OLD_SP;
            }

            if (Current_SP > SP)
            {
                SP[0] = SP + SPChangeRate;
                if (SP > Current_SP)
                {
                    SP[0] = Current_SP;
                }
            }

            if (Current_SP < SP)
            {
                SP[0] = SP - SPChangeRate;
                if (SP < Current_SP)
                {
                    SP[0] = Current_SP;
                }
            }

            OLD_SP = SP;

            float Ks = (MU - MD) / (PU - PD);//标度变化系数
            float Kp = 100 / PT;
            float EK = PV - SP;
			if(AD == 1)
			{
				EK = -EK;
			}

            float detalEK = EK - OLD_EK;//偏差变化
            if (detalEK > DL)//偏差报警位
                DA = true;
            else
                DA = false;

            float P = Kp * Ks * detalEK;//比例
            float I = 0;
            if (TI > 0)
            {
                I = Kp * Ks * CP / TI * EK;//积分
            }

			float D = Kp * Ks * TD / CP * (detalEK - OLD_detalEK);//微分

            bool Si = true;//积分分离控制;false：PD控制；true：PID控制
            float En = SP - PV + IC;

			//if (Math.Abs(En) > I)
			//{
			//    Si = false;
			//}
			//else
			//{
			//    Si = true;
			//}

            if (MC == 0)//单PID
            {
                
            }
            else if (MC == 1)//串级主PID
            {
                
            }
            else if (MC == 2)//串级副PID
            {
                
            }

            //当跟踪开关变为“0”时，退回到上一次的工作状态
            if (OLD_TS == true && TS == false)
            {
                RM[0] = OLD_RM;
            }

            ////当跟踪开关变为“1”时，进入自动跟踪状态，记录上一次的工作状态
            //if (OLD_TS == false && TS == true)
            //{
            //    OLD_RM = RM;
            //}

			if(TS)
			{
				RM[0] = 4;//自动跟踪时，对RM的其他赋值均无效
				if(FE)
					AV[0] = TP;
                OLD_OC = OC;
			}
			else
			{
				if(RM == 0)//手动
				{
					if(ME)
					{
						if(OM == 0)//位置式
						{
							if(MM == 1)//快增
								AV[0] = OLD_AV + MI;
							else if(MM == 2)//快减
								AV[0] = OLD_AV - MI;
							else if(MM == 3)//慢增
								AV[0] = OLD_AV + MS;
							else if(MM == 4)//慢减
								AV[0] = OLD_AV - MS;
						}
						else if(OM == 1)//增量式
						{
							if(MM == 1)//快增
								AV[0] = MI;
							else if(MM == 2)//快减
								AV[0] = -MI;
							else if(MM == 3)//慢增
								AV[0] = MS;
							else if(MM == 4)//慢减
								AV[0] = -MS;
						}
					}
				}
				else if(RM == 1)//自动
				{
					if(AE)
					{
                        OC1 = OC - OLD_OC;
                        if (OM == 0)//位置式
                        {
                            if (Si)
                                AV[0] = OLD_AV + P + I + D + OC1;
                            else
                                AV[0] = OLD_AV + P + D + OC1;
                        }
                        else if (OM == 1)//增量式
                        {
                            if (Si)
                                AV[0] = P + I + D + OC1;
                            else
                                AV[0] = P + D + OC1;
                        }

                        OLD_OC = OC;
					}
				}
				else if(RM == 2)//串级
				{
					if(CE)
					{
                        OC1 = OC - OLD_OC;
						if(OM == 0)//位置式
						{
							if(Si)
								AV[0] = OLD_AV + P + I + D + OC1;
							else
                                AV[0] = OLD_AV + P + D + OC1;
						}
						else if(OM == 1)//增量式
						{
							if(Si)
                                AV[0] = P + I + D + OC1;
							else
                                AV[0] = P + D + OC1;
						}
                       // OC1 = OC - OLD_OC;//by 2013-4-23 胡波 应该是笔误 添加下面这句
                        OLD_OC = OC; ;//by 胡波

					}
				}
				else if(RM == 3)//手动跟踪
				{
					if(TE)
						AV[0] = TP;
                    OLD_OC = OC;
				}
                else if (RM == 4)//自动跟踪
                {
                    if (FE)
                        AV[0] = TP;
                    OLD_OC = OC;
                }

                OLD_RM = RM;
			}

			//输出变化最大幅值限制
			float AVChangeRange = AV - OLD_AV;
			if(Math.Abs(AVChangeRange) > OU && (AVChangeRange) > 0)
			{
				//AV[0] = OLD_AV + OU / 100;
				AV[0] = OLD_AV + OU;
			}
			else if(Math.Abs(AVChangeRange) > OU && (AVChangeRange) < 0)
			{
				//AV[0] = OLD_AV - OU / 100;
				AV[0] = OLD_AV - OU;
			}

            //输出限幅
            if (AV > OT)
                AV[0] = OT;

            if (AV < OB)
               AV[0] = OB; 

            OLD_EK = EK;
            OLD_detalEK = detalEK;
			OLD_AV = AV;
            OLD_TS = TS;
		}
	}
}
