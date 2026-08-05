using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("HSSLOPE")]
    [FCDisplay("计算变化率")]
    public partial class HSSLOPE : Function
    {

        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("计算开关")]
        public LD SW = new LD(QualityTypes.Good, false, false, false, 0, false);

        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LA AV = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("存取周期数")]
        public int AP = 10;

        //规格数
        [PinType(PinTypes.Internal)]
        [PinDisplay("计数器")]
        private int CT = 0;


        //[PinType(PinTypes.Internal)]
        //[PinDisplay("内部变量2")]
        //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 4)]
        //private float[] SampleBuffer = new float[4];


        List<float> SampleBuffer = new List<float>();

        protected override void Run(ICommand cmd)
        {

            if (SW)
            {
                if (CT >= AP)
                {
                    CT = 0;
                    //AV[0] = (20 * IN + 10 * SampleBuffer[0] - 10 * SampleBuffer[2] - 20 * SampleBuffer[3]) / (100 * AP * ExcuteEngine.cycle);
                    AV[0] = (20 * IN1 + 10 * SampleBuffer[0] - 10 * SampleBuffer[SampleBuffer.Count - 2] - 20 * SampleBuffer[SampleBuffer.Count - 1]) / (100 * AP * ExcuteEngine.cycle / 1000);
                    SampleBuffer.Clear();
                }
                else
                {
                    SampleBuffer.Add(IN1);
                    //SampleBuffer[CT] = IN;
                    CT++;
                }

            }
            else
            {
                AV[0] = 0;
                CT = 0;
                SampleBuffer.Clear();
            }
        }
    }
}