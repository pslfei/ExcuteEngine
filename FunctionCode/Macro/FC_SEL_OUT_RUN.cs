using DCSCommon;
namespace FunctionCode
{
	public partial class SEL_OUT
	{
		public override ICommand Command
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
