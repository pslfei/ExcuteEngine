using System;
using DCSCommon;
namespace FunctionCode
{
    public partial class Input
	{
		protected override void Run(ICommand cmd)
		{
            OUT[0] = IN;    
		}
	}
}
