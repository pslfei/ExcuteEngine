using DCSCommon;
namespace FunctionCode
{
	public partial class RS
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;
            Q1[0] = (!RESET1) && (SET | Q1);

		}
	}
}
