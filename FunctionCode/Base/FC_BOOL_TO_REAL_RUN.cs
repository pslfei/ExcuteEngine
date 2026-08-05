using DCSCommon;
namespace FunctionCode
{
	public partial class BOOL_TO_REAL
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN)
            {
                OUT[0] = 1.0f;
            }
            else
            {
                OUT[0] = 0.0f;
            }
		}
	}
}
