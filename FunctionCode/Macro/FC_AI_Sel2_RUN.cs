using DCSCommon;
using System;

namespace FunctionCode
{
	public partial class AI_Sel2
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
			bool b1 = (AI1.Quality == QualityTypes.Good);
			bool b2 = (AI2.Quality == QualityTypes.Good);
			bool b3 = (AI1 < LO || AI1 > UP);
			bool b4 = (AI2 < LO || AI2 > UP);
			bool b5 = (Math.Abs(AI1 - AI2) < error);
			bool b6 = (AI1 < AlarmLO || AI1 > AlarmUP);
			bool b7 = (AI2 < AlarmLO || AI2 > AlarmUP);

			if(AlarmUP == 0)
			{
				AlarmUP = UP;
			}

			if(AlarmLO == 0)
			{
				AlarmLO = 0;
			}

			if(!MAN)//自动选择
			{
				ER[0] = 0;
				if(b1 && b2 && (!b3) && (!b4) && b5 && (!b6) && (!b7))
				{
					if(MD == 0)
					{
						O[0] = (AI1 + AI2) / 2;
					}
					else if(MD == 1)
					{
						O[0] = Math.Min(AI1, AI2);
					}
					else if(MD == 2)
					{
						O[0] = Math.Max(AI1, AI2);
					}
				}
				else if(b1 && (!b3) && ((!b2) || b4 || b7))
				{
					O[0] = AI1;
				}
				else if(b2 && (!b4) && ((!b1) || b3 || b6))
				{
					O[0] = AI2;
				}
				else
				{
					ER[0] = 1;//故障
					O[0] = O_1;//保持
				}
			}
			else
			{
				ER[0] = 2;
				if(MAN12)
				{
					O[0] = AI2;
				}
				else
				{
					O[0] = AI1;
				}
			}

			if(ER != 1)
			{
				O_1 = 0;
			}
		}
	}
}
