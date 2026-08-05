using DCSCommon;

namespace FunctionCode
{
	public partial class ata_mpa
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
            //ps:=pt/10-po;
            ps[0] = pt / 10 - po;
		}
	}
}
