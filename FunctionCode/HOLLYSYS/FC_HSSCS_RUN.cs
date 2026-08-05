using DCSCommon;
namespace FunctionCode
{
	public partial class HSSCS
	{
		protected override void Run(ICommand cmd)
		{
			_ENO[0] = _EN;
			if(!_EN)
				return;


			//命令方向已有位置状态反馈信号 -- M3
			if((L6 | L7) & V1)
				M3 = true;
			else if((TP | TC) & V2)
				M3 = true;
			else
				M3 = false;

			//命令方向已有该方向的指令输出 -- M4
			if((L6 | L7) & DV)
				M4 = true;
			else if((TP | TC) & RV)
				M4 = true;
			else
				M4 = false;

			//信号确认 -- M2
			if(L8 | TP | TC)//初始化脉冲有效
			{
				//M2 = true;//确认信号
                OC = false;//状态偏差开到关
                CO = false;//状态偏差关到开
                CP = false;//设备关保护触发
				OT = false;//开超时
				CT = false;//关超时
                AL = false;//报警指示灯常亮
                DV[0] = false;
                RV[0] = false;
                OA = false;
                CA = false;
			}
			//else
			//    M2 = false;

			if(M2 | M3 | M4)//屏蔽命令阻塞信号
			{
				CJ = false;
			}
			else
			{
				//自动开、自动关
				if(L6 & L7)
					CJ = true;//命令阻塞

				//手动开、手动关
				else if(TP & TC)
					CJ = true;//命令阻塞

				////开许可不满足
				//else if (!L4)
				//    CJ = true;//命令阻塞

				////关许可不满足
				//else if (!L5)
				//    CJ = true;//命令阻塞
				else
					CJ = false;//命令阻塞
			}

			FeedBackMonit(DE);

			//命令优先级
			//设备保护关/厂区保护关 > 厂区保护开 > 手动停止 > 手动关/自动关 > 手动开/自动开
			//手动关、自动关、手动开、自动开受开关许可条件限制，设备保护关、厂区保护关、厂区保护开不受开关许可条件限制



			//else
			//{
			//    OT = false;
			//    CT = false; 
			//    AL = false;
			//}

			M1 = OC | CO;//状态偏差
			M5 = (!CM) & (!OS) & (!CS);//点动
			M6 = CM & OS & CS;//连续
			M7 = CM & (!OS) & (!CS);//闭锁

            if (M6)
            {
                if (preOpen == false && DV == true)
                {
                    SampleTime = cmd.Dpu.Cycle * cmd.Dpu.CycleCount;
                    DV0To1 = true;
                }

                if (preClose == false && RV == true)
                {
                    SampleTime = cmd.Dpu.Cycle * cmd.Dpu.CycleCount;
                    RV0To1 = true;
                }

                if (DV0To1)
                {
                    if (cmd.Dpu.Cycle * cmd.Dpu.CycleCount > (SampleTime + RT) && V1 == false)
                    {
                        OT = true;//开信号超时
                        DV0To1 = false;
                        AL = true;
                    }
                }

                if (RV0To1)
                {
                    if (cmd.Dpu.Cycle * cmd.Dpu.CycleCount > (SampleTime + RT) && V2 == false)
                    {
                        CT = true;//关信号超时
                        AL = true;
                        RV0To1 = false;
                    }
                }
            }

			//设备类型
			if(DE == 0)//电动机
			{
				if(L0)//电气故障
				{
					DV[0] = false;
					RV[0] = false;
					CM = false;
					AL = true;
					//如果设备在运行状态，将产生状态偏差开到关信号
				}
				else
				{
					AL = false;

					if(M5)
						InchingMode();
					else if(M6)
						ContinuousMode();
					else if(M7)
						LockMode();
				}
			}
			else if(DE == 1)//电动门
			{
				if(M5)
					InchingMode();
				else if(M6)
					ContinuousMode();
			}
			else if(DE == 2)//电磁阀
			{
				if(M5)
					InchingMode();
				else if(M6)
					ContinuousMode();
			}
		}

