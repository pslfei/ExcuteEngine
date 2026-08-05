using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ADO")]
    [FCDisplay("模拟量延时输出")]
    public partial class ADO : Function
    {
        //输入
        [PinType(PinTypes.Input)]
        [PinDisplay("输入管脚1")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA OUT = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Constant)]
        [PinDisplay("延时时间")]
        public int DT = 30;

        Queue<float> SampleQueue = new Queue<float>();

        protected override void Run(ICommand cmd)
        {
            int dcCount = DT * 1000 / ExcuteEngine.cycle;
            if (SampleQueue.Count < dcCount)
            {
                SampleQueue.Enqueue(IN1);
            }
            else
            {
                OUT[0] = SampleQueue.Dequeue();
                SampleQueue.Enqueue(IN1);
            }
        }
    }
}
