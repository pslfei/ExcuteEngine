using DCSCommon;

namespace FunctionCode
{
	public partial class mpa_ata
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
            //pt:=(ps+po)*10;
            pt[0] = (ps + po) * 10;
		}
	}
}
