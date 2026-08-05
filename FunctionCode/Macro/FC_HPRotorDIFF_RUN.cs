using DCSCommon;

namespace FunctionCode
{
	public partial class HPRotorDIFF
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
            //hpstrinv :=FALSE;
            //(*数学模型初始化*)
            //IF  HPRotor.uMM.bInitioned=FALSE THEN
            //    HPRotor.uMM.R1 := R1;
            //    HPRotor.uMM.R2 := R2;
            //    HPRotor.uMM.Kth := Kth;
            //END_IF

            //(*采集参数有效性判断*)
            //IF ttj<0 OR  ttj>600 OR ptj<-0.01 OR ptj>20 OR rpm<0 OR rpm>3600 OR dtime<=0 THEN
            //    hpstrinv :=TRUE;
            //    RETURN;
            //END_IF
            //(*计算当前应力情况*)
            //RT(AMV:=ttj, AMDT:=dtime);
            //HPRotor(Tcc:=ttj,Pcc:=ptj,Tqg:=tqg,RpM:=rpm,dTime:=dtime);
            //hpstrinv := HPRotor.DSTRINV;
            //FOR i:=0 TO HPRotor.uMM.Nset DO
            //    hptRotor[i] := HPRotor.TT[i] ;
            //END_FOR
            //hpvstr :=HPRotor.AVSTR;
            //hpstr := HPRotor.ASTR;
            //hpsurt :=HPRotor.ASURT;
            //hpbort := HPRotor.ABORT;
            //hpvolt  := HPRotor.AVOLT;
            //(*计算预测应力情况*)
            //HPRotor(Tcc:=ttj+RT.AMRATION*dtime/1000,Pcc:=ptj,Tqg:=tqg,RpM:=rpm,dTime:=dtime);
            //hpfvstr:=HPRotor.AVSTR;
            //hpfstr := HPRotor.ASTR;
            //(*恢复温度场*)
            //FOR i:=0 TO HPRotor.uMM.Nset DO
            //    HPRotor.TT[i] := hptRotor[i] ;
            //END_FOR
            //hpstrinv := HPRotor.DSTRINV;
		}
	}
}
