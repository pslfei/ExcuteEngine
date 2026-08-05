using DCSCommon;
namespace FunctionCode
{
	public partial class HSHLLIM
	{
		protected override void Run(ICommand cmd) 
        {
            if (IN > HL)
            {
                IN[0] = HL;
            }
            else if (IN < LL)
            {
                IN[0] = LL;
            }
  
            AV[0] = IN;            
		}
	}
}
