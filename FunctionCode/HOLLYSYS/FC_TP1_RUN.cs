using DCSCommon;
namespace FunctionCode
{
    public partial class TP1
	{
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            float RunTime = 0.2f * 10;
            if (OLD_IN == false && IN == true)
            {
                StartTime = RunTime;
                StartTP = true;
                Q[0] = true;
                ET[0] = 0;
            }


            if (StartTP)
            {
                ET[0] = ET + 0.2;
                if (RunTime > (StartTime + PT))
                {
                    Q[0] = false;
                    StartTP = false;
                }
            }

            OLD_IN = IN;
        }
	}
}
