using System;
using System.CodeDom.Compiler;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Microsoft.CSharp;
using Newtonsoft.Json;
using RestSharp;

namespace POWERSISAI
{
	public class EXATools
	{
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

		public string GetHistorySinglePoint(string pointCode, string st, string et, int interval, string EXA_IP)
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

		public string ClearDataEXA(string ItemsInfo, string SamplingTimePeriods, string Constraint, int SamplingPeriod, int DCount, string EXA_IP, out List<List<float?>> newDTList2)
		{
			DateTime JavaScriptStartTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
			newDTList2 = new List<List<float?>>();
			string rtnStr = "OK";
			string result = "OK";
			DateTime now = DateTime.Now;
			DateTime now2 = DateTime.Now;
			DateTime now3 = DateTime.Now;
			DateTime now4 = DateTime.Now;
			DateTime now5 = DateTime.Now;
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
				now2 = DateTime.Now;
				List<long> TSList = new List<long>();
				Parallel.ForEach(ItemNameArray, delegate(string ItemName)
				{
					SortedList<long, float?> sortedList = new SortedList<long, float?>();
					RestClient restClient = new RestClient("http://" + EXA_IP + ":9000/exawebapi/exatime/GetRawValueArrayFloat?ItemName=" + ItemName + "&StartingTime=" + StartingTime.ToString() + "&TerminalTime=" + TerminalTime.ToString());
					RestRequest request = new RestRequest("", Method.Get);
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
				now3 = DateTime.Now;
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
				CSharpCodeProvider cSharpCodeProvider = new CSharpCodeProvider();
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
				now4 = DateTime.Now;
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
			catch (Exception ex2)
			{
				result = ex2.ToString();
			}
			now5 = DateTime.Now;
			double totalSeconds = (now2 - now).TotalSeconds;
			double totalSeconds2 = (now3 - now2).TotalSeconds;
			double totalSeconds3 = (now4 - now3).TotalSeconds;
			double totalSeconds4 = (now5 - now4).TotalSeconds;
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
						string historySinglePoint = GetHistorySinglePoint(array[j], ST, ET, interval, EXA_IP);
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
	}
}
