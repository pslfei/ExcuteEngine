using DCSCommon;

namespace FunctionCode
{
	public partial class THR_SEL
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
				SEL_34.Command = this.Command;
				QOR1.Command = this.Command;
				THR.Command = this.Command;
				AND_39.Command = this.Command;
				SEL_47.Command = this.Command;
				SEL_51.Command = this.Command;
				AND_52.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd)
		{
			SEL_34.G[0] = QOR1.D;
			SEL_34.IN0[0] = 0;
			SEL_34.IN1[0] = SEL_47.OUT;
			SEL_34.Implement(cmd);
			
			QOR1.A[0] = C1;
			QOR1.B[0] = C2;
			QOR1.C[0] = C3;
			QOR1.Implement(cmd);
			
			THR.X1[0] = S1;
			THR.A1[0] = C1;
			THR.X2[0] = S2;
			THR.A2[0] = C2;
			THR.X3[0] = S3;
			THR.A3[0] = C3;
			THR.MD[0] = SEL_34.OUT;
			THR.DB[0] = DB;
			THR.Implement(cmd);
			
			S_OUT[0] = THR.AV;
			AND_39.IN1[0] = C1;
			AND_39.IN2[0] = C2;
			AND_39.Implement(cmd);
			
			SEL_47.G[0] = AND_39.OUT;
			SEL_47.IN0[0] = SEL_51.OUT;
			SEL_47.IN1[0] = 6;
			SEL_47.Implement(cmd);
			
			SEL_51.G[0] = AND_52.OUT;
			SEL_51.IN0[0] = 5;
			SEL_51.IN1[0] = 4;
			SEL_51.Implement(cmd);
			
			AND_52.IN1[0] = C2;
			AND_52.IN2[0] = C3;
			AND_52.Implement(cmd);
			
			S_Q[0] = THR.Q0;
		}
	}
}
