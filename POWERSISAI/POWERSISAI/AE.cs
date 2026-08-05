using MathNet.Numerics.LinearAlgebra;
using Newtonsoft.Json;
using RestSharp;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;


namespace POWERSISAI
{
    public class AE
    {
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

        public class ReviewOutput
        {
            public List<List<double>> sampleData { get; set; }

            public List<List<double>> reconData { get; set; }

            public List<List<double>> errorData { get; set; }

            public List<double> SPE { get; set; }

            public List<List<double>> paraState { get; set; }

            public string msg { get; set; }

            public string time { get; set; }
        }

        public class ItemInfo
        {
            public string ItemName { get; set; }

            public bool ClearDeadZone { get; set; }
        }

        public class RealState
        {
            public double[][] RealBias { get; set; }
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

        public class alarmmodelset
        {
            public string alarmname { get; set; }

            public string alarmcondition { get; set; }
        }

        public class para
        {
            public Model_info Model_info { get; set; }
        }

        public class PointInfoItem
        {
            public bool Lock { get; set; }

            public string PointId { get; set; }
        }

        public class Model_info
        {
            public List<double> maxdata { get; set; }

            public List<double> mindata { get; set; }

            public double sigma { get; set; }

            public double[][] v1 { get; set; }

            public double[][] v2 { get; set; }

            public double[][] w1 { get; set; }

            public double[][] w2 { get; set; }
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

        private string myConnectionString;

        private SqlConnection myConnection;

        private EXATools EXA = new EXATools();

