using DCSCommon;
namespace FunctionCode
{
	public partial class DIV
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN2 != 0)
            {
                OUT[0] = IN1 / IN2;
            }
		}
	}
}
