using DCSCommon;
namespace FunctionCode
{
	public partial class HSFOP
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

            AV[0] = (TC * OLD_AV + KG * cmd.Dpu.Cycle * IN) / (cmd.Dpu.Cycle + TC);
            OLD_AV = AV;
		}
	}
}