        public string ClearDataEXA(string ItemsInfo, string SamplingTimePeriods, string Constraint, int SamplingPeriod, int DCount, string EXA_IP, out List<List<float?>> newDTList2)
        {
            DateTime JavaScriptStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
            newDTList2 = new List<List<float?>>();
            string rtnStr = "OK";
            try
            {
                if (ItemsInfo == null || ItemsInfo.Length == 0)
                {
                    return "";
                }
                if (SamplingTimePeriods == null || SamplingTimePeriods.Length == 0)
                {
                    return "";
                }
                List<CDItem> list = JsonConvert.DeserializeObject<List<CDItem>>(ItemsInfo);
                List<CDTimePeriod> list2 = JsonConvert.DeserializeObject<List<CDTimePeriod>>(SamplingTimePeriods);
                List<string> list3 = new List<string>();
                for (int i = 0; i < list.Count; i++)
                {
                    list3.Add(list[i].ItemName);
                }
                List<string> list4 = new List<string>();
                List<string> list5 = new List<string>();
                list4.AddRange(list3.ToArray());
                string pattern = "\\[(.*?)\\]";
                MatchCollection matchCollection = Regex.Matches(Constraint, pattern);
                for (int j = 0; j < matchCollection.Count; j++)
                {
                    bool flag = false;
                    for (int k = 0; k < list.Count; k++)
                    {
                        if (matchCollection[j].Value.Replace("[", "").Replace("]", "").Equals(list[k].ItemName))
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (!flag)
                    {
                        CDItem cDItem = new CDItem();
                        cDItem.ClearDeadZone = false;
                        cDItem.ItemName = matchCollection[j].Value.Replace("[", "").Replace("]", "");
                        list.Add(cDItem);
                    }
                    string item = matchCollection[j].Value.Replace("[", "").Replace("]", "");
                    if (!list4.Contains(item))
                    {
                        list5.Add(item);
                    }
                }
                List<string> list6 = new List<string>();
                for (int l = 0; l < list.Count; l++)
                {
                    list6.Add(list[l].ItemName);
                }
                if (list.Count == 0 || list2.Count == 0)
                {
                    return "";
                }
                Dictionary<string, bool> dictionary = new Dictionary<string, bool>();
                for (int m = 0; m < list.Count; m++)
                {
                    dictionary.Add(list[m].ItemName, list[m].ClearDeadZone);
                }
                string[] ItemNameArray = new string[list.Count];
                for (int n = 0; n < ItemNameArray.Length; n++)
                {
                    ItemNameArray[n] = list[n].ItemName;
                }
                DateTime StartingTime = list2[0].StartingTime;
                DateTime TerminalTime = list2[0].StartingTime;
                List<CDTimeStampPeriod> list7 = new List<CDTimeStampPeriod>();
                for (int num = 0; num < list2.Count; num++)
                {
                    if (list2[num].StartingTime < StartingTime)
                    {
                        StartingTime = list2[num].StartingTime;
                    }
                    if (list2[num].TerminalTime < StartingTime)
                    {
                        StartingTime = list2[num].TerminalTime;
                    }
                    if (list2[num].StartingTime > TerminalTime)
                    {
                        TerminalTime = list2[num].StartingTime;
                    }
                    if (list2[num].TerminalTime > StartingTime)
                    {
                        TerminalTime = list2[num].TerminalTime;
                    }
                    CDTimeStampPeriod cDTimeStampPeriod = new CDTimeStampPeriod();
                    cDTimeStampPeriod.StartingTimeStamp = (long)(list2[num].StartingTime.ToUniversalTime() - JavaScriptStartTime).TotalMilliseconds;
                    cDTimeStampPeriod.TerminalTimeStamp = (long)(list2[num].TerminalTime.ToUniversalTime() - JavaScriptStartTime).TotalMilliseconds;
                    list7.Add(cDTimeStampPeriod);
                }
                ConcurrentDictionary<string, List<float?>> ResultDictionary = new ConcurrentDictionary<string, List<float?>>();
                for (int num2 = 0; num2 < ItemNameArray.Length; num2++)
                {
                    ResultDictionary.TryAdd(ItemNameArray[num2], null);
                }
                List<long> TSList = new List<long>();
                Parallel.ForEach(ItemNameArray, delegate (string ItemName)
                {
                    SortedList<long, float?> sortedList = new SortedList<long, float?>();
                    RestClient restClient = new RestClient("http://" + EXA_IP + ":9000/exawebapi/exatime/GetRawValueArrayFloat?ItemName=" + ItemName + "&StartingTime=" + StartingTime.ToString() + "&TerminalTime=" + TerminalTime.ToString());
                    RestRequest request = new RestRequest("",Method.Get);

                  
                    RestResponse restResponse = restClient.Execute(request);
                    rtnStr = JsonConvert.DeserializeObject<string>(restResponse.Content);
                    List<object[]> list18 = JsonConvert.DeserializeObject<List<object[]>>(rtnStr);
                    for (int num19 = 0; num19 < list18.Count; num19++)
                    {
                        long key = (long)list18[num19][0];
                        float? value = (float)Convert.ToDouble(list18[num19][1]);
                        sortedList.Add(key, value);
                    }
                    int num20 = 0;
                    if (sortedList.Count > 0)
                    {
                        num20 = 1;
                    }
                    if (num20 == 1)
                    {
                        long num21 = (long)(StartingTime.ToUniversalTime() - JavaScriptStartTime).TotalMilliseconds;
                        long num22 = (long)(TerminalTime.ToUniversalTime() - JavaScriptStartTime).TotalMilliseconds;
                        SortedList<long, float?> sortedList2 = new SortedList<long, float?>();
                        long[] array2 = sortedList.Keys.ToArray();
                        int num23 = 0;
                        for (long num24 = num21; num24 <= num22; num24 += SamplingPeriod)
                        {
                            bool flag5 = false;
                            for (int num25 = num23; num25 < array2.Length - 1; num25++)
                            {
                                if (num24 >= array2[num25] && num24 < array2[num25 + 1])
                                {
                                    sortedList2.Add(num24, sortedList[array2[num25]]);
                                    num23 = num25;
                                    flag5 = true;
                                    break;
                                }
                            }
                            if (!flag5)
                            {
                                sortedList2.Add(num24, sortedList[array2[num23]]);
                            }
                        }
                        ResultDictionary[ItemName] = sortedList2.Values.ToList();
                        if (ItemName == ItemNameArray[0])
                        {
                            TSList = sortedList2.Keys.ToList();
                        }
                    }
                });
                List<bool> list8 = new List<bool>();
                int num3 = 0;
                for (int num4 = 0; num4 < TSList.Count; num4++)
                {
                    bool flag2 = false;
                    for (int num5 = 0; num5 < list7.Count; num5++)
                    {
                        if (TSList[num4] >= list7[num5].StartingTimeStamp && TSList[num4] <= list7[num5].TerminalTimeStamp)
                        {
                            flag2 = true;
                            break;
                        }
                    }
                    if (flag2)
                    {
                        num3++;
                    }
                    else
                    {
                        TSList[num4] = -num4;
                    }
                    list8.Add(flag2);
                }
                foreach (string key2 in dictionary.Keys)
                {
                    if (!dictionary[key2])
                    {
                        continue;
                    }
                    bool[] array = new bool[DCount];
                    for (int num6 = 0; num6 < DCount - 2; num6++)
                    {
                        array[num6] = (double)Math.Abs(ResultDictionary[key2][num6 + 1].Value - ResultDictionary[key2][num6].Value) < 1E-06;
                    }
                    for (int num7 = DCount; num7 < ResultDictionary[key2].Count; num7++)
                    {
                        bool flag3 = (double)Math.Abs(ResultDictionary[key2][num7].Value - ResultDictionary[key2][num7 - 1].Value) < 1E-06;
                        bool flag4 = true;
                        for (int num8 = 0; num8 < array.Length - 1; num8++)
                        {
                            flag4 = flag4 && array[num8];
                        }
                        if (flag4 && flag3)
                        {
                            for (int num9 = 0; num9 < DCount; num9++)
                            {
                                list8[num7 - num9 - 1] = false;
                            }
                        }
                        for (int num10 = 0; num10 < DCount - 1; num10++)
                        {
                            array[num10] = array[num10 + 1];
                        }
                        array[DCount - 1] = flag3;
                    }
                }
                List<long> list9 = new List<long>();
                List<List<float?>> list10 = new List<List<float?>>();
                List<Dictionary<string, float?>> list11 = new List<Dictionary<string, float?>>();
                for (int num11 = 0; num11 < TSList.Count; num11++)
                {
                    if (list8[num11])
                    {
                        Dictionary<string, float?> dictionary2 = new Dictionary<string, float?>();
                        foreach (string key3 in ResultDictionary.Keys)
                        {
                            dictionary2.Add(key3, ResultDictionary[key3][num11]);
                        }
                        list11.Add(dictionary2);
                    }
                    else
                    {
                        list11.Add(null);
                    }
                }
                Constraint = Constraint.Replace("[", "D[");
                Constraint = Constraint.Replace("[", "[\"").Replace("]", "\"]").Replace(" and ", " && ")
                    .Replace(" or ", " || ");
                Func<Dictionary<string, float?>, bool> func = null;
                Microsoft.CSharp.CSharpCodeProvider cSharpCodeProvider = new Microsoft.CSharp.CSharpCodeProvider();
                CompilerParameters compilerParameters = new CompilerParameters();
                try
                {
                    compilerParameters.GenerateInMemory = true;
                    compilerParameters.GenerateExecutable = false;
                    StringBuilder stringBuilder = new StringBuilder();
                    stringBuilder.AppendLine("using System;");
                    stringBuilder.AppendLine("using System.Collections;");
                    stringBuilder.AppendLine("using System.Collections.Generic;");
                    stringBuilder.AppendLine("using System.Diagnostics;");
                    stringBuilder.AppendLine("namespace RunExpression");
                    stringBuilder.AppendLine("{");
                    stringBuilder.AppendLine("public class Expression");
                    stringBuilder.AppendLine("{");
                    stringBuilder.AppendLine("public bool Run(Dictionary<string,float?> D)");
                    stringBuilder.AppendLine("{");
                    stringBuilder.AppendLine("return " + Constraint + ";");
                    stringBuilder.AppendLine("}");
                    stringBuilder.AppendLine("}");
                    stringBuilder.AppendLine("}");
                    CompilerResults compilerResults = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, stringBuilder.ToString());
                    Assembly compiledAssembly = cSharpCodeProvider.CompileAssemblyFromSource(compilerParameters, stringBuilder.ToString()).CompiledAssembly;
                    func = (Func<Dictionary<string, float?>, bool>)compiledAssembly.GetType("RunExpression.Expression").GetMethod("Run").CreateDelegate(typeof(Func<Dictionary<string, float?>, bool>), compiledAssembly.CreateInstance("RunExpression.Expression"));
                }
                catch (Exception)
                {
                    func = null;
                }
                finally
                {
                    cSharpCodeProvider.Dispose();
                    compilerParameters = null;
                }
                if (func == null)
                {
                    return "";
                }
                List<long> list12 = new List<long>();
                List<List<float?>> list13 = new List<List<float?>>();
                List<int> list14 = new List<int>();
                for (int num12 = 0; num12 < ItemNameArray.Length; num12++)
                {
                    List<float?> item2 = new List<float?>();
                    list13.Add(item2);
                }
                for (int num13 = 0; num13 < ItemNameArray.Length; num13++)
                {
                    if (list5.Contains(ItemNameArray[num13]))
                    {
                        list14.Add(num13);
                    }
                }
                for (int num14 = 0; num14 < TSList.Count; num14++)
                {
                    if (list8[num14] && !func(list11[num14]))
                    {
                        list8[num14] = false;
                    }
                    if (!list8[num14] && TSList[num14] > 0)
                    {
                        list9.Add(TSList[num14]);
                        List<float?> list15 = new List<float?>();
                        foreach (string item3 in list3)
                        {
                            list15.Add(ResultDictionary[item3][num14]);
                        }
                        list10.Add(list15);
                    }
                    if (list8[num14])
                    {
                        list12.Add(TSList[num14]);
                        for (int num15 = 0; num15 < list3.Count; num15++)
                        {
                            list13[num15].Add(ResultDictionary[list3[num15]][num14]);
                        }
                    }
                }
                List<List<float?>> list16 = new List<List<float?>>();
                for (int num16 = 0; num16 < list13.Count; num16++)
                {
                    if (!list14.Contains(num16))
                    {
                        list16.Add(list13[num16]);
                    }
                }
                for (int num17 = 0; num17 < list16[0].Count; num17++)
                {
                    List<float?> list17 = new List<float?>();
                    for (int num18 = 0; num18 < list16.Count; num18++)
                    {
                        list17.Add(list16[num18][num17]);
                    }
                    newDTList2.Add(list17);
                }
                var anon = new
                {
                    Test_Data = newDTList2
                };
            }
            catch (Exception)
            {
                rtnStr = "";
            }
            return rtnStr;
        }

        public string Diagnosis(string model, string InputInfo)
        {
            Info info = JsonConvert.DeserializeObject<Info>(model);
            Input input = JsonConvert.DeserializeObject<Input>(InputInfo);
            int num = input.Test_Data.Length;
            Output output = new Output();
            List<List<double>> list = new List<List<double>>();
            List<List<double>> list2 = new List<List<double>>();
            List<List<double>> list3 = new List<List<double>>();
            List<double> list4 = new List<double>();
            string text = "";
            int count = info.pointInfo.Count;
            for (int i = 0; i < num; i++)
            {
                double[] array = input.Test_Data[i];
                double[] outputValue = new double[count];
                string text2 = AANN_fit(info, array, out outputValue, out var IndexValue);
                List<double> list5 = new List<double>();
                List<double> list6 = new List<double>();
                List<double> list7 = new List<double>();
                if (IndexValue > info.para.Model_info.sigma)
                {
                    double[] ReconData = new double[count];
                    double[] ParaState = new double[count];
                    text2 = SF_RB_AANN(info, array, IndexValue, out ReconData, out ParaState);
                    if (text2 == "OK")
                    {
                        for (int j = 0; j < input.Test_Data[i].Length; j++)
                        {
                            double num2 = 0.5 * (ReconData[j] * (info.para.Model_info.maxdata[j] - info.para.Model_info.mindata[j]) + info.para.Model_info.maxdata[j] + info.para.Model_info.mindata[j]);
                            list5.Add(num2);
                            list6.Add(array[j] - num2);
                            list7.Add(ParaState[j]);
                        }
                    }
                    else
                    {
                        text = text + ",第[" + i + "]个样本出现错误：" + text2;
                        for (int k = 0; k < input.Test_Data[i].Length; k++)
                        {
                            list5.Add(array[k]);
                            list6.Add(0.0);
                            list7.Add(0.0);
                        }
                    }
                }
                else
                {
                    for (int l = 0; l < input.Test_Data[i].Length; l++)
                    {
                        list5.Add(array[l]);
                        list6.Add(0.0);
                        list7.Add(0.0);
                    }
                }
                list.Add(list5);
                list2.Add(list6);
                list3.Add(list7);
                list4.Add(IndexValue);
            }
            text = ((!(text == "")) ? ("出现错误" + text) : "OK");
            output.reconData = list;
            output.errorData = list2;
            output.paraState = list3;
            output.Index = list4;
            output.msg = text;
            return JsonConvert.SerializeObject(output);
        }

