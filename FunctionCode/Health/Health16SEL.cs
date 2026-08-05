using DCSCommon;
using DCSType;
using PerformanceCalc;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("Health16SEL")]
    [FCDisplay("健康度16")]
    public partial class Health16SEL : HealthFunction
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("是否可用")]
        public LD EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入2")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入3")]
        public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入4")]
        public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入5")]
        public LA IN5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入6")]
        public LA IN6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入7")]
        public LA IN7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入8")]
        public LA IN8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入9")]
        public LA IN9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入10")]
        public LA IN10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入11")]
        public LA IN11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入12")]
        public LA IN12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入13")]
        public LA IN13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入14")]
        public LA IN14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入15")]
        public LA IN15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("输入16")]
        public LA IN16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("健康度")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA AlarmIndex = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

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




        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tempOut16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);



        public Health16SEL()
        {
            FcName = "Health16SEL";
            FcType = enumType.Health;

            outList2 = new List<object>() { tempOut1, tempOut2, tempOut3, tempOut4, tempOut5, tempOut6, tempOut7, tempOut8, tempOut9, tempOut10, tempOut11, tempOut12, tempOut13, tempOut14, tempOut15, tempOut16 };
        }



        protected override void Run(ICommand cmd)
        {
            if (!EN) return;
            outList.Clear();

            LA[] inArr = new LA[16] { IN1, IN2, IN3, IN4, IN5, IN6, IN7, IN8, IN9, IN10, IN11, IN12, IN13, IN14, IN15, IN16 };


            float[] pv = new float[4] { Condition1.buffer, Condition2.buffer, Condition3.buffer, Condition4.buffer };
            bool bresult = AnalyticalExpression.HasDeviceStop(DeviceRunCondition, pv);
            if (!bresult)
            {
                for (int i = 0; i < inArr.Length; i++)
                {
                    if (inArr[i].Connected)
                    {
                        outList.Add(-1);
                    }
                }
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

            Dictionary<int, float> dict = new Dictionary<int, float>();

            for (int i = 0; i < inArr.Length; i++)
            {
                LA tmpIN = inArr[i];
                if (tmpIN.Connected)
                {
                    float fOut = 0;
                    if (NormalValue1 < AlarmValue1 && AlarmValue1 < TripValue1)//正向
                    {
                        if (tmpIN <= NormalValue1)
                        {
                            fOut = 100;
                        }
                        else if (tmpIN > NormalValue1 && tmpIN < TripValue1)
                        {
                            fOut = C1 * (tmpIN * tmpIN) + C2 * tmpIN + C3;
                        }
                        else if (tmpIN >= TripValue1)
                        {
                            fOut = 0;
                        }
                    }
                    else if (NormalValue1 > AlarmValue1 && AlarmValue1 > TripValue1)//反向
                    {
                        if (tmpIN >= NormalValue1)
                        {
                            fOut = 100;
                        }
                        else if (tmpIN > TripValue1 && tmpIN < AlarmValue1)
                        {
                            fOut = C1 * (tmpIN * tmpIN) + C2 * tmpIN + C3;
                        }
                        else if (tmpIN <= TripValue1)
                        {
                            fOut = 0;
                        }
                    }


                    if (fOut > 100)
                    {
                        fOut = 100;
                    }
                    ((LA)outList2[i])[0] = fOut;
                    outList.Add(fOut);
                    dict.Add(i, fOut);
                }
            }

            if (outList.Count <= 0)
            {
                return;
            }

            if (outList.Count > SelNum)
            {
                OUT[0] = outList.OrderBy(x => x).Skip(SelNum - 1).First();
            }
            else
            {
                OUT[0] = outList.Max();
            }

            foreach (var item in dict)
            {
                if (item.Value == OUT.buffer)
                {
                    AlarmIndex[0] = item.Key + 1;
                }
            }
        }
    }
}
