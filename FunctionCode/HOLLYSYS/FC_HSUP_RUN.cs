using DCSCommon;
namespace FunctionCode
{
	public partial class HSUP
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (OLD_IN == false && IN == true)
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
