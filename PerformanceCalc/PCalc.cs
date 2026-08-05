using DBServer.LogServer;
using Newtonsoft.Json;
using System.Data;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Text;

namespace PerformanceCalc
{

    public class PCalc
    {
        [DllImport("tpri.dll", EntryPoint = "?computeBoiler@@YAPEADPEBD@Z")]
        private static extern IntPtr computeBoiler(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeTurbin@@YAPEADPEBD@Z")]
        private static extern IntPtr computeTurbin(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computePlant@@YAPEADPEBD@Z")]
        private extern static IntPtr computePlant(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computePlantPcr@@YAPEADPEBD@Z")]
        private extern static IntPtr computePlantPcr(string inputs);


        [DllImport("tpri.dll", EntryPoint = "?computetpy@@YAPEADPEBD@Z")]
        private extern static IntPtr computetpy(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeq5@@YAPEADPEBD@Z")]
        private extern static IntPtr computeq5(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeq4@@YAPEADPEBD@Z")]
        private extern static IntPtr computeq4(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeov@@YAPEADPEBD@Z")]
        private extern static IntPtr computeov(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computecfhc@@YAPEADPEBD@Z")]
        private extern static IntPtr computecfhc(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeclzc@@YAPEADPEBD@Z")]
        private extern static IntPtr computeclzc(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeQnet@@YAPEADPEBD@Z")]
        private extern static IntPtr computeQnet(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeAad@@YAPEADPEBD@Z")]
        private extern static IntPtr computeAad(string inputs);


        [DllImport("tpri.dll", EntryPoint = "?computeMar@@YAPEADPEBD@Z")]
        private extern static IntPtr computeMar(string inputs);


        [DllImport("tpri.dll", EntryPoint = "?computeeb@@YAPEADPEBD@Z")]
        private extern static IntPtr computeeb(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeq2@@YAPEADPEBD@Z")]
        private extern static IntPtr computeq2(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeq6@@YAPEADPEBD@Z")]
        private extern static IntPtr computeq6(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computepcre@@YAPEADPEBD@Z")]
        private extern static IntPtr computepcre(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computepcr@@YAPEADPEBD@Z")]
        private extern static IntPtr computepcr(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computepz@@YAPEADPEBD@Z")]
        private extern static IntPtr computepz(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computetz@@YAPEADPEBD@Z")]
        private extern static IntPtr computetz(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computepzr@@YAPEADPEBD@Z")]
        private extern static IntPtr computepzr(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computetzr@@YAPEADPEBD@Z")]
        public extern static IntPtr computetzr(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computepc@@YAPEADPEBD@Z")]
        private extern static IntPtr computepc(string inputs);


        [DllImport("tpri.dll", EntryPoint = "?freeMallocMemory@@YAPEADAEAPEAX@Z")]
        public static extern IntPtr freeMallocMemory(ref IntPtr ptr);


        [DllImport("tpri.dll", EntryPoint = "?computeed@@YAPEADPEBD@Z")]
        public static extern IntPtr computeEED(string inputs);





        [DllImport("tpri.dll", EntryPoint = "?computeeb@@YAPEADPEBD@Z")]
        public static extern IntPtr compuetBoilerE(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeov@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerOv(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computetpy@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerTpy(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computecfhc@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerCfhc(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeQnet@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerQnet(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeclzc@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerClzc(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeq2@@YAPEADPEBD@Z")]
        public static extern IntPtr computeBoilerQ2(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeDzrj@@YAPEADPEBD@Z")]
        public static extern IntPtr computeDzrj(string inputs);




        [DllImport("tpri.dll", EntryPoint = "?computeTE@@YAPEADPEBD@Z")]
        public static extern IntPtr computeTE(string inputs);

        [DllImport("tpri.dll", EntryPoint = "?computeTPX@@YAPEADPEBD@Z")]
        public static extern IntPtr computeTPX(string inputs);




        /// <summary>
        /// 汽机相对内效率
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static double calcComputeTE(string json)
        {
            return 0;
            IntPtr result = computeTE(json);
            var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
            freeMallocMemory(ref result);
            //Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
            return (double)(outputs["data"] ?? 0);

        }


        /// <summary>
        /// 凝汽器端差
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static double calcComputeTPX(string json)
        {
            return 0;
            IntPtr result = computeTPX(json);
            var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
            freeMallocMemory(ref result);
            //Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
            return (double)(outputs["data"] ?? 0);

        }

        /// <summary>
        /// 计算高压缸效率
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static double calcComputepeH(InputModel model)
        {
            return 0;
            string ins = JsonConvert.SerializeObject(model);
            IntPtr result = computeEED(ins);
            var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
            freeMallocMemory(ref result);
            //Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
            return (double)(outputs["data"] ?? 0);

        }


        /// <summary>
        /// 计算中压缸效率
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static double calcComputepeM(InputModel model)
        {
            return 0;
            string ins = JsonConvert.SerializeObject(model);
            IntPtr result = computeEED(ins);
            var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
            freeMallocMemory(ref result);
            //Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
            return (double)(outputs["data"] ?? 0);

        }


        /// <summary>
        /// 计算低压缸效率
        /// </summary>
        /// <param name="json"></param>
        /// <returns></returns>
        public static double calcComputepeL(InputModel model)
        {
            string ins = JsonConvert.SerializeObject(model);
            IntPtr result = computeEED(ins);
            var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
            freeMallocMemory(ref result);
            //Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
            return (double)(outputs["data"] ?? 0);

        }


        public static async void ComputeTest()
        {

            var contents = (from x in File.ReadAllText("./fx.csv").Split(new char[] { '\r', '\n' }) where !string.IsNullOrEmpty(x) select x).ToList();
            List<ComputeModel> models = new();
            var names = contents[1].Split(",");
            for (int i = 1; i < names.Length; i++)
            {
                models.Add(new()
                {
                    Index = i,
                    Des = names[i]
                });
            }
            Dictionary<string, List<double>> ds = new();

            int count = 0;

            foreach (var model in models)
            {

                List<double> dd = new();

                for (int i = 2; i < contents.Count; i++)
                {
                    dd.Add(Convert.ToDouble(contents[i].Split(",")[model.Index]));
                }

                ds[model.Des] = dd;

                count = dd.Count;


            }

            // 高压缸效率
            double[] x1 = new double[count];
            List<Task<bool>> workers = new();
            for (int ii = 0; ii < count; ii++)
            {
                int i = ii;
                workers.Add(Task.Run(() =>
                {
                    InputModel model = new()
                    {
                        Pin = ds["主汽压力"][i],
                        Tin = ds["主汽温度"][i],
                        Pwout = ds["高排压力"][i],
                        Twout = ds["高排温度"][i],
                        T = "h"
                    };

                    string ins = JsonConvert.SerializeObject(model);
                    IntPtr result = computeEED(ins);
                    var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
                    freeMallocMemory(ref result);
                    Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
                    x1[i] = (Convert.ToDouble(outputs["data"]));
                    return true;
                }));


            }

            Task.WhenAll(workers.ToArray()).Wait();
            Console.WriteLine("x1");

            // 低压缸效率
            workers.Clear();
            double[] x3 = new double[count];
            for (int ii = 0; ii < count; ii++)
            {
                int i = ii;
                workers.Add(Task.Run(() =>
                {
                    InputModel model = new()
                    {
                        Pin = ds["中压缸排气"][i],
                        Tin = ds["中排温度"][i],
                        Pwout = (ds["大气压力"][i] + ds["低压缸抽气"][i]) / 1000,
                        Twout = ds["低排温度"][i],
                        T = "l"
                    };

                    string ins = JsonConvert.SerializeObject(model);
                    IntPtr result = computeEED(ins);
                    var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
                    freeMallocMemory(ref result);
                    Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
                    x3[i] = (Convert.ToDouble(outputs["data"]));
                    return true;
                }));


            }

            Task.WhenAll(workers.ToArray()).Wait();

            Console.WriteLine("x3");



            // 中压缸效率
            double[] x2 = new double[count];
            workers.Clear();
            for (int ii = 0; ii < count; ii++)
            {
                int i = ii;
                workers.Add(Task.Run(() =>
                {
                    InputModel model = new()
                    {
                        Pin = ds["再热压力"][i],
                        Tin = ds["再热温度"][i],
                        Pwout = ds["中压缸排气"][i],
                        Twout = ds["中排温度"][i],
                        T = "m"
                    };

                    string ins = JsonConvert.SerializeObject(model);
                    IntPtr result = computeEED(ins);
                    var outputs = JsonConvert.DeserializeObject<Dictionary<string, object>>(Marshal.PtrToStringAnsi(result));
                    freeMallocMemory(ref result);
                    Debug.Assert(string.IsNullOrEmpty(outputs["msg"].ToString()) && result == IntPtr.Zero);
                    x2[i] = (Convert.ToDouble(outputs["data"]));
                    return true;
                }));


            }
            Task.WhenAll(workers.ToArray()).Wait();

            Console.WriteLine("x2");




            List<string> items = new()
            {
                "负荷",
                "高压缸效率",
                "中压缸效率",
                "低压缸效率"
            };

            for (int i = 0; i < count; i++)
            {

                var load = ds["机组负荷"][i];
                items.Add($"{load}, {x1[i]}, {x2[i]}, {x3[i]}");

            }

            File.WriteAllLines("./r11.csv", items);

            Console.WriteLine("ok");

            Console.ReadLine();


        }



        public static double CompuetPcrE(double eb, double qsr, double pcr, double pcrdst)
        {
            if (eb == 0 || qsr == 0)
            {
                return 0;
            }
            return 123 / ((eb * 3600 / qsr * 0.998 * 0.998) * (1 - pcr) * (1 - pcr)) * (pcr - pcrdst);
        }




        /// 计算汽机热耗的耗差
        /// eb: 实际工况的锅炉效率
        /// qsr: 实际工况的汽机热耗
        /// qsrdst: 目标工况的汽机热耗
        public static double ComputeQsr(double eb, double qsr, double qsrdst)
        {
            if (eb == 0)
            {
                return 0;
            }
            return 123 / (3600 * 0.998 * 0.998 * eb) * (qsr - qsrdst);

        }

        /// 计算锅炉效率的耗差
        /// eb: 实际工况的锅炉效率
        /// ebdst: 目标工况的锅炉效率
        /// qsr: 实际工况的汽机热耗
        public static double ComputeEb(double eb, double ebdst, double qsr)
        {
            if (eb == 0)
            {
                return 0;
            }
            return 123 * qsr / (3600 * 0.998 * 0.998 * eb * eb) * (eb - ebdst) * -1;

        }


        /// <summary>
        /// 计算正平衡锅炉效率   
        /// </summary>
        /// <param name="qsr">汽机热耗</param>
        /// <param name="pw">机组负荷</param>
        /// <param name="coal">燃料量</param>
        /// <param name="qnet">低位发热量</param>
        /// <returns></returns>
        private static double ComputeEb(double qsr, double pw, double coal, double qnet)
        {
            if (coal == 0 || qnet == 0)
            {
                return 0;
            }
            double q1 = qsr * pw / coal;
            return q1 / (4.184 * qnet);
        }


        /// <summary>
        /// 计算耗差分析的目标值
        /// </summary>
        /// <param name="inputs"></param>
        /// <returns></returns>
        [DllImport("tpri.dll", EntryPoint = "?compute_t@@YAPEADPEBD@Z")]
        public extern static IntPtr compute_t(string inputs);


        #region 汽机耗差
        public static double calcComputepz(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computepz(str);
            return getValue(ptr, out calcStatus);
        }

        public static double calcComputetz(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computetz(str);
            return getValue(ptr, out calcStatus); ;
        }

        public static double calcComputepzr(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computepzr(str);
            return getValue(ptr, out calcStatus);
        }

        public static double calcComputetzr(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computetzr(str);
            return getValue(ptr, out calcStatus);
        }

        public static double calcComputepc(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computepc(str);
            return getValue(ptr, out calcStatus);
        }
        #endregion

        #region 锅炉耗差

        public static double calcComputeAda(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computeAad(str);
            return getValue(ptr, out calcStatus);
        }

        public static double calcComputeMar(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computeMar(str);
            return getValue(ptr, out calcStatus);
        }

        //public static double calcComputeQnet(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeQnet(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputetpy(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computetpy(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeq5(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeq5(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeq4(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeq4(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeov(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeov(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputecfhc(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computecfhc(str);
        //    return getValue(ptr, out calcStatus);
        //}


        //public static double calcComputeclzc(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeclzc(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeeb(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeeb(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeq2(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeq2(str);
        //    return getValue(ptr, out calcStatus);
        //}

        //public static double calcComputeq6(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computeq6(str);
        //    return getValue(ptr, out calcStatus);
        //}

        public static double calcComputepcre(string str, out int calcStatus)
        {
            calcStatus = 2;
            return 0;
            IntPtr ptr = computepcre(str);
            return getValue(ptr, out calcStatus);
        }

        //public static double calcComputepcr(string str, out int calcStatus)
        //{
        //    IntPtr ptr = computepcr(str);
        //    return getValue(ptr, out calcStatus);
        //}

        #endregion

        public static double getValue(IntPtr ptr, out int calcStatus)
        {
            string outputs = Marshal.PtrToStringAnsi(ptr);
            Marshal.FreeHGlobal(ptr);

            CalcResultMsg calcResultMsg = JsonConvert.DeserializeObject<CalcResultMsg>(outputs);
            if (calcResultMsg.code == 200)
            {
                calcStatus = 0;
                return Convert.ToDouble(calcResultMsg.data);
            }
            else
            {
                if (calcResultMsg.msg == "plant stops")
                {
                    calcStatus = 2;
                }
                else
                {
                    calcStatus = 1;
                }
                return 0;
            }
        }


        private static LoggerService<PCalc> logger = new LoggerService<PCalc>();

        public static BoilerData calcBoilerValue(string jstr, out int calcStatus)
        {
            try
            {
                calcStatus = 2;
                return null;
                //WriterData(AppDomain.CurrentDomain.BaseDirectory + "BoilerJson.txt", jstr);
                IntPtr result = computeBoiler(jstr);
                string outputs = Marshal.PtrToStringAnsi(result);
                Marshal.FreeHGlobal(result);
                BoilerResultMsg boilerResultMsg = JsonConvert.DeserializeObject<BoilerResultMsg>(outputs);
                if (boilerResultMsg.code == 200)
                {
                    calcStatus = 0;
                    return boilerResultMsg.data;
                }
                else
                {
                    if (boilerResultMsg.msg == "plant stops")
                    {
                        calcStatus = 2;
                    }
                    else
                    {
                        //数据异常导致计算错误
                        calcStatus = 1;
                        logger.ErrorLog(boilerResultMsg.msg + "\r\n" + jstr);
                    }
                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message + "\r\n" + jstr);
                calcStatus = 1;
                return null;
            }
        }


        public static void WriterData(string path, string jstr)
        {
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.WriteLine(jstr);
            }
        }


        public static void WriterLog(string logstr)
        {
            logger.InfoLog(logstr);
        }

        public static TurbinData calcTurbinValue(string jstr, out int calcStatus)
        {
            try
            {
                //WriterData(AppDomain.CurrentDomain.BaseDirectory + "TurbinJson.txt", jstr);
                calcStatus = 2;
                return null;
                IntPtr result = computeTurbin(jstr);
                string outputs = Marshal.PtrToStringAnsi(result);
                Marshal.FreeHGlobal(result);
                TurbinResultMsg turbinResultMsg = JsonConvert.DeserializeObject<TurbinResultMsg>(outputs);
                if (turbinResultMsg.code == 200)
                {

                    calcStatus = 0;
                    return turbinResultMsg.data;
                }
                else
                {
                    if (turbinResultMsg.msg == "plant stops")
                    {
                        calcStatus = 2;
                    }
                    else
                    {
                        //数据异常导致计算错误
                        calcStatus = 1;
                        logger.ErrorLog(turbinResultMsg.msg + "\r\n" + jstr);
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message + "\r\n" + jstr);
                calcStatus = 1;
                return null;
            }
        }



        public static PlantPcrData calcPlantPcrValue(string jstr, out int calcStatus)
        {
            try
            {
                //WriterData(AppDomain.CurrentDomain.BaseDirectory + "PlantPcrJson.txt", jstr);
                calcStatus = 2;
                return null;
                IntPtr result = computePlantPcr(jstr);
                string outputs = Marshal.PtrToStringAnsi(result);
                Marshal.FreeHGlobal(result);
                PlantPcrResultMsg plantPcrResultMsg = JsonConvert.DeserializeObject<PlantPcrResultMsg>(outputs);
                if (plantPcrResultMsg.code == 200)
                {
                    calcStatus = 0;
                    return plantPcrResultMsg.data;
                }
                else
                {
                    if (plantPcrResultMsg.msg == "plant stops")
                    {
                        calcStatus = 2;
                    }
                    else
                    {
                        //数据异常导致计算错误
                        calcStatus = 1;
                        logger.ErrorLog(plantPcrResultMsg.msg + "\r\n" + jstr);
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message + "\r\n" + jstr);
                calcStatus = 1;
                return null;
            }

        }

        public static PlantData calcPlantValue(string jstr, out int calcStatus)
        {
            try
            {
                //WriterData(AppDomain.CurrentDomain.BaseDirectory + "PlantJson.txt", jstr);
                calcStatus = 2;
                return null;
                IntPtr result = computePlant(jstr);
                string outputs = Marshal.PtrToStringAnsi(result);
                Marshal.FreeHGlobal(result);
                PlantResultMsg plantResultMsg = JsonConvert.DeserializeObject<PlantResultMsg>(outputs);
                if (plantResultMsg.code == 200)
                {
                    calcStatus = 0;
                    return plantResultMsg.data;
                }
                else
                {
                    if (plantResultMsg.msg == "plant stops")
                    {
                        calcStatus = 2;
                    }
                    else
                    {
                        //数据异常导致计算错误
                        calcStatus = 1;
                        logger.ErrorLog(plantResultMsg.msg + "\r\n" + jstr);
                    }

                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message + "\r\n" + jstr);
                calcStatus = 1;
                return null;
            }
        }


        public static double compute_dst(double pw, List<double> y)
        {
            return 0;

            List<double> x = null;
            if (y.Count == 5)
            {
                x = new List<double>() { 1000, 750, 500, 400, 300 };
            }
            else if (y.Count == 4)
            {
                x = new List<double>() { 1000, 750, 500, 400 };
            }
            else
            {

            }

            string inputs = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"X", x},
                {"y", y },
                {"pw", pw }
            });
            IntPtr result = compute_t(inputs);
            string outputs = Marshal.PtrToStringAnsi(result);
            Marshal.FreeHGlobal(result);
            CalcResultMsg calcResultMsg = JsonConvert.DeserializeObject<CalcResultMsg>(outputs);

            if (calcResultMsg.code == 200)
            {
                return Convert.ToDouble(calcResultMsg.data);
            }
            else
            {
                return 0;
            }
            Marshal.FreeHGlobal(result);
        }

        public static double compute_dst(double pw, List<double> x, List<double> y)
        {

            return 0;
            string inputs = JsonConvert.SerializeObject(new Dictionary<string, object>()
            {
                {"X", x},
                {"y", y },
                {"pw", pw }
            });
            IntPtr result = compute_t(inputs);
            string outputs = Marshal.PtrToStringAnsi(result);
            Marshal.FreeHGlobal(result);
            CalcResultMsg calcResultMsg = JsonConvert.DeserializeObject<CalcResultMsg>(outputs);

            if (calcResultMsg.code == 200)
            {
                //logger.InfoLog($"{inputs}--------{calcResultMsg.data}");
                return Convert.ToDouble(calcResultMsg.data);
            }
            else
            {
                return 0;
            }
            Marshal.FreeHGlobal(result);
        }


        /// <summary>
        /// 计算煤耗
        /// </summary>
        /// <param name="Qnetar">低位发热量</param>
        /// <param name="b">燃料量t/h</param>
        /// <param name="pw">机组负荷</param>
        /// <returns></returns>
        public static double ComputeCoal(double Qnetar, double b, double pw)
        {
            if (pw == 0)
            {
                return 0;
            }
            return Qnetar * 4.184 / 29270 * (b / pw) * 1000;
        }

        /// <summary>
        /// 计算机组的热耗
        /// </summary>
        /// <param name="coal">发电煤耗</param>
        /// <param name="eb">锅炉效率</param>
        /// <returns></returns>
        public static double ComputeQsr(double coal, double eb)
        {
            if (coal == 0 || eb == 0)
            {
                return 0;
            }
            double e = 123 / coal;
            double eq = e / eb / 0.99 / 0.99;
            if (eq == 0) return 0;
            return 3600 / eq;
        }

        /// <summary>
        /// 计算热耗和锅炉效率的耗差
        /// </summary>
        /// <param name="t1">实际值</param>
        /// <param name="target">目标值</param>
        /// <param name="coal">发电煤耗</param>
        /// <returns></returns>
        public static double ComputeHC(double t1, double target, double coal)
        {
            if (t1 == 0 || target == 0 || coal == 0)
            {
                return 0;
            }
            double x1 = 1 / t1;
            double xt = 1 / target;

            return (x1 - xt) / xt * coal;
        }
    }


    public class TurbinElaInputs<T>
    {
        public T pz1 { get; set; }

        public T pz { get; set; }

        public T pzdst { get; set; }

        public T tz1 { get; set; }

        public T tz { get; set; }

        public T tzdst { get; set; }

        public T pg { get; set; }

        public T tg { get; set; }

        public T pzr1 { get; set; }

        public T pzr { get; set; }

        public T pzrdst { get; set; }

        public T tzr1 { get; set; }

        public T tzr { get; set; }

        public T tzrdst { get; set; }

        public T pc1 { get; set; }

        public T pc { get; set; }

        public T pcdst { get; set; }

        public T pw { get; set; }

        public T pgs { get; set; }

        public T tgs { get; set; }

        public T eb { get; set; }

    }

    public class TurbinElaInputs2<T>
    {

        public T pc1 { get; set; }


        public T pw { get; set; }


        public T eb { get; set; }

        public T qsr { get; set; }
    }

    public class BoilerElaInputs<T>
    {
        public T ov { get; set; }
        public T tpy { get; set; }
        public T tsf { get; set; }
        public T D { get; set; }
        public T Qnetar { get; set; }
        public T Clzc { get; set; }
        public T Cfhc { get; set; }
        public T Vad { get; set; }
    }


    public class Response<T>
    {

        [JsonProperty("message")]
        /// <summary>
        /// message
        /// </summary>
        public string? Message { get; set; }

        [JsonProperty("data")]
        /// <summary>
        /// data field
        /// </summary>
        public T? Data { get; set; }

        [JsonProperty("code")]
        public int Code { get; set; } = 200;

        public override string ToString()
        {
            return Data == null ? string.Empty : Data.ToString();
        }

        [JsonIgnore]
        public string? Msg { get; set; } // for performance outputs

    }

    public class CalcResultMsg
    {
        public int code { get; set; }
        public string msg { get; set; }
        public float? data { get; set; }
    }

    public class TurbinResultMsg
    {
        public int code { get; set; }
        public string msg { get; set; }
        public TurbinData data { get; set; }
    }

    public class BoilerResultMsg
    {
        public int code { get; set; }
        public string msg { get; set; }
        public BoilerData data { get; set; }
    }

    public class PlantResultMsg
    {
        public int code { get; set; }
        public string msg { get; set; }
        public PlantData data { get; set; }
    }

    public class PlantPcrResultMsg
    {
        public int code { get; set; }
        public string msg { get; set; }
        public PlantPcrData data { get; set; }
    }
    public class TurbinData
    {

        /// <summary>
        /// 计算次数
        /// </summary>
        public int? count { get; set; }
        /// <summary>
        /// 汽耗率
        /// </summary>
        public double? d0 { get; set; }
        /// <summary>
        /// 汽轮机组效率
        /// </summary>
        public double e { get; set; }

        public List<OHeaters>? heaters { get; set; }

        /// <summary>
        /// 各个缸的等熵焓降
        /// </summary>
        public List<double> hoh { get; set; }


        /// <summary>
        /// 排汽焓值
        /// </summary>
        public double hp { get; set; }
        /// <summary>
        /// 排汽理想焓值
        /// </summary>
        public double hps { get; set; }
        /// <summary>
        /// 各个缸的效率
        /// </summary>
        public List<double> pe { get; set; }

        public double pwc { get; set; }

        /// <summary>
        /// 高压缸排汽流量
        /// </summary>
        public double qh { get; set; }

        /// <summary>
        /// 各个缸的折算流量
        /// </summary>
        public List<double> qhs { get; set; }

        /// <summary>
        /// 热耗率
        /// </summary>
        public double qsr { get; set; }
        /// <summary>
        /// 计算耗时ms
        /// </summary>
        public double time { get; set; }

        /// <summary>
        /// 主蒸汽焓值
        /// </summary>
        public double hz { get; set; }

        /// <summary>
        /// 给水焓值 
        /// </summary>
        public double hgs { get; set; }

        /// <summary>
        /// 再热焓值  
        /// </summary>
        public double hzr { get; set; }

        /// <summary>
        /// 再热冷段流量   
        /// </summary>
        public double dzrl { get; set; }

        /// <summary>
        /// 再热冷段焓值   
        /// </summary>
        public double hzrl { get; set; }

        /// <summary>
        /// 再热流量 
        /// </summary>
        public double dzr { get; set; }

        /// <summary>
        /// 再热减温水焓值  
        /// </summary>
        public double dzrg { get; set; }
    }

    public class OHeaters
    {
        public double? dother { get; set; }
        public double? dss { get; set; }
        public double? dssn { get; set; }
        public double? dwin { get; set; }
        public double? dwout { get; set; }
        public double? hc { get; set; }
        public double? hcs { get; set; }
        public double? hd { get; set; }
        public double? hin { get; set; }
        public double? hother { get; set; }
        public double? hss { get; set; }
        public double? hssn { get; set; }
        public double? hwin { get; set; }
        public double? hwout { get; set; }
        public int? index { get; set; }
        public bool? last { get; set; }
        // 加热器下端差
        public double? lower { get; set; }
        public double? pc { get; set; }
        public double? pin { get; set; }
        public double? pwin { get; set; }
        public double? pwout { get; set; }
        public bool? reheater { get; set; }
        public double? sc { get; set; }
        public double? tc { get; set; }
        public double? tin { get; set; }
        public double? tss { get; set; }
        public double? tssn { get; set; }
        public double? twin { get; set; }
        public double? twout { get; set; }
        public int? type { get; set; }
        // 加热器上端差
        public double? upper { get; set; }
    }

    public class PlantData
    {
        /// <summary>
        /// 空预器漏风率A
        /// </summary>
        public double airp { get; set; }

        /// <summary>
        /// 空预器漏风率B
        /// </summary>
        public double airpb { get; set; }


        /// <summary>
        /// 正平衡发电煤耗
        /// </summary>
        public double bcp { get; set; }

        /// <summary>
        /// 反平衡供电煤耗
        /// </summary>
        public double bcpn { get; set; }

        /// <summary>
        /// 反平衡发电煤耗
        /// </summary>
        public double bcpr { get; set; }

        /// <summary>
        /// 机组效率
        /// </summary>
        public double ep { get; set; }
        /// <summary>
        /// 厂用电率
        /// </summary>
        public double pcr { get; set; }

    }

    public class PlantPcrData
    {
        /// <summary>
        /// 一次风机电耗率
        /// </summary>
        public double? ycfj { get; set; }

        /// <summary>
        /// 送风机电耗率
        /// </summary>
        public double? sfj { get; set; }

        /// <summary>
        /// 引风机电耗率
        /// </summary>
        public double? yfj { get; set; }

        /// <summary>
        /// 磨煤机电耗率
        /// </summary>
        public double? mmj { get; set; }

        /// <summary>
        /// 凝结水泵电耗率
        /// </summary>
        public double? njsb { get; set; }

        /// <summary>
        /// 循环水泵电耗率
        /// </summary>
        public double? xhsb { get; set; }

    }

    public class BoilerData
    {
        /// <summary>
        /// 锅炉效率
        /// </summary>
        public double e { get; set; }
        /// <summary>
        /// 排烟热损失
        /// </summary>
        public double q2 { get; set; }
        /// <summary>
        /// 可燃气体未完全燃烧热损失
        /// </summary>
        public double q3 { get; set; }
        /// <summary>
        /// 固体未完全燃烧热损失 
        /// </summary>
        public double q4 { get; set; }
        /// <summary>
        /// 散热损失
        /// </summary>
        public double q5 { get; set; }
        /// <summary>
        /// 灰渣物理热损失
        /// </summary>
        public double q6 { get; set; }

        public int ClacStatus { get; set; }
        public double C { get; set; }
        public double CpH2o { get; set; }
        public double Cpgy { get; set; }
        public double Q2H2O { get; set; }
        public double Q2gy { get; set; }
        public double Vgkco { get; set; }
        public double Vgy { get; set; }
        public double Vgyco { get; set; }
        public double Vh2o { get; set; }
        public double afh { get; set; }
        public double alz { get; set; }
        public double apy { get; set; }
        public double cfh { get; set; }
        public double clz { get; set; }
        public double d { get; set; }
        public double dk { get; set; }
        public double k1 { get; set; }
        public double k2 { get; set; }
        public double pre { get; set; }
        public double tlz { get; set; }
    }


    public class InputModel
    {
        [JsonProperty("pin")]
        public double Pin { get; set; }

        [JsonProperty("tin")]

        public double Tin { get; set; }

        [JsonProperty("pwout")]

        public double Pwout { get; set; }

        [JsonProperty("twout")]

        public double Twout { get; set; }

        [JsonProperty("t")]
        public string? T { get; set; }

    }


    public class ComputeModel
    {
        public int Index { get; set; }

        public string? PointName { get; set; }

        public string? Des { get; set; }
    }
}