        public string GetHistory(string pointCode, string st, string et, int interval, string EXA_IP)
        {
            string result = "";
            try
            {
                RestClient restClient = new RestClient("http://" + EXA_IP + ":9000/exawebapi/exatime/GetSamplingValueArrayFloat");
                RestRequest restRequest = new RestRequest("", Method.Get);
                restRequest.AddHeader("Content-Type", "application/json;charset=utf-8");
                restRequest.AddParameter("itemName", pointCode);
                restRequest.AddParameter("StartingTime", st);
                restRequest.AddParameter("TerminalTime", et);
                restRequest.AddParameter("SamplingPeriod", interval);
                RestResponse restResponse = restClient.Execute(restRequest);
                string text = restResponse.Content.Replace("\"", "");
                result = text;
            }
            catch
            {
            }
            return result;
        }

        public string Assess_PositiveAndNegative(string model, string InputInfo, string EXA_IP)
        {
            DateTime now = DateTime.Now;
            string message = "OK";
            string text = "";
            try
            {
                Info info = JsonConvert.DeserializeObject<Info>(model);
                Assess_Info assess_Info = JsonConvert.DeserializeObject<Assess_Info>(InputInfo);
                int count = info.pointInfo.Count;
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
                for (int i = 0; i < count; i++)
                {
                    ItemInfo itemInfo = new ItemInfo();
                    itemInfo.ItemName = array2[i];
                    if (array[i].Trim() == "1")
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
                for (int j = 0; j < array3.Length; j++)
                {
                    CDTimePeriod cDTimePeriod = new CDTimePeriod();
                    string[] array4 = array3[j].Split(',');
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
                for (int k = 0; k < array5.Length; k++)
                {
                    if (array5[k].Trim() == "1")
                    {
                        text2 = text2 + " and ([" + array2[k] + "]<" + array6[k].Split(',')[1] + " and [" + array2[k] + "]>" + array6[k].Split(',')[0] + ")";
                    }
                }
                List<List<float?>> newDTList = new List<List<float?>>();
                string text3 = ClearDataEXA(itemsInfo, samplingTimePeriods, text2, interval, dCount, EXA_IP, out newDTList);
                DateTime now2 = DateTime.Now;
                int num = assess_Info.assess.Length;
                double[] array7 = new double[num];
                double[] array8 = new double[num];
                double[] array9 = new double[num];
                double[] array10 = new double[num];
                double[] array11 = new double[num];
                double[] array12 = new double[num];
                double[] array13 = new double[num];
                double[] array14 = new double[num];
                Random random = new Random();
                int[] array15 = new int[assess_Info.number_sample];
                for (int l = 0; l < assess_Info.number_sample; l++)
                {
                    array15[l] = random.Next(0, newDTList.Count);
                }
                for (int m = 0; m < num; m++)
                {
                    List<List<float?>> list3 = new List<List<float?>>();
                    List<List<float?>> list4 = new List<List<float?>>();
                    string[] array16 = assess_Info.assess[m].low_f.Split(',');
                    float?[] array17 = new float?[array16.Length];
                    int num2 = 0;
                    for (int n = 0; n < array16.Length; n++)
                    {
                        array17[n] = (float)Convert.ToDouble(array16[n]);
                        if (array17[n] != 0f)
                        {
                            num2 = n;
                            array7[m] = Convert.ToDouble(array16[n]);
                            array11[m] = Convert.ToDouble(array16[n]) * -1.0;
                        }
                    }
                    for (int num3 = 0; num3 < assess_Info.number_sample; num3++)
                    {
                        List<float?> list5 = new List<float?>();
                        List<float?> list6 = new List<float?>();
                        for (int num4 = 0; num4 < newDTList[array15[num3]].Count; num4++)
                        {
                            list5.Add(newDTList[array15[num3]][num4] + array17[num4]);
                            list6.Add(newDTList[array15[num3]][num4] - array17[num4]);
                        }
                        list3.Add(list5);
                        list4.Add(list6);
                    }
                    var value = new
                    {
                        Test_Data = list3
                    };
                    var value2 = new
                    {
                        Test_Data = list4
                    };
                    string inputInfo = JsonConvert.SerializeObject(value);
                    string inputInfo2 = JsonConvert.SerializeObject(value2);
                    string value3 = Diagnosis(model, inputInfo);
                    string value4 = Diagnosis(model, inputInfo2);
                    Output1 output = JsonConvert.DeserializeObject<Output1>(value3);
                    Output1 output2 = JsonConvert.DeserializeObject<Output1>(value4);
                    if (output.msg == "OK")
                    {
                        Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(output.paraState);
                        Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(output.errorData);
                        double num5 = 0.0;
                        double num6 = 0.0;
                        double num7 = 0.0;
                        double num8 = 0.0;
                        double num9 = 0.0;
                        string[] array18 = new string[matrix.RowCount];
                        for (int num10 = 0; num10 < matrix.RowCount; num10++)
                        {
                            array18[num10] = "";
                            for (int num11 = 0; num11 < matrix.ColumnCount; num11++)
                            {
                                if (matrix[num10, num11] == 1.0 && array17[num10] != 0f)
                                {
                                    num6 += 1.0;
                                }
                                if (matrix[num10, num11] == 1.0 && array17[num10] == 0f)
                                {
                                    num7 += 1.0;
                                }
                                if (array17[num10] != 0f)
                                {
                                    num8 += 1.0;
                                }
                                if (array17[num10] == 0f)
                                {
                                    num9 += 1.0;
                                }
                                ref string reference = ref array18[num10];
                                reference = reference + matrix[num10, num11] + ",";
                                if (num10 == num2)
                                {
                                    num5 += Math.Abs(matrix2[num10, num11] - Convert.ToDouble(array17[num10]));
                                }
                            }
                        }
                        array8[m] = Convert.ToDouble((num6 / num8).ToString("0.0000"));
                        array9[m] = Convert.ToDouble((num7 / num9).ToString("0.0000"));
                        array10[m] = Convert.ToDouble((num5 / num8).ToString("0.0000"));
                    }
                    if (!(output2.msg == "OK"))
                    {
                        continue;
                    }
                    Matrix<double> matrix3 = Matrix<double>.Build.DenseOfColumnArrays(output2.paraState);
                    Matrix<double> matrix4 = Matrix<double>.Build.DenseOfColumnArrays(output2.errorData);
                    double num12 = 0.0;
                    double num13 = 0.0;
                    double num14 = 0.0;
                    double num15 = 0.0;
                    double num16 = 0.0;
                    string[] array19 = new string[matrix3.RowCount];
                    for (int num17 = 0; num17 < matrix3.RowCount; num17++)
                    {
                        array19[num17] = "";
                        for (int num18 = 0; num18 < matrix3.ColumnCount; num18++)
                        {
                            if (matrix3[num17, num18] == 1.0 && array17[num17] != 0f)
                            {
                                num13 += 1.0;
                            }
                            if (matrix3[num17, num18] == 1.0 && array17[num17] == 0f)
                            {
                                num14 += 1.0;
                            }
                            if (array17[num17] != 0f)
                            {
                                num15 += 1.0;
                            }
                            if (array17[num17] == 0f)
                            {
                                num16 += 1.0;
                            }
                            ref string reference2 = ref array19[num17];
                            reference2 = reference2 + matrix3[num17, num18] + ",";
                            if (num17 == num2)
                            {
                                num12 += Math.Abs(matrix4[num17, num18] + Convert.ToDouble(array17[num17]));
                            }
                        }
                    }
                    array12[m] = Convert.ToDouble((num13 / num15).ToString("0.0000"));
                    array13[m] = Convert.ToDouble((num14 / num16).ToString("0.0000"));
                    array14[m] = Convert.ToDouble((num12 / num15).ToString("0.0000"));
                }
                Assess_output assess_output = new Assess_output();
                Assess_output assess_output2 = new Assess_output();
                assess_output.Reconstruction_precision = array10;
                assess_output.fdr_variable = array8;
                assess_output.far_variable = array9;
                assess_output.amplitude = array7;
                assess_output2.Reconstruction_precision = array14;
                assess_output2.fdr_variable = array12;
                assess_output2.far_variable = array13;
                assess_output2.amplitude = array11;
                DateTime now3 = DateTime.Now;
                var value5 = new
                {
                    Positive = assess_output,
                    negative = assess_output2,
                    CleanTime = (now2 - now).TotalSeconds,
                    AssessTime = (now3 - now2).TotalSeconds,
                    message = message
                };
                return JsonConvert.SerializeObject(value5);
            }
            catch (Exception ex)
            {
                message = ex.ToString();
                var value6 = new
                {
                    Positive = "",
                    negative = "",
                    CleanTime = 0,
                    AssessTime = 0,
                    message = message
                };
                return JsonConvert.SerializeObject(value6);
            }
        }

        public string Review(string model, string InputInfo, string EXA_IP)
        {
            ReviewOutput reviewOutput = new ReviewOutput();
            string msg = "OK";
            try
            {
                Review_Info review_Info = JsonConvert.DeserializeObject<Review_Info>(InputInfo);
                string[] array = review_Info.Test_Data.points.Split(',');
                double[] array2 = new double[array.Length];
                string text = "";
                string text2 = "";
                double num = 0.0;
                double num2 = 0.0;
                string text3 = review_Info.Test_Data.time.Split(',')[0];
                string et = review_Info.Test_Data.time.Split(',')[1];
                reviewOutput.time = text3;
                if (review_Info.Test_Data.AddBias != null && review_Info.Test_Data.AddBias_Time != null)
                {
                    text = review_Info.Test_Data.AddBias_Time.Split(',')[0];
                    text2 = review_Info.Test_Data.AddBias_Time.Split(',')[1];
                    num = (Convert.ToDateTime(text) - Convert.ToDateTime(text3)).TotalMilliseconds / Convert.ToDouble(review_Info.Test_Data.interval.ToString());
                    num2 = (Convert.ToDateTime(text2) - Convert.ToDateTime(text3)).TotalMilliseconds / Convert.ToDouble(review_Info.Test_Data.interval.ToString());
                    array2 = review_Info.Test_Data.AddBias;
                }
                List<List<double>> list = new List<List<double>>();
                double[][] array3 = new double[array.Length][];
                for (int i = 0; i < array.Length; i++)
                {
                    string historySinglePoint = EXA.GetHistorySinglePoint(array[i], text3, et, review_Info.Test_Data.interval, EXA_IP);
                    List<double[]> list2 = JsonConvert.DeserializeObject<List<double[]>>(historySinglePoint);
                    List<double> list3 = new List<double>();
                    array3[i] = new double[list2.Count];
                    for (int j = 0; j < list2.Count; j++)
                    {
                        double num3 = list2[j][1];
                        if ((double)j > num && (double)j < num2)
                        {
                            num3 += array2[i];
                        }
                        list3.Add(num3);
                        array3[i][j] = num3;
                    }
                    list.Add(list3);
                }
                reviewOutput.sampleData = list;
                double[][] array4 = new double[array3[0].Length][];
                for (int k = 0; k < array3[0].Length; k++)
                {
                    array4[k] = new double[array.Length];
                    for (int l = 0; l < array.Length; l++)
                    {
                        array4[k][l] = array3[l][k];
                    }
                }
                Input input = new Input();
                input.Test_Data = array4;
                string inputInfo = JsonConvert.SerializeObject(input);
                inputInfo = Diagnosis(model, inputInfo);
                Output output = JsonConvert.DeserializeObject<Output>(inputInfo);
                reviewOutput.paraState = output.paraState;
                reviewOutput.SPE = output.Index;
                List<List<double>> list4 = new List<List<double>>();
                List<List<double>> list5 = new List<List<double>>();
                for (int m = 0; m < array.Length; m++)
                {
                    List<double> list6 = new List<double>();
                    List<double> list7 = new List<double>();
                    for (int n = 0; n < array3[0].Length; n++)
                    {
                        list6.Add(output.reconData[n][m]);
                        list7.Add(output.errorData[n][m]);
                    }
                    list4.Add(list6);
                    list5.Add(list7);
                }
                reviewOutput.reconData = list4;
                reviewOutput.errorData = list5;
            }
            catch (Exception ex)
            {
                msg = ex.ToString();
            }
            reviewOutput.msg = msg;
            return JsonConvert.SerializeObject(reviewOutput);
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
                double sigma = info.para.Model_info.sigma;
                List<int> Status = new List<int>();
                string text2 = "";
                text2 = ((info.alarmmodelset != null && !(info.alarmmodelset.alarmcondition.Trim() == "")) ? info.alarmmodelset.alarmcondition : "1=1");
                string text3 = CheckStatus(text2, ST, ET, interval, EXA_IP, out Status);
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
                    bool flag = false;
                    DateTime dateTime = Convert.ToDateTime(ST);
                    DateTime dateTime2 = dateTime;
                    for (int l = 0; l < num4; l++)
                    {
                        if (Status[l] == 1)
                        {
                            num += 1.0;
                            double[] array3 = new double[array.Length];
                            for (int m = 0; m < array.Length; m++)
                            {
                                array3[m] = array2[m][l];
                            }
                            double[] outputValue = new double[count];
                            double IndexValue;
                            string text4 = AANN_fit(info, array3, out outputValue, out IndexValue);
                            if (IndexValue > sigma)
                            {
                                num2 += 1.0;
                                if (!flag)
                                {
                                    dateTime2 = dateTime.AddSeconds(interval / 1000 * l);
                                    flag = true;
                                }
                            }
                            else if (flag)
                            {
                                text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * l).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * l) - dateTime2).TotalMinutes.ToString("0.0") + ";";
                                flag = false;
                            }
                            if (l == num4 - 1 && flag)
                            {
                                text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * l).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * l) - dateTime2).TotalMinutes.ToString("0.0") + ";";
                            }
                        }
                        else if (flag)
                        {
                            text = text + dateTime2.ToString() + "," + dateTime.AddSeconds(interval / 1000 * l).ToString() + "," + (dateTime.AddSeconds(interval / 1000 * l) - dateTime2).TotalMinutes.ToString("0.0") + ";";
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
            List<List<string>> list4 = new List<List<string>>();
            if (text != "")
            {
                string[] array4 = (text + "$").Replace(";$", "").Split(';');
                alarmNumber = array4.Length;
                for (int n = 0; n < array4.Length; n++)
                {
                    List<string> list5 = new List<string>();
                    list5.Add(array4[n].Split(',')[0]);
                    list5.Add(array4[n].Split(',')[1]);
                    list5.Add(array4[n].Split(',')[2]);
                    list4.Add(list5);
                }
            }
            var value = new
            {
                Model_Name = info.name,
                Algorithom = info.algorithm,
                Dimension = count,
                CoveredPercent = num.ToString("0.0") + "%",
                AlarmDetail = list4,
                AlarmToatlMinutes = num2.ToString("0.0"),
                AlarmNumber = alarmNumber,
                CalcSeconds = (DateTime.Now - now).TotalSeconds.ToString("0.0")
            };
            rtn = JsonConvert.SerializeObject(value);
            return result;
        }

