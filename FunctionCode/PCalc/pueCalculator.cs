using DCSCommon;
using DCSType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using TDServer.Service;


namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("PueCalculator")]
    [FCDisplay("设备耗电率")]
    public partial class PueCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("#1一次风机1A(后备)")]
        public LA ycfjA1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1一次风机1A(后备)")]
        public LA ycfjA2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1一次风机1B(后备)")]
        public LA ycfjB1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1一次风机1B(后备)")]
        public LA ycfjB2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1送风机1A(后备)")]
        public LA sfjA1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1送风机1A(主)")]
        public LA sfjA2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1送风机1B(后备)")]
        public LA sfjB1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1送风机1B(主)")]
        public LA sfjB2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1引风机1A(后备)")]
        public LA yfjA1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1引风机1A(主)")]
        public LA yfjA2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1引风机1B(后备)")]
        public LA yfjB1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1引风机1B(主)")]
        public LA yfjB2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1A")]
        public LA mmjA = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1B")]
        public LA mmjB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1C")]
        public LA mmjC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1D")]
        public LA mmjD = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1E")]
        public LA mmjE = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1磨煤机1F")]
        public LA mmjF = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("#1凝结水泵1A")]
        public LA njsbA = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#11凝结水泵1B")]
        public LA njsbB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1A(高速)")]
        public LA xhsbAH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1A(低速)")]
        public LA xhsbAL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1B(高速)")]
        public LA xhsbBH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1B(低速)")]
        public LA xhsbBL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1C(高速)")]
        public LA xhsbCH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1C(低速)")]
        public LA xhsbCL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1D(高速)")]
        public LA xhsbDH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1循环水泵1D(低速)")]
        public LA xhsbDL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1脱硫10kv1A")]
        public LA tlA = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1脱硫10kv1B")]
        public LA tlB = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("一次风机耗电量")]
        public LA ycfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("送风机耗电量")]
        public LA sfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("引风机耗电量")]
        public LA yfje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("磨煤机耗电量")]
        public LA mmje = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("循环水泵耗电量")]
        public LA xhsbe = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("脱硫耗电量")]
        public LA tle = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("凝结水泵耗电量")]
        public LA njsbe = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        public PueCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            if (ExcuteEngine.eletodaysum2 <= 0)
            {
                ycfje[0] = 0;
                sfje[0] = 0;
                yfje[0] = 0;
                mmje[0] = 0;
                njsbe[0] = 0;
                xhsbe[0] = 0;
                tle[0] = 0;
            }
            else
            {
                ycfje[0] = ((ycfjA1 + ycfjA2 + ycfjB1 + ycfjB2) * 10) / ExcuteEngine.eletodaysum2;
                sfje[0] = ((sfjA1 + sfjA2 + sfjB1 + sfjB2) * 10) / ExcuteEngine.eletodaysum2;
                yfje[0] = ((yfjA1 + yfjA2 + yfjB1 + yfjB2) * 10) / ExcuteEngine.eletodaysum2;
                mmje[0] = ((mmjA + mmjB + mmjC + mmjD + mmjE + mmjF) * 10) / ExcuteEngine.eletodaysum2;
                njsbe[0] = ((njsbA + njsbB) * 10) / ExcuteEngine.eletodaysum2;
                xhsbe[0] = ((xhsbAH + xhsbAL + xhsbBH + xhsbBL + xhsbCH + xhsbCL + xhsbDH + xhsbDL) * 10) / ExcuteEngine.eletodaysum2;
                tle[0] = ((tlA + tlB) * 10) / ExcuteEngine.eletodaysum2;
            }
        }
    }
}
