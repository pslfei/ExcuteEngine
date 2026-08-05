using DCSCommon;
namespace FunctionCode
{
	public partial class DT_TO_DWORD
	{
		protected override void Run(ICommand cmd) 
        {
            OUT[0] = IN;
		}
	}
}
