using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PlantPcrCalculator")]
    [FCDisplay("设备电耗指标计算")]
    public partial class PlantPcrCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机1电流")]
        public LA ycfj1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机1电压")]
        public LA ycfj1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机1系数")]
        public LA ycfj1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机2电流")]
        public LA ycfj2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机2电压")]
        public LA ycfj2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("一次风机2系数")]
        public LA ycfj2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机1电流")]
        public LA sfj1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机1电压")]
        public LA sfj1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机1系数")]
        public LA sfj1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机2电流")]
        public LA sfj2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机2电压")]
        public LA sfj2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机2系数")]
        public LA sfj2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机1电流")]
        public LA yfj1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机1电压")]
        public LA yfj1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机1系数")]
        public LA yfj1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机2电流")]
        public LA yfj2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机2电压")]
        public LA yfj2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("引风机2系数")]
        public LA yfj2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机1电流")]
        public LA mmj1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机1电压")]
        public LA mmj1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机1系数")]
        public LA mmj1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机2电流")]
        public LA mmj2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机2电压")]
        public LA mmj2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机2系数")]
        public LA mmj2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机3电流")]
        public LA mmj3_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机3电压")]
        public LA mmj3_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机3系数")]
        public LA mmj3_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机4电流")]
        public LA mmj4_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机4电压")]
        public LA mmj4_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机4系数")]
        public LA mmj4_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机5电流")]
        public LA mmj5_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机5电压")]
        public LA mmj5_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机5系数")]
        public LA mmj5_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机6电流")]
        public LA mmj6_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机6电压")]
        public LA mmj6_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("磨煤机6系数")]
        public LA mmj6_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵1电流")]
        public LA njsb1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵1电压")]
        public LA njsb1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵1系数")]
        public LA njsb1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵2电流")]
        public LA njsb2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵2电压")]
        public LA njsb2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝结水泵2系数")]
        public LA njsb2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵1电流")]
        public LA xhsb1_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵1电压")]
        public LA xhsb1_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵1系数")]
        public LA xhsb1_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵2电流")]
        public LA xhsb2_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵2电压")]
        public LA xhsb2_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵2系数")]
        public LA xhsb2_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵3电流")]
        public LA xhsb3_A = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵3电压")]
        public LA xhsb3_V = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("循环水泵3系数")]
        public LA xhsb3_alpha = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("一次风机电耗率")]
        public LA ycfjdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("送风机电耗率")]
        public LA sfjdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("引风机电耗率")]
        public LA yfjdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("磨煤机电耗率")]
        public LA mmjdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("凝结水泵电耗率")]
        public LA njsbdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("循环水泵电耗率")]
        public LA xhsbdhl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public PlantPcrCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            string jstr = $"{{\"pw\":{pw}," +
                $"\"ycfj\":[{{ \"A\": {ycfj1_A}, \"V\": {ycfj1_V}, \"alpha\": {ycfj1_alpha} }},{{ \"A\": {ycfj2_A}, \"V\": {ycfj2_V}, \"alpha\": {ycfj2_alpha} }}]," +
                $"\"sfj\":[{{ \"A\": {sfj1_A}, \"V\": {sfj1_V}, \"alpha\": {sfj1_alpha} }},{{ \"A\": {sfj2_A}, \"V\": {sfj2_V}, \"alpha\": {sfj2_alpha} }}]," +
                $"\"yfj\":[{{ \"A\": {yfj1_A}, \"V\": {yfj1_V}, \"alpha\": {yfj1_alpha} }},{{ \"A\": {yfj2_A}, \"V\": {yfj2_V}, \"alpha\": {yfj2_alpha} }}]," +
                $"\"mmj\":[{{ \"A\": {mmj1_A}, \"V\": {mmj1_V}, \"alpha\": {mmj1_alpha} }},{{ \"A\": {mmj2_A}, \"V\": {mmj2_V}, \"alpha\": {mmj2_alpha} }}," +
                $"{{ \"A\": {mmj3_A}, \"V\": {mmj3_V}, \"alpha\": {mmj3_alpha} }},{{ \"A\": {mmj4_A}, \"V\": {mmj4_V}, \"alpha\": {mmj4_alpha} }}," +
                $"{{ \"A\": {mmj5_A}, \"V\": {mmj5_V}, \"alpha\": {mmj5_alpha} }},{{ \"A\": {mmj6_A}, \"V\": {mmj6_V}, \"alpha\": {mmj6_alpha} }}]," +
                $"\"njsb\":[{{ \"A\": {njsb1_A}, \"V\": {njsb1_V}, \"alpha\": {njsb1_alpha} }},{{ \"A\": {njsb2_A}, \"V\": {njsb2_V}, \"alpha\": {njsb2_alpha} }}]," +
                $"\"xhsb\":[{{ \"A\": {xhsb1_A}, \"V\": {xhsb1_V}, \"alpha\": {xhsb1_alpha} }},{{ \"A\": {xhsb2_A}, \"V\": {xhsb2_V}, \"alpha\": {xhsb2_alpha} }}," +
                $"{{ \"A\": {xhsb3_A}, \"V\": {xhsb3_V}, \"alpha\": {xhsb3_alpha} }}]}}";

            int calcStatus = 0;
            PerformanceCalc.PlantPcrData plantPcrData = PerformanceCalc.PCalc.calcPlantPcrValue(jstr, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;

            if (plantPcrData != null)
            {
                ycfjdhl[0] = plantPcrData.ycfj != null ? plantPcrData.ycfj : ycfjdhl;
                sfjdhl[0] = plantPcrData.sfj != null ? plantPcrData.sfj : sfjdhl;
                yfjdhl[0] = plantPcrData.yfj != null ? plantPcrData.yfj : yfjdhl;
                mmjdhl[0] = plantPcrData.mmj != null ? plantPcrData.mmj : mmjdhl;
                njsbdhl[0] = plantPcrData.njsb != null ? plantPcrData.njsb : njsbdhl;
                xhsbdhl[0] = plantPcrData.xhsb != null ? plantPcrData.xhsb : xhsbdhl;
            }
            else
            {
                ycfjdhl[0] = 0;
                sfjdhl[0] = 0;
                yfjdhl[0] = 0;
                mmjdhl[0] = 0;
                njsbdhl[0] = 0;
                xhsbdhl[0] = 0;
            }
        }
    }
}
