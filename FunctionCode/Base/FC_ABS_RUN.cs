using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class ABS
	{
		protected override void Run(ICommand cmd)
		{
			OUT[0] = Math.Abs(IN);
		}
	}
}
