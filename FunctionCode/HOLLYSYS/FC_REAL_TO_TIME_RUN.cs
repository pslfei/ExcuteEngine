using DCSCommon;
namespace FunctionCode
{
	public partial class REAL_TO_TIME
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;

            OUT[0] = IN;
		}
	}
}
