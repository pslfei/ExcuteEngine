using DBFirstMysql;
using DCSCommon;
using DCSType;
using PerformanceCalc;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("Health")]
    [FCDisplay("健康度")]
    public partial class Health : HealthFunction
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("是否可用输入")]
        public LD EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("测点值")]
        public LA IN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("健康度")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA Condition1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA Condition2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA Condition3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA Condition4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        List<string> list = new List<string>();

        public Health()
        {
            FcName = "Health";
            FcType = enumType.Health;
            outList2 = new List<object>() { OUT };

        }


        protected override void Run(ICommand cmd)
        {
            if (!EN) return;
            outList.Clear();

            float[] pv = new float[4] { Condition1.buffer, Condition2.buffer, Condition3.buffer, Condition4.buffer };
            bool bresult = AnalyticalExpression.HasDeviceStop(DeviceRunCondition, pv);
            if (!bresult)
            {
                outList.Add(-1);
                OUT[0] = -1;
                return;
            }

            float anVariance = AlarmValue1 * AlarmValue1 - NormalValue1 * NormalValue1;
            float tnDiff = TripValue1 - NormalValue1;
            float tnVariance = TripValue1 * TripValue1 - NormalValue1 * NormalValue1;
            float anDiff = AlarmValue1 - NormalValue1;

            float C1 = 0;
            float diff1 = anVariance * tnDiff - tnVariance * anDiff;
            if (diff1 != 0)
            {
                C1 = (100 * anDiff - 40 * tnDiff) / diff1;
            }

            float C2 = 0;
            float diff2 = tnVariance * anDiff - anVariance * tnDiff;
            if (diff2 != 0)
            {
                C2 = (100 * anVariance - 40 * tnVariance) / diff2;
            }
            float C3 = 0;

            if (diff1 != 0 && diff2 != 0)
            {
                C3 = (40 * tnDiff - 100 * anDiff) * TripValue1 * TripValue1 / diff1 + (40 * tnVariance - 100 * anVariance) * TripValue1 / diff2;
            }

            if (NormalValue1 < AlarmValue1 && AlarmValue1 < TripValue1)//正向
            {
                if (IN <= NormalValue1)
                {
                    OUT[0] = 100;
                }
                else if (IN > NormalValue1 && IN <= TripValue1)
                {
                    OUT[0] = C1 * (IN * IN) + C2 * IN + C3;
                }
                else if (IN > TripValue1)
                {
                    OUT[0] = 0;
                }
            }
            else if (NormalValue1 > AlarmValue1 && AlarmValue1 > TripValue1)//反向
            {
                if (IN >= NormalValue1)
                {
                    OUT[0] = 100;
                }
                else if (IN > TripValue1 && IN < NormalValue1)
                {
                    OUT[0] = C1 * (IN * IN) + C2 * IN + C3;
                }
                else if (IN <= TripValue1)
                {
                    OUT[0] = 0;
                }
            }
            if(Convert.ToDouble(OUT[0])>100)
            {
                OUT[0] = 100;
            }
            outList.Add(OUT.buffer);
        }
    }
}
