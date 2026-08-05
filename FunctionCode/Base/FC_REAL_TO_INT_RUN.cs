using DCSCommon;
namespace FunctionCode
{
	public partial class REAL_TO_INT
	{
		protected override void Run(ICommand cmd)
		{
			OUT[0] = (int)IN;
		}
	}
}
