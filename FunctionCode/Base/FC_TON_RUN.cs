using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
	public partial class TON
	{
		protected override void Run(ICommand cmd) 
        {
            float RunTime = ExcuteEngine.cycle * ExcuteEngine.cycleCount;
            if (OLD_IN == false && IN == true)
            {
                StartTime = RunTime;
                StartTON = true;
				ET[0] = 0;
            }

            if (!IN)
            {
                Q[0] = false;
                StartTON = false;
                ET[0] = 0;
            }
            else
            {
                if (StartTON)
                {
                    ET[0] = ET + ExcuteEngine.cycle / 1000;
					if(RunTime >= (StartTime + PT * 1000))
                    {
                        Q[0] = true;
                        //StartTON = false;
                    }
					if(ET > PT)
						ET[0] = PT;
                }
                else
                    Q[0] = false;

                //if (ET == PT)
                //{
                //    Q[0] = true;
                //}
            }
            OLD_IN = IN;
		}
	}
}
