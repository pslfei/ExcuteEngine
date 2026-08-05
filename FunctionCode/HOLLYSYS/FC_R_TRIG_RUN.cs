using DCSCommon;
namespace FunctionCode
{
	public partial class R_TRIG
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

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
