using DCSCommon;

namespace FunctionCode
{
	public partial class HPRotorFEM
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
            //(*数学模型初始化*)
            //IF  HPRotor.uMM.bInitioned=FALSE THEN
            //    HPRotor.uMM.Nmax := Nmax;
            //    HPRotor.uMM.Emax := Emax;
            //    HPRotor.uMM.Nborder := Nborder;
            //    HPRotor.uMM.Nset := Nset;
            //    HPRotor.uMM.Calcset := Calcset;
            //    HPRotor.uMM.Mark := Mark;
            //    HPRotor.uMM.Kth := Kth;
            //    FOR i:=1 TO HPRotor.uMM.Nmax DO
            //        HPRotor.TT[i] :=tqg;
            //        FOR j:=0 TO 1 DO
            //            HPRotor.uMM.YX[i,j] :=YX[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO HPRotor.uMM.Emax DO
            //        FOR j:=0 TO 3 DO
            //            HPRotor.uMM.EP[i,j] :=EP[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO HPRotor.uMM.Nborder DO
            //        FOR j:=0 TO 5 DO
            //            HPRotor.uMM.TBI[i,j] :=TBI[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO HPRotor.uMM.Nset DO
            //        FOR j:=0 TO 1 DO
            //            HPRotor.uMM.XII[i,j] :=XII[i,j];
            //        END_FOR
            //        END_FOR
            //    HPRotor.RN[0]:=1;	HPRotor.RN[1]:=7;
            //    HPRotor.RN[2]:=9;	HPRotor.RN[3]:=9;
            //END_IF

            //(*初始边界条件*)
            //tcc[0]:=tqzd;pcc[0]:=0.0;						(*前轴端*)
            //tcc[1]:=tqzf;pcc[1]:=pqzf;						(*前轴封*)
            //tcc[2]:=tzq;pcc[2]:=pzq;						(*主进汽*)
            //tcc[3]:=ttj;pcc[3]:=ptj;							(*调节级后*)
            //tcc[4]:=tcq1;pcc[4]:=pcq1;						(*第1#抽汽后*)
            //tcc[5]:=tcq2;pcc[5]:=pcq2;						(*第2#抽汽后*)
            //tcc[8]:=tpq;pcc[8]:=ppq;						(*汽缸排汽*)
            //tcc[9]:=thzf;pcc[9]:=phzf;						(*后轴封*)
            //tcc[10]:=thzd;pcc[10]:=0.0;						(*后轴端*)
            //tcc[11]:=tqg;

            //(*采集参数有效性判断*)
            //IF  rpm<0 OR rpm>3600 OR dtime<=0 THEN
            //    hpstrinv :=TRUE;
            //    RETURN;
            //ELSE
            //    FOR i:=0 TO 11 DO
            //        IF tcc[i]<0 OR tcc[i]>600  OR pcc[i]<-0.01 OR pcc[i]>20 THEN
            //            hpstrinv :=TRUE;
            //            RETURN;
            //        END_IF
            //    END_FOR
            //END_IF
            //(*
            //RT1(AMV:=tzq, AMDT:=dtime);
            //RT2(AMV:=ttj, AMDT:=dtime);
            //RT3(AMV:=tcq1, AMDT:=dtime);
            //*)
            //(*计算当前应力情况*)
            //HPRotor(Tcc:=tcc,Pcc:=pcc,RpM:=rpm,dTime:=dtime);
            //FOR i:=1 TO HPRotor.uMM.Nmax DO
            //    hptRotor[i] := HPRotor.TT[i] ;
            //END_FOR
            //hpvstr :=HPRotor.AVSTR;
            //hpstr := HPRotor.ASTR;
            //hpsurt :=HPRotor.ASURT;
            //hpbort := HPRotor.ABORT;
            //hpvolt  := HPRotor.AVOLT;
            //(*
            //(*计算预测应力情况*)
            //HPRotor(Tcc:=tcc,Pcc:=pcc,RpM:=rpm,dTime:=dtime);
            //hpfvstr:=HPRotor.AVSTR;
            //hpfstr := HPRotor.ASTR;

            //(*恢复温度场*)
            //FOR i:=1 TO HPRotor.uMM.Nmax DO
            //    HPRotor.TT[i] := hptRotor[i] ;
            //END_FOR
            //*)
            //hpstrinv := HPRotor.DSTRINV;
		}
	}
}
