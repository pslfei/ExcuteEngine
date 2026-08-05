//using System;
//using DCSCommon;
//using System.IO;
//namespace FunctionCode
//{
//    public partial class HSINTG
//    {
//        protected override void Run(ICommand cmd) 
//        {
//            UK = AV;
//            AV_1 = UK;
//            if (TS)
//            {
//                UK = TP;
//            }
//            else
//            {
//                EK = SP - PV;

//                if (Math.Abs(EK) <= Math.Abs(DI))
//                {
//                    UK = 0;
//                }
//                else
//                {
//                    if (AD)
//                    {
//                        EK = -EK;
//                    }
//                    if (TI !=0)
//                    {
//                        UK += TB * KI * EK / TI;
//                    }
//                }
//            }

//            if (UK !=0)
//            {
//                if (Math.Abs(UK - AV_1) > OTR)
//                {
//                    if (UK > AV_1)
//                    {
//                        UK = AV_1 + OTR;
//                    }
//                    else
//                    {
//                        UK = AV_1 - OTR;
//                    }

//                    if (UK > OT)
//                        UK = OT;

//                    if (UK < OB)
//                        UK = OB;

//                    AV[0] = UK;
//                }
//            }
//        }
//    }
//}
using System;
using DCSCommon;
using System.IO;
namespace FunctionCode
{
    public partial class HSINTG
    {
        protected override void Run(ICommand cmd)
        {
            UK = AV;
            AV_1 = UK;
            if (TS)
            {
                UK = TP;
            }
            else
            {
                EK = SP - PV;

                if (Math.Abs(EK) <= Math.Abs(DI))
                {
                    UK = 0;
                }
                else
                {
                    if (AD)
                    {
                        EK = -EK;
                    }
                    if (TI != 0)
                    {
                        UK += TB * KI * EK / TI;
                    }
                }
            }

            if (UK != 0)
            {
                if (Math.Abs(UK - AV_1) > OTR)
                {
                    if (UK > AV_1)
                    {
                        UK = AV_1 + OTR;
                    }
                    else
                    {
                        UK = AV_1 - OTR;
                    }
                }

                if (UK > OT)
                    UK = OT;

                if (UK < OB)
                    UK = OB;

                AV[0] = UK;
            }
        }
    }
}
