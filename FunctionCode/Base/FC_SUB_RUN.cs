using DCSCommon;
namespace FunctionCode
{
	public partial class SUB
	{
		protected override void Run(ICommand cmd) 
        {
            OUT[0] = IN1 - IN2;
		}
	}
}
