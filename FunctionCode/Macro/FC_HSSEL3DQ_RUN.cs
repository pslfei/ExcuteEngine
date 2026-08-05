using DCSCommon;
namespace FunctionCode
{
	public partial class HSSEL3DQ
	{
		public override ICommand Command
		{
			get
			{
				return base.Command;
			}
			set
			{
				base.Command = value;
				AND_5.Command = this.Command;
				AND_7.Command = this.Command;
				AND_10.Command = this.Command;
				OR_12.Command = this.Command;
				AND_17.Command = this.Command;
				AND_15.Command = this.Command;
				OR_23.Command = this.Command;
				AND_22.Command = this.Command;
				OR_41.Command = this.Command;
				AND_38.Command = this.Command;
				OR_48.Command = this.Command;
				AND_45.Command = this.Command;
				AND_52.Command = this.Command;
				AND_59.Command = this.Command;
				AND_65.Command = this.Command;
				OR_20.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AND_5.IN1[0] = A1;
			AND_5.IN2[0] = B1;
			AND_5.Implement(cmd);
			
			AND_7.IN1[0] = A1;
			AND_7.IN2[0] = C1;
			AND_7.Implement(cmd);
			
			AND_10.IN1[0] = B1;
			AND_10.IN2[0] = C1;
			AND_10.Implement(cmd);
			
			OR_12.IN1[0] = AND_5.OUT;
			OR_12.IN2[0] = AND_7.OUT;
			OR_12.IN3[0] = AND_10.OUT;
			OR_12.Implement(cmd);
			
			AND_17.IN1[0] = !A2;
			AND_17.IN2[0] = !B2;
			AND_17.IN3[0] = !C2;
			AND_17.Implement(cmd);
			
			AND_15.IN1[0] = OR_12.OUT;
			AND_15.IN2[0] = AND_17.OUT;
			AND_15.Implement(cmd);
			
			OR_23.IN1[0] = B1;
			OR_23.IN2[0] = C1;
			OR_23.Implement(cmd);
			
			AND_22.IN1[0] = A2;
			AND_22.IN2[0] = !B2;
			AND_22.IN3[0] = !C2;
			AND_22.IN4[0] = OR_23.OUT;
			AND_22.Implement(cmd);
			
			OR_41.IN1[0] = A1;
			OR_41.IN2[0] = C1;
			OR_41.Implement(cmd);
			
			AND_38.IN1[0] = !A2;
			AND_38.IN2[0] = B2;
			AND_38.IN3[0] = !C2;
			AND_38.IN4[0] = OR_41.OUT;
			AND_38.Implement(cmd);
			
			OR_48.IN1[0] = A1;
			OR_48.IN2[0] = B1;
			OR_48.Implement(cmd);
			
			AND_45.IN1[0] = !A2;
			AND_45.IN2[0] = !B2;
			AND_45.IN3[0] = C2;
			AND_45.IN4[0] = OR_48.OUT;
			AND_45.Implement(cmd);
			
			AND_52.IN1[0] = !A2;
			AND_52.IN2[0] = B2;
			AND_52.IN3[0] = C2;
			AND_52.IN4[0] = A1;
			AND_52.Implement(cmd);
			
			AND_59.IN1[0] = A2;
			AND_59.IN2[0] = !B2;
			AND_59.IN3[0] = C2;
			AND_59.IN4[0] = B1;
			AND_59.Implement(cmd);
			
			AND_65.IN1[0] = A2;
			AND_65.IN2[0] = B2;
			AND_65.IN3[0] = !C2;
			AND_65.IN4[0] = C1;
			AND_65.Implement(cmd);
			
			OR_20.IN1[0] = AND_15.OUT;
			OR_20.IN2[0] = AND_22.OUT;
			OR_20.IN3[0] = AND_38.OUT;
			OR_20.IN4[0] = AND_45.OUT;
			OR_20.IN5[0] = AND_52.OUT;
			OR_20.IN6[0] = AND_59.OUT;
			OR_20.IN7[0] = AND_65.OUT;
			OR_20.Implement(cmd);
			
			DV[0] = OR_20.OUT;
		}
	}
}