        public string CheckStatus(string logic, string ST, string ET, int interval, string EXA_IP, out List<int> Status)
        {
            string result = "OK";
            Status = new List<int>();
            try
            {
                string text = "";
                string text2 = "";
                bool flag = false;
                int length = logic.Length;
                for (int i = 0; i < length; i++)
                {
                    if (logic[i] == '[')
                    {
                        flag = true;
                    }
                    else if (logic[i] == ']')
                    {
                        flag = false;
                        text2 = text2 + text + ",";
                        text = "";
                    }
                    else if (flag)
                    {
                        text += logic[i];
                    }
                }
                text2 = (text2 + "*").Replace(",*", "").Replace("*", "");
                if (text2.Length > 0)
                {
                    string[] array = text2.Split(',');
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
                            double num = list2[k][1];
                            list3.Add(num);
                            array2[j][k] = num;
                        }
                        list.Add(list3);
                    }
                    for (int l = 0; l < array2[0].Length; l++)
                    {
                        string text3 = logic;
                        double[] array3 = new double[array.Length];
                        for (int m = 0; m < array.Length; m++)
                        {
                            array3[m] = array2[m][l];
                        }
                        for (int n = 0; n < array.Length; n++)
                        {
                            text3 = text3.Replace(array[n], array3[n].ToString());
                        }
                        text3 = text3.Replace("[", "").Replace("]", "").Replace("\n", " ");
                        DataTable dataTable = new DataTable();
                        bool flag2 = true;
                        object value = dataTable.Compute(text3, "");
                        if (Convert.ToBoolean(value))
                        {
                            Status.Add(1);
                        }
                        else
                        {
                            Status.Add(0);
                        }
                    }
                }
                else
                {
                    DataTable dataTable2 = new DataTable();
                    bool flag3 = true;
                    object value2 = dataTable2.Compute(logic, "");
                    if (Convert.ToBoolean(value2))
                    {
                        Status.Add(1);
                    }
                    else
                    {
                        Status.Add(0);
                    }
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }

