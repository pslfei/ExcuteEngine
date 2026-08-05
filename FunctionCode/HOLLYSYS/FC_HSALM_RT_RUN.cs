using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class HSALM_RT
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;

            int CycleCount = (int)cmd.Dpu.CycleCount;

            if (Math.Abs(IN - IK[DP]) > HL)
            {
                DV[0] = true;
                LC = 0;
            }
            else if (Math.Abs(IN - IK[DP]) > HL && OLD_DV == true)
            {
                if (LC < AP)
                {
                    LC += 1;
                    DV[0] = true;
                }
                else
                {
                    DV[0] = false;
                    LC = 0;
                }
            }

            IK[CycleCount % 10] = IN;
            OLD_DV = DV;
		}
	}
}
