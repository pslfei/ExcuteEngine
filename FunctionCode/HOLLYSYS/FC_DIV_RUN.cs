using DCSCommon;
namespace FunctionCode
{
	public partial class DIV
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (IN2 != 0)
            {
                OUT[0] = IN1 / IN2;
            }
		}
	}
}
