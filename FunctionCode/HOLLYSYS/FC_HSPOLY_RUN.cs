using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class HSPOLY
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            AV[0] = CF[0] + CF[1] * IN + CF[2] * Math.Pow(IN, 2) + CF[3] * Math.Pow(IN, 3) + CF[4] * Math.Pow(IN, 4) + CF[5] * Math.Pow(IN, 5) + CF[6] * Math.Pow(IN, 6);
		}
	}
}
