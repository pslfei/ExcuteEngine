using DCSCommon;
using System;
namespace FunctionCode
{
	public partial class LIMIT
	{
		protected override void Run(ICommand cmd) 
        {
            OUT[0] = Math.Min(Math.Max(IN, Min), Max);
		}
	}
}
