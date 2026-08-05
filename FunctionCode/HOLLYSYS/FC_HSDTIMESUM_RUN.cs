using DCSCommon;
namespace FunctionCode
{
	public partial class HSDTIMESUM
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (RS)
            {
                AV[0] = 0;
                AV1[0] = 0;
                L1 = 0;
                L0 = 0;
            }
            else
            {
                float TS = cmd.Dpu.Cycle;
                float factor = 1;
                if (SOF == 0) // 秒
                {
                    factor = 1000;
                }
                else if (SOF == 1) // 分钟
                {
                    factor = 1000 * 60;
                }
                else if (SOF == 2) // 小时
                {
                    factor = 1000 * 3600;
                }
                else if (SOF == 3) // 毫秒
                {
                    factor = 1;
                }

                if (RB) // 累计状态"1"时间
                {
                    if (I1)
                    {
                        L1 += TS;
                    }
                    AV[0] = L1 / factor;
                    AV1[0] = L1;
                }
                else // 累计状态"0"时间
                {
                    if (!I1)
                    {
                        L0 += TS;
                    }
                    AV[0] = L0 / factor;
                    AV1[0] = L0;
                }
            }
		}
	}
}
