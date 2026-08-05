using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
	public partial class HSTIMER
	{
		protected override void Run(ICommand cmd) 
        {
            float RunTime = ExcuteEngine.cycle * ExcuteEngine.cycleCount;

            if (!RS)
            {
                if (TT == 0)//基本型
                {
                    if (OLD_SS == false && SS == true)//经过TC时间后，发一个周期的脉冲
                    {
                        StartTime = RunTime;
                        Start = true;
                    }

                    if (Start)
                    {
                        if ((RunTime > (StartTime + TC * 1000)) && (RunTime < (StartTime + TC * 1000 + ExcuteEngine.cycle)))
                        {
                            DV[0] = true;
                        }

						if(RunTime > (StartTime + TC * 1000 + ExcuteEngine.cycle))
						{
                            DV[0] = false;
                            Start = false;
                        }
                    }
                }
                else if (TT == 1)//脉冲跟随型型
                {
                    if (OLD_SS == false && SS == true)
                    {
                        StartTime = RunTime;
                        Start = true;
                        DV[0] = true;
                    }

                    if (!SS)
                    {
                        DV[0] = false;
                        Start = false;
                    }
                    else
                    {
                        if (Start)
                        {
                            if (RunTime >= (StartTime + TC * 1000))
                            {
                                DV[0] = false;
                                Start = false;
                            }
                        }
                    }
                }
                else if (TT == 2)//定宽脉冲型
                {
                    if (OLD_SS == false && SS == true)
                    {
                        StartTime = RunTime;
                        Start = true;
                        DV[0] = true;
                    }

                    if (Start)
                    {
                        if (RunTime >= (StartTime + TC * 1000))
                        {
                            DV[0] = false;
                            Start = false;
                        }
                    }
                }
                else if (TT == 3)//滞后置位型
                {
                    if (OLD_SS == false && SS == true)
                    {
                        StartTime = RunTime;
                        Start = true;
                    }

                    if (SS)
                    {
                        if (Start)
                        {
                            if (RunTime >= (StartTime + TC * 1000))
                            {
                                DV[0] = true;
                                Start = false;
                            }
                        }                        
                    }
                }
                else if (TT == 4)//滞后复位型
                {
                    if (OLD_SS == false && SS == true)
                    {
                        DV[0] = true;
                    }

                    if (OLD_SS == true && SS == false)
                    {
                        StartTime = RunTime;
                        Start = true;
                    }


                    if (DV == true && Start)
                    {
                        if (RunTime >= (StartTime + TC * 1000))
                        {
                            DV[0] = false;
                            Start = false;
                        }
                    }
                }
                else if (TT == 5)//保持滞后置位型
                {
                    if (OLD_SS == false && SS == true)
                    {
                        StartTime = RunTime;
                        Start = true;
                    }

                    if (Start)
                    {
                        if (RunTime >= (StartTime + TC * 1000))
                        {
                            DV[0] = true;
                            Start = false;
                        }
                    }
                }
            }
            else if (OLD_RS == false && RS == true)
            {
                DV[0] = false;
                Start = false;
            }

			OLD_SS = SS;
			OLD_RS = RS;
		}
	}
}
