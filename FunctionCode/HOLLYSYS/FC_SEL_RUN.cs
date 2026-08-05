using DCSCommon;
namespace FunctionCode
{
	public partial class SEL
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (G)
            {
                OUT[0] = IN1;
            }
            else
            {
                OUT[0] = IN0;
            }
		}
	}
}
