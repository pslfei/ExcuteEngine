using DCSCommon;
namespace FunctionCode
{
	public partial class HSDOWN
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (IN == false && OLD_IN == true)
            {
                OUT[0] = true;
            }
            else
            {
                OUT[0] = false;
            }

            OLD_IN = IN;
		}
	}
}
