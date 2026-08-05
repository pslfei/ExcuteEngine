using DCSCommon;
namespace FunctionCode
{
	public partial class GE
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (IN1 >= IN2)
            {
                OUT[0] = true;
            }
            else
            {
                OUT[0] = false;
            }
		}
	}
}
