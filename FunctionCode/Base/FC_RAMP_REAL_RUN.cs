using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
    public partial class RAMP_REAL
	{
        protected override void Run(ICommand cmd) 
        {
            DIFF = IN - OLD_IN;
            if (TIMEBASE == 0)
            {
                if (DIFF > ASCEND)
                {
                    OUT[0] = OLD_IN + ASCEND;
                }
                else if (DIFF < -DESCEND)
                {
                    OUT[0] = OLD_IN - DESCEND;
                }
                else
                {
                    OUT[0] = IN;
                }
            }
            else
            {
                TB = TIMEBASE;
                CLOCK.Implement(cmd);
                CET = CLOCK.ET;

                if (CET > 0)
                {
                    CLOCK.IN[0] = false;
                    CLOCK.Implement(cmd);
                    CLOCK.IN[0] = true;
                    CLOCK.Implement(cmd);
                    CET = CLOCK.ET;
                    if (TB * DIFF / CET > ASCEND)
                    {
                        OUT[0] = OLD_IN + ASCEND * CET / TB;                    
                    }
                    else if (DIFF * TB / CET < -DESCEND)
                    {
                        OUT[0] = OLD_IN - DESCEND * CET / TB ;
                    }
                    else
                    {
                        OUT[0] = IN;
                    }
                }
                else
                {
                    OUT[0] = OLD_IN;
                    CLOCK.PT[0] = TIMEBASE;
                    CLOCK.IN[0] = true;
                }
            }

            OLD_IN = OUT;
        }
	}
}
