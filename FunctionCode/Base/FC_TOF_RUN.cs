using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
	public partial class TOF
	{
		protected override void Run(ICommand cmd) 
        {
            float RunTime = ExcuteEngine.cycle * ExcuteEngine.cycleCount;
            if (OLD_IN == true && IN == false)
            {
                StartTime = RunTime;
                StartTOF = true;
                ET[0] = 0;
            }

            if (IN)
            {
                Q[0] = true;
                StartTOF = false;
                ET[0] = 0;
            }
            else
            {
                if (StartTOF)
                {
					ET[0] = ET + ExcuteEngine.cycle / 1000;
                    if (RunTime >= (StartTime + PT * 1000))
                    {
                        Q[0] = false;
                        StartTOF = false;
                    }

					if(ET > PT)
						ET[0] = PT;
                }
                else
                    Q[0] = false;
            }
            OLD_IN = IN;
		}
	}
}
