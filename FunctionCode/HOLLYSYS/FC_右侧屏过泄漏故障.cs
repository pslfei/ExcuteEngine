using DCSCommon;
using DCSType;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("右侧屏过泄漏故障")]
    [FCDisplay("2、A一次风机出口压力预测模型")]
    public partial class FC_右侧屏过泄漏故障 : Function
    {      

        [PinType(PinTypes.Input)]
        [PinDisplay("10MKA01CE03")]
        public LA IN1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("MSFLOW.UNIT1@W3")]
        public LA IN2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("ECOFWFLOW.UNIT1@W3")]
        public LA IN3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNC10AN010CE01")]
        public LA IN4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNC10AN020CE01")]
        public LA IN5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNA80CT201")]
        public LA IN6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNA80CT202")]
        public LA IN7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNA80CT203")]
        public LA IN8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("10HNA80CT204")]
        public LA IN9 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08260001R")]
        public LA IN10 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M10530001R")]
        public LA IN11 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M10460001R")]
        public LA IN12 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M10470001R")]
        public LA IN13 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520001B")]
        public LA IN14 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520002B")]
        public LA IN15 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.1f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520003B")]
        public LA IN16 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.2f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520004B")]
        public LA IN17 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.3f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520005B")]
        public LA IN18 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.4f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520006B")]
        public LA IN19 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.5f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520007B")]
        public LA IN20 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.6f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520008B")]
        public LA IN21 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.7f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520009B")]
        public LA IN22 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.8f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520010B")]
        public LA IN23 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.9f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520011B")]
        public LA IN24 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.10f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520012B")]
        public LA IN25 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.11f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520013B")]
        public LA IN26 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.12f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520014B")]
        public LA IN27 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.13f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520015B")]
        public LA IN28 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.14f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520016B")]
        public LA IN29 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.15f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520017B")]
        public LA IN30 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.16f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520018B")]
        public LA IN31 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.17f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520019B")]
        public LA IN32 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.18f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520020B")]
        public LA IN33 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.19f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520021B")]
        public LA IN34 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.20f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520022B")]
        public LA IN35 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.21f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520023B")]
        public LA IN36 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.22f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520024B")]
        public LA IN37 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.23f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520025B")]
        public LA IN38 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.24f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520026B")]
        public LA IN39 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.25f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520027B")]
        public LA IN40 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.26f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520028B")]
        public LA IN41 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.27f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520029B")]
        public LA IN42 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.28f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520030B")]
        public LA IN43 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.29f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520031B")]
        public LA IN44 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.30f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520032B")]
        public LA IN45 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.31f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520033B")]
        public LA IN46 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.32f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520034B")]
        public LA IN47 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.33f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520035B")]
        public LA IN48 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.34f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520036B")]
        public LA IN49 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.35f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520037B")]
        public LA IN50 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.36f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520038B")]
        public LA IN51 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.37f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520039B")]
        public LA IN52 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.38f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520040B")]
        public LA IN53 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.39f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520041B")]
        public LA IN54 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.40f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520042B")]
        public LA IN55 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.41f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520043B")]
        public LA IN56 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.42f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520044B")]
        public LA IN57 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.43f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520045B")]
        public LA IN58 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.44f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520046B")]
        public LA IN59 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.45f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520047B")]
        public LA IN60 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.46f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520048B")]
        public LA IN61 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.47f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520049B")]
        public LA IN62 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.48f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520050B")]
        public LA IN63 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.49f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520051B")]
        public LA IN64 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.50f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520052B")]
        public LA IN65 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.51f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520053B")]
        public LA IN66 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.52f);

        [PinType(PinTypes.Input)]
        [PinDisplay("LZ.M08520054B")]
        public LA IN67 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.53f);


        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("输出管脚1")]
        public LD OUT = new LD(QualityTypes.Good, false, false, false, 0, false);

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float DelayTime1 = 20;

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("规格数1")]
        private float DelayTime2 = 40;

        //内部变量
        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量1")]
        private int ValidSample;

        [PinType(PinTypes.Internal)]
        [PinDisplay("内部变量2")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 40)]
        private float[] SampleBuffer = new float[40];

        protected override void Run(ICommand cmd)
        {

            float CLOADDiff = 10;//判断负荷稳定
            float CSTEAMDIFF = 80;//判断给水odds1
            float CCURRDIFF = 0;//判断引风机电流odds2
            float CFLUGASTEMPANNBIAS = -10;//判断烟温odds3&&判断壁温odds4
            uint SampleCycle = cmd.Dpu.CycleCount / 60;//60秒采样一次


            if (ValidSample < DelayTime2)
            {
                SampleBuffer[ValidSample] = IN1;
                ValidSample++;
            }
            else 
            {

                float sumLOADout = 0;
                float sumLOADout2 = 0;

                for (int i = 1; i < ValidSample; i++)
                {
                    SampleBuffer[i - 1] = SampleBuffer[i];
                }
                SampleBuffer[ValidSample - 1] = IN1;


                //以下计算前20分钟负荷均值
                for (int i = 20; i < 40; i++)
                {
                    sumLOADout = sumLOADout + SampleBuffer[i];
                }
                float avgLOADout = sumLOADout / 20;

                //以下计算前40分钟至前20分钟负荷均值
                for (int i = 0; i < 20; i++)
                {
                    sumLOADout2 = sumLOADout2 + SampleBuffer[i];
                }
                float avgLOADout2 = sumLOADout2 / 20;

                //获取负荷均值差
                var LOADDiff = avgLOADout - avgLOADout2;
                if (LOADDiff < 0)
                {
                    LOADDiff = -LOADDiff;
                }

                //获取给水与蒸汽量差
                double MSFLOW = IN2;
                double ECOFWFLOW = IN3;
                double STEAMDIFF = MSFLOW - ECOFWFLOW;

                int LEAKODDS1 = 0;
                if (STEAMDIFF > CSTEAMDIFF) { LEAKODDS1 = 1; }

                //获取"蒸汽量"-"引风机电流和"上包络线电流拟合值（大于零认为疑似泄露）
                double SIMUSUMIDFCURR = IN2 * IN2 * 0.00009 - 0.1318 * IN2 + 413.78 + 0;
                double IDFACURR = IN4;//获取单精度浮点数值主蒸汽流量
                double IDFBCURR = IN5;//获取单精度浮点数值省煤器入口流量
                double SUMIDFCURR = IDFACURR + IDFBCURR;//获取单精度浮点数值省煤器入口流量
                double CURRDIFF = SUMIDFCURR - SIMUSUMIDFCURR;
                var LEAKODDS2 = 0;
                if (CURRDIFF > CCURRDIFF) { LEAKODDS2 = 1; }

                //获取右侧低过、低再入口烟温神经网络算法偏差值
                var FLUGASTEMPANNBIAS = IN6 - IN10;
                var FLUGASTEMPANNBIAS2 = IN7 - IN11;
                var FLUGASTEMPANNBIAS3 = IN8- IN12;
                var FLUGASTEMPANNBIAS4 = IN9 - IN13;
                var LEAKODDS3 = 0;
                if (FLUGASTEMPANNBIAS < CFLUGASTEMPANNBIAS && FLUGASTEMPANNBIAS2 < CFLUGASTEMPANNBIAS && FLUGASTEMPANNBIAS3 < CFLUGASTEMPANNBIAS && FLUGASTEMPANNBIAS4 < CFLUGASTEMPANNBIAS)
                { LEAKODDS3 = 1; }

                var LEAKODDS4 = 0;
                if (IN14 > 30 | IN5 > 30 | IN16 > 30 | IN17 > 30 | IN18 > 30 | IN19 > 30 | IN20 > 30 | IN21 > 30 | IN22 > 30 | 
                    IN23 > 30 | IN24 > 30 | IN25 > 30 | IN5 > 30 | IN14 > 30 | IN5 > 30 | IN14 > 30 | IN5 > 30)
                {

                }
            }
        }
    }
}
