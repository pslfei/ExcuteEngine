using DCSCommon;
namespace FunctionCode
{
    public partial class UINT_TO_BOOL
	{
		protected override void Run(ICommand cmd)
		{
            if (IN > 0)
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
