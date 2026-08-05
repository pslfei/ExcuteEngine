using DCSCommon;
namespace FunctionCode
{
	public partial class SR
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;

            Q1[0] = (!RESET & Q1) | SET1;
		}
	}
}
