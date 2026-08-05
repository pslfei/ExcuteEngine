using DCSCommon;
namespace FunctionCode
{
	public partial class TOF
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            float RunTime = cmd.Dpu.Cycle * cmd.Dpu.CycleCount;
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
					ET[0] = ET + cmd.Dpu.Cycle;
                    if (RunTime >= (StartTime + PT))
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
