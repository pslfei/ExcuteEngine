using DCSCommon;
namespace FunctionCode
{
	public partial class SCTIME_42
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
				AAAA.Command = this.Command;
				DT_TO_DWORD_9.Command = this.Command;
				DIV_10.Command = this.Command;
				MUL_11.Command = this.Command;
				SUB_12.Command = this.Command;
				ADD_13.Command = this.Command;
				DT_TO_DWORD_1.Command = this.Command;
				DIV_2.Command = this.Command;
				MUL_3.Command = this.Command;
				SUB_4.Command = this.Command;
				ADD_5.Command = this.Command;
			}
		}

		protected override void Run(ICommand cmd) 
		{
			AAAA.EN[0] = EN;
			AAAA.Implement(cmd);
			
			Q[0] = AAAA.Q;
			DT_TO_DWORD_9.IN[0] = AAAA.PDT;
			DT_TO_DWORD_9.Implement(cmd);
			
			DIV_10.IN1[0] = DT_TO_DWORD_9.OUT;
			DIV_10.IN2[0] = 86400;
			DIV_10.Implement(cmd);
			
			MUL_11.IN1[0] = DIV_10.OUT;
			MUL_11.IN2[0] = 86400;
			MUL_11.Implement(cmd);
			
			SUB_12.IN1[0] = DT_TO_DWORD_9.OUT;
			SUB_12.IN2[0] = MUL_11.OUT;
			SUB_12.Implement(cmd);
			
			ADD_13.IN1[0] = SUB_12.OUT;
			ADD_13.IN2[0] = 57600;
			ADD_13.Implement(cmd);
			
			SC[0] = ADD_13.OUT;
			DT_TO_DWORD_1.IN[0] = AAAA.CDT;
			DT_TO_DWORD_1.Implement(cmd);
			
			DIV_2.IN1[0] = DT_TO_DWORD_1.OUT;
			DIV_2.IN2[0] = 86400;
			DIV_2.Implement(cmd);
			
			MUL_3.IN1[0] = DIV_2.OUT;
			MUL_3.IN2[0] = 86400;
			MUL_3.Implement(cmd);
			
			SUB_4.IN1[0] = DT_TO_DWORD_1.OUT;
			SUB_4.IN2[0] = MUL_3.OUT;
			SUB_4.Implement(cmd);
			
			ADD_5.IN1[0] = SUB_4.OUT;
			ADD_5.IN2[0] = 57600;
			ADD_5.Implement(cmd);
			
			RSC[0] = ADD_5.OUT;
		}
	}
}
