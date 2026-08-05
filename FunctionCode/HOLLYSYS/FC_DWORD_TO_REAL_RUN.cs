using DCSCommon;
namespace FunctionCode
{
	public partial class DWORD_TO_REAL
	{
		protected override void Run(ICommand cmd)  
		{
            OUT[0] = IN;
		}
	}
}
