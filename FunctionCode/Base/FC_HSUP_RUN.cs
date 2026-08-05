using DCSCommon;
namespace FunctionCode
{
	public partial class HSUP
	{
		protected override void Run(ICommand cmd) 
        {
            if (OLD_IN == false && IN == true)
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
