using DCSCommon;
namespace FunctionCode
{
	public partial class BYTE_TO_BOOL
	{
		protected override void Run(ICommand cmd)
		{
            if (IN >= 1)
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
