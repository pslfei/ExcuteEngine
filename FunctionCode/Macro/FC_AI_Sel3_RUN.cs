using DCSCommon;

namespace FunctionCode
{
	public partial class AI_Sel3
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
			//            (*1 获取状态*)																							(*1 get module statues*)
			//    FM_01_STATE(stationAdd:=UINT_TO_BYTE(BD1));
			//    FM_02_STATE(stationAdd:=UINT_TO_BYTE(BD2));
			//    FM_03_STATE(stationAdd:=UINT_TO_BYTE(BD3));
			//    b1:=BYTE_TO_BOOL(FM_01_STATE.SLState.bActive);
			//    b2:=BYTE_TO_BOOL(FM_02_STATE.SLState.bActive);
			//    b3:=BYTE_TO_BOOL(FM_03_STATE.SLState.bActive);
			//    b4:=(AI1<LO OR AI1>UP);
			//    b5:=(AI2<LO OR AI2>UP);
			//    b6:=(AI3<LO OR AI3>UP);
			//    b7:=(AI1<AlarmLO OR AI1>AlarmUP);
			//    b8:=(AI2<AlarmLO OR AI2>AlarmUP);
			//    b9:=(AI3<AlarmLO OR AI3>AlarmUP);
			//    b10:=(MAX(MAX(ABS(AI1-AI2),ABS(AI1-AI3)),ABS(AI2-AI3))<error);
			//       b:=b1 AND b2 AND b3 AND NOT(b4) AND NOT(b5) AND NOT(b6) AND NOT(b7) AND NOT(b8) AND NOT(b9) AND b10;
			//       A12:=MIN(AI1,AI2);
			//       A13:=MIN(AI1,AI3);
			//       A23:=MIN(AI2,AI3);

			//(*2 报警上下限处理。如果缺省值为0，则取量程上下限*)												(*2 alarm upper lower line process .*)
			//    IF(AlarmUP=0) THEN
			//        AlarmUP:=UP;
			//    END_IF
			//    IF(AlarmLO=0) THEN
			//        AlarmLO:=LO;
			//    END_IF
			//(*3判断处理*)																							(*3 judged process*)
			//    IF(NOT(MAN))	 THEN		(*自动选择*)															(*auto select*)
			//        ER:=0;					(*正确*)																(*correct *)
			//        IF(b) THEN
			//            IF MD=0 THEN
			//                O:=(AI1+AI2+AI3)/3;
			//            ELSIF MD=1 THEN
			//                O:=MIN(MIN(AI1,AI2),AI3);
			//            ELSIF MD=2 THEN
			//                O:=MAX(MAX(AI1,AI2),AI3);
			//            ELSIF MD=3 THEN
			//                O:=MAX(A12,MAX(A13,A23));
			//            END_IF
			//        ELSIF (b1 AND NOT(b4) AND NOT(b7) AND b2 AND NOT(b5) AND NOT(b8) AND (NOT(b3) OR b6 OR b9)) THEN
			//            O:=(AI1+AI2)/2;
			//        ELSIF (b1 AND NOT(b4) AND NOT(b7) AND b3 AND NOT(b6) AND NOT(b9) AND (NOT(b2) OR b5 OR b8)) THEN
			//            O:=(AI1+AI3)/2;
			//        ELSIF (b2 AND NOT(b5) AND NOT(b8) AND b3 AND NOT(b6) AND NOT(b9) AND (NOT(b1) OR b4 OR b7)) THEN
			//            O:=(AI2+AI3)/2;
			//        ELSIF (b1 AND NOT(b4) AND NOT(b7) AND (NOT(b2) OR b5 OR b8 OR NOT(b3) OR b6 OR b9)) THEN
			//            O:=AI1;
			//        ELSIF (b2 AND NOT(b5) AND NOT(b8) AND (NOT(b1) OR b4 OR b7 OR NOT(b3) OR b6 OR b9)) THEN
			//            O:=AI2;
			//        ELSIF (b3 AND NOT(b6) AND NOT(b9) AND (NOT(b1) OR b4 OR b7 OR NOT(b2) OR b5 OR b8)) THEN
			//            O:=AI3;
			//        ELSE
			//            ER:=1;				(*故障*)																(*wrong*)
			//            O:=O_1;			(*保持*)																(*keep*)
			//        END_IF
			//    ELSE						(*手选*)																(*man select*)
			//        ER:=2;				(*手动选择*)																(*mannual select*)
			//        IF(SD1 AND SD2 AND SD3) THEN
			//            O:=MAX(MAX(A12,A13),A23);
			//            ELSIF(SD1 AND SD2 AND (NOT SD3)) THEN
			//            O:=(AI1+AI2)/2;
			//            ELSIF(SD1 AND SD3 AND (NOT SD2)) THEN
			//            O:=(AI1+AI3)/2;
			//                 ELSIF(SD2 AND SD3 AND (NOT SD1)) THEN
			//            O:=(AI2+AI3)/2;
			//            ELSIF(SD1 AND (NOT SD2) AND (NOT SD3)) THEN
			//            O:=AI1;
			//            ELSIF(SD2 AND (NOT SD1) AND (NOT SD3)) THEN
			//            O:=AI2;
			//                 ELSIF(SD3 AND (NOT SD1) AND (NOT SD2)) THEN
			//            O:=AI3;
			//             ELSE
			//            O:=O_1;			(*保持*)																(*keep*)
			//        END_IF
			//    END_IF
			//(*4循环赋值*)																							(*4 assigned value cyclely*)
			//    IF(ER<>1) THEN
			//        O_1:=O;
			//    END_IF

		}
	}
}
