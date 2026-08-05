using DCSCommon;

namespace FunctionCode
{
	public partial class GetRation
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
		}
	}
}
