using DCSCommon;

namespace FunctionCode
{
	public partial class IPRotorDIFF
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
            //        ipstrinv :=FALSE;
            //(*数学模型初始化*)
            //IF  IPRotor.uMM.bInitioned=0 THEN
            //    IPRotor.uMM.R1 := R1;
            //    IPRotor.uMM.R2 := R2;
            //    IPRotor.uMM.Kth := Kth;
            //END_IF

            //(*采集参数有效性判断*)
            //IF tyl1<0 OR  tyl1>600 OR pyl1<-0.01 OR pyl1>20 OR rpm<0 OR rpm>3600 OR dtime<=0 THEN
            //    ipstrinv :=TRUE;
            //    RETURN;
            //END_IF
            //(*计算当前应力情况*)
            //RT(AMV:=tyl1, AMDT:=dtime);
            //IPRotor(Tcc:=tyl1,Pcc:=pyl1,Tqg:=tqg,RpM:=rpm,dTime:=dtime);
            //ipstrinv := IPRotor.DSTRINV;
            //FOR i:=0 TO IPRotor.uMM.Nset DO
            //    iptRotor[i] := IPRotor.TT[i] ;
            //END_FOR
            //ipvstr :=IPRotor.AVSTR;
            //ipstr := IPRotor.ASTR;
            //ipsurt :=IPRotor.ASURT;
            //ipbort := IPRotor.ABORT;
            //ipvolt  := IPRotor.AVOLT;
            //(*计算预测应力情况*)
            //IPRotor(Tcc:=tyl1+RT.AMRATION*dtime/1000,Pcc:=pyl1,Tqg:=tqg,RpM:=rpm,dTime:=dtime);
            //ipfvstr:=IPRotor.AVSTR;
            //ipfstr := IPRotor.ASTR;
            //(*恢复温度场*)
            //FOR i:=0 TO IPRotor.uMM.Nset DO
            //    IPRotor.TT[i] := iptRotor[i] ;
            //END_FOR
            //ipstrinv := IPRotor.DSTRINV;
		}
	}
}
