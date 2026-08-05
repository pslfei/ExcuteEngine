using DCSCommon;

namespace FunctionCode
{
	public partial class GetSteamVT
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
            //DINV :=FALSE;
            //IF (ps<=0) THEN ;
            //    satmt:=0;
            //    DINV :=TRUE;
            //    RETURN;
            //END_IF

            //ta :=100.0*HSEXPT(ABS(ps),0.25);
            //vpst(ts:=ta);
            //pb := vpst.satmp;
            //WHILE (ABS((ps-pb)/ps)>=5.0E-6) DO
            //       ta :=ta+25.*(ps-pb)/HSEXPT(ABS(pb),0.75);
            //    vpst(ts:=ta);
            //    pb := vpst.satmp;
            //END_WHILE
            //satmt :=ta;
		}
	}
}
