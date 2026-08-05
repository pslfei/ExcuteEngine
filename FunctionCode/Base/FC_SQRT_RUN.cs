using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class SQRT
	{
		protected override void Run(ICommand cmd) 
        {
            OUT[0] = Math.Sqrt(IN);
		}
	}
}
