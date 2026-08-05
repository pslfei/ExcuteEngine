using DCSCommon;
namespace FunctionCode
{
	public partial class SUB
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            OUT[0] = IN1 - IN2;
		}
	}
}
