using DCSCommon;

namespace FunctionCode
{
	public partial class GetSteamVP
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
            //IF  (ts<0) THEN
            //    satmp:=0;
            //    DINV :=TRUE;
            //    RETURN;
            //END_IF

            //zt :=(ts+273.15)/647.3;
            //az1:=1-zt;
            //az2 :=(((64.23285504-118.9646225*az1)*az1-168.1706546)*az1-26.08023696)*az1;
            //az2 :=(az2-7.691234564)*az1;
            //az3 :=(20.9750676*az1+4.16711732)*az1+1.;
            //az4 :=az1/(1E9*az1*az1+6.);
            //ddxx :=az2/az3/zt-az4;

            //satmp :=221.2*EXP(ddxx);
		}
	}
}
