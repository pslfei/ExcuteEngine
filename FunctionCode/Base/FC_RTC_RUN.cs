using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
    public partial class RTC
    {
        protected override void Run(ICommand cmd) 
        {
            if (OLD_EN == false && EN == true)
            {
                CDT[0] = PDT;
            }

            float TS = ExcuteEngine.cycle / 1000;
            if (EN)
            {
                CDT[0] = CDT + TS;
            }
            else
            {
                CDT[0] = 0;
            }

            OLD_EN = EN;
        }
    }
}
