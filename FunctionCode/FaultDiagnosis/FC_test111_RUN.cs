using DCSCommon;
using PerformanceCalc;

namespace FunctionCode
{
	partial class test111
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
                SUB_1.Command = this.Command;
                ABS_2.Command = this.Command;
                MOVAVG_22.Command = this.Command;
                MOVAVG_23.Command = this.Command;
                LT_3.Command = this.Command;
                GT_7.Command = this.Command;
                GT_9.Command = this.Command;
                SIMUSUMIDFCURR_4.Command = this.Command;
                DISTATS_6.Command = this.Command;
                HSAISW_10.Command = this.Command;
                SUB_8.Command = this.Command;
                ADD4_12.Command = this.Command;
                SUB_11.Command = this.Command;
                GT_13.Command = this.Command;
                SUB_14.Command = this.Command;
                SUB_15.Command = this.Command;
                SUB_16.Command = this.Command;
                SUB_17.Command = this.Command;
                MAX_18.Command = this.Command;
                MAX_19.Command = this.Command;
                MAX_20.Command = this.Command;
                LT_21.Command = this.Command;
                GT_25.Command = this.Command;
            }
        }

        protected override void Run(ICommand cmd)
		{
            //PCalc.q2Test();

            MOVAVG_22.IN1[0] = IN1;
            MOVAVG_22.StartTime = 0;
            MOVAVG_22.EndTime = TIME1;
            MOVAVG_22.Implement(cmd);

            MOVAVG_23.IN1[0] = IN1;
            MOVAVG_23.StartTime = TIME1;
            MOVAVG_23.EndTime = TIME2;
            MOVAVG_23.Implement(cmd);

            SUB_1.IN1[0] = MOVAVG_22.AVG;
            SUB_1.IN2[0] = MOVAVG_23.AVG;
            SUB_1.Implement(cmd);

            ABS_2.IN[0] = SUB_1.OUT;
            ABS_2.Implement(cmd);

            LT_3.IN1[0] = ABS_2.OUT;
            LT_3.IN2[0] = L1;
            LT_3.Implement(cmd);

            HSAISW_10.SW[0] = LT_3.OUT;
            HSAISW_10.I1[0] = DISTATS_6.OUT;
            HSAISW_10.Implement(cmd);

            GT_7.IN1[0] = HSAISW_10.AV;
            GT_7.IN2[0] = H1;
            GT_7.Implement(cmd);

            SUB_11.IN1[0] = IN2;
            SUB_11.IN2[0] = IN3;
            SUB_11.Implement(cmd);

            GT_9.IN1[0] = SUB_11.OUT;
            GT_9.IN2[0] = H2;
            GT_9.Implement(cmd);

            DISTATS_6.IN1[0] = GT_9.OUT;
            DISTATS_6.IN2[0] = GT_13.OUT;
            DISTATS_6.IN3[0] = LT_21.OUT;
            DISTATS_6.IN4[0] = GT_25.OUT;
            DISTATS_6.Implement(cmd);

            ADD4_12.IN1[0] = IN4;
            ADD4_12.IN2[0] = IN5;
            ADD4_12.Implement(cmd);

            SIMUSUMIDFCURR_4.IN1[0] = IN2;
            SIMUSUMIDFCURR_4.Implement(cmd);

            SUB_8.IN1[0] = ADD4_12.OUT;
            SUB_8.IN2[0] = SIMUSUMIDFCURR_4.OUT;
            SUB_8.Implement(cmd);

            GT_13.IN1[0] = SUB_8.OUT;
            GT_13.Implement(cmd);

            SUB_14.IN1[0] = IN6;
            SUB_14.IN2[0] = IN7;
            SUB_14.Implement(cmd);

            SUB_15.IN1[0] = IN8;
            SUB_15.IN2[0] = IN9;
            SUB_15.Implement(cmd);

            MAX_18.IN1[0] = SUB_14.OUT;
            MAX_18.IN2[0] = SUB_15.OUT;
            MAX_18.Implement(cmd);

            SUB_16.IN1[0] = IN10;
            SUB_16.IN2[0] = IN11;
            SUB_16.Implement(cmd);

            SUB_17.IN1[0] = IN12;
            SUB_17.IN2[0] = IN13;
            SUB_17.Implement(cmd);

            MAX_19.IN1[0] = SUB_16.OUT;
            MAX_19.IN2[0] = SUB_17.OUT;
            MAX_19.Implement(cmd);

            MAX_20.IN1[0] = MAX_18.OUT;
            MAX_20.IN2[0] = MAX_19.OUT;
            MAX_20.Implement(cmd);

            LT_21.IN1[0] = MAX_20.OUT;
            LT_21.IN2[0] = L2;
            LT_21.Implement(cmd);

            MIN_5.IN1[0] = IN14;
            MIN_5.IN2[0] = IN15;
            MIN_5.Implement(cmd);

            GT_25.IN1[0] = MIN_5.OUT;
            GT_25.IN1[0] = H3;
            GT_25.Implement(cmd);


            OUT[0] = GT_7.OUT;
        }
    }
}
