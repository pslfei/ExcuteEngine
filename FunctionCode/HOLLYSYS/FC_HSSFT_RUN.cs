using DCSCommon;
namespace FunctionCode
{
	public partial class HSSFT
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (SW)
            {
                float Diff = I2 - I1;
                AV[0] = AV + RT * Diff;
                if (Diff > 0 && AV > I2)
                {
                    AV[0] = I2;
                }
                else if (Diff < 0 && AV < I2)
                {
                    AV[0] = I2;
                }
            }
            else
            {
                float Diff = I1 - I2;
                AV[0] = AV + RT * Diff;
                if (Diff > 0 && AV > I1)
                {
                    AV[0] = I1;
                }
                else if (Diff < 0 && AV < I1)
                {
                    AV[0] = I1;
                }
            }
		}
	}
}
