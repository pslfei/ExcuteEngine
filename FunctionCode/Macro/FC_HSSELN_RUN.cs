using DCSCommon;
namespace FunctionCode
{
	public partial class HSSELN
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
				BOOL_TO_INT_8.Command = this.Command;
				BOOL_TO_INT_9.Command = this.Command;
				BOOL_TO_INT_10.Command = this.Command;
				BOOL_TO_INT_11.Command = this.Command;
				BOOL_TO_INT_13.Command = this.Command;
				BOOL_TO_INT_14.Command = this.Command;
				BOOL_TO_INT_20.Command = this.Command;
				BOOL_TO_INT_21.Command = this.Command;
				ADD_15.Command = this.Command;
				GE_16.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			BOOL_TO_INT_8.IN[0] = B1;
			BOOL_TO_INT_8.Implement(cmd);
			
			BOOL_TO_INT_9.IN[0] = B2;
			BOOL_TO_INT_9.Implement(cmd);
			
			BOOL_TO_INT_10.IN[0] = B3;
			BOOL_TO_INT_10.Implement(cmd);
			
			BOOL_TO_INT_11.IN[0] = B4;
			BOOL_TO_INT_11.Implement(cmd);
			
			BOOL_TO_INT_13.IN[0] = B5;
			BOOL_TO_INT_13.Implement(cmd);
			
			BOOL_TO_INT_14.IN[0] = B6;
			BOOL_TO_INT_14.Implement(cmd);
			
			BOOL_TO_INT_20.IN[0] = B7;
			BOOL_TO_INT_20.Implement(cmd);
			
			BOOL_TO_INT_21.IN[0] = B8;
			BOOL_TO_INT_21.Implement(cmd);
			
			ADD_15.IN1[0] = BOOL_TO_INT_8.OUT;
			ADD_15.IN2[0] = BOOL_TO_INT_9.OUT;
			ADD_15.IN3[0] = BOOL_TO_INT_10.OUT;
			ADD_15.IN4[0] = BOOL_TO_INT_11.OUT;
			ADD_15.IN5[0] = BOOL_TO_INT_13.OUT;
			ADD_15.IN6[0] = BOOL_TO_INT_14.OUT;
			ADD_15.IN7[0] = BOOL_TO_INT_20.OUT;
			ADD_15.IN8[0] = BOOL_TO_INT_21.OUT;
			ADD_15.Implement(cmd);
			
			GE_16.IN1[0] = ADD_15.OUT;
			GE_16.IN2[0] = NM;
			GE_16.Implement(cmd);
			
			DV[0] = GE_16.OUT;
		}
	}
}
