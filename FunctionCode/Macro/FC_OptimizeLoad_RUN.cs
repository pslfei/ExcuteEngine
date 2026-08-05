using DCSCommon;

namespace FunctionCode
{
	public partial class OptimizeLoad
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
            //            dinv :=FALSE;
            //RT(AMV:=load, AMDT:=dtime);
            //loadrate := RT.AMRATION*60;
            //(*2007.02.04改*)
            //(*IF load<=0.1 OR  load>300 THEN
            //    iID :=0;
            //    oloadrate:=0;
            //    RETURN;
            //END_IF*)

            //FOR i:=1 TO 9 DO
            //    IF (loadrate -(LoadStage[i-1]+LoadStage[i])/2)*(loadrate -(LoadStage[i]+LoadStage[i+1])/2)<=0 THEN
            //        CNT :=i;
            //        EXIT;
            //    ELSIF loadrate >(LoadStage[9]+LoadStage[10])/2 THEN
            //        CNT:=10;
            //    ELSE
            //        CNT:=0;
            //    END_IF
            //END_FOR

            //IF strinv=FALSE THEN
            //    IF str >=100 OR  fstr>=100 THEN
            //        iID :=0;
            //    ELSIF str>=85 THEN
            //        IF CNT<=iID AND iID>0 THEN
            //            iID := iID-1;
            //        END_IF
            //    ELSE
            //        IF fstr<50 AND CNT<=iID  AND iID<10 THEN  (*2007.02.04改 原为 IF fstr<50 AND CNT>=iID  AND iID<10 THEN*)
            //            iID := iID+1;
            //        END_IF
            //    END_IF
            //    oloadrate :=LoadStage[iID];
            //ELSE
            //    dinv:=TRUE;
            //END_IF
		}
	}
}
