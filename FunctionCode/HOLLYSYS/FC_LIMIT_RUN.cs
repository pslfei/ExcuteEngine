using DCSCommon;
using System;
namespace FunctionCode
{
	public partial class LIMIT
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;
            //OUT:=MIN(MAX(IN,Min),Max)
            OUT[0] = Math.Min(Math.Max(IN, Min), Max);
		}
	}
}
