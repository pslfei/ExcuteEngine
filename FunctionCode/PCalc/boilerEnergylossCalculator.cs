using DCSCommon;
using DCSType;
using Newtonsoft.Json;
using PerformanceCalc;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("boilerEnergylossCalculator")]
    [FCDisplay("锅炉耗差计算")]
    public partial class boilerEnergylossCalculator : Function
    {

        [PinType(PinTypes.Input)]
        [PinDisplay("汽机热耗")]
        public LA qsr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("氧量 ")]
        public LA ov = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排烟温度 ")]
        public LA tpy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风温度 ")]
        public LA tsf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("锅炉实际蒸发量 ")]
        public LA D = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("锅炉的额定蒸发量")]
        public LA Ded = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("燃料收到基水分含量 ")]
        public LA Mar = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("收到基氢含量 ")]
        public LA Har = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空气干燥基水分")]
        public LA Mad = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空气干燥基灰分 ")]
        public LA Aad = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空气干燥基挥发分")]
        public LA Vad = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("煤种的收到基发热量 ")]
        public LA Qnetar = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("炉渣含碳量 ")]
        public LA Clzc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("飞灰含碳量 ")]
        public LA Cfhc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("供电煤耗")]
        public LA bcpn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机电耗率")]
        public LA mmj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机电耗率")]
        public LA ycfj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机电耗率")]
        public LA sfj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("yfj电耗率")]
        public LA yfj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵电耗率")]
        public LA xhsb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵电耗率")]
        public LA njsb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("厂用电率")]
        public LA pcr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA ebdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率耗差")]
        public LA ebe = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA q2dst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("q2e耗差")]
        public LA q2e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA q4dst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("q4e耗差")]
        public LA q4e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA q5dst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("q5e耗差")]
        public LA q5e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA q6dst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("q6e耗差")]
        public LA q6e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA ovdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("氧量耗差")]
        public LA ove = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tpydst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("排烟温度耗差")]
        public LA tpye = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA cfhcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA cfhce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA clzcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA clzce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA qnetardst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA qnetare = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA adadst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA adae = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA mmjdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA mmje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA ycfjdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA ycfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA yfjdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA yfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA sfjdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA sfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA njsbdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA njsbe = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA xhsbdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA xhsbe = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA pcrdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA pcre = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA mardst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA mare = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public boilerEnergylossCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            tpy.buffer = (float)ExcuteEngine.tpy;
            Dictionary<string, double> inputs = new Dictionary<string, double>()
            {
                {"ov",  ov.buffer},
                {"tpy", tpy.buffer},
                {"tsf", tsf.buffer},
                {"D", D.buffer },
                {"Ded", Ded.buffer},
                {"Mar", Mar.buffer},
                {"Har", Har.buffer},
                {"Mad", Mad.buffer},
                {"Aad", Aad.buffer},
                {"Qnetar", Qnetar.buffer},
                {"Clzc", Clzc.buffer},
                {"Cfhc", Cfhc.buffer},
                {"Vad", Vad.buffer}

            };


            string jstr = $"{{\"ov\":{ov},\"tpy\":{tpy},\"tsf\":{tsf},\"D\":{D},\"Ded\":{Ded},\"Mar\":{Mar},\"Har\":{Har},\"Mad\":{Mad},\"Aad\":{Aad},\"Vad\":{Vad},\"Qnetar\":{Qnetar},\"Clzc\":{Clzc},\"Cfhc\":{Cfhc},\"X\":[1000, 750, 500, 400], \"y\": [0.38,0.37,0.36,0.35], \"pw\": {pw}}}";

            string json = JsonConvert.SerializeObject(inputs);

            int calcStatus = 0;
            BoilerData boilerData = PCalc.calcBoilerValue(jstr, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;

            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                ebe[0] = 0;
                q2e[0] = 0;
                q4e[0] = 0;
                q5e[0] = 0;
                q6e[0] = 0;
                ove[0] = 0;
                tpye[0] = 0;
                cfhce[0] = 0;
                clzce[0] = 0;
                qnetare[0] = 0;
                adae[0] = 0;
                mmje[0] = 0;
                ycfje[0] = 0;
                yfje[0] = 0;
                sfje[0] = 0;
                xhsbe[0] = 0;
                njsbe[0] = 0;
                pcre[0] = 0;
            }


            if (boilerData != null)
            {
                double eb1 = boilerData.e;//锅炉效率的实际值
                double q2 = boilerData.q2;
                double q4 = boilerData.q4;
                double q5 = boilerData.q5;
                double q6 = boilerData.q6;


                //锅炉效率
                //ebdst[0] = PCalc.compute_dst(pw, new List<double>() { (100 - 4.98) / 100, (100 - 5.12) / 100, (100 - 5.41) / 100, (100 - 5.86) / 100 });  // 目标值
                //double d1 = PCalc.calcComputeeb(JsonConvert.SerializeObject(new Dictionary<string, object>() { { "eb1", eb1 }, { "ebdst", ebdst.buffer }}), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //ebe[0] = d1 * bcpn;

                ebdst[0] = PCalc.compute_dst(pw, new List<double>() { (100 - 4.98) / 100, (100 - 5.12) / 100, (100 - 5.41) / 100, (100 - 5.86) / 100 });  // 目标值
                json = JsonConvert.SerializeObject(new Dictionary<string, double>() { { "eb1", eb1 }, { "ebdst", ebdst.buffer }, { "qsr", qsr } });
                IntPtr ptr = PCalc.compuetBoilerE(json);
                ebe[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                PCalc.freeMallocMemory(ref ptr);

                //q2的耗差值-排烟损失%
                //q2dst[0] = PCalc.compute_dst(pw, new List<double>() { 4.03 / 100, 4.13 / 100, 4.34 / 100, 4.73 / 100 });  // 目标值
                //double d2 = PCalc.calcComputeq2(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q21", q2 }, { "q2dst", q2dst.buffer }, { "eb", eb1 } }), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //q2e[0] = d2 * bcpn;

                q2dst[0] = PCalc.compute_dst(pw, new List<double>() { 4.03 / 100, 4.13 / 100, 4.34 / 100, 4.73 / 100 });  // 目标值
                json = JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q21", q2 }, { "q2dst", q2dst.buffer }, { "eb", eb1 }, { "qsr", qsr } });
                ptr = PCalc.computeBoilerQ2(json);
                q2e[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);


                ////q4的耗差值-机械未完全燃烧损失
                //q4dst[0] = PCalc.compute_dst(pw, new List<double>() { 0.3 / 100, 0.3 / 100, 0.3 / 100, 0.3 / 100 });  // 目标值
                //double d3 = PCalc.calcComputeq4(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q41", q4 }, { "q4dst", q4dst.buffer }, { "eb", eb1 } }), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //q4e[0] = d3 * bcpn;

                q4dst[0] = PCalc.compute_dst(pw, new List<double>() { 0.3 / 100, 0.3 / 100, 0.3 / 100, 0.3 / 100 });  // 目标值
                json = JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q21", q4 }, { "q2dst", q4dst.buffer }, { "eb", eb1 }, { "qsr", qsr } });
                ptr = PCalc.computeBoilerQ2(json);
                q4e[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);


                ////q5的耗差值-散热损失%
                //q5dst[0] = PCalc.compute_dst(pw, new List<double>() { 0.17 / 100, 0.22 / 100, 0.31 / 100, 0.39 / 100 });  // 目标值
                //double d4 = PCalc.calcComputeq5(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q51", q5 }, { "q5dst", q5dst.buffer }, { "eb", eb1 } }), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //q5e[0] = d4 * bcpn;

                q5dst[0] = PCalc.compute_dst(pw, new List<double>() { 0.17 / 100, 0.22 / 100, 0.31 / 100, 0.39 / 100 });  // 目标值
                json = JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q21", q5 }, { "q2dst", q5dst.buffer }, { "eb", eb1 }, { "qsr", qsr } });
                ptr = PCalc.computeBoilerQ2(json);
                q5e[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);


                //q6的耗差值
                q6dst[0] = PCalc.compute_dst(pw, new List<double>() { 0.48 / 100, 0.47 / 100, 0.46 / 100, 0.45 / 100 });  // 目标值
                ptr = PCalc.computeBoilerQ2(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "q21", q6 }, { "q2dst", q6dst.buffer }, { "eb", eb1 }, { "qsr", qsr } }));


                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                q6e[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);

                //氧量的耗差值
                //var ovInputs = inputs;
                //ovInputs["ov1"] = ovInputs["ov"];
                //ovdst[0] = PCalc.compute_dst(pw, new List<double>() { 3.5, 4.97, 6.52, 8.34 });  // 目标值
                //ovInputs["ovdst"] = ovdst.buffer;
                //ovInputs["eb"] = eb1;
                //double d6 = PCalc.calcComputeov(JsonConvert.SerializeObject(ovInputs), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //ove[0] = d6 * bcpn;

                var ovInputs = inputs;
                ovInputs["ov1"] = ovInputs["ov"];
                ovdst[0] = PCalc.compute_dst(pw, new List<double>() { 3.5, 4.97, 6.52, 8.34 });  // 目标值
                ovInputs["ovdst"] = ovdst.buffer;
                ovInputs["eb"] = eb1;
                ovInputs["qsr"] = qsr;

                ptr = PCalc.computeBoilerOv(JsonConvert.SerializeObject(ovInputs));
                ove[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                PCalc.freeMallocMemory(ref ptr);



                //排烟温度的耗差值
                //var tpyInputs = inputs;
                //tpyInputs["t1"] = inputs["tpy"];
                //tpydst[0] = PCalc.compute_dst(pw, new List<double>() { 117, 114, 112, 110 });  // 目标值
                //tpyInputs["tdst"] = tpydst.buffer;
                //tpyInputs["eb"] = eb1;
                //tpyInputs["qsr"] = qsr;
                //double d7 = PCalc.calcComputetpy(JsonConvert.SerializeObject(tpyInputs), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //tpye[0] = d7 * bcpn;

                var tpyInputs = inputs;
                tpyInputs["t1"] = inputs["tpy"];
                tpydst[0] = PCalc.compute_dst(pw, new List<double>() { 117, 114, 112, 110 });  // 目标值
                tpyInputs["tdst"] = tpydst.buffer;
                //tpyInputs["eb"] = eb1;
                //tpyInputs["qsr"] = qsr;

                ptr = PCalc.computeBoilerTpy(JsonConvert.SerializeObject(tpyInputs));
                double d7 = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                tpye[0] = d7;





                // 飞灰含碳量
                //var fhInputs = inputs;
                //fhInputs["cfhc1"] = fhInputs["Cfhc"];
                //cfhcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1.2, 1.2, 1.2, 1.2, 1.2 });  // 目标值
                //fhInputs["cfhdst"] = cfhcdst.buffer;
                //fhInputs["eb"] = eb1;
                //double d0 = PCalc.calcComputecfhc(JsonConvert.SerializeObject(fhInputs), out calcStatus);
                //cfhce[0] = d0 * bcpn;

                var fhInputs = inputs;
                fhInputs["cfhc1"] = fhInputs["Cfhc"];
                cfhcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1.2, 1.2, 1.2, 1.2, 1.2 });  // 目标值
                fhInputs["cfhdst"] = cfhcdst.buffer;
                //fhInputs["eb"] = eb1;
                //fhInputs["qsr"] = qsr;


                ptr = PCalc.computeBoilerCfhc(JsonConvert.SerializeObject(fhInputs));
                cfhce[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);



                // 炉渣含碳量
                //var lzInputs = inputs;
                //lzInputs["clzc1"] = lzInputs["Clzc"];
                //clzcdst[0] = PCalc.compute_dst(pw, new List<double>() { 4.0, 4.0, 4.0, 4.0, 4.0 });  // 目标值
                //lzInputs["clzcdst"] = clzcdst.buffer;
                //lzInputs["eb"] = eb1;
                //double d8 = PCalc.calcComputeclzc(JsonConvert.SerializeObject(lzInputs), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //clzce[0] = d8 * bcpn;

                var lzInputs = inputs;
                lzInputs["clzc1"] = lzInputs["Clzc"];
                clzcdst[0] = PCalc.compute_dst(pw, new List<double>() { 4.0, 4.0, 4.0, 4.0, 4.0 });  // 目标值
                lzInputs["clzcdst"] = clzcdst.buffer;
                //lzInputs["eb"] = eb1;
                //lzInputs["qsr"] = qsr;

                ptr = PCalc.computeBoilerClzc(JsonConvert.SerializeObject(lzInputs));
                clzce[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);

                // 燃料低位发热量
                qnetardst[0] = PCalc.compute_dst(pw, new List<double>() { 5755.25, 5755.25, 5755.25, 5755.25 });  // 目标值
                var qInputs = inputs;
                qInputs["Q1"] = qInputs["Qnetar"];               
                qInputs["Qdst"] = qnetardst.buffer;
                //qInputs["eb"] = eb1;
                //qInputs["qsr"] = qsr;

                ptr = PCalc.computeBoilerQnet(JsonConvert.SerializeObject(qInputs));
                qnetare[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                PCalc.freeMallocMemory(ref ptr);


                // 燃料灰分Aad
                var adInputs = inputs;
                adInputs["Aad1"] = adInputs["Aad"];
                adadst[0] = PCalc.compute_dst(pw, new List<double>() { 10.97, 10.97, 10.97, 10.97 });  // 目标值
                adInputs["Aaddst"] = adadst.buffer;
                //adInputs["eb"] = eb1;
                //adInputs["qsr"] = qsr;
                double d10 = PCalc.calcComputeAda(JsonConvert.SerializeObject(adInputs), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                adae[0] = d10;


                // 全水分耗差Mar
                var marInputs = inputs;
                marInputs["Mar1"] = marInputs["Mar"];
                mardst[0] = PCalc.compute_dst(pw, new List<double>() { 1.32, 1.32, 1.32, 1.32, 1.32 });  // 目标值
                marInputs["Mardst"] = mardst;
                //marInputs["eb"] = eb1;
                //adInputs["qsr"] = qsr;
                double d11 = PCalc.calcComputeMar(JsonConvert.SerializeObject(marInputs), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }

                mare[0] = d11;

                // 磨煤机耗电率
                mmjdst[0] = PCalc.compute_dst(pw, new List<double>() { 0.4 / 100, 0.4 / 100, 0.4 / 100, 0.4 / 100, 0.4 / 100 });  // 目标值
                double d12 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", mmj }, { "pdst", mmjdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                mmje[0] = d12;

                //一次风机耗电率
                ycfjdst[0] = PCalc.compute_dst(pw, new List<double>() { 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100 });  // 目标值
                double d13 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", ycfj }, { "pdst", ycfjdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                ycfje[0] = d13;

                //引风机耗电率
                yfjdst[0] = PCalc.compute_dst(pw, new List<double>() { 1.0 / 100, 1.0 / 100, 1.0 / 100, 1.0 / 100, 1.0 / 100 });  // 目标值
                double d14 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", yfj }, { "pdst", yfjdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                yfje[0] = d14;

                //送风机耗电率
                sfjdst[0] = PCalc.compute_dst(pw, new List<double>() { 0.2 / 100, 0.2 / 100, 0.2 / 100, 0.2 / 100, 0.2 / 100 });  // 目标值
                double d15 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", sfj }, { "pdst", sfjdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                sfje[0] = d15;

                //循环水泵电耗率
                xhsbdst[0] = PCalc.compute_dst(pw, new List<double>() { 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100 });  // 目标值
                double d16 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", xhsb }, { "pdst", xhsbdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                xhsbe[0] = d16;


                //凝结水泵电耗率
                njsbdst[0] = PCalc.compute_dst(pw, new List<double>() { 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100, 0.6 / 100 });  // 目标值
                double d17 = PCalc.calcComputepcre(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "p1", njsb }, { "pdst", njsbdst.buffer }, { "pcr", pcr }, { "qsr", qsr } }), out calcStatus);
                CalcStatus = (enumCalcType)calcStatus;
                if (CalcStatus == enumCalcType.Error)
                {
                    return;
                }
                njsbe[0] = d17;


                // 厂用电率
                pcrdst[0] = PCalc.compute_dst(pw, new List<double>() { 4.3 / 100, 4.3 / 100, 4.3 / 100, 4.3 / 100, 4.3 / 100 });  // 目标值
                //double d18 = PCalc.calcComputepcr(JsonConvert.SerializeObject(new Dictionary<string, double>() { { "pcr1", pcr }, { "pcrdst", pcrdst.buffer }, { "qsr", qsr } }), out calcStatus);
                //CalcStatus = (enumCalcType)calcStatus;
                //if (CalcStatus == enumCalcType.Error)
                //{
                //    return;
                //}
                //pcre[0] = d18;
                pcre[0] = PCalc.CompuetPcrE(eb1, qsr, pcr, pcrdst);


                //double eb = (double)steadyStateIC.Glxl / 100;
                ////实际工况的汽机热耗
                //double qsr = (double)steadyStateIC.Qjrh;
                ////目标工况的汽机热耗
                //double qsrdst = (double)standardIC.Qjrh;
                ////目标工况的锅炉效率
                //double ebdst = (double)standardIC.Glxl / 100;

                //double qjrhhc = PCalc.ComputeQsr(eb, qsr, qsrdst).To2d();
            }
        }
    }
}
