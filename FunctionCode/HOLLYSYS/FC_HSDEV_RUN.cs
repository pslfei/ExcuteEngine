using DCSCommon;
namespace FunctionCode
{
	public partial class HSDEV
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (IN > float.MaxValue || IN < float.MinValue)
            {
                return;
            }

            AV[0] = (TC * OLD_AV + KG * (IN - OLD_IN)) / (cmd.Dpu.Cycle + TC);

            if (AV > float.MaxValue)
            {
                AV[0] = float.MaxValue;
            }

            if (AV < float.MinValue)
            {
                AV[0] = float.MinValue;
            }

            OLD_IN = IN;
            OLD_AV = AV;
		}
	}
}
