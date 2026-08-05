using DCSCommon;
namespace FunctionCode
{
	public partial class BOOL_TO_INT
	{
		protected override void Run(ICommand cmd)
		{
            if (IN)
            {
                OUT[0] = 1;
            }
            else
            {
                OUT[0] = 0;
            }
		}
	}
}
