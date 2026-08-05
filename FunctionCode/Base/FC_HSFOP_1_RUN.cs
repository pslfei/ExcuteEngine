using DCSCommon;
using TDServer.Service;
namespace FunctionCode
{
	public partial class HSFOP_1
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN > float.MaxValue || IN < float.MinValue)
            {
                return;
            }

            AV[0] = (TC * OLD_AV + KG * ExcuteEngine.cycle / 1000 * IN) / (ExcuteEngine.cycle / 1000 + TC);
            OLD_AV = AV;
		}
	}
}
