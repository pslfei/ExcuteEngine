using System;
using DCSCommon;
namespace FunctionCode
{
    public partial class FLOR
	{
		protected override void Run(ICommand cmd)  
		{
            _ENO[0] = _EN;
            if (!_EN)
                return;

            DV[0] = I1 | I2 | I3 | I4 | I5 | I6 | I7 | I8;
		}
	}
}
