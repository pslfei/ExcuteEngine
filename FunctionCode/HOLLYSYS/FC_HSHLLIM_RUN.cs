using DCSCommon;
namespace FunctionCode
{
	public partial class HSHLLIM
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

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
