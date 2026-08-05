using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class CTU
	{
		protected override void Run(ICommand cmd)  
		{
			_ENO[0] = _EN;
            if (!_EN)
                return;
		}
	}
}
