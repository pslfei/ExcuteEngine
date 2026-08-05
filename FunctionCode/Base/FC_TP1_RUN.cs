using DCSCommon;
using TDServer.Service;

namespace FunctionCode
{
    public partial class TP1
	{
        protected override void Run(ICommand cmd) 
        {
            float RunTime = ExcuteEngine.cycle * ExcuteEngine.cycleCount;
            if (OLD_IN == false && IN == true)
            {
                StartTime = RunTime;
                StartTP = true;
                Q[0] = true;
                ET[0] = 0;
            }


            if (StartTP)
            {
                ET[0] = ET + ExcuteEngine.cycle / 1000;
                if (RunTime > (StartTime + PT * 1000))
                {
                    Q[0] = false;
                    StartTP = false;
                }
            }

            OLD_IN = IN;
        }
	}
}
