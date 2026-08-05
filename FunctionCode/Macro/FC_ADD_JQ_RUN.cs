using DCSCommon;
namespace FunctionCode
{
	public partial class ADD_JQ
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
            OUT[0] = S1 * S3 + S2 * S4;
		}
	}
}
