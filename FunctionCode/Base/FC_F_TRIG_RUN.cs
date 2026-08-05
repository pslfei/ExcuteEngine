using DCSCommon;
namespace FunctionCode
{
	public partial class F_TRIG
	{
		protected override void Run(ICommand cmd) 
        {
            if (OLD_CLK == true && CLK == false)
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
