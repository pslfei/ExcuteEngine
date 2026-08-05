using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class MIN
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            OUT[0] = Math.Min(IN1, IN2);
		}
	}
}
