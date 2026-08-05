using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class COS
	{
		protected override void Run(ICommand cmd)
		{
            OUT[0] = Math.Cos(IN);     
		}
	}
}
