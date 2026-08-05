using DCSCommon;
namespace FunctionCode
{
	public partial class R_TRIG
	{
		protected override void Run(ICommand cmd) 
        {
            if (OLD_CLK == false && CLK == true)
            {
                Q[0] = true;
            }
            else
            {
                Q[0] = false;
            }

            OLD_CLK = CLK;
		}
	}
}
