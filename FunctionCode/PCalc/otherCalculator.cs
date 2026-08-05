using DCSCommon;
using DCSType;
using Newtonsoft.Json;
using PerformanceCalc;
using System.Runtime.InteropServices;


namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("otherCalculator")]
    [FCDisplay("计算凝汽器端差和汽轮机相对内效")]
    public partial class otherCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("机左高压主汽阀进汽压力")]
        public LA jzgyzqfjqyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("机右高压主汽阀进汽压力")]
        public LA jygyzqfjqyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("高压主汽阀进汽温度(左)")]
        public LA gyzqfjqwdz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("高压主汽阀进汽温度(右)")]
        public LA gyzqfjqwdy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排汽装置压力A1")]
        public LA pqzzyla1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排汽装置压力A2")]
        public LA pqzzyla2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排汽装置压力B1")]
        public LA pqzzylb1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排汽装置压力B2")]
        public LA pqzzylb2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);



        [PinType(PinTypes.Input)]
        [PinDisplay("高压凝汽器循环水出水支管1温度1")]
        public LA gynqqxhscszg1wd1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("高压凝汽器循环水出水支管1温度2")]
        public LA gynqqxhscszg1wd2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("高压凝汽器循环水出水支管2温度1")]
        public LA gynqqxhscszg2wd1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("高压凝汽器循环水出水支管2温度2")]
        public LA gynqqxhscszg2wd2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("凝汽器端差")]
        public LA nqqdc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("汽轮机相对内效")]
        public LA qjxdnxl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public otherCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            // 计算凝汽器端差
            double tc = (gynqqxhscszg1wd1 + gynqqxhscszg1wd2 + gynqqxhscszg2wd1 + gynqqxhscszg2wd2) / 4; // 高压凝汽器循环水出水支管1温度1 4个测点的均值
            double pc = (pqzzyla1 + pqzzyla2 + pqzzylb1 + pqzzylb2) / 4; // 排汽装置压力A1 4个测点的均值
            string inputs = JsonConvert.SerializeObject(new Dictionary<string, double>()
            {
                ["p"] = pc / 1000,  // 需要除1000将Kpa转成Mpa
                ["x"] = 0.0
            });

            double t = PCalc.calcComputeTPX(inputs);
            nqqdc[0] = t - tc;  // 此值即为凝汽器端差

            // 计算汽轮机相对内效率
            double pin = (jzgyzqfjqyl + jygyzqfjqyl) / 2;  // 主汽阀进汽压力 2个值的均值
            double tin = (gyzqfjqwdz + gyzqfjqwdy) / 2;  // 主汽阀进汽温度 2个值的均值
            inputs = JsonConvert.SerializeObject(new Dictionary<string, double>()
            {
                ["pin"] = pin,
                ["tin"] = tin,
                ["pc"] = pc,
                ["tc"] = tc
            });

            double e = PCalc.calcComputeTE(inputs);
            qjxdnxl[0] = e;

        }
    }
}
