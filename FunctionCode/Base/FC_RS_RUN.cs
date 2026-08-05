using DCSCommon;
namespace FunctionCode
{
	public partial class RS
	{
		protected override void Run(ICommand cmd) 
        {
            Q1[0] = (!RESET1) && (SET | Q1);
		}
	}
}