        private string AANN_fit(Info model_Info, double[] inputValue, out double[] outputValue, out double IndexValue)
        {
            string result = "OK";
            outputValue = new double[inputValue.Length];
            IndexValue = 0.0;
            try
            {
                Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.v1);
                Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.v2);
                Matrix<double> matrix3 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.w1);
                Matrix<double> matrix4 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.w2);
                int count = model_Info.pointInfo.Count;
                double sigma = model_Info.para.Model_info.sigma;
                double[] array = new double[inputValue.Length];
                for (int i = 0; i < inputValue.Length; i++)
                {
                    array[i] = (inputValue[i] * 2.0 - model_Info.para.Model_info.maxdata[i] - model_Info.para.Model_info.mindata[i]) / (model_Info.para.Model_info.maxdata[i] - model_Info.para.Model_info.mindata[i]);
                }
                Matrix<double> matrix5 = Matrix<double>.Build.DenseOfColumnArrays(array).Transpose();
                Matrix<double> mdata1 = matrix5 * matrix.Transpose();
                Matrix<double> matrix6 = Matrix<double>.Build.Dense(mdata1.RowCount, mdata1.ColumnCount, (int p, int q) => 1.0 / (1.0 + Math.Exp(0.0 - mdata1[p, q])));
                Matrix<double> mdata2 = matrix6 * matrix3.Transpose() * matrix2.Transpose();
                Matrix<double> matrix7 = Matrix<double>.Build.Dense(mdata2.RowCount, mdata2.ColumnCount, (int p, int q) => 1.0 / (1.0 + Math.Exp(0.0 - mdata2[p, q])));
                Matrix<double> matrix8 = matrix7 * matrix4.Transpose();
                for (int j = 0; j < inputValue.Length; j++)
                {
                    outputValue[j] = matrix8[0, j] * (model_Info.para.Model_info.maxdata[j] - model_Info.para.Model_info.mindata[j]) + model_Info.para.Model_info.maxdata[j] + model_Info.para.Model_info.mindata[j];
                    outputValue[j] /= 2.0;
                }
                IndexValue = ((matrix5 - matrix8) * (matrix5 - matrix8).Transpose())[0, 0];
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            return result;
        }

        private string SF_RB_AANN(Info model_Info, double[] inputValue, double Index, out double[] ReconData, out double[] ParaState)
        {
            string result = "OK";
            bool[] array = new bool[model_Info.pointInfo.Count];
            for (int j = 0; j < model_Info.pointInfo.Count; j++)
            {
                array[j] = model_Info.pointInfo[j].Lock;
            }
            double sigma = model_Info.para.Model_info.sigma;
            int num = array.Length;
            double[] array2 = new double[inputValue.Length];
            for (int k = 0; k < inputValue.Length; k++)
            {
                array2[k] = (inputValue[k] * 2.0 - model_Info.para.Model_info.maxdata[k] - model_Info.para.Model_info.mindata[k]) / (model_Info.para.Model_info.maxdata[k] - model_Info.para.Model_info.mindata[k]);
            }
            Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(array2);
            Vector<double> vector = Vector<double>.Build.Dense(num, (int i) => i);
            Vector<double> vector2 = Vector<double>.Build.Dense(num, (int i) => 0.0);
            Matrix<double> matrix2 = Matrix<double>.Build.DenseOfMatrix(matrix);
            Matrix<double> matrix3 = Matrix<double>.Build.DenseOfMatrix(matrix);
            ReconData = new double[num];
            try
            {
                for (double num2 = 0.0; num2 < (double)num; num2 += 1.0)
                {
                    string text = "";
                    string text2 = "";
                    int num3 = 0;
                    for (int l = 0; l < num; l++)
                    {
                        if (!array[l])
                        {
                            if (vector2[l] == 1.0)
                            {
                                text = text + l + ",";
                                continue;
                            }
                            text2 = text2 + l + ",";
                            num3++;
                        }
                    }
                    if (text != "")
                    {
                        text = (text + "$").Replace(",$", "");
                    }
                    if (text2 != "")
                    {
                        text2 = (text2 + "$").Replace(",$", "");
                    }
                    string[] array3 = text2.Split(',');
                    Vector<double> vector3 = Vector<double>.Build.Dense(num3);
                    double num4 = Index;
                    Matrix<double> matrix4 = Matrix<double>.Build.DenseOfMatrix(matrix);
                    Matrix<double> matrix5 = Matrix<double>.Build.DenseOfMatrix(matrix);
                    int index = 0;
                    for (int m = 0; m < num3; m++)
                    {
                        string text3 = "";
                        text3 = ((!(text != "")) ? array3[m] : (text + "," + array3[m]));
                        string[] array4 = text3.Split(',');
                        int[] array5 = new int[array4.Length];
                        for (int n = 0; n < array4.Length; n++)
                        {
                            array5[n] = Convert.ToInt32(array4[n].ToString().Trim());
                        }
                        double[] fault_Magnitude = new double[num];
                        double IndexValue = Index;
                        string text4 = RBAANN_steffensen(model_Info, array2, Index, array5, out IndexValue, out fault_Magnitude);
                        vector3[m] = IndexValue;
                        if (m == 0)
                        {
                            num4 = vector3[m];
                            matrix5 = Matrix<double>.Build.DenseOfColumnArrays(fault_Magnitude);
                            matrix4 = matrix - matrix5;
                            index = Convert.ToInt32(array3[m].Trim());
                        }
                        else if (num4 > vector3[m])
                        {
                            num4 = vector3[m];
                            matrix5 = Matrix<double>.Build.DenseOfColumnArrays(fault_Magnitude);
                            matrix4 = matrix - matrix5;
                            index = Convert.ToInt32(array3[m].Trim());
                        }
                    }
                    if (num4 < sigma)
                    {
                        matrix2 = matrix4;
                        matrix3 = matrix5;
                        vector2[index] = 1.0;
                        break;
                    }
                    vector2[index] = 1.0;
                }
            }
            catch (Exception ex)
            {
                result = ex.ToString();
            }
            ReconData = matrix2.AsColumnMajorArray();
            ParaState = vector2.AsArray();
            return result;
        }

        private string RBAANN_steffensen(Info model_Info, double[] inputValue, double Index, int[] fault_direction, out double IndexValue, out double[] fault_Magnitude)
        {
            string result = "OK";
            Matrix<double> matrix = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.v1);
            Matrix<double> matrix2 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.v2);
            Matrix<double> matrix3 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.w1);
            Matrix<double> matrix4 = Matrix<double>.Build.DenseOfColumnArrays(model_Info.para.Model_info.w2);
            int count = model_Info.pointInfo.Count;
            double sigma = model_Info.para.Model_info.sigma;
            IndexValue = 0.0;
            fault_Magnitude = new double[count];
            int num = 50;
            int num2 = 0;
            int num3 = 0;
            Matrix<double> matrix5 = Matrix<double>.Build.Dense(1, count);
            Matrix<double> matrix6 = Matrix<double>.Build.Dense(num + 1, count);
            Matrix<double> matrix7 = Matrix<double>.Build.Dense(1, count);
            Matrix<double> matrix8 = Matrix<double>.Build.DenseOfColumnArrays(inputValue).Transpose();
            Matrix<double> matrix9 = Matrix<double>.Build.DenseOfColumnArrays(inputValue).Transpose();
            double[] array = new double[num + 1];
            Matrix<double> matrix10 = Matrix<double>.Build.Dense(3, count);
            try
            {
                Matrix<double> mdata1;
                Matrix<double> mdata2;
                while (true)
                {
                    matrix9 -= matrix6.SubMatrix(num2, 1, 0, count);
                    for (int i = 0; i < 2; i++)
                    {
                        try
                        {
                            matrix8 = matrix9 - matrix10.SubMatrix(i, 1, 0, count);
                            mdata1 = matrix8 * matrix.Transpose();
                            Matrix<double> matrix11 = Matrix<double>.Build.Dense(mdata1.RowCount, mdata1.ColumnCount, (int p, int q) => 1.0 / (1.0 + Math.Exp(0.0 - mdata1[p, q])));
                            mdata2 = matrix11 * matrix3.Transpose() * matrix2.Transpose();
                            Matrix<double> matrix12 = Matrix<double>.Build.Dense(mdata2.RowCount, mdata2.ColumnCount, (int p, int q) => 1.0 / (1.0 + Math.Exp(0.0 - mdata2[p, q])));
                            Matrix<double> matrix13 = matrix12 * matrix4.Transpose();
                            Matrix<double> matrix14 = matrix8 - matrix13;
                            array[num2] = (matrix14 * matrix14.Transpose())[0, 0];
                            for (int j = 0; j < fault_direction.Length; j++)
                            {
                                Matrix<double> other = (matrix11 - matrix11.PointwiseMultiply(matrix11)).PointwiseMultiply(-matrix.Transpose().SubMatrix(fault_direction[j], 1, 0, matrix.RowCount)) * matrix3.Transpose() * matrix2.Transpose();
                                Matrix<double> matrix15 = (matrix12 - matrix12.PointwiseMultiply(matrix12)).PointwiseMultiply(other) * matrix4.Transpose();
                                Matrix<double> matrix16 = matrix15.Transpose();
                                Matrix<double> matrix17 = matrix9 - matrix13;
                                try
                                {
                                    switch (i)
                                    {
                                        case 0:
                                            matrix10[1, fault_direction[j]] = 0.5 * (2.0 * (matrix17 * matrix16).ColumnSums()[0] + 2.0 * (matrix17[0, fault_direction[j]] - matrix16[fault_direction[j], 0] * matrix6[num2, fault_direction[j]]));
                                            break;
                                        case 1:
                                            matrix10[2, fault_direction[j]] = 0.5 * (2.0 * (matrix17 * matrix16).ColumnSums()[0] + 2.0 * (matrix17[0, fault_direction[j]] - matrix16[fault_direction[j], 0] * matrix10[1, fault_direction[j]]));
                                            matrix6[num2 + 1, fault_direction[j]] = matrix6[num2, fault_direction[j]] - (matrix10[1, fault_direction[j]] - matrix6[num2, fault_direction[j]]) * (matrix10[1, fault_direction[j]] - matrix6[num2, fault_direction[j]]) / (matrix10[2, fault_direction[j]] - 2.0 * matrix10[1, fault_direction[j]] + matrix6[num2, fault_direction[j]]);
                                            matrix10[0, fault_direction[j]] = matrix6[num2 + 1, fault_direction[j]];
                                            break;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    result = ex.ToString();
                                }
                            }
                        }
                        catch (Exception ex2)
                        {
                            result = ex2.ToString();
                        }
                    }
                    if (num2 >= 1 && (num2 >= num - 1 || Math.Abs(array[num2] - array[num2 - 1]) < 1E-05))
                    {
                        break;
                    }
                    num2++;
                }
                num3 = num2;
                IndexValue = array[num3];
                fault_Magnitude = matrix6.ColumnSums().ToArray();
            }
            catch (Exception ex3)
            {
                result = ex3.ToString();
            }
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
