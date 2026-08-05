using DCSCommon;
namespace FunctionCode
{
	public partial class HSDOWN
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN == false && OLD_IN == true)
            {
                OUT[0] = true;
            }
            else
            {
                OUT[0] = false;
            }

            OLD_IN = IN;
		}
	}
}
