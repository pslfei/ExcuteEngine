using DCSCommon;
namespace FunctionCode
{
	public partial class NOT
	{
		protected override void Run(ICommand cmd) 
        {
            OUT[0] = !IN;
		}
	}
}
