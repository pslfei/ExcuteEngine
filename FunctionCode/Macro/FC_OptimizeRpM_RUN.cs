using DCSCommon;

namespace FunctionCode
{
	public partial class OptimizeRpM
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
            //RT(AMV:=rpm, AMDT:=dtime);
            //rpmrate := RT.AMRATION*60;
            //(*2007.02.04改*)
            //(*IF rpm<=590 OR  rpm>2998 THEN
            //    iID :=0;
            //    orpmrate:=0;
            //    dinv :=TRUE;
            //    RETURN;
            //END_IF*)

            //(*处于临界转数*)
            //FOR i:=1 TO 6 DO
            //    IF (rpm -VibrateRpM[i,1])*(rpm -VibrateRpM[i,2])<=0 AND  iID<8 THEN
            //        iID :=8;
            //        orpmrate :=RpMStage[iID];
            //        RETURN;
            //    END_IF
            //END_FOR
            //(*判断当前速率级*)
            //FOR i:=1 TO 9 DO
            //    IF (rpmrate -(RpMStage[i-1]+RpMStage[i])/2)*(rpmrate -(RpMStage[i]+RpMStage[i+1])/2)<=0 THEN
            //        CNT :=i;
            //        EXIT;
            //    ELSIF rpmrate >(RpMStage[9]+RpMStage[10])/2 THEN
            //        CNT:=10;
            //    ELSE
            //        CNT:=0;
            //    END_IF
            //END_FOR

            //IF strinv=FALSE THEN
            //    (*计算优化后的速率级*)
            //    IF str >=100 OR  fstr>=100 THEN
            //        iID :=0;
            //    ELSIF str>=85 THEN
            //        IF CNT<=iID AND iID>0 THEN
            //            iID := iID-1;
            //        END_IF
            //    ELSE
            //        IF fstr<50 AND CNT>=iID AND iID<10 THEN
            //            iID := iID+1;
            //        END_IF
            //    END_IF
            //    orpmrate :=RpMStage[iID];
            //ELSE
            //    dinv:=TRUE;
            //END_IF
		}
	}
}
