using DCSCommon;

namespace FunctionCode
{
	public partial class GetSteamHSV
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
            //IF (ps<=0 OR ts<0) THEN
            //    DINV :=TRUE;RETURN;
            //END_IF
            //zp:=ps/221.2;
            //zt :=(ts+273.15)/647.3;
            //az0:=z7[0]+(z7[1]+z7[2]*zt)*zt;
            //azz:=zp*HSEXPT(ABS((zp/az0)),10);
            //az1:=z7[1]+2.0*z7[2]*zt;
            //az2:=EXP(z7[3]*(1.0-zt));
            //az3:=0.0;
            //az4:=0.0;
            //az5:=0.0;

            //FOR i:=1 TO 5 DO
            //    az6:=0.0;
            //    az7:=0.0;
            //       FOR j:=1 TO 3 DO
            //                az8:=HSEXPT(ABS(az2),z9[i-1,j-1]);
            //                az6:=az6+z8[i-1,j-1]*az8;
            //                az7:=az7+z8[i-1,j-1]*(1.+z7[3]*z9[i-1,j-1]*zt)*az8;
            //                az3:=az3+z7[3]*HSEXPT(ABS(zp),i)*z9[i-1,j-1]*z8[i-1,j-1]*az8;
            //    END_FOR
            //       az4:=az4+az6*i*HSEXPT(ABS(zp),(i-1));
            //       az5:=az5+az7*HSEXPT(ABS(zp),i);
            //END_FOR

            //az8:=0.0;
            //FOR i:=1 TO 3 DO
            //    az6:=0.0;
            //    az9:=0.0;
            //    FOR j:=1 TO 3 DO
            //        az6:=az6+z8[i+4,j-1]*HSEXPT(ABS(az2),z9[i+4,j-1]);
            //                az9:=az9+zz[i-1,j-1]*HSEXPT(ABS(az2),zs[i-1,j-1]);
            //        END_FOR
            //        azs:=HSEXPT(ABS(zp),(i+2));
            //    az8:=az8+az6*(i+3)*azs/HSEXPT(ABS(1.+az9*zp*azs),2);
            //END_FOR

            //az6:=0.0;
            //IF (zp>=0.1) THEN
            //    FOR i:=1TO 7 DO
            //        az6:=az6*az2+z3[i-1];
            //        END_FOR
            //        az6:=11.0*az6*HSEXPT(ABS(zp/az0),10);
            //END_IF
            //vg :=0.00317*(z7[5]*zt/zp-az4-az8+az6);

            //az4:=0.0;
            //FOR i:=1 TO 5 DO
            //    az4:=az4*zt+(4-i)*z4[i-1];
            //END_FOR
            //az6:=0.0;
            //IF (zp>=0.005) THEN
            //    FOR i:=1 TO 3 DO
            //        az8:=0.0;
            //             FOR j:=1 TO 3 DO
            //            az7:=0.0;
            //                    az9:=0.0;
            //                    FOR k:=1 TO 3 DO
            //                        az7:=az7+zs[i-1,k-1]*zz[i-1,k-1]*HSEXPT(ABS(az2),zs[i-1,k-1]);
            //                        az9:=az9+zz[i-1,k-1]*az2*zs[i-1,j-1];
            //                    END_FOR
            //                    azs:=HSEXPT(ABS(zp),(i+2));
            //                    zv:=HSEXPT(ABS(az2),z9[i+4,j-1])*(1.0+(z9[i+4,j-1]-az7/(az9+1.0/azs))*z7[3]*zt);
            //                    az8:=az8+zv*z8[i+4,j-1];
            //        END_FOR
            //             az6:=az6+az8/(az9+1./zp/azs);
            //    END_FOR
            //END_IF

            //az8:=0.0;
            //IF (zp>=0.1) THEN
            //    FOR i:=1TO 7 DO
            //        az8:=az8*az2+z3[i-1]*(1.+zt*(10.+az1/az0+z7[2]*(7-i)));
            //        END_FOR
            //END_IF
            // zh:=z7[4]*zt-az4-az5-az6+az8*azz;
            //enth:=zh*70.1204;

            //az4:=0.0;
            //FOR i:=1 TO 5 DO
            //    az4:=az4*zt+(5-i)*z4[i-1];
            //END_FOR
            //az5:=0.0;
            //IF (zp>=0.005) THEN
            //    FOR i:=1 TO 3 DO
            //        az6:=0.0;
            //              FOR j:=1 TO 3 DO
            //                az7:=0.0;
            //                    az8:=0.0;
            //                    FOR k:=1 TO 3 DO
            //                        az9:=HSEXPT(ABS(az2),zs[i-1,k-1])*zz[i-1,k-1];
            //                        az7:=az7+az9*zs[i-1,k-1];
            //                        az8:=az8+az9;
            //                    END_FOR
            //                    azs:=1.0/HSEXPT(ABS(zp),(i+3))+az8;
            //                    az6:=az6+(z9[i+4,j-1]-az7/azs)*z8[i+4,j-1]*HSEXPT(ABS(az2),z9[i+4,j-1]);
            //            END_FOR
            //                az5:=az5+az6/azs;
            //        END_FOR
            //END_IF
            //az5:=az5*z7[3];

            //az6:=0.0;
            //IF (zp>=0.1) THEN
            //    FOR i:=1 TO 7 DO
            //        az6:=az6*az2+(10.*az1/az0+z7[3]*(7-i))*z3[i-1];
            //        END_FOR
            //       az6:=az6*azz;
            //END_IF
            //azs:=z7[4]*LOG(ABS(zt))-z7[5]*LOG(ABS(zp))-az4/zt-az3-az5+az6;
            //sg:=azs*0.108327514;
		}
	}
}
