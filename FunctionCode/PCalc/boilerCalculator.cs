using DCSCommon;
using DCSType;
using PerformanceCalc;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("BoilerCalculator")]
    [FCDisplay("锅炉性能计算")]
    public partial class BoilerCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("负荷")]
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

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率")]
        public LA e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("排烟热损失")]
        public LA q2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("可燃气体未完全燃烧热损失")]
        public LA q3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("固体未完全燃烧热损失")]
        public LA q4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("散热损失")]
        public LA q5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("灰渣物理热损失")]
        public LA q6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率1")]
        public LA C = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率2")]
        public LA CpH2o = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率3")]
        public LA Cpgy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率4")]
        public LA Q2H2O = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率5")]
        public LA Q2gy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率6")]
        public LA Vgkco = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率7")]
        public LA Vgy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率8")]
        public LA Vgyco = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率9")]
        public LA Vh2o = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率10")]
        public LA afh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率11")]
        public LA alz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率12")]
        public LA apy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率13")]
        public LA cfh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率14")]
        public LA clz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率15")]
        public LA d = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率16")]
        public LA dk = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率17")]
        public LA k1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率18")]
        public LA k2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率19")]
        public LA pre = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率20")]
        public LA tlz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public BoilerCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            //tpy.buffer= (float)ExcuteEngine.tpy;

            //float tmptpy = (float)ExcuteEngine.tpy;


            //string jstr = $"{{\"ov\":{ov},\"tpy\":{tpy},\"tsf\":{tsf},\"D\":{D},\"Ded\":{Ded},\"Mar\":{Mar},\"Har\":{Har},\"Mad\":{Mad},\"Aad\":{Aad},\"Vad\":{Vad},\"Qnetar\":{Qnetar},\"Clzc\":{Clzc},\"Cfhc\":{Cfhc}}}";
            string jstr = $"{{\"ov\":{ov},\"tpy\":{tpy},\"tsf\":{tsf},\"D\":{D},\"Ded\":{Ded},\"Mar\":{Mar},\"Har\":{Har},\"Mad\":{Mad},\"Aad\":{Aad},\"Vad\":{Vad},\"Qnetar\":{Qnetar},\"Clzc\":{Clzc},\"Cfhc\":{Cfhc},\"X\":[1000, 750, 500, 400], \"y\": [0.38,0.37,0.36,0.35], \"pw\": {pw}}}";
            if (pw < 100)
            {
                e[0] = 0;
                q2[0] = 0;
                q3[0] = 0;
                q4[0] = 0;
                q5[0] = 0;
                q6[0] = 0;
                C[0] = 0;
                CpH2o[0] = 0;
                Cpgy[0] = 0;
                Q2H2O[0] = 0;
                Q2gy[0] = 0;
                Vgkco[0] = 0;
                Vgy[0] = 0;
                Vgyco[0] = 0;
                Vh2o[0] = 0;
                afh[0] = 0;
                alz[0] = 0;
                apy[0] = 0;
                cfh[0] = 0;
                clz[0] = 0;
                d[0] = 0;
                dk[0] = 0;
                k1[0] = 0;
                k2[0] = 0;
                pre[0] = 0;
                tlz[0] = 0;
            }
            else
            {
                PerformanceCalc.BoilerData boilerData = PerformanceCalc.PCalc.calcBoilerValue(jstr, out int calcStatus);
                if (boilerData != null)
                {
                    e[0] = boilerData.e;
                    q2[0] = boilerData.q2;
                    q3[0] = boilerData.q3;
                    q4[0] = boilerData.q4;
                    q5[0] = boilerData.q5;
                    q6[0] = boilerData.q6;
                    C[0] = boilerData.C;
                    CpH2o[0] = boilerData.CpH2o;
                    Cpgy[0] = boilerData.Cpgy;
                    Q2H2O[0] = boilerData.Q2H2O;
                    Q2gy[0] = boilerData.Q2gy;
                    Vgkco[0] = boilerData.Vgkco;
                    Vgy[0] = boilerData.Vgy;
                    Vgyco[0] = boilerData.Vgyco;
                    Vh2o[0] = boilerData.Vh2o;
                    afh[0] = boilerData.afh;
                    alz[0] = boilerData.alz;
                    apy[0] = boilerData.apy;
                    cfh[0] = boilerData.cfh;
                    clz[0] = boilerData.clz;
                    d[0] = boilerData.d;
                    dk[0] = boilerData.dk;
                    k1[0] = boilerData.k1;
                    k2[0] = boilerData.k2;
                    pre[0] = boilerData.pre;
                    tlz[0] = boilerData.tlz;
                }
                else
                {
                    e[0] = 0;
                    q2[0] = 0;
                    q3[0] = 0;
                    q4[0] = 0;
                    q5[0] = 0;
                    q6[0] = 0;
                    C[0] = 0;
                    CpH2o[0] = 0;
                    Cpgy[0] = 0;
                    Q2H2O[0] = 0;
                    Q2gy[0] = 0;
                    Vgkco[0] = 0;
                    Vgy[0] = 0;
                    Vgyco[0] = 0;
                    Vh2o[0] = 0;
                    afh[0] = 0;
                    alz[0] = 0;
                    apy[0] = 0;
                    cfh[0] = 0;
                    clz[0] = 0;
                    d[0] = 0;
                    dk[0] = 0;
                    k1[0] = 0;
                    k2[0] = 0;
                    pre[0] = 0;
                    tlz[0] = 0;
                }
            }
        }

    }
}
