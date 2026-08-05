using DCSCommon;
namespace FunctionCode
{
    public partial class RTC
    {
        protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            //Sets CDT to PDT when rising edge in EN and starts increasing CDT.
            //With EN = FALSE, CDT set to DT#1970-01-01-00-00:00

            if (OLD_EN == false && EN == true)
            {
                CDT[0] = PDT;
            }

            if (EN)
            {
                CDT[0] = CDT + 1;
            }
            else
            {
                CDT[0] = 0;
            }

            OLD_EN = EN;
        }
    }
}
