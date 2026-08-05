using DCSCommon;
namespace FunctionCode
{
	public partial class EQ
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN1 == IN2)
            {
                OUT[0] = true;
            }
            else
            {
                OUT[0] = false;
            }
		}
	}
}
