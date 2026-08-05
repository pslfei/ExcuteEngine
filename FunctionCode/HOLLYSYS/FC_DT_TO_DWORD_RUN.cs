using DCSCommon;
namespace FunctionCode
{
	public partial class DT_TO_DWORD
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
