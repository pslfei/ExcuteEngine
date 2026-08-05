using DCSCommon;
using DCSType;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PlantCalculator")]
    [FCDisplay("厂级指标计算")]
    public partial class PlantCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("锅炉效率")]
        public LA eb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("汽轮机组效率")]
        public LA et = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("燃料量t/h")]
        public LA B = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("燃料低位发热量")]
        public LA Qnetar = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("上网电量")]
        public LA pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器进口烟气氧量A侧")]
        public LA oin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器出口烟气氧量A侧")]
        public LA oout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器进口烟气氧量B侧")]
        public LA oinB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器出口烟气氧量B侧")]
        public LA ooutB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("空预器漏风率A")]
        public LA airp = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("空预器漏风率B")]
        public LA airpb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("正平衡发电煤耗")]
        public LA bcp = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("反平衡供电煤耗")]
        public LA bcpn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("反平衡发电煤耗")]
        public LA bcpr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("机组效率")]
        public LA ep = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("厂用电率")]
        public LA pcr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public PlantCalculator()
        {
            FcType = enumType.SC;
        }


        protected override void Run(ICommand cmd)
        {
            string jstr = $"{{\"eb\":{eb},\"et\":{et},\"B\":{B},\"Qnetar\":{Qnetar},\"pw\":{pw},\"pwout\":{pwout},\"oin\":{oin},\"oout\":{oout},\"oinB\":{oinB},\"ooutB\":{ooutB}}}";

            int calcStatus = 0;
            PerformanceCalc.PlantData plantData = PerformanceCalc.PCalc.calcPlantValue(jstr, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;


            if (plantData != null)
            {
                
                airp[0] = plantData.airp;
                if (plantData.airp < 0)
                    airp[0] = 0;
                airpb[0] = plantData.airpb;
                if (plantData.airpb < 0)
                    airpb[0] = 0;
                bcp[0] = plantData.bcp;
                bcpn[0] = plantData.bcpn;
                bcpr[0] = plantData.bcpr;
                ep[0] = plantData.ep;
                pcr[0] = plantData.pcr;
            }
            else
            {
                airp[0] = 0;
                airpb[0] = 0;
                bcp[0] = 0;
                bcpn[0] = 0;
                bcpr[0] = 0;
                ep[0] = 0;
                pcr[0] = 0;
            }

            pcr[0] = ExcuteEngine.pcr;

        }
    }
}
