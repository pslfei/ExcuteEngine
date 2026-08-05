using DCSCommon;

namespace FunctionCode
{
	public partial class IPRotorFEM
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
            //IF  IPRotor.uMM.bInitioned=FALSE THEN
            //    IPRotor.uMM.Nmax := Nmax;
            //    IPRotor.uMM.Emax := Emax;
            //    IPRotor.uMM.Nborder := Nborder;
            //    IPRotor.uMM.Nset := Nset;
            //    IPRotor.uMM.Calcset := Calcset;
            //    IPRotor.uMM.Mark := Mark;
            //    IPRotor.uMM.Kth := Kth;
            //    FOR i:=1 TO IPRotor.uMM.Nmax DO
            //        IPRotor.TT[i] :=tqg;
            //        FOR j:=0 TO 1 DO
            //            IPRotor.uMM.YX[i,j] :=YX[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO IPRotor.uMM.Emax DO
            //        FOR j:=0 TO 3 DO
            //            IPRotor.uMM.EP[i,j] :=EP[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO IPRotor.uMM.Nborder DO
            //        FOR j:=0 TO 5 DO
            //            IPRotor.uMM.TBI[i,j] :=TBI[i,j];
            //        END_FOR
            //        END_FOR
            //    FOR i:=1 TO IPRotor.uMM.Nset DO
            //        FOR j:=0 TO 1 DO
            //            IPRotor.uMM.XII[i,j] :=XII[i,j];
            //        END_FOR
            //        END_FOR
            //    IPRotor.RN[0]:=1;	IPRotor.RN[1]:=4;
            //    IPRotor.RN[2]:=7;;	IPRotor.RN[3]:=9;
            //END_IF

            //(*初始边界条件*)
            //tcc[0]:=tqzd;pcc[0]:=0.0;					(*前轴端*)
            //tcc[1]:=tqzf;pcc[1]:=pqzf;						(*主进汽*)
            //tcc[2]:=tzr;pcc[2]:=pzr;							(*主进汽*)
            //tcc[3]:=tyl1;pcc[3]:=pyl1;						(*第1级后*)
            //tcc[4]:=tcq3;pcc[4]:=pcq3;						(*第1#抽汽后*)
            //tcc[5]:=tcq4;pcc[5]:=pcq4;						(*第2#抽汽后*)
            //tcc[6]:=tcq5;pcc[6]:=pcq5;						(*第3#抽汽后*)
            //tcc[7]:=tcq6;pcc[7]:=pcq6;						(*第4#抽汽后*)
            //tcc[8]:=tpq;pcc[8]:=ppq;						(*汽缸排汽*)
            //tcc[9]:=thzf;pcc[9]:=phzf;						(*后轴封*)
            //tcc[10]:=thzd;pcc[10]:=0.0;				(*后轴端*)
            //tcc[11]:=tqg;

            //(*采集参数有效性判断*)
            //IF  rpm<0 OR rpm>=3600 OR dtime<=0 THEN
            //    ipstrinv :=TRUE;
            //    RETURN;
            //ELSE
            //    FOR i:=0 TO 11 DO
            //        IF tcc[i]<0 OR tcc[i]>600  OR pcc[i]<-0.01 OR pcc[i]>20 THEN
            //            ipstrinv :=TRUE;
            //            RETURN;
            //        END_IF
            //    END_FOR
            //END_IF

            //(*
            //RT1(AMV:=tzr, AMDT:=dtime);
            //RT2(AMV:=tyl1, AMDT:=dtime);
            //RT3(AMV:=tcq3, AMDT:=dtime);
            //*)
            //(*计算当前应力情况*)
            //IPRotor(Tcc:=tcc,Pcc:=pcc,RpM:=rpm,dTime:=dtime);
            //FOR i:=1 TO IPRotor.uMM.Nmax DO
            //    iptRotor[i] := IPRotor.TT[i] ;
            //END_FOR
            //ipvstr:=IPRotor.AVSTR;
            //ipstr := IPRotor.ASTR;
            //ipsurt :=IPRotor.ASURT;
            //ipbort := IPRotor.ABORT;
            //ipvolt  := IPRotor.AVOLT;
            //(*
            //(*计算预测应力情况*)
            //IPRotor(Tcc:=tcc,Pcc:=pcc,RpM:=rpm,dTime:=dtime);
            //ipfvstr:=IPRotor.AVSTR;
            //ipfstr := IPRotor.ASTR;

            //(*恢复温度场*)
            //FOR i:=1 TO IPRotor.uMM.Nmax DO
            //    IPRotor.TT[i] := iptRotor[i] ;
            //END_FOR
            //*)
            //ipstrinv := IPRotor.DSTRINV;
		}
	}
}
