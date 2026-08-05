using DCSCommon;

namespace FunctionCode
{
	public partial class CDIFF_Modal
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
            //            rRotor := (R2 - R1) / Nset;

            //VCo[0] := 0.5 * R1 * rRotor;
            //VRi_1[0] := R1 / rRotor + 0.5;
            //VRi_2[0] := 0;

            //FOR i:=1 TO Nset-1 DO
            //    Ri := R1 + rRotor * i;
            //       VCo[i] := Ri * rRotor;
            //       VRi_1[i] := Ri / rRotor + 0.5;
            //       VRi_2[i] := Ri / rRotor - 0.5;
            //END_FOR
            //VCo[Nset] := 0.5 * R2 * rRotor;
            //VRi_1[Nset] := 0;
            //VRi_2[Nset] := R2 / rRotor - 0.5;

            //VRx[Nset] := 0;
            //FOR i:=0 TO Nset-1 DO
            //    Ri := R1 + rRotor * i;
            //       Rj := Ri + rRotor;
            //       VRx[i] := Rj * Rj - Ri * Ri;
            //       VRx[NSet] := VRx[NSet] + VRx[i];
            //END_FOR
            //bInitioned :=TRUE;
		}
	}
}
