using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class ABS
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;
			IN[0] = IN + 1;
            OUT[0] = Math.Abs(IN);     
		}
	}
}
