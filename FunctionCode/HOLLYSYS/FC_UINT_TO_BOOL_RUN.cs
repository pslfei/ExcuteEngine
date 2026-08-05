using DCSCommon;
namespace FunctionCode
{
    public partial class UINT_TO_BOOL
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (IN > 0)
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
