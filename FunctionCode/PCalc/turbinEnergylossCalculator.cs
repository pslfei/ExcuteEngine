using DCSCommon;
using DCSType;
using Newtonsoft.Json;
using PerformanceCalc;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("turbinEnergylossCalculator")]
    [FCDisplay("汽机耗差计算")]
    public partial class turbinEnergylossCalculator : Function
    {

        [PinType(PinTypes.Input)]
        [PinDisplay("锅炉效率")]
        public LA eb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("汽机热耗")]
        public LA qsr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("供电煤耗")]
        public LA bcpn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热减温水流量")]
        public LA zrjwsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("0号高加上端差")]
        public LA heater0_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("1号高加上端差")]
        public LA heater1_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("2号高加上端差")]
        public LA heater2_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("3号高加上端差")]
        public LA heater3_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("4号高加上端差")]
        public LA heater4_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("5号低加上端差")]
        public LA heater5_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("6号低加上端差")]
        public LA heater6_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("7号低加上端差")]
        public LA heater7_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("8号低加上端差")]
        public LA heater8_dc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA pz1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA tz1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA tg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA pg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA pzr1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA tzr1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("")]
        public LA pc1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水压力")]
        public LA pgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水温度")]
        public LA tgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA pzdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("主汽压力耗差")]
        public LA pze = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tzdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("主汽温度耗差")]
        public LA tze = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA pzrdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热压力耗差")]
        public LA pzre = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA tzrdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热温度耗差")]
        public LA tzre = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA pcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("排汽压力耗差")]
        public LA pce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热减温水流量目标值")]
        public LA zrjwslldst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热减温水流量耗差")]
        public LA zrjwslle = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("0号高加上端差目标值")]
        public LA heater0dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("0号高加上端差耗差")]
        public LA heater0dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("1号高加上端差目标值")]
        public LA heater1dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("1号高加上端差耗差")]
        public LA heater1dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("2号高加上端差目标值")]
        public LA heater2dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("2号高加上端差耗差")]
        public LA heater2dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("3号高加上端差目标值")]
        public LA heater3dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("3号高加上端差耗差")]
        public LA heater3dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("5号高加上端差目标值")]
        public LA heater5dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("5号高加上端差耗差")]
        public LA heater5dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("6号高加上端差目标值")]
        public LA heater6dcdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("6号高加上端差耗差")]
        public LA heater6dce = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("汽机热耗目标值")]
        public LA qsrdst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("汽机热耗耗差")]
        public LA qsre = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        public turbinEnergylossCalculator()
        {
            FcType = enumType.SC;
        }

        protected override void Run(ICommand cmd)
        {
            return;
            LAExWarn lAExWarn = ExcuteEngine.GetPointValue("dcs_MSP_SP_TR") as LAExWarn;
            int calcStatus = 0;
            //pzdst[0] = PCalc.compute_dst(pw, new List<double>() { 28, 21.32, 14.19, 11.49, 8.71 });
            pzdst[0] = lAExWarn.buffer;
            tzdst[0] = PCalc.compute_dst(pw, new List<double>() { 600, 600, 600, 600, 600 });
            pzrdst[0] = PCalc.compute_dst(pw, new List<double>() { 5.685, 4.175, 2.818, 2.289, 1.732 });
            
            pcdst[0] = PCalc.compute_dst(pw, new List<double>() { 9.0 / 1000, 9.0 / 1000, 9.0 / 1000, 9.0 / 1000, 9.0 / 1000 });
            //if (pw >= 500)
            //{
            //    tzrdst[0] = 620;
            //}
            //else
            //{
            //    tzrdst[0] = PCalc.compute_dst(pw, new List<double>() { 500, 400, 300 }, new List<double>() { 620, 605, 590 });
            //}
            tzrdst[0] = 620;

            string inputs_ela = JsonConvert.SerializeObject(new TurbinElaInputs<double>()
            {
                pz1 = pz1,
                pz = pz1,
                pzdst = pzdst.buffer,
                tz1 = tz1,
                tz = tz1,
                tzdst = tzdst.buffer,
                tg = tg,
                pg = pg,
                pzr1 = pzr1,
                pzr = pzr1,
                pzrdst = pzrdst.buffer,
                tzr1 = tzr1,
                tzr = tzr1,
                tzrdst = tzrdst.buffer,
                pc1 = pc1 / 1000,  // 排汽压力需/1000
                pc = pc1 / 1000,
                pcdst = pcdst.buffer,
                pw = pw,
                pgs = pgs,
                tgs = tgs,
                eb = eb
            });


            // 主汽压力	pze
            double pzn = PCalc.calcComputepz(inputs_ela, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;
            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                pze[0] = 0;
            }
            else
            {
                pze[0] = pzn;
            }

            // 主汽温度	tze
            double tzn = PCalc.calcComputetz(inputs_ela, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;
            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                tze[0] = 0;
            }
            else
            {
                tze[0] = tzn;
            }


            // 再热压力	pzre
            double pzrn = PCalc.calcComputepzr(inputs_ela, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;
            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                pzre[0] = 0;
            }
            else
            {
                pzre[0] = pzrn;
            }



            // 再热温度	tzre
            double tzrn = PCalc.calcComputetzr(inputs_ela, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;
            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                tzre[0] = 0;
            }
            else
            {
                tzre[0] = tzrn;
            }


            // 排汽压力	pce
            string inputs_ela2 = JsonConvert.SerializeObject(new TurbinElaInputs2<double>()
            {
                pc1 = pc1,  // 排汽压力需/1000
                pw = pw,
                qsr = qsr,
                eb = eb
            });
            // 排汽压力	pce
            double pcn = PCalc.calcComputepc(inputs_ela2, out calcStatus);

            CalcStatus = (enumCalcType)calcStatus;
            if (CalcStatus == enumCalcType.Error)
            {
                return;
            }
            else if (CalcStatus == enumCalcType.PlantStops)
            {
                pce[0] = 0;
            }
            else
            {
                pce[0] = pcn;
            }

            //汽机热耗耗差
            Dictionary<string, object> ins = new()
            {
                ["X"] = new List<double>()
                {
                    1000, 750, 600, 500, 400, 300
                },

                ["y"] = new List<double>()
                {
                    7460, 7560, 7700, 7831, 8034, 8334
                },

                ["pw"] = pw.buffer
            };
            IntPtr ptr = PCalc.compute_t(JsonConvert.SerializeObject(ins));
            

            if (ExcuteEngine.powerUnitStop)
            {
                qsrdst[0] = 0;
                qsre[0] = 0;
            }
            else
            {
                qsrdst[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                PCalc.freeMallocMemory(ref ptr);
                Debug.Assert(ptr == IntPtr.Zero);
                qsre[0] = PCalc.ComputeQsr(eb, qsr, qsrdst);
            }




            if (pw > 100)
            {
                double thaCoal = 269;
                //首先根据负荷计算设计值
                heater0dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 495, 330, 264, 198 }, new List<double>() { -1.7, -1.7, -1.7, -1.7 });
                List<double> y = new List<double>() { 0.141 / thaCoal, 0.137 / thaCoal, 0.132 / thaCoal };
                List<double> x = new List<double>() { 495, 330, 264, 198 }.Take(y.Count).ToList();
                double coalChangeRate0 = PCalc.compute_dst(pw, x, y); //计算煤耗变化率
                heater0dce[0] = (heater0_dc - heater0dcdst) / -1 * coalChangeRate0 * bcpn / 2;


                heater1dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1000, 750, 500, 400, 300 }, new List<double>() { -1.7, -1.7, -1.7, -1.7, -1.7 });
                y = new List<double>() { 0.170 / thaCoal, 0.047 / thaCoal, 0.046 / thaCoal, 0.045 / thaCoal };
                x = new List<double>() { 1000, 750, 500, 400, 300 }.Take(y.Count).ToList();
                double coalChangeRate1 = PCalc.compute_dst(pw, x, y);
                heater1dce[0] = (heater1_dc - heater1dcdst) / -1 * coalChangeRate1 * bcpn / 2;


                heater2dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1000, 750, 500, 400, 300 }, new List<double>() { 0.0, 0.0, 0.0, 0.0, 0.0 });
                y = new List<double>() { 0.063 / thaCoal, 0.061 / thaCoal, 0.060 / thaCoal, 0.063 / thaCoal };
                x = new List<double>() { 1000, 750, 500, 400, 300 }.Take(y.Count).ToList();
                double coalChangeRate2 = PCalc.compute_dst(pw, x, y);
                heater2dce[0] = (heater2_dc - heater2dcdst) / -1 * coalChangeRate2 * bcpn / 2;


                heater3dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1000, 750, 500, 400, 300 }, new List<double>() { 0.0, 0.0, 0.0, 0.0, 0.0 });
                y = new List<double>() { 0.063 / thaCoal, 0.055 / thaCoal, 0.057 / thaCoal, 0.060 / thaCoal };
                x = new List<double>() { 1000, 750, 500, 400, 300 }.Take(y.Count).ToList();
                double coalChangeRate3 = PCalc.compute_dst(pw, x, y);
                heater3dce[0] = (heater3_dc - heater3dcdst) / -1 * coalChangeRate3 * bcpn / 2;


                heater5dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1000, 750, 500, 400, 300 }, new List<double>() { 2.8, 2.8, 2.8, 2.8, 2.8 });
                y = new List<double>() { 0.069 / thaCoal, 0.069 / thaCoal, 0.071 / thaCoal, 0.078 / thaCoal };
                x = new List<double>() { 1000, 750, 500, 400, 300 }.Take(y.Count).ToList();
                double coalChangeRate5 = PCalc.compute_dst(pw, x, y);
                heater5dce[0] = (heater5_dc - heater5dcdst) / 1 * coalChangeRate5 * bcpn / 2;


                heater6dcdst[0] = PCalc.compute_dst(pw, new List<double>() { 1000, 750, 500, 400, 300 }, new List<double>() { 2.8, 2.8, 2.8, 2.8, 2.8 });
                y = new List<double>() { 0.041 / thaCoal, 0.041 / thaCoal, 0.043 / thaCoal, 0.045 / thaCoal };
                x = new List<double>() { 1000, 750, 500, 400, 300 }.Take(y.Count).ToList();
                double coalChangeRate6 = PCalc.compute_dst(pw, x, y);
                heater6dce[0] = (heater6_dc - heater6dcdst) / 1 * coalChangeRate6 * bcpn / 2;


                zrjwslldst[0] = 0;
                ////再热减温水耗差
                //zrjwslle[0] = PCalc.compute_dst(zrjwsll, new List<double>() { 20, 40, 60, 80 }, new List<double>() { 0.5, 1.0, 1.5, 2.0 });

                ptr = PCalc.computeDzrj(ExcuteEngine.turbinJson);

                double dd = ptr == IntPtr.Zero ? 0 : Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);  // 计算减温水流量为0时的再热温度
                PCalc.freeMallocMemory(ref ptr);
                if (dd == 0.0)
                {
                    zrjwslle[0] = 0;
                }
                else
                {
                    inputs_ela = JsonConvert.SerializeObject(new TurbinElaInputs<double>()
                    {
                        pz1 = pz1,
                        pz = pz1,
                        pzdst = pzdst.buffer,
                        tz1 = tz1,
                        tz = tz1,
                        tzdst = tzdst.buffer,
                        tg = tg,
                        pg = pg,
                        pzr1 = pzr1,
                        pzr = pzr1,
                        pzrdst = pzrdst.buffer,
                        tzr1 = tzr1,
                        tzr = tzr1,
                        tzrdst = tzrdst.buffer,
                        pc1 = pc1 / 1000,  // 排汽压力需/1000
                        pc = pc1 / 1000,
                        pcdst = pcdst.buffer,
                        pw = pw,
                        pgs = pgs,
                        tgs = tgs,
                        eb = eb
                    });

                    ptr = PCalc.computetzr(inputs_ela);
                    zrjwslle[0] = Convert.ToDouble(JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(ptr))["data"]);
                    PCalc.freeMallocMemory(ref ptr);

                }


            }
            else
            {
                zrjwslldst[0] = 0;
                zrjwslle[0] = 0;
                heater0dcdst[0] = 0;
                heater0dce[0] = 0;
                heater1dcdst[0] = 0;
                heater1dce[0] = 0;
                heater2dcdst[0] = 0;
                heater2dce[0] = 0;
                heater3dcdst[0] = 0;
                heater3dce[0] = 0;
                heater5dcdst[0] = 0;
                heater5dce[0] = 0;
                heater6dcdst[0] = 0;
                heater6dce[0] = 0;
            }

        }
    }
}
