using DCSCommon;
namespace FunctionCode
{
	public partial class TP
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;
            
            float RunTime = cmd.Dpu.Cycle * cmd.Dpu.CycleCount;
            if (OLD_IN == false && IN == true)
            {
                StartTime = RunTime;
                StartTP = true;
                Q[0] = true;
                ET[0] = 0;
            }

            if (StartTP)
            {
                ET[0] = ET + cmd.Dpu.Cycle;
                if (RunTime > (StartTime + PT))
                {
                    Q[0] = false;
                    StartTP = false;
                }

                if (ET > PT)
                    ET[0] = PT;
            }
            else
                Q[0] = false;
   
            OLD_IN = IN;
		}
	}
}