		//点动模式
		public void InchingMode()
		{
			//CM = false;//命令记忆
			//OS = false;//开命令终止连接
			//CS = false;//关命令终止连接

            //关指令
            RV[0] = L1 | (!M1 & (L3 | (!L2 & !TS & (!CJ & ((TC | L7) & L5)))));

            //开指令
            DV[0] = !L1 & !M1 & (!L3 & (L2 | (!TS & (!CJ & ((TP | L6) & L4)))));

            if (V1)//开位置状态反馈
            {
                DV[0] = false;
                OA = false;
                OL = true;
                CL = false;
                DV0To1 = false;
            }

            if (V2)//关位置状态反馈
            {
                RV[0] = false;
                CA = false;
                CL = true;
                OL = false;
                RV0To1 = false;
            }


            //if(L1)//设备保护关
            //{
            //    RV[0] = true;
            //}
            //else
            //{
            //    if(M1)//当状态偏差存在时，除设备保护关以外的所有输入命令被屏蔽，直到状态偏差被确认。
            //    {
            //        RV[0] = false;
            //        DV[0] = false;
            //    }
            //    else
            //    {
            //        if(L3)//厂区保护关
            //        {
            //            RV[0] = true;
            //        }
            //        else
            //        {
            //            if(L2)//厂区保护开
            //            {
            //                DV[0] = true;
            //            }
            //            else
            //            {
            //                if(TS)//手动停
            //                {
            //                    RV[0] = false;
            //                    DV[0] = false;
            //                }
            //                else
            //                {
            //                    if(!CJ)
            //                    {
            //                        if((TC | L7) & L5)//关命令
            //                        {
            //                            RV[0] = true;
            //                        }
            //                        else
            //                        {
            //                            if((TP | L6) & L4)//开命令
            //                            {
            //                                DV[0] = true;
            //                            }
            //                            else
            //                            {
            //                                DV[0] = false;
            //                                RV[0] = false;
            //                            }
            //                        }
            //                    }
            //                }
            //            }
            //        }
            //    }
            //}
		}

		//连续模式
		public void ContinuousMode()
		{
			//CM = true;//命令记忆
			//OS = true;//开命令终止连接
			//CS = true;//关命令终止连接


			////电气故障、确认信号、状态偏差（反向命令、命令记忆将被清除时？？？）
			//if(L0 | M2)
			//{
			//    DV[0] = false;
			//    RV[0] = false;
			//}
			//else
			//{
			if(L1)//设备保护关
			{
				if(V1)
				{
					CP = true;
					OC = true;
					DV[0] = false;
				}

				RV[0] = true;
			}
			else
			{
				if(M1)//状态偏差
				{
					RV[0] = false;
					DV[0] = false;
				}
				else
				{
					if(L3)//厂区保护关
					{
						RV[0] = true;
						DV[0] = false;
					}
					else
					{
						if(L2)//厂区保护开
						{
							DV[0] = true;
							RV[0] = false;
						}
						else
						{
							if(TS)//手动停
							{
								RV[0] = false;
								DV[0] = false;
							}
							else
							{
								if(!CJ)
								{
                        
									if((TC | L7) & L5)//关命令
									{
										RV[0] = true;
										DV[0] = false;
										CA = true;
										OA = false;
									}
									else
									{
										if((TP | L6) & L4)//开命令
										{
											DV[0] = true;
											RV[0] = false;
											CA = false;
											OA = true;
										}
									}
								}
							}
						}
					}
				}
				//}
			}


			if(V1)//开位置状态反馈
			{
				DV[0] = false;
				OA = false;
				OL = true;
				CL = false;
				DV0To1 = false;
			}

			if(V2)//关位置状态反馈
			{
				RV[0] = false;
				CA = false;
				CL = true;
				OL = false;
				RV0To1 = false;
			}
		}

		//闭锁模式
		public void LockMode()
		{
			//CM = true;//命令记忆
			//OS = false;//开命令终止连接
			//CS = false;//关命令终止连接

			////电气故障、确认信号、状态偏差（反向命令、命令记忆将被清除时？？？）
			//if(L0 | M2)
			//{
			//    DV[0] = false;
			//    RV[0] = false;
			//}
			//else
			//{
			if(L1)//设备保护关
			{
				RV[0] = true;
			}
			else
			{
				if(M1)//状态偏差
				{
					RV[0] = false;
					DV[0] = false;
				}
				else
				{
					if(L3)//厂区保护关
					{
						RV[0] = true;
					}
					else
					{
						if(L2)//厂区保护开
						{
							DV[0] = true;
						}
						else
						{
							if(TS)//手动停
							{
								RV[0] = false;
								DV[0] = false;
							}
							else
							{
								if(!CJ)
								{
									if((TC | L7) & L5)//关命令
									{
										RV[0] = true;
									}
									else
									{
										if((TP | L6) & L4)//开命令
										{
											DV[0] = true;
										}
									}
								}
							}
						}
					}
				}
			}
			//}
		}

		//反馈监视
		public void FeedBackMonit(int DeviceType)
		{
			if(DeviceType == 0 || DeviceType == 2)
			{
				if(V1 ^ V2 == false)//状态反馈错误,同时状态偏差和运行超时信号被阻塞
				{
					SE = true;
					AL = true;

					M1 = false;
					OT = false;
					CT = false;
				}
				else
					SE = false;
			}
			else if(DeviceType == 1)
			{
				if(V1 & V2)//状态反馈错误,同时状态偏差和运行超时信号被阻塞
				{
					SE = true;
					AL = true;

					M1 = false;
					OT = false;
					CT = false;
				}
				else
					SE = false;
			}
		}
	}
}