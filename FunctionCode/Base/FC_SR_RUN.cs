using DCSCommon;
namespace FunctionCode
{
	public partial class SR
	{
		protected override void Run(ICommand cmd)
		{
            Q1[0] = (!RESET & Q1) | SET1;
		}
	}
}
