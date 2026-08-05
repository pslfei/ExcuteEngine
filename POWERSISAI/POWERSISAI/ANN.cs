using DBServer.LogServer;
using MathNet.Numerics.LinearAlgebra;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace POWERSISAI
{
    public class ANN
    {
        public class Output_Info
        {
            public float[][] reconData;
            public float[][] errorData;
            public float[][] paraState;
            public float R;
            public float[] SPE;
            public float[] FAI;
            public float[] Index;
        }
        public class Assess_Info
        {
            public bool expand { get; set; }

            public Test_Data Test_Data { get; set; }

            public string dead { get; set; }

            public string condition { get; set; }

            public string limit { get; set; }

            public int number_sample { get; set; }

            public string uplow { get; set; }

            public Assess_Point[] assess { get; set; }
        }

        public class Assess_Point
        {
            public int number_fault_variable { get; set; }

            public string low_f { get; set; }

            public string high_f { get; set; }
        }

        public class Assess_output
        {
            public double[] amplitude { get; set; }

            public double[] far_variable { get; set; }

            public double[] fdr_variable { get; set; }

            public double[] Reconstruction_precision { get; set; }
        }

        public class ItemInfo
        {
            public string ItemName { get; set; }

            public bool ClearDeadZone { get; set; }
        }

        public class Review_Info
        {
            public Test_Data Test_Data { get; set; }
        }

        public class Test_Data
        {
            public string time;

            public double[] AddBias;

            public string points;

            public string AddBias_Time;

            public int interval;
        }

        public class LayerNet
        {
            public Matrix<double> W { get; set; }

            public Matrix<double> B { get; set; }
        }

        public class Input
        {
            public int Model_id;

            public string version;

            public double[][] Test_Data;

            public double[][] Target_Data;
        }

        public class Info
        {
            public para para { get; set; }

            public string name { get; set; }

            public string algorithm { get; set; }

            public List<PointInfoItem> pointInfo { get; set; }

            public alarmmodelset alarmmodelset { get; set; }
        }

        public class para
        {
            public List<List<object>> weight { get; set; }

            public double limit { get; set; }
        }

        public class PointInfoItem
        {
            public bool? type { get; set; }

            public double TMax { get; set; }

            public double TMin { get; set; }

            public double? C95 { get; set; }

            public string PointId { get; set; }
        }

        public class Output
        {
            public List<List<double>> reconData { get; set; }

            public List<List<double>> errorData { get; set; }

            public List<double> Index { get; set; }

            public List<List<double>> paraState { get; set; }

            public string msg { get; set; }
        }

        public class Output1
        {
            public double[][] reconData { get; set; }

            public double[][] errorData { get; set; }

            public double[] Index { get; set; }

            public double[][] paraState { get; set; }

            public string msg { get; set; }
        }

        public class CDItem
        {
            public string ItemName;

            public bool ClearDeadZone;
        }

        public class CDTimePeriod
        {
            public DateTime StartingTime;

            public DateTime TerminalTime;
        }

        public class CDTimeStampPeriod
        {
            public long StartingTimeStamp;

            public long TerminalTimeStamp;
        }

        public class alarmmodelset
        {
            public string alarmname { get; set; }

            public string alarmcondition { get; set; }
        }

        private string myConnectionString;

        private SqlConnection myConnection;

        private EXATools EXA = new EXATools();

        public static Output_Info OutputInfo = new Output_Info();

        private static LoggerService<ANN> logger = new LoggerService<ANN>();

        public static string Diagnosis(string model, string InputInfo)
        {

            string msg = "OK";
            Output output = new Output();
            List<List<double>> list = new List<List<double>>();
            List<List<double>> list2 = new List<List<double>>();
            List<List<double>> list3 = new List<List<double>>();
            List<double> list4 = new List<double>();
            Info info = JsonConvert.DeserializeObject<Info>(model);
            Input input = JsonConvert.DeserializeObject<Input>(InputInfo);


            if (info.para == null)
            {
                return "";
            }


            int length = input.Test_Data[0].GetLength(0);
            int length2 = input.Target_Data[0].GetLength(0);
            if (length + length2 != info.pointInfo.Count())
            {
                msg = "输入数据与模型结构不匹配。";
            }
            else
            {
                try
                {
                    List<PointInfoItem> list5 = new List<PointInfoItem>();
                    List<PointInfoItem> list6 = new List<PointInfoItem>();
                    for (int i = 0; i < info.pointInfo.Count; i++)
                    {
                        if (info.pointInfo[i].type != null)
                        {
                            if ((bool)info.pointInfo[i].type)
                            {
                                PointInfoItem pointInfoItem = new PointInfoItem();
                                pointInfoItem.type = true;

                                pointInfoItem.TMax = info.pointInfo[i].TMax;
                                pointInfoItem.TMin = info.pointInfo[i].TMin;

                                pointInfoItem.C95 = info.pointInfo[i].C95;
                                list6.Add(pointInfoItem);
                            }
                            else
                            {
                                PointInfoItem pointInfoItem2 = new PointInfoItem();
                                pointInfoItem2.type = false;
                                pointInfoItem2.TMax = info.pointInfo[i].TMax;
                                pointInfoItem2.TMin = info.pointInfo[i].TMin;
                                pointInfoItem2.C95 = 0.0;
                                list5.Add(pointInfoItem2);
                            }
                        }
                        else
                        {

                            PointInfoItem pointInfoItem2 = new PointInfoItem();
                            pointInfoItem2.type = false;
                            pointInfoItem2.TMax = info.pointInfo[i].TMax;
                            pointInfoItem2.TMin = info.pointInfo[i].TMin;
                            pointInfoItem2.C95 = 0.0;
                            list5.Add(pointInfoItem2);

                        }
                    }

                    List<LayerNet> list7 = new List<LayerNet>();
                    for (int j = 0; j < info.para.weight.Count; j += 2)
                    {
                        LayerNet layerNet = new LayerNet();
                        double[][] array = new double[info.para.weight[j].Count()][];
                        for (int k = 0; k < info.para.weight[j].Count(); k++)
                        {
                            string text = info.para.weight[j][k].ToString();
                            array[k] = Array.ConvertAll(text.Replace("[", "").Replace("]", "").Replace("\r\n", "")
                                .Replace(" ", "")
                                .Trim()
                                .Split(','), (string s) => double.Parse(s));
                        }
                        layerNet.W = Matrix<double>.Build.DenseOfColumnArrays(array).Transpose();
                        double[] array2 = new double[layerNet.W.ColumnCount];
                        for (int l = 0; l < layerNet.W.ColumnCount; l++)
                        {
                            array2[l] = Convert.ToDouble(info.para.weight[j + 1][l].ToString());
                        }
                        layerNet.B = Matrix<double>.Build.DenseOfColumnArrays(array2).Transpose();
                        list7.Add(layerNet);

                    }
                    int num = input.Test_Data.Length;
                    for (int m = 0; m < num; m++)
                    {
                        double[] array3 = input.Test_Data[m];
                        double[] array4 = input.Target_Data[m];
                        double[] array5 = new double[array3.Length];
                        double[] array6 = new double[array4.Length];

                        for (int n = 0; n < input.Test_Data[m].Length; n++)
                        {
                            array5[n] = (array3[n] - list5[n].TMin) / (list5[n].TMax - list5[n].TMin);
                        }
                        for (int num2 = 0; num2 < input.Target_Data[m].Length; num2++)
                        {
                            array6[num2] = (array4[num2] - list6[num2].TMin) / (list6[num2].TMax - list6[num2].TMin);
                        }

                        Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(array5).Transpose();
                        Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(array6).Transpose();

                        for (int num3 = 0; num3 < list7.Count; num3++)
                        {

                            Matrix<double> Cur_mdata = matrix * list7[num3].W + list7[num3].B;
                            if (num3 < list7.Count - 1)
                            {
                                Matrix<double> matrix3 = Matrix<double>.Build.Dense(Cur_mdata.RowCount, Cur_mdata.ColumnCount, (int p, int q) => 1.0 / (1.0 + Math.Exp(0.0 - Cur_mdata[p, q])));
                                matrix = matrix3;
                            }
                            else
                            {
                                matrix = Cur_mdata;
                            }
                        }

                        List<double> list8 = new List<double>();
                        List<double> list9 = new List<double>();
                        List<double> list10 = new List<double>();
                        for (int num4 = 0; num4 < length2; num4++)
                        {
                            double num5 = matrix[0, num4] * (list6[num4].TMax - list6[num4].TMin) + list6[num4].TMin;
                            list8.Add(num5);
                            list9.Add(array4[num4] - num5);
                            list10.Add((Math.Abs(array4[num4] - num5) > list6[num4].C95) ? 1 : 0);
                        }
                        Matrix<double> matrix4 = (matrix - matrix2) * (matrix - matrix2).Transpose();
                        list.Add(list8);
                        list2.Add(list9);
                        list3.Add(list10);
                        list4.Add(Math.Sqrt(matrix4[0, 0] / (double)length2));
                    }
                    output.reconData = list;
                    output.errorData = list2;
                    output.paraState = list3;
                    output.Index = list4;
                }
                catch (Exception ex)
                {

                    throw;
                }
            }

            output.msg = msg;
            //return JsonConvert.SerializeObject(output);
            string returnStr = JsonConvert.SerializeObject(output);
            OutputInfo = JsonConvert.DeserializeObject<Output_Info>(returnStr);

            return returnStr;
        }

        public static float[][] GetReconData(string jstr)
        {
            Output_Info output_Info = JsonConvert.DeserializeObject<Output_Info>(jstr);
            return output_Info.reconData;

        }

        public static float[][] GetErrorData(string jstr)
        {
            Output_Info output_Info = JsonConvert.DeserializeObject<Output_Info>(jstr);
            return output_Info.errorData;
        }
        public string Assess(string model, string InputInfo, string EXA_IP)
        {
            DateTime now = DateTime.Now;
            string message = "OK";
            string text = "";
            try
            {
                Info info = JsonConvert.DeserializeObject<Info>(model);
                Assess_Info assess_Info = JsonConvert.DeserializeObject<Assess_Info>(InputInfo);
                int count = info.pointInfo.Count;
                int num = 0;
                for (int i = 0; i < count; i++)
                {
                    if ((bool)info.pointInfo[i].type)
                    {
                        num++;
                    }
                }
                int interval = assess_Info.Test_Data.interval;
                int dCount = 0;
                if (interval < 10000)
                {
                    dCount = 100;
                }
                else if (interval < 100000)
                {
                    dCount = 50;
                }
                else if (interval < 500000)
                {
                    dCount = 10;
                }
                string[] array = assess_Info.dead.Split(',');
                string[] array2 = assess_Info.Test_Data.points.Split(',');
                List<ItemInfo> list = new List<ItemInfo>();
                for (int j = 0; j < count; j++)
                {
                    ItemInfo itemInfo = new ItemInfo();
                    itemInfo.ItemName = array2[j];
                    if (array[j].Trim() == "1")
                    {
                        itemInfo.ClearDeadZone = true;
                    }
                    else
                    {
                        itemInfo.ClearDeadZone = false;
                    }
                    list.Add(itemInfo);
                }
                string itemsInfo = JsonConvert.SerializeObject(list);
                string[] array3 = assess_Info.Test_Data.time.Split(';');
                List<CDTimePeriod> list2 = new List<CDTimePeriod>();
                for (int k = 0; k < array3.Length; k++)
                {
                    CDTimePeriod cDTimePeriod = new CDTimePeriod();
                    string[] array4 = array3[k].Split(',');
                    cDTimePeriod.StartingTime = Convert.ToDateTime(array4[0]);
                    cDTimePeriod.TerminalTime = Convert.ToDateTime(array4[1]);
                    list2.Add(cDTimePeriod);
                }
                string samplingTimePeriods = JsonConvert.SerializeObject(list2);
                string text2 = "";
                if (assess_Info.condition.Trim() != "")
                {
                    text2 = assess_Info.condition.Replace("==", "###").Replace(">=", ">").Replace("<=", "<");
                    text2 = text2.Replace("=", "==");
                    text2 = text2.Replace("###", "==");
                    text2 = "(" + text2 + ")";
                }
                else
                {
                    text2 = "(1==1)";
                }
                string[] array5 = assess_Info.limit.Split(',');
                string[] array6 = assess_Info.uplow.Split(';');
                for (int l = 0; l < array5.Length; l++)
                {
                    if (array5[l].Trim() == "1")
                    {
                        text2 = text2 + " and ([" + array2[l] + "]<" + array6[l].Split(',')[1] + " and [" + array2[l] + "]>" + array6[l].Split(',')[0] + ")";
                    }
                }
                List<List<float?>> newDTList = new List<List<float?>>();
                string text3 = EXA.ClearDataEXA(itemsInfo, samplingTimePeriods, text2, interval, dCount, EXA_IP, out newDTList);
                DateTime now2 = DateTime.Now;
                int num2 = assess_Info.assess.Length;
                double[] array7 = new double[num2];
                double[] array8 = new double[num2];
                double[] array9 = new double[num2];
                double[] array10 = new double[num2];
                double[] array11 = new double[num2];
                Random random = new Random();
                int[] array12 = new int[assess_Info.number_sample];
                for (int m = 0; m < assess_Info.number_sample; m++)
                {
                    array12[m] = random.Next(0, newDTList.Count);
                }
                for (int n = 0; n < num2; n++)
                {
                    List<List<float?>> list3 = new List<List<float?>>();
                    List<List<float?>> list4 = new List<List<float?>>();
                    string[] array13 = assess_Info.assess[n].low_f.Split(',');
                    float?[] array14 = new float?[array13.Length];
                    float?[] array15 = new float?[num];
                    int num3 = -1;
                    for (int num4 = 0; num4 < array13.Length; num4++)
                    {
                        array14[num4] = (float)Convert.ToDouble(array13[num4]);
                        if (array14[num4] != 0f)
                        {
                            array7[n] = Convert.ToDouble(array13[num4]);
                            array8[n] = Convert.ToDouble(array13[num4]) * -1.0;
                            if ((bool)info.pointInfo[num4].type)
                            {
                                num3++;
                            }
                        }
                    }
                    for (int num5 = 0; num5 < assess_Info.number_sample; num5++)
                    {
                        List<float?> list5 = new List<float?>();
                        List<float?> list6 = new List<float?>();
                        int num6 = 0;
                        for (int num7 = 0; num7 < newDTList[array12[num5]].Count; num7++)
                        {
                            if ((bool)!info.pointInfo[num7].type)
                            {
                                list5.Add(newDTList[array12[num5]][num7] + array14[num7]);
                                continue;
                            }
                            list6.Add(newDTList[array12[num5]][num7] + array14[num7]);
                            array15[num6] = array14[num7];
                            num6++;
                        }
                        list3.Add(list5);
                        list4.Add(list6);
                    }
                    var value = new
                    {
                        Test_Data = list3,
                        Target_Data = list4
                    };
                    string inputInfo = JsonConvert.SerializeObject(value);
                    string value2 = Diagnosis(model, inputInfo);
                    Output1 output = JsonConvert.DeserializeObject<Output1>(value2);
                    if (!(output.msg == "OK"))
                    {
                        continue;
                    }
                    Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(output.paraState);
                    Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(output.errorData);
                    double num8 = 0.0;
                    double num9 = 0.0;
                    double num10 = 0.0;
                    double num11 = 0.0;
                    double num12 = 0.0;
                    string[] array16 = new string[matrix.RowCount];
                    for (int num13 = 0; num13 < matrix.RowCount; num13++)
                    {
                        array16[num13] = "";
                        for (int num14 = 0; num14 < matrix.ColumnCount; num14++)
                        {
                            if (matrix[num13, num14] == 1.0 && array15[num13] != 0f)
                            {
                                num9 += 1.0;
                            }
                            if (matrix[num13, num14] == 1.0 && array15[num13] == 0f)
                            {
                                num10 += 1.0;
                            }
                            if (array15[num13] != 0f)
                            {
                                num11 += 1.0;
                            }
                            if (array15[num13] == 0f)
                            {
                                num12 += 1.0;
                            }
                            ref string reference = ref array16[num13];
                            reference = reference + matrix[num13, num14] + ",";
                            if (num13 == num3)
                            {
                                num8 += Math.Abs(matrix2[num13, num14] - Convert.ToDouble(array15[num13]));
                            }
                        }
                    }
                    array9[n] = Convert.ToDouble((num9 / num11).ToString("0.0000"));
                    if (num12 != 0.0)
                    {
                        array10[n] = Convert.ToDouble((num10 / num12).ToString("0.0000"));
                    }
                    else
                    {
                        array10[n] = 0.0;
                    }
                    array11[n] = Convert.ToDouble((num8 / num11).ToString("0.0000"));
                }
                Assess_output assess_output = new Assess_output();
                Assess_output assess_output2 = new Assess_output();
                assess_output.Reconstruction_precision = array11;
                assess_output.fdr_variable = array9;
                assess_output.far_variable = array10;
                assess_output.amplitude = array7;
                assess_output2.Reconstruction_precision = array11;
                assess_output2.fdr_variable = array9;
                assess_output2.far_variable = array10;
                assess_output2.amplitude = array8;
                DateTime now3 = DateTime.Now;
                var value3 = new
                {
                    Positive = assess_output,
                    negative = assess_output2,
                    CleanTime = (now2 - now).TotalSeconds,
                    AssessTime = (now3 - now2).TotalSeconds,
                    message = message
                };
                return JsonConvert.SerializeObject(value3);
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                var value4 = new
                {
                    Positive = "",
                    negative = "",
                    CleanTime = 0,
                    AssessTime = 0,
                    message = message
                };
                return JsonConvert.SerializeObject(value4);
            }
        }

        public string Track(string model, string ST, string ET, string EXA_IP, int interval, out string rtn)
        {
            string result = "OK";
            DateTime now = DateTime.Now;
            string text = "";
            double num = 0.0;
            double num2 = 0.0;
            Info info = JsonConvert.DeserializeObject<Info>(model);
            int count = info.pointInfo.Count;
            try
            {
                string[] array = new string[count];
                for (int i = 0; i < count; i++)
                {
                    array[i] = info.pointInfo[i].PointId;
                }
                double limit = info.para.limit;
                List<int> Status = new List<int>();
                string text2 = "";
                text2 = ((info.alarmmodelset != null && !(info.alarmmodelset.alarmcondition.Trim() == "")) ? info.alarmmodelset.alarmcondition : "1=1");
                string text3 = EXA.CheckStatus(text2, ST, ET, interval, EXA_IP, out Status);
                if (text3 == "OK")
                {
                    List<List<double>> list = new List<List<double>>();
                    double[][] array2 = new double[array.Length][];
                    for (int j = 0; j < array.Length; j++)
                    {
                        string historySinglePoint = EXA.GetHistorySinglePoint(array[j], ST, ET, interval, EXA_IP);
                        List<double[]> list2 = JsonConvert.DeserializeObject<List<double[]>>(historySinglePoint);
                        List<double> list3 = new List<double>();
                        array2[j] = new double[list2.Count];
                        for (int k = 0; k < list2.Count; k++)
                        {
                            double num3 = list2[k][1];
                            list3.Add(num3);
                            array2[j][k] = num3;
                        }
                        list.Add(list3);
                    }
                    int num4 = array2[0].Count();
                    if (num4 > Status.Count)
                    {
                        num4 = Status.Count;
                    }
                    List<List<float?>> list4 = new List<List<float?>>();
                    List<List<float?>> list5 = new List<List<float?>>();
                    for (int l = 0; l < num4; l++)
                    {
                        List<float?> list6 = new List<float?>();
                        List<float?> list7 = new List<float?>();
                        for (int m = 0; m < array.Length; m++)
                        {
                            if ((bool)!info.pointInfo[m].type)
                            {
                                list6.Add((float)list[m][l]);
                            }
                            else
                            {
                                list7.Add((float)list[m][l]);
                            }
                        }
                        list4.Add(list6);
                        list5.Add(list7);
                    }
                    var value = new
                    {
                        Test_Data = list4,
                        Target_Data = list5
                    };
                    string inputInfo = JsonConvert.SerializeObject(value);
                    string value2 = Diagnosis(model, inputInfo);
                    Output1 output = JsonConvert.DeserializeObject<Output1>(value2);
                    bool flag = false;
                    DateTime dateTime = Convert.ToDateTime(ST);
                    DateTime dateTime2 = dateTime;
                    for (int n = 0; n < num4; n++)
                    {
                        if (Status[n] == 1)
                        {
                            num += 1.0;
                            if (output.Index[n] > limit)
                            {
                                num2 += 1.0;
                                if (!flag)
                                {
                                    dateTime2 = dateTime.AddSeconds(interval / 1000 * n);
                                    flag = true;
                                }
                            }
                            else if (flag)
                            {
                                text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * n).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * n) - dateTime2).TotalMinutes.ToString("0.0") + ";";
                                flag = false;
                            }
                            if (n == num4 - 1 && flag)
                            {
                                text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * n).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * n) - dateTime2).TotalMinutes.ToString("0.0") + ";";
                            }
                        }
                        else if (flag)
                        {
                            text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * n).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * n) - dateTime2).TotalMinutes.ToString("0.0") + ";";
                            flag = false;
                        }
                    }
                    num = num / (double)num4 * 100.0;
                    num2 = num2 * (double)interval / 60000.0;
                }
                else
                {
                    result = text3;
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            int alarmNumber = 0;
            List<List<string>> list8 = new List<List<string>>();
            if (text != "")
            {
                string[] array3 = (text + "$").Replace(";$", "").Split(';');
                alarmNumber = array3.Length;
                for (int num5 = 0; num5 < array3.Length; num5++)
                {
                    List<string> list9 = new List<string>();
                    list9.Add(array3[num5].Split(',')[0]);
                    list9.Add(array3[num5].Split(',')[1]);
                    list9.Add(array3[num5].Split(',')[2]);
                    list8.Add(list9);
                }
            }
            var value3 = new
            {
                Model_Name = info.name,
                Algorithm = info.algorithm,
                Dimension = count,
                CoveredPercent = num.ToString("0.0") + "%",
                AlarmDetail = list8,
                AlarmToatlMinutes = num2.ToString("0.0"),
                AlarmNumber = alarmNumber,
                CalcSeconds = (DateTime.Now - now).TotalSeconds.ToString("0.0")
            };
            rtn = JsonConvert.SerializeObject(value3);
            return result;
        }

        private int ConnectionDB(string DBIP, string DataBaseName, string PWD)
        {
            try
            {
                myConnectionString = "Data Source=" + DBIP + ";Initial Catalog=" + DataBaseName + ";User Id=sa;Password=" + PWD;
                myConnection = new SqlConnection(myConnectionString);
                myConnection.Open();
                return 1;
            }
            catch (SqlException)
            {
                return 0;
            }
        }
    }
}
