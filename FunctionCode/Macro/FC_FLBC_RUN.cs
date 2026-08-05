using DCSCommon;
using System;

namespace FunctionCode
{
	public partial class FLBC
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
			//IF (DP*(Ph+P*1000)/(273.5+t))>0 AND DP>TJ  THEN
			//Qm:=0.0590393*A*K*F*C*E*SQRT(DP*(Ph+P*1000)/(273.5+t));
			//Qv:=16.937858*A*K*F*C*E*SQRT(DP*(273.5+t)/(Ph+P*1000));
			//Qvn:=0.0456607*A*K*F*C*E*SQRT(DP*(Ph+P*1000)/(273.5+t));
			//ELSE
			//Qm:=0;
			//Qv:=0;
			//Qvn:=0;
			//END_IF

			if((DP * (Ph + P * 1000) / (273.5 + t)) > 0 && DP > TJ)
			{
				Qm[0] = 0.0590393 * A * K * F * C * E * Math.Sqrt(DP * (Ph + P * 1000) / (273.5 + t));
				Qv[0] = 16.937858 * A * K * F * C * E * Math.Sqrt(DP * (273.5 + t) / (Ph + P * 1000));
				Qvn[0] = 0.0456607 * A * K * F * C * E * Math.Sqrt(DP * (Ph + P * 1000) / (273.5 + t));
			}
			else
			{
				Qm[0] = 0;
				Qv[0] = 0;
				Qvn[0] = 0;
			}
		}
	}
}
