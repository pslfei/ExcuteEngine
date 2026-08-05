using DCSCommon;

namespace FunctionCode
{
	public partial class MST1_FB
	{
		public override DCSCommon.ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
			}
		}

		protected override void Run(ICommand cmd)
		{
            ST1[0] = MST;
            ER[0] = false;
		}
	}
}
