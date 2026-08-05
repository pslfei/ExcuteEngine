using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
    public partial class HSALM_RT
    {
        protected override void Run(ICommand cmd)
        {
            long CycleCount = ExcuteEngine.cycleCount;
            //DP=0，即用本周期输入值跟上一个周期的输入值作比较进行超速判断。
            LastDPIN[0] = IK[DP];
            Dev[0] = Math.Abs(IN - IK[DP]);

            if (Dev > HL)
            {
                DV[0] = true;
                LC[0] = 0;
            }
            else if (Dev <= HL && OLD_DV == true)//如果|IN(k-1)-IN[K-1-DP]|> HL???,|IN(K)-IN[K-DP]≤HL，表示超速消失，此后若连续 AP 个周期再无超速发生，则清报警，DV(K)=0。
            {
                if (LC < AP)
                {
                    LC[0] = LC + 1;
                    DV[0] = true;
                }
                else
                {
                    DV[0] = false;
                    LC[0] = 0;
                }
            }

            IK[CycleCount % (DP + 1)] = IN;
            OLD_DV = DV;
        }
    }
}
