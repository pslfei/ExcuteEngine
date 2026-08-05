using DCSCommon;
namespace FunctionCode
{
	public partial class HSALM_DV
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (((I1 - I2) >= HL) || ((I1 - I2) <= -LL))
            {
                DV[0] = true;
            }
            else
            {
                DV[0] = false;
            }
		}
	}
}
