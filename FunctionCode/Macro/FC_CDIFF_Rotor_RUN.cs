using DCSCommon;

namespace FunctionCode
{
	public partial class CDIFF_Rotor
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
            //            DSTRINV :=FALSE;
            //IF  uMM.bInitioned=FALSE THEN
            //    uMM();
            //    FOR i:=0 TO uMM.Nset DO
            //        TT[i] :=Tqg;
            //        END_FOR
            //    d_time:=1000;
            //END_IF

            //d_time:=dTime/1000.0;
            //FOR i:=0 TO uMM.Nset DO
            //       TP(Ts:=TT[i]);
            //    LAMD:=TP.LAMD;
            //    AA:=TP.AA;
            //    Co[i] := LAMD / AA * uMM.VCo[i];
            //       Ri_1[i] := LAMD * uMM.VRi_1[i];
            //       Ri_2[i] := LAMD * uMM.VRi_2[i];
            //END_FOR

            //(*»»ÈÈÏµÊý*)
            //Pcc:=Pcc+0.1013;
            //ALFA(T:=Tcc, P:=Pcc, N:=0, Dk:=uMM.R2, PN:=0, PM:=0, Mc:=3);
            //af_ :=ALFA.alfa;

            //FOR i:=0 TO uMM.Nset DO
            //    A[i] := Co[i] / d_Time + Ri_1[i] + Ri_2[i];
            //       B[i] := -Ri_1[i];
            //        C[i] := -Ri_2[i];
            //       D[i] := TT[i] * Co[i] / d_time;
            //END_FOR
            //A[Nset] := A[Nset] + af_ * uMM.R2;
            //D[Nset] := D[Nset] + af_ * uMM.R2 * Tcc;

            //FOR i:=1 TO uMM.Nset DO
            //    A[i] := A[i] - B[i - 1] * C[i] / A[i - 1];
            //        D[i] := D[i] - D[i - 1] * C[i] / A[i - 1];
            //END_FOR

            //TT[Nset] := D[Nset] / A[Nset];
            //FOR i:= uMM.Nset-1 TO 0 BY -1 DO
            //        TT[i] := (D[i] - B[i] * TT[i + 1]) / A[i];
            //END_FOR

            //AVOLT :=0;
            //FOR i :=0 TO uMM.Nset-1 DO
            //      AVOLT := AVOLT + (TT[i] + TT[i+1]) * uMM.VRx[i] / 2;
            //END_FOR
            //AVOLT := AVOLT / uMM.VRx[uMM.Nset];
            //ASURT :=TT[uMM.Nset];
            //ABORT :=TT[0];
            //IF (AVOLT-ASURT)*(AVOLT-ABORT)>0.001 THEN
            //    DSTRINV :=TRUE;
            //    RETURN;
            //END_IF

            //SP(Ts := AVOLT);
            //EE :=SP.EE;
            //BATA :=SP.BATA;
            //Mu :=SP.Mu;

            //strL := 30 * (RpM / 3000)*(RpM / 3000);
            //strR := uMM.Kth * BATA * EE / (1 - Mu) * (AVOLT - ASURT);

            //AVSTR := SQRT(strR * strR + strL * strL + strR * strL);
            //ASTR := 100*(AVSTR/320);
            //IF ABS(ASTR)>300 THEN
            //    DSTRINV :=TRUE;
            //END_IF
		}
	}
}
