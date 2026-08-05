using DCSCommon;
namespace FunctionCode
{
	public partial class REAL_TO_TIME
	{
		protected override void Run(ICommand cmd)
		{
            OUT[0] = IN;
		}
	}
}
