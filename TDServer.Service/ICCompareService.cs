using AutoMapper;
using DBServer.LogServer;
using DCSCommon;
using EngineCore;
using EngineCore.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MySqlConnector;
using Newtonsoft.Json;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using PerformanceCalc;
using System.Data;
using System.Net.Http.Headers;
using System.Text;
using System.Text.RegularExpressions;
using Match = System.Text.RegularExpressions.Match;

namespace TDServer.Service
{
    public class ICCompareService
    {
        public static ConfigInfo configInfo;
        private static LoggerService<ICCompareService> logger = new LoggerService<ICCompareService>();
        private static readonly object locker_dic = new object();
        static Sensitivefactorstandard? sensitivefactorstandard = null;
        public static List<CldIndexcondition> cldIndexconditions;
        public static ICCompareResult iCCompareResult = null;
        private static Timer timer;
        public static Dictionary<int, string> devicesequence = new Dictionary<int, string>();
        public static standardhc standard = new();

        public static List<Pointmsg> pointmsgs = new List<Pointmsg>();
        public static List<content> OptimizationSuggestions = new();


        public static void Start()
        {
            if (!ExcuteEngine.configInfo.enableICCompareService) return;
            logger.InfoLog("工况寻优功能已开启！");
            OptimizationSuggestions = initialize("在线节能与优化指导意见.xlsx");
      
            iCCompareResult = new ICCompareResult();
            configInfo = ExcuteEngine.configInfo;

            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                cldIndexconditions = warnContext.CldIndexconditions.AsQueryable().ToList();
                sensitivefactorstandard = warnContext.Sensitivefactorstandards.First();
            }

            Task.Run(() =>
            {
                while (true)
                {
                    if (ExcuteEngine.hasRun)
                    {
                        FirstSteadyStateICCompare();
                    }
                    Thread.Sleep(1000);
                }
            });

            #region 稳态工况对标
            Task.Run(() =>
            {
                while (true)
                {
                    if (iCCompareResult.HasSteadyState == true)
                    {
                        try
                        {

                            standard = ICCompare(ExcuteEngine.optimizingFunction.SteadyStateICList).Result;
                            Thread.Sleep(configInfo.ICCompareTime);
                            standard = new();

                        }
                        catch (Exception ex)
                        {
                            logger.ErrorLog(ex.Message);
                        }
                    }
                    else
                    {

                        Thread.Sleep(200);
                    }

                }
            });
            #endregion

            #region 删除超期标杆工况
            if (ExcuteEngine.configInfo.enableICCompareService)
            {
                Task.Run(() =>
                {
                    while (true)
                    {
                        try
                        {
                            DeleteIC();
                            DeleteICcompare();
                            Thread.Sleep(600000);
                        }
                        catch (Exception ex)
                        {
                            logger.ErrorLog("删除标杆库异常：" + ex.Message);
                        }
                    }
                });
            }

            #endregion
        }

        public static List<content> initialize(string file)
        {
            try
            {
                string currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
                string filePath = Path.Combine(currentDirectory, file);
                if (!File.Exists(filePath)) return null;
                FileStream fileStream = new FileStream(filePath, FileMode.Open, FileAccess.Read);
                IWorkbook workbook = new XSSFWorkbook(fileStream);//读取excel

                int sheetCount = workbook.NumberOfSheets;//获取excel表的数量
                ISheet pointsheet = workbook.GetSheetAt(0);
                for (int rowIndex = 1; rowIndex <= pointsheet.LastRowNum; rowIndex++)
                {
                    IRow row = pointsheet.GetRow(rowIndex);
                    if (row != null)
                    {
                        Pointmsg standardpoint = new Pointmsg();
                        Pointmsg steadypoint = new Pointmsg();
                        // 获取设备名（第一列）
                        ICell dcspoints = row.GetCell(0);
                        if (dcspoints != null && dcspoints.ToString().Contains("select"))
                        {
                            standardpoint.issql = true;
                            steadypoint.issql = true;
                        }
                        standardpoint.dcspoint = dcspoints?.ToString() ?? string.Empty;
                        steadypoint.dcspoint = dcspoints?.ToString() ?? string.Empty;
                        ICell des = row.GetCell(1);
                        standardpoint.description = des?.ToString() ?? string.Empty;
                        steadypoint.description = des?.ToString() ?? string.Empty;
                        // 获取序号（第二列）
                        ICell steadypoint1 = row.GetCell(2);
                        steadypoint.comparepoint = steadypoint1?.ToString() ?? string.Empty;
                        steadypoint.issteady = true;
                        ICell standardpoint1 = row.GetCell(3);
                        standardpoint.comparepoint = standardpoint1?.ToString() ?? string.Empty;
                        standardpoint.issteady = false;
                        pointmsgs.Add(standardpoint);
                        pointmsgs.Add(steadypoint);
                    }
                }
                List<content> zdyj = new List<content>();//存储每个表的条件及文本内容
                                                         // 遍历除第一个表以外的表\
                ISheet devicesheet = workbook.GetSheetAt(1);
                for (int rowIndex = 1; rowIndex <= devicesheet.LastRowNum; rowIndex++)
                {
                    IRow row = devicesheet.GetRow(rowIndex);
                    if (row != null)
                    {
                        // 获取设备名（第一列）
                        ICell deviceCell = row.GetCell(0);
                        string deviceName = deviceCell?.ToString() ?? string.Empty;

                        // 获取序号（第二列）
                        ICell numberCell = row.GetCell(1);
                        if (numberCell != null && numberCell.CellType == NPOI.SS.UserModel.CellType.Numeric)
                        {
                            int deviceNumber = (int)numberCell.NumericCellValue;
                            // 将序号作为键，设备名作为值存入字典
                            devicesequence[deviceNumber] = deviceName;
                        }
                    }
                }

                for (int num = 2; num < sheetCount; num++)
                {
                    content zdyjsheet = new content();//单个表的条件及文本内容
                    ISheet sheet = workbook.GetSheetAt(num);
                    IRow currentRow = sheet.GetRow(1);
                    if (currentRow == null) continue;
                    var formula = currentRow.GetCell(1)?.ToString();  // 第一行是条件表达式
                    if (string.IsNullOrEmpty(formula))
                        formula = "True";
                    zdyjsheet.conditon = formula;//获取条件

                    IRow row1 = devicesheet.GetRow(1);
                    ICell numberCell = row1.GetCell(1);
                    if (numberCell != null && numberCell.CellType == NPOI.SS.UserModel.CellType.Numeric)
                    {
                        zdyjsheet.device = (int)numberCell.NumericCellValue;
                    }
                    else
                    {
                        zdyjsheet.device = 0;
                    }

                    int cellCount = sheet.GetRow(3).LastCellNum;//读取第三行最后一位，获取表格列数
                    int rowCount = sheet.LastRowNum;//获取表格行数
                    List<List<string>> data = new List<List<string>>();
                    for (int rowIndex = 2; rowIndex < rowCount + 1; rowIndex++)
                    {
                        IRow row = sheet.GetRow(rowIndex);
                        List<string> rowData = new List<string>();
                        // 遍历
                        for (int colIndex = 0; colIndex < cellCount; colIndex++)
                        {
                            ICell cell = row?.GetCell(colIndex); // 获取单元格
                            rowData.Add(cell?.ToString());
                        }

                        if (!rowData.All(string.IsNullOrEmpty))
                            data.Add(rowData); // 添加行数据
                        zdyjsheet.text = data;
                    }
                    zdyj.Add(zdyjsheet);
                }
                fileStream.Close();// 关闭文件
                return zdyj;
            }
            catch (Exception ex)
            {
                return null;
            }
        }


        public static void DeleteICcompare()
        {
            double deletehour = 168d;
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                Sensitivefactorstandard sensitivefactorstandard = warnContext.Sensitivefactorstandards.FirstOrDefault();
                if (sensitivefactorstandard?.Forget != null)
                {
                    deletehour = (double)sensitivefactorstandard?.Forget;
                }
            }
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlEnergyanalySis))
            {
                List<Xunyouhis> cldIndexconditions = warnContext.XunYoudata.AsQueryable().ToList();

                DateTime deleteTime = DateTime.Now.AddHours(-deletehour);
                var deleteIC = cldIndexconditions.Where(x => x.steadytime < deleteTime && x.unit == "1DCS");

                if (deleteIC?.Count() > 0)
                {
                    warnContext.XunYoudata.RemoveRange(deleteIC);
                    warnContext.SaveChanges();
                    logger.InfoLog($"删除{deleteTime.ToString("yyyy-MM-dd HH:mm:ss")}之前的标杆库,遗忘因子时间为{sensitivefactorstandard?.Forget}小时，已删除的标杆库为：{JsonConvert.SerializeObject(deleteIC)}");
                }

            }
        }


        public static void DeleteIC()
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                Sensitivefactorstandard sensitivefactorstandard = warnContext.Sensitivefactorstandards.FirstOrDefault();
                List<CldIndexcondition> cldIndexconditions = warnContext.CldIndexconditions.AsQueryable().ToList();

                if (sensitivefactorstandard?.Forget != null)
                {
                    double forgetvalue = (double)sensitivefactorstandard?.Forget;
                    DateTime deleteTime = DateTime.Now.AddHours(-forgetvalue);
                    var deleteIC = cldIndexconditions.Where(x => x.Sj < deleteTime && x.Type == 0);

                    if (deleteIC?.Count() > 0)
                    {
                        //warnContext.CldIndexconditions.RemoveRange(deleteIC);
                        //warnContext.SaveChanges();
                        logger.InfoLog($"删除{deleteTime.ToString("yyyy-MM-dd HH:mm:ss")}之前的标杆库,遗忘因子时间为{sensitivefactorstandard?.Forget}小时，已删除的标杆库为：{JsonConvert.SerializeObject(deleteIC)}");
                    }
                }
            }
        }

        public static bool OldHasSteadyState = false;
        public async static void FirstSteadyStateICCompare()
        {
            try
            {
                if (ExcuteEngine.optimizingFunction == null)
                {
                    return;
                }

                if (iCCompareResult.NewIC?.Sj != null)
                {
                    iCCompareResult.Freshness = (int)(DateTime.Now - iCCompareResult.NewIC.Sj.Value).TotalSeconds;
                }
                else
                {
                    iCCompareResult.Freshness = -1;
                }


                iCCompareResult.HasSteadyState = ExcuteEngine.optimizingFunction.HasSteadyState;


                if (!OldHasSteadyState && ExcuteEngine.optimizingFunction.HasSteadyState)
                {
                    logger.InfoLog("进入稳态！");
                }

                List<CldIndexcondition> expertICList = cldIndexconditions.AsQueryable().Where(x => x.Type == 1).ToList();
                iCCompareResult.ExpertIC = GetExpertIC(expertICList);

                #region 稳态结束，将距离稳态结束时间五分钟内更新及新增的标杆库删除
                if (OldHasSteadyState && !ExcuteEngine.optimizingFunction.HasSteadyState)
                {
                    iCCompareResult.Init();
                    DateTime curTime = DateTime.Now;

                    logger.InfoLog("稳态结束！");
                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        if (iCCompareResult.NewIC != null && iCCompareResult.NewIC.Sj.HasValue)
                        {
                            if ((DateTime.Now - iCCompareResult.NewIC.Sj.Value).TotalSeconds <= ExcuteEngine.configInfo.ICCompareTime / 1000)
                            {
                                logger.InfoLog($"对标成功工况的时间距离稳态结束时间小于5分钟。对标成功工况：{JsonConvert.SerializeObject(iCCompareResult.NewIC)}");
                                if (iCCompareResult.OldIC != null)//如果OldIC不为null，说明对标成功，OldIC为更新前的标杆库
                                {

                                    //获取距离稳态结束时间大于5分钟的工况再进行对标
                                    CldIndexcondition secondCompareIC = oldSteadyStateICList.Where(x => x.Sj < curTime.AddSeconds(-ExcuteEngine.configInfo.ICCompareTime / 1000)).ToList().OrderByDescending(p => p.Zhhc).LastOrDefault();
                                    if (secondCompareIC != null)
                                    {
                                        logger.InfoLog($"获取到距离稳态结束时间超过5分钟的最优工况为：{JsonConvert.SerializeObject(secondCompareIC)}");

                                        double eb = (double)secondCompareIC.Glxl / 100;
                                        //实际工况的汽机热耗
                                        double qsr = (double)secondCompareIC.Qjrh;
                                        //目标工况的汽机热耗
                                        double qsrdst = (double)iCCompareResult.StandardIC.Qjrh;
                                        //目标工况的锅炉效率
                                        double ebdst = (double)iCCompareResult.StandardIC.Glxl / 100;

                                        double qjrhhc = PCalc.ComputeQsr(eb, qsr, qsrdst).To2d();
                                        double glxlhc = PCalc.ComputeEb(eb, ebdst, qsr).To2d();
                                        double zhhc = (qjrhhc + glxlhc).To2d();

                                        secondCompareIC.Zhhc = zhhc;
                                        secondCompareIC.Glxlhc = glxlhc;
                                        secondCompareIC.Qjrhhc = qjrhhc;


                                        if (secondCompareIC.Zhhc < 0)
                                        {
                                            logger.InfoLog($"二次对标成功重新更新标杆库。");
                                            secondCompareIC.Id = iCCompareResult.OldIC.Id;

                                            //将更新前的标杆库的分组区间赋值给最新工况，防止对标工况出现多个分组
                                            secondCompareIC.Fhqj = iCCompareResult.OldIC.Fhqj;
                                            secondCompareIC.Hjwdqj = iCCompareResult.OldIC.Hjwdqj;
                                            secondCompareIC.Zhhc = iCCompareResult.OldIC.Zhhc;
                                            warnContext.CldIndexconditions.Update(secondCompareIC);
                                            iCCompareResult.NewIC = secondCompareIC;
                                        }
                                        else if (secondCompareIC.Zhhc > 0)
                                        {
                                            logger.InfoLog($"二次对标失败还原更新前的标杆工况：{JsonConvert.SerializeObject(iCCompareResult.OldIC)}");
                                            warnContext.CldIndexconditions.Update(iCCompareResult.OldIC);
                                            iCCompareResult.OldIC = null;
                                            iCCompareResult.NewIC = null;
                                        }
                                    }
                                    else
                                    {
                                        logger.InfoLog($"未获取到距离稳态结束时间超过5分钟的最优工况，还原更新前的标杆工况：{JsonConvert.SerializeObject(iCCompareResult.OldIC)}");
                                        warnContext.CldIndexconditions.Update(iCCompareResult.OldIC);
                                        iCCompareResult.OldIC = null;
                                        iCCompareResult.NewIC = null;
                                    }
                                    warnContext.SaveChanges();
                                }
                                else
                                {

                                    //if (iCCompareResult.NewAddICList.Count > 0)
                                    //{
                                    //    List<CldIndexcondition> deleteICList = iCCompareResult.NewAddICList.Where(x => x.Sj > curTime.AddMinutes(-5)).ToList();

                                    //    if (deleteICList.Count > 0)
                                    //    {
                                    //        logger.InfoLog($"删除距离稳态结束时间5分钟内的新增工况，删除工况为：{JsonConvert.SerializeObject(deleteICList)}");
                                    //        warnContext.CldIndexconditions.RemoveRange(deleteICList);
                                    //        warnContext.SaveChanges();
                                    //    }
                                    //    iCCompareResult.NewAddICList.Clear();
                                    //}

                                    logger.InfoLog($"删除距离稳态结束时间5分钟内的新增工况，删除工况为：{JsonConvert.SerializeObject(iCCompareResult.NewIC)}");
                                    warnContext.CldIndexconditions.Remove(iCCompareResult.NewIC);
                                    warnContext.SaveChanges();

                                    iCCompareResult.NewIC = null;
                                }
                            }
                        }

                        oldSteadyStateICList.Clear();
                        cldIndexconditions = warnContext.CldIndexconditions.AsQueryable().ToList();
                    }
                }
                #endregion

                OldHasSteadyState = ExcuteEngine.optimizingFunction.HasSteadyState;

                if (!iCCompareResult.HasSteadyState)
                {
                    dictColor = new Dictionary<string, string>() { { "zfl", null}, { "yl", null }, { "acpywd", null }, { "bcpywd", null }, { "kyqckhyl", null },
                                                      { "zzqwd", null }, { "zrzqwd", null }, { "zzqyl", null }, { "zrzqyl", null }, { "by", null } ,{ "zrqjwsll", null }};

                    if (ExcuteEngine.powerUnitStop)
                    {
                        iCCompareResult.IsShowGIF = false;
                        iCCompareResult.GuideIdeaTitle = "当前机组处于停机状态。";
                        iCCompareResult.guideIdeaContentAndCharts = new List<GuideIdeaContentAndChart>
                        {
                            new GuideIdeaContentAndChart() { GuideIdeaContent =  iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null }
                        };
                    }
                    else
                    {
                        iCCompareResult.IsShowGIF = true;
                        iCCompareResult.GuideIdeaTitle = "当前工况处于非稳态，请按照AGC指令调整负荷，直至稳态。";

                        iCCompareResult.guideIdeaContentAndCharts = new List<GuideIdeaContentAndChart>
                        {
                            new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null }
                        };

                        iCCompareResult.AGCStandardIC = GetAGCStandardIC();
                        iCCompareResult.SensitivefactorsCharts = GetSensitivefactorsChart(iCCompareResult.RealTimeIC, iCCompareResult.AGCStandardIC);
                        iCCompareResult.curveContents = GetCurveContent(iCCompareResult.RealTimeIC, iCCompareResult.AGCStandardIC);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog("FirstSteadyStateICCompare" + ex.Message);
            }
        }


        public static CldIndexcondition? GetAGCStandardIC()
        {
            if (ExcuteEngine.optimizingFunction != null)
            {
                CldIndexcondition realtimeIC = ExcuteEngine.optimizingFunction.RealTimeIC;

                iCCompareResult.RealTimeIC = ExcuteEngine.optimizingFunction.RealTimeIC;
                List<string> groupInfo = ExcuteEngine.optimizingFunction.FindGroupInfo(realtimeIC.AGCJzhf, realtimeIC.Hjwd, realtimeIC.Dwfrl);

                if (groupInfo != null && groupInfo.Count > 0)
                {
                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        return warnContext.CldIndexconditions.AsQueryable().FirstOrDefault(x => x.Fhqj == groupInfo[0] && x.Hjwdqj == groupInfo[1] && x.Dwfrlqj == groupInfo[2] && x.Type == 0) ?? new CldIndexcondition();
                    }
                }
            }
            return null;
        }

        public static void ComputeSteadyStateICZhhc(List<CldIndexcondition> steadyStateICList)
        {
            CldIndexcondition standardIC = steadyStateICList[0];
            foreach (var steadyStateIC in steadyStateICList)
            {
                double eb = (double)steadyStateIC.Glxl / 100;
                //实际工况的汽机热耗
                double qsr = (double)steadyStateIC.Qjrh;
                //目标工况的汽机热耗
                double qsrdst = (double)standardIC.Qjrh;
                //目标工况的锅炉效率
                double ebdst = (double)standardIC.Glxl / 100;

                double qjrhhc = PCalc.ComputeQsr(eb, qsr, qsrdst).To2d();
                double glxlhc = PCalc.ComputeEb(eb, ebdst, qsr).To2d();
                double zhhc = (qjrhhc + glxlhc).To2d();

                steadyStateIC.Zhhc = zhhc;
                steadyStateIC.Glxlhc = glxlhc;
                steadyStateIC.Qjrhhc = qjrhhc;
            }
        }
        public static List<GuideIdeaContentAndChart> guideIdeaContentAndCharts = new List<GuideIdeaContentAndChart>();
        public static List<CldIndexcondition> oldSteadyStateICList = new List<CldIndexcondition>();



        /// <summary>
        /// 工况对标
        /// </summary>
        public static async Task<standardhc> ICCompare(List<CldIndexcondition> steadyStateICList)
        {
            try
            {
                standardhc standard = new();
                dictColor = new Dictionary<string, string>() { { "zfl", null}, { "yl", null }, { "acpywd", null }, { "bcpywd", null }, { "kyqckhyl", null },
                                                                { "zzqwd", null }, { "zrzqwd", null }, { "zzqyl", null }, { "zrzqyl", null }, { "by", null } ,{ "zrqjwsll", null }};
                guideIdeaContentAndCharts.Clear();
                iCCompareResult.IsShowGIF = false;
                if (steadyStateICList.Count == 0)
                {
                    iCCompareResult.CompareOKTime = DateTime.Now;
                    iCCompareResult.GuideIdeaTitle = "当前工况处于稳态，但工况被清洗，没有采集到稳态工况。" + OptimizingFunction.cleanlog;
                    if (guideIdeaContentAndCharts.Count == 0)
                    {
                        iCCompareResult.guideIdeaContentAndCharts = new List<GuideIdeaContentAndChart>
                        {
                            new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null }
                        };
                        iCCompareResult.IsShowGIF = true;
                    }
                    else
                    {
                        iCCompareResult.IsShowGIF = false;
                    }
                    return null;
                }
                oldSteadyStateICList = steadyStateICList;
                ComputeSteadyStateICZhhc(steadyStateICList);//以第一工况为标杆工况，计算采集到的工况的综合耗差
                CldIndexcondition bestSteadyStateIC = steadyStateICList.OrderByDescending(p => p.Zhhc).LastOrDefault();//获取耗差最小的稳态工况 
                CldIndexcondition lastSteadyStateIC = steadyStateICList.Last();
                iCCompareResult.CompareOKTime = (DateTime)bestSteadyStateIC.Sj;
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    CldIndexcondition standardIC = cldIndexconditions.FirstOrDefault(x => x.Fhqj == bestSteadyStateIC.Fhqj && x.Hjwdqj == bestSteadyStateIC.Hjwdqj && x.Dwfrlqj == bestSteadyStateIC.Dwfrlqj && x.Type == 0 && (DateTime.Now - x.Sj.Value).TotalDays < 90);
                    if (standardIC != null)
                    {
                        double eb = (double)bestSteadyStateIC.Glxl / 100;
                        //实际工况的汽机热耗
                        double qsr = (double)bestSteadyStateIC.Qjrh;
                        //目标工况的汽机热耗
                        double qsrdst = (double)standardIC.Qjrh;
                        //目标工况的锅炉效率
                        double ebdst = (double)standardIC.Glxl / 100;
                        standard.qjrh = qsrdst;
                        standard.glxl = ebdst;
                        double qjrhhc = PCalc.ComputeQsr(eb, qsr, qsrdst).To2d();
                        double glxlhc = PCalc.ComputeEb(eb, ebdst, qsr).To2d();
                        double zhhc = (qjrhhc + glxlhc).To2d();

                        bestSteadyStateIC.Zhhc = zhhc;
                        bestSteadyStateIC.Glxlhc = glxlhc;
                        bestSteadyStateIC.Qjrhhc = qjrhhc;

                        iCCompareResult.RealTimeIC = bestSteadyStateIC;
                        iCCompareResult.StandardIC = standardIC;

                        List<CldIndexcondition> expertICList = cldIndexconditions.AsQueryable().Where(x => x.Fhqj == bestSteadyStateIC.Fhqj && x.Hjwdqj == bestSteadyStateIC.Hjwdqj && x.Dwfrlqj == bestSteadyStateIC.Dwfrlqj && x.Type == 1).ToList();
                        iCCompareResult.ExpertIC = GetExpertIC(expertICList);
                        if (bestSteadyStateIC.Zhhc < 0)
                        {

                            iCCompareResult.IsShowGIF = true;
                            iCCompareResult.CompareResult = 0;

                            if (!ICClean(bestSteadyStateIC))
                            {
                                iCCompareResult.NewIC = bestSteadyStateIC;
                                iCCompareResult.OldIC = standardIC;
                                iCCompareResult.Freshness = 0;
                                bestSteadyStateIC.Id = standardIC.Id;
                                warnContext.CldIndexconditions.Update(bestSteadyStateIC);
                                await warnContext.SaveChangesAsync();

                                iCCompareResult.GuideIdeaTitle = "经与标杆工况进行对标，当前工况的综合耗差优于标杆工况，标杆工况库已更新。";
                                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null });
                            }
                            else
                            {
                                iCCompareResult.GuideIdeaTitle = "当前工况部分参数超过清洗条件限定值，不符合标杆工况标准，不更新标杆工况库。";
                                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null });
                            }
                        }
                        else if (bestSteadyStateIC.Zhhc > 0)
                        {
                            iCCompareResult.CompareResult = 1;
                            iCCompareResult.GuideIdeaTitle = $"经与标杆工况进行对标，标杆工况的综合耗差优于当前工况，差值为{bestSteadyStateIC.Zhhc}g/kWh。";
                            var suggestions = await GetGuideIdeaContentAndChart1(lastSteadyStateIC.Sj.Value,standardIC.Sj.Value);
                            if (suggestions != null)
                            {
                                guideIdeaContentAndCharts.AddRange(suggestions);
                                lastSteadyStateIC.comparetime = standardIC.Sj.Value;
                                var config = new MapperConfiguration(cfg =>
                                {
                                    cfg.CreateMap<CldIndexcondition, CldIndexconditioncompare>();
                                });
                                var mapper = config.CreateMapper();
                                var source = new CldIndexcondition { /* 初始化属性 */ };
                                var target = mapper.Map<CldIndexconditioncompare>(lastSteadyStateIC);
                                warnContext.CldIndexconditionscompare.Add(target);
                                await warnContext.SaveChangesAsync(); // 
                            }
                            if (guideIdeaContentAndCharts.Count == 0)
                            {
                                iCCompareResult.GuideIdeaTitle = "当前机组已在趋近于目标工况的状态运行，无相关操作指导。";
                                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null });
                                iCCompareResult.IsShowGIF = true;
                            }
                            else
                            {
                                insertxydata(JsonConvert.SerializeObject(guideIdeaContentAndCharts), lastSteadyStateIC.Sj.Value.ToString("yyyy-MM-dd HH:mm:ss"), standardIC.Sj.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                            }
                        }
                    }
                    else
                    {

                        iCCompareResult.IsShowGIF = true;
                        iCCompareResult.CompareResult = 2;
                        iCCompareResult.ExpertIC = null;
                        iCCompareResult.RealTimeIC = bestSteadyStateIC;
                        iCCompareResult.StandardIC = null;

                        if (!ICClean(bestSteadyStateIC))
                        {
                            bestSteadyStateIC.Zhhc = 0;
                            bestSteadyStateIC.Glxlhc = 0;
                            bestSteadyStateIC.Qjrhhc = 0;
                            iCCompareResult.NewIC = bestSteadyStateIC;
                            iCCompareResult.OldIC = null;
                            iCCompareResult.GuideIdeaTitle = "经与标杆工况进行对标，标杆工况库无当前分组数据，当前数据已录入标杆工况库。";
                            guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null });

                            //添加新分组工况       
                            warnContext.CldIndexconditions.Add(bestSteadyStateIC);
                            await warnContext.SaveChangesAsync();
                            iCCompareResult.NewAddICList = new List<CldIndexcondition>() { bestSteadyStateIC };
                        }
                        else
                        {
                            iCCompareResult.GuideIdeaTitle = "当前工况部分参数超过清洗条件限定值，不符合标杆工况标准，不新增标杆工况库。";
                            guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = iCCompareResult.GuideIdeaTitle, Percent = null, GuideIdeaChart = null });
                        }
                    }

                    iCCompareResult.guideIdeaContentAndCharts = guideIdeaContentAndCharts;
                    iCCompareResult.curveContents = GetCurveContent(iCCompareResult.RealTimeIC, iCCompareResult.StandardIC);
                    iCCompareResult.BarChartContent = GetBarChartContent(iCCompareResult.RealTimeIC, iCCompareResult.StandardIC);
                    iCCompareResult.RadarChartContents = GetRadarChartContent(iCCompareResult.RealTimeIC, iCCompareResult.StandardIC);
                    iCCompareResult.SensitivefactorsCharts = GetSensitivefactorsChart(iCCompareResult.RealTimeIC, iCCompareResult.StandardIC);
                    cldIndexconditions = warnContext.CldIndexconditions.AsQueryable().ToList();
                }
                return standard;
            }
            catch (Exception ex)
            {
                return null;
            }
        }
        private static void insertxydata(string json, string steadytime, string standardtime)
        {
            MySqlConnection con = Initializemysql();
            try
            {
                if (con == null)
                {
                    return;
                }
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                string str = "values" + "('" + steadytime + "','" + standardtime + "','" + "1DCS" + "','" + json  + "');";
                string sql = "insert into xunyoudata(steadytime,standardtime,unit,json)" + str;
                MySqlCommand cmd = new MySqlCommand(sql, con);
                using (MySqlDataReader reader = cmd.ExecuteReader()) { }
            }
            catch (Exception ex)
            {
                con.Close();
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
        public static MySqlConnection Initializemysql()
        {
            try
            {
                MySqlConnection con = new MySqlConnection(configInfo.mysqlEnergyanalySis);
                return con;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.ToString());
                return null;
            }
        }

        public static async Task<List<GuideIdeaContentAndChart>> GetGuideIdeaContentAndChart1(DateTime steadyStateICsj, DateTime standardICsj)
        {
            var allTasks = OptimizationSuggestions.Select(async original =>
            {
                try
                {
                    var suggestion = new content
                    {
                        conditon = original.conditon,
                        device = original.device,
                        text = original.text.Select(innerList => new List<string>(innerList)).ToList()
                    };

                    var variables = ExtractVariables(suggestion.conditon);
                    var resultdata = await getconditonvalueAsync(variables, standardICsj.AddHours(-8), steadyStateICsj.AddHours(-8));

                    if (resultdata is null || resultdata.Count == 0)
                        return null;

                    var conditionDict = variables.Zip(resultdata, (k, v) => new { k, v })
                                                 .ToDictionary(x => x.k, x => x.v);

                    double percent = 0d;
                    suggestion.conditon = ReplaceVariablesInCondition(suggestion.conditon, conditionDict, ref percent);

                    if (!EvaluateCondition(suggestion.conditon))
                        return null;

                    var textVariables = GetTextVariables(suggestion, pointmsgs);
                    if (!textVariables.Any())
                        return null;

                    var textResult = await getconditonvalueAsync(textVariables, standardICsj.AddHours(-8), steadyStateICsj.AddHours(-8));
                    if (textResult is null || textResult.Count == 0)
                        return null;

                    var textDict = textVariables.Zip(textResult, (k, v) => new { k, v })
                                                .ToDictionary(x => x.k, x => x.v);

                    if (suggestion.text[0][1] != null)
                        suggestion.text[0][1] = ReplaceTextVariables(suggestion.text[0][1], textDict);

                    string percentDesc = suggestion.device + devicesequence[suggestion.device] + percent;
                    UpdateTextContent(suggestion, textDict);
                    var chartList = ConvertToChartRowList(suggestion.text);

                    return new GuideIdeaContentAndChart
                    {
                        GuideIdeaContent = suggestion.text[0][1],
                        Percent = percentDesc,
                        GuideIdeaChart = new List<object> { chartList }
                    };
                }
                catch (Exception ex)
                {
                    logger.ErrorLog("单项处理异常：" + ex.ToString());
                    return null;
                }
            });

            var results = await Task.WhenAll(allTasks);

            // 添加编号前缀
            int index = 1;
            var finalResults = results
                .Where(r => r != null && !string.IsNullOrWhiteSpace(r.GuideIdeaContent))
                .Select(r => new GuideIdeaContentAndChart
                {
                    GuideIdeaContent = $"{index++}) {r.GuideIdeaContent}",
                    Percent = r.Percent,
                    GuideIdeaChart = r.GuideIdeaChart
                }).ToList();
            if (finalResults.Count > 0)
            {
                return finalResults;
            }
            else
            {
                return null;
            }

        }

        private static string ReplaceTextVariables(string text, Dictionary<string, double> textdict)
        {
            string pattern = @"\[(.*?)\]";  // 匹配[]中的内容
            return Regex.Replace(text, pattern, match =>
            {
                string key = match.Groups[1].Value;  // 获取[]中的key
                return textdict.ContainsKey(key) ? textdict[key].ToString() : match.Value;  // 替换为字典中的值，如果key不存在则保留原匹配内容
            });
        }
        private static void UpdateTextContent(content suggestion, Dictionary<string, double> textdict)
        {
            for (int z = 0; z < suggestion.text.Count; z++)
            {
                for (int j = 1; j < suggestion.text[z].Count; j++)
                {
                    if (suggestion.text[z][j] == null)
                    {
                        //suggestion.text[z][j] = "";
                        continue;
                    }
                    if (textdict.ContainsKey(suggestion.text[z][j]))
                    {
                        suggestion.text[z][j] = textdict[suggestion.text[z][j]].ToString();
                    }

                    if (suggestion.text[z][0].Contains("%"))
                    {
                        suggestion.text[z][j] = CalcPercent(Convert.ToDouble(suggestion.text[z - 1][j]), Convert.ToDouble(suggestion.text[z - 2][j])).ToString();
                    }
                }
            }
        }
        private static string ReplaceVariablesInCondition(string condition, Dictionary<string, double> conditiondict, ref double result)
        {
            if (conditiondict.Count >= 2)
            {
                int count = 0;
                double firstValue = 0;
                double secondValue = 0;
                foreach (KeyValuePair<string, double> kvp in conditiondict)
                {
                    if (count == 0)
                    {
                        firstValue = kvp.Value;
                    }
                    else if (count == 1)
                    {
                        secondValue = kvp.Value;
                        break;
                    }
                    count++;
                }
                if (secondValue != 0)
                {
                    result = Math.Round(Math.Abs(firstValue / secondValue), 2);
                }
                else
                {
                    result = 1;
                }
            }
            else
            {
                result = 1;
            }
            foreach (var variable in conditiondict.Keys)
            {
                condition = condition.Replace("[" + variable + "]", conditiondict[variable].ToString());
            }
            return condition;
        }
        private static List<string> GetTextVariables(content suggestion, List<Pointmsg> pointmsgs)
        {
            List<string> textvariables = new List<string>();
            if (devicesequence.ContainsKey(suggestion.device) && suggestion.text.Count > 3)
            {
                foreach (var innerList in suggestion.text)
                {
                    foreach (var item in innerList)
                    {
                        for (int i = 0; i < pointmsgs.Count; i++)
                        {
                            if (pointmsgs[i].comparepoint == item)
                            {
                                textvariables.Add(item);
                                break;
                            }
                        }
                    }
                }
            }
            List<string> uniqueList = textvariables.Distinct().ToList();
            return uniqueList;
        }
        static List<List<object>> ConvertToChartRowList(List<List<string>> stringList)
        {
            List<List<object>> resultList = new List<List<object>>();

            for (int i = 1; i < stringList.Count; i++)
            {
                List<object> newRow = new List<object>();
                foreach (var str in stringList[i])
                {
                    newRow.Add(new ChartRow() { name = str, spanCol = 1, spanRow = 1 });
                }
                resultList.Add(newRow);
            }

            return resultList;
        }
        public static async Task<List<double>> getconditonvalueAsync(List<string> variables, DateTime? standard, DateTime? steady)//标杆0点稳态12点
        {
            List<double> unitsum = new List<double>();
            var foundPoints = variables
        .Where(v => pointmsgs.Any(p => p.comparepoint == v))  // 确保 pointmsgs 中存在
        .Select(v => pointmsgs.First(p => p.comparepoint == v))  // 获取匹配的第一个
        .ToList();
            for (int i = 0; i < foundPoints.Count; i++)
            {
                Dictionary<string, double> containpoint = new Dictionary<string, double>();
                bool contain = false;
                List<getdata> sqls = new List<getdata>();
                List<string> tables = new List<string>();
                if (foundPoints[i].issql)
                {
                    tables.Add(foundPoints[i].dcspoint.ToLower());
                }
                else
                {
                    tables = ExtractTableNames(foundPoints[i].dcspoint.ToLower());
                }
                if (ContainsOperators(foundPoints[i].dcspoint) && !foundPoints[i].issql)//检查存不存在+-*/
                {
                    contain = true;
                    foreach (var table in tables)
                    {
                        getdata getpoint = new getdata();
                        if (foundPoints[i].issteady)
                        {
                            getpoint.sql = string.Format("select last(*) from {0} WHERE  time <= '{1}';", table, steady.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                        else
                        {
                            getpoint.sql = string.Format("select last(*) from {0} WHERE  time <= '{1}';", table, standard.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                        sqls.Add(getpoint);
                    }
                }
                else
                {
                    getdata getpoint = new getdata();
                    if (foundPoints[i].issteady)
                    {
                        if (foundPoints[i].issql)
                        {
                            getpoint.sql = foundPoints[i].dcspoint + string.Format("  WHERE  time <= '{0}';", steady.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                        else
                        {
                            getpoint.sql = string.Format("select last(*) from {0} WHERE  time <= '{1}';", foundPoints[i].dcspoint, steady.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                    }
                    else
                    {
                        if (foundPoints[i].issql)
                        {
                            getpoint.sql = foundPoints[i].dcspoint + string.Format("  WHERE  time <= '{0}';", standard.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                        else
                        {
                            getpoint.sql = string.Format("select last(*) from {0} WHERE  time <= '{1}';", foundPoints[i].dcspoint, standard.Value.ToString("yyyy-MM-dd HH:mm:ss"));
                        }
                    }
                    sqls.Add(getpoint);
                }
                try
                {
                    for (int j = 0; j < sqls.Count; j++)
                    {
                        var stringPayload = JsonConvert.SerializeObject(sqls[j]);
                        var client = new HttpClient();
                        var request = new HttpRequestMessage();
                        request = new HttpRequestMessage
                        {
                            Method = HttpMethod.Post,
                            RequestUri = new Uri("http://10.116.17.13:5336/api/Point/OriginQuery"),
                            Content = new StringContent(stringPayload)
                            {
                                Headers ={ContentType = new MediaTypeHeaderValue("application/json")
        }
                            }
                        };
                        using (var response = await client.SendAsync(request))
                        {
                            response.EnsureSuccessStatusCode();
                            var resultJson = await response.Content.ReadAsStringAsync();
                            if (resultJson == null || resultJson.Trim() == "") return null;
                            Root1 newhis = JsonConvert.DeserializeObject<Root1>(resultJson);
                            if (contain)
                            {
                                containpoint[newhis.data[0].series[0].name] = Convert.ToDouble(newhis.data[0].series[0].values[0][1]);
                            }
                            else
                            {
                                unitsum.Add(Math.Round(Convert.ToDouble(newhis.data[0].series[0].values[0][1]), 2));
                            }
                        }
                    }
                    if (contain)
                    {
                        double result = Math.Round(CalculateExpression(foundPoints[i].dcspoint, containpoint), 2);
                        unitsum.Add(result);
                    }
                }
                catch (Exception ex)
                {
                    return null;
                }
            }
            return unitsum;
        }
        static double CalculateExpression(string input, Dictionary<string, double> values)
        {
            // 提取所有表名
            List<string> tables = ExtractTableNames(input);

            // 替换表名为字典中的值
            foreach (var table in tables)
            {
                if (values.ContainsKey(table))
                {
                    input = input.Replace(table, values[table].ToString());
                }
                else
                {
                    throw new KeyNotFoundException($"Table {table} not found in the dictionary.");
                }
            }

            // 计算并返回结果
            return EvaluateExpression(input);
        }
        static double EvaluateExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            // 使用 C# 内置的 System.Data.DataTable 来计算简单的数学表达式
            var dataTable = new System.Data.DataTable();
            return Convert.ToDouble(dataTable.Compute(expression, string.Empty));
        }
        static List<string> ExtractTableNames(string input)
        {
            List<string> tables = new List<string>();

            // 去除外部括号
            input = input.Trim('(', ')');

            // 使用正则表达式匹配所有表名（假设表名形式如 dcs_had10ct621）
            string pattern = @"\w+_\w+\d*\w+";
            MatchCollection matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                if (!tables.Contains(match.Value))
                {
                    tables.Add(match.Value);
                }
            }

            return tables;
        }
        public static List<string> ExtractVariables(string formula)
        {
            var variables = new List<string>();
            var regex = new Regex(@"\[([^\]]+)\]");  // 匹配[]中的内容
            var matches = regex.Matches(formula);

            foreach (Match match in matches)
            {
                if (!variables.Contains(match.Groups[1].Value))
                    variables.Add(match.Groups[1].Value);  // 提取括号中的内容
            }

            return variables;
        }
        public static bool EvaluateCondition(string formula)
        {
            bool finalResult = false;
            if (formula.Contains("&&"))
            {
                // 拆分为两部分
                var parts = formula.Split(new string[] { "&&" }, StringSplitOptions.None);

                // 计算两部分
                bool result1 = CalculateExpression(parts[0]);
                bool result2 = CalculateExpression(parts[1]);

                // 使用逻辑与运算符
                finalResult = result1 && result2;
                //Console.WriteLine(finalResult);
            }
            else
            {
                // 如果没有 "&&"，直接计算单一表达式
                finalResult = CalculateExpression(formula);
                //Console.WriteLine(finalResult);
            }
            return finalResult;
        }
        static bool CalculateExpression(string expr)
        {
            // 使用 DataTable.Compute 计算数学表达式
            var result = new DataTable().Compute(expr, string.Empty);

            // 将计算结果转换为布尔值
            return Convert.ToBoolean(result);
        }

        static bool ContainsOperators(string input)
        {
            return Regex.IsMatch(input, @"[\+\-\*/]");
        }
        public static void GetGuideIdeaContentAndChart(CldIndexcondition steadyStateIC, CldIndexcondition standardIC)
        {
            //当前工况氧量—标杆工况的氧量>0.5%时
            if (steadyStateIC.Yl - standardIC.Yl > configInfo.optimizingGuidePara.ylHighValue && steadyStateIC.Glxlhc > 0)
            {
                dictColor["yl"] = "#FFFF00";
                string title = $"氧量值偏高，有减小空间。当前工况氧量为：{steadyStateIC.Yl}% ，标杆工况的氧量为：{standardIC.Yl}% ，建议将氧量向标杆值靠近。具体相关操作数据对比如下表：\r\n\n";
                string ylPercent = "0锅炉" + CalcPercent2(steadyStateIC.Yl, standardIC.Yl, sensitivefactorstandard.Yl, true);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "氧量设定值（%）",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "送风机A动叶开度（%）",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "送风机B动叶开度（%）",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Ylsdz,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Sfjadykd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Sfjbdykd,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Ylsdz,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Sfjadykd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Sfjbdykd,spanCol = 1,spanRow = 1}
                                }
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = ylPercent, GuideIdeaChart = new List<object>() { list } });
            }

            //标杆工况的氧量—当前工况氧量>0.5%时
            if (standardIC.Yl - steadyStateIC.Yl > configInfo.optimizingGuidePara.ylLowValue && steadyStateIC.Glxlhc > 0)
            {
                dictColor["yl"] = "#FFFF00";
                string title = $"氧量值偏低，当前工况氧量为：{steadyStateIC.Yl}% ，标杆工况的氧量为：{standardIC.Yl}% 。不利于保持炉膛燃烧稳定，同时也有可能造成燃烧不充分，影响锅炉效率，建议在NOx不超标的前提下，将氧量向标杆值靠近。" +
                    $"具体相关操作数据对比如下表：\r\n\n";
                string ylPercent = "0锅炉" + CalcPercent2(steadyStateIC.Yl, standardIC.Yl, sensitivefactorstandard.Yl, true);
                List<object> list = new List<object>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "氧量设定值（%）",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "送风机A动叶开度（%）",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "送风机B动叶开度（%）",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Ylsdz,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Sfjadykd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Sfjbdykd,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Ylsdz,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Sfjadykd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Sfjbdykd,spanCol = 1,spanRow = 1}
                                }
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = ylPercent, GuideIdeaChart = new List<object>() { list } });
            }

            //当前工况A侧排烟温度—标杆工况A侧排烟温度>5℃时
            if (steadyStateIC.Acpywd - standardIC.Acpywd > configInfo.optimizingGuidePara.acpywdHighValue && steadyStateIC.Glxlhc > 0)
            {
                dictColor["acpywd"] = "#FFFF00";
                string title = $"A侧排烟温度较高，当前工况A侧排烟温度为：{steadyStateIC.Acpywd}℃，标杆工况A侧排烟温度为：{standardIC.Acpywd}℃ 。建议通过优化二次风的配风、优化各个磨煤机的煤量配比、加强炉膛及烟道吹灰等措施，降低排烟温度。" +
                    $"具体相关操作数据对比如下表：\r\n\n";
                string bpywdPercent = "0锅炉" + CalcPercent2(steadyStateIC.Acpywd, standardIC.Acpywd, sensitivefactorstandard.Acpywd, false);
                List<List<object>> list1 = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各台给煤机给煤量（t/h）",spanCol = 6,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "A",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "B",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "C",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "D",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "E",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "F",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Fgmjml,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Fgmjml,spanCol = 1,spanRow = 1}
                                }
                            };

                List<List<object>> list2 = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "各二次风/燃烬风流量（t/h）",spanCol = 4,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右下",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzxecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyxecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzxecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyxecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右中",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyzecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyzecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右上",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqysecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqysecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqysecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqysecfll,spanCol = 1,spanRow = 1}
                                },


                                new List<object>()
                                {
                                    new ChartRow() {name = "燃烬风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右下",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyxrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyxrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "燃烬风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右上",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqysrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqysrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqysrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqysrjfll,spanCol = 1,spanRow = 1}
                                },
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = bpywdPercent, GuideIdeaChart = new List<object>() { list1, list2 } });
            }

            //当前工况B侧排烟温度—标杆工况B侧排烟温度>5℃时
            if (steadyStateIC.Bcpywd - standardIC.Bcpywd > configInfo.optimizingGuidePara.bcpywdHighValue && steadyStateIC.Glxlhc > 0)
            {
                dictColor["bcpywd"] = "#FFFF00";
                string title = $"B侧排烟温度较高，当前工况B侧排烟温度为：{steadyStateIC.Bcpywd}℃，标杆工况B侧排烟温度为：{standardIC.Bcpywd}℃ 。建议通过优化二次风的配风、优化各个磨煤机的煤量配比、加强炉膛及烟道吹灰等措施，" +
                    $"降低排烟温度。具体相关操作数据对比如下表：\r\n\n";
                string bpywdPercent = "0锅炉" + CalcPercent2(steadyStateIC.Bcpywd, standardIC.Bcpywd, sensitivefactorstandard.Bcpywd, false);
                List<List<object>> list1 = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各台给煤机给煤量（t/h）",spanCol = 6,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "A",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "B",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "C",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "D",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "E",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "F",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Fgmjml,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Fgmjml,spanCol = 1,spanRow = 1}
                                }
                            };


                List<List<object>> list2 = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "各二次风/燃烬风流量（t/h）",spanCol = 4,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右下",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzxecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyxecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzxecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyxecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左中",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右中",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyzecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzzecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyzecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "二次风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右上",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqysecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqysecfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqysecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzsecfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqysecfll,spanCol = 1,spanRow = 1}
                                },


                                new List<object>()
                                {
                                    new ChartRow() {name = "燃烬风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左下",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右下",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqyxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqyxrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqyxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzxrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqyxrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "燃烬风",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "前墙右上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙左上",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "后墙右上",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Qqysrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hqysrjfll,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Qqysrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqzsrjfll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hqysrjfll,spanCol = 1,spanRow = 1}
                                },
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = bpywdPercent, GuideIdeaChart = new List<object>() { list1, list2 } });
            }

            //当前工况总风量—标杆工况总风量>50t/h时 
            if (steadyStateIC.Zfl - standardIC.Zfl > configInfo.optimizingGuidePara.zflHighValue && (steadyStateIC.Zfl - standardIC.Zfl) > (steadyStateIC.Rll - standardIC.Rll) * 10 && steadyStateIC.Glxlhc > 0)
            {
                dictColor["zfl"] = "#FFFF00";
                string zflPercent = "0锅炉" + CalcPercent2(steadyStateIC.Zfl, standardIC.Zfl, sensitivefactorstandard.Fl, true);
                string title = $"炉膛总风量较大，当前工况总风量为{steadyStateIC.Zfl}t/h：标杆工况总风量为：{standardIC.Zfl}t/h。总风量过大会导致排烟热损失增加，建议适当减小锅炉总风量，" +
                    $"调整过程中注意锅炉受热面管壁温度变化，密切监视过热度，主再热蒸汽温度的变化，防止超温现象发生。\r\n\n";
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zflPercent, GuideIdeaChart = null });
            }

            double steadyStateIC_kyqckhyl = (double)(steadyStateIC?.KyqAckyqhyl + steadyStateIC?.KyqBckyqhyl) / 2;
            double standardIC_kyqckhyl = (double)(standardIC.KyqAckyqhyl + standardIC.KyqBckyqhyl) / 2;
            if ((steadyStateIC_kyqckhyl - standardIC_kyqckhyl) > configInfo.optimizingGuidePara.kyqckyqhylValue && (steadyStateIC.Yl - standardIC.Yl) < configInfo.optimizingGuidePara.ylHighValue && steadyStateIC.Glxlhc > 0)
            {
                dictColor["kyqckhyl"] = "#FFFF00";
                string kyqckhylPercent = "0锅炉" + CalcPercent2(steadyStateIC_kyqckhyl, standardIC_kyqckhyl, sensitivefactorstandard.Kyqckhyl, false);
                string title = $"空预器出口含氧量偏高，当前工况空预器出口含氧量为：{steadyStateIC_kyqckhyl}%，标杆工况空预器出口含氧量为：{standardIC_kyqckhyl}% 。结合炉膛氧量大小，判断可能存在空预器漏风增大的情况，影响空预器换热效果，建议进行排查\r\n\n";
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = kyqckhylPercent, GuideIdeaChart = null });
            }


            //主蒸汽温度标准值—当前工况主蒸汽温度>5℃时
            if (standardIC.Zzqwd - steadyStateIC.Zzqwd > configInfo.optimizingGuidePara.zzqwdLowValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zzqwd"] = "#FFFF00";
                string title = $"主蒸汽温度偏低，当前工况主蒸汽温度为：{steadyStateIC.Zzqwd}℃，主蒸汽温度标准值为：标杆工况主蒸汽温度为：{standardIC.Zzqwd}℃。主蒸汽温度偏低会影响蒸汽的做功能力，进而影响汽轮机效率和热耗率，机组的经济性降低，" +
                    $"建议通过人工干预减温水、调整烟气挡板、调整燃烧方式、适当提高中间点温度等方式提升主蒸汽温度，调整过程中注意防止超温现象发生。\r\n\n";
                string zzqwdPercent = "1汽机" + CalcPercent2(standardIC.Zzqwd, steadyStateIC.Zzqwd, sensitivefactorstandard.Zqwd, false);

                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "过热度（℃）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各级减温水流量（t/h）",spanCol = 4,spanRow = 1},
                                    new ChartRow() {name = "各烟气挡板开度（%）",spanCol = 4,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "一级左侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "一级右侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "二级左侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "二级右侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板5",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板6",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板7",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板8",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqzcyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqycyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqzcejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqycejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb5,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb6,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb7,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb8,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqzcyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqycyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqzcejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqycejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb5,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb6,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb7,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb8,spanCol = 1,spanRow = 1}
                                }
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zzqwdPercent, GuideIdeaChart = new List<object>() { list } });
            }

            //当前工况主蒸汽温度—主蒸汽温度标准值
            if (steadyStateIC.Zzqwd - 605 > configInfo.optimizingGuidePara.zzqwdHighValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zzqwd"] = "#FFFF00";
                string title = $"主蒸汽温度偏高，当前工况主蒸汽温度为：{steadyStateIC.Zzqwd}℃，主蒸汽温度偏高有超温的风险，影响机组的安全运行，建议通过人工干预减温水、调整燃烧等方式适当降低主蒸汽温度。具体相关操作数据对比如下表：\r\n\n";

                string zzqwdPercent = "1汽机" + CalcPercent2(605, steadyStateIC.Zzqwd, sensitivefactorstandard.Zqwd, false);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "过热度（℃）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各级减温水流量（t/h）",spanCol = 4,spanRow = 1},
                                    new ChartRow() {name = "各烟气挡板开度（%）",spanCol = 4,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "一级左侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "一级右侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "二级左侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "二级右侧",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板5",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板6",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板7",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板8",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqzcyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqycyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqzcejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqycejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb5,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb6,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb7,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Grqyqdb8,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grd,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqzcyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqycyjjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqzcejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqycejjwsll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb5,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb6,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb7,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Grqyqdb8,spanCol = 1,spanRow = 1}
                                }
                            };
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zzqwdPercent, GuideIdeaChart = new List<object>() { list } });

            }

            //再热蒸汽温度标准值—当前工况再热蒸汽温度>5℃时
            if (standardIC.Zrzqwd - steadyStateIC.Zrzqwd > configInfo.optimizingGuidePara.zrzqwdLowValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zrzqwd"] = "#FFFF00";
                string title = $"再热蒸汽温度偏低，当前工况再热蒸汽温度为：{steadyStateIC.Zrzqwd}℃，标杆工况再热蒸汽温度为：{standardIC.Zrzqwd}℃。再热蒸汽温度偏低会影响蒸汽的做功能力，进而影响汽轮机效率和热耗率，机组的经济性降低，" +
                    $"建议通过人工干预减温水、调整烟气挡板、调整燃烧方式、合理配比二次风量等方式提升再热蒸汽温度，调整过程中注意防止超温现象发生。\r\n\n";
                string zrzqwdPercent = "1汽机" + CalcPercent2(standardIC.Zrzqwd, steadyStateIC.Zrzqwd, sensitivefactorstandard.Zrqwd, false);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各烟气挡板开度（%）",spanCol = 4,spanRow = 1},
                                    new ChartRow() {name = "再热汽减温水流量（t/h）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各给煤机给煤量",spanCol = 6,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "挡板1",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板2",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板3",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板4",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "A",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "B",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "C",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "D",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "E",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "F",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb1,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb2,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb3,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb4,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll)).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Fgmjml,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb1,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb2,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb3,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb4,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll)).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Fgmjml,spanCol = 1,spanRow = 1}
                                }
                            };


                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zrzqwdPercent, GuideIdeaChart = new List<object>() { list } });

            }

            //当前工况再热蒸汽温度—623
            if (steadyStateIC.Zrzqwd - 623 > configInfo.optimizingGuidePara.zrzqwdHighValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zrzqwd"] = "#FFFF00";
                string title = $"再热蒸汽温度偏高，当前工况再热蒸汽温度为：{steadyStateIC.Zrzqwd}℃，再热蒸汽温度偏高有超温的风险，影响机组的安全运行，建议通过人工干预减温水、调整燃烧等方式适当降低再热蒸汽温度。具体相关操作数据对比如下表：\r\n\n";
                string zrzqwdPercent = "1汽机" + CalcPercent2(623, steadyStateIC.Zrzqwd, sensitivefactorstandard.Zrqwd, false);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各烟气挡板开度（%）",spanCol = 4,spanRow = 1},
                                    new ChartRow() {name = "再热汽减温水流量（t/h）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各给煤机给煤量",spanCol = 6,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "挡板1",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板2",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板3",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "挡板4",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "A",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "B",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "C",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "D",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "E",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "F",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb1,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb2,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb3,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zrqyqdb4,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll)).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Fgmjml,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb1,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb2,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb3,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zrqyqdb4,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll)).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Agmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Bgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Cgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Dgmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Egmjml,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Fgmjml,spanCol = 1,spanRow = 1}
                                }
                            };
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zrzqwdPercent, GuideIdeaChart = new List<object>() { list } });

            }

            //标杆工况主蒸汽压力—当前工况主蒸汽压力>0.5MPa时
            if (standardIC.Zzqyl - steadyStateIC.Zzqyl > configInfo.optimizingGuidePara.zzqyldLowValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zzqyl"] = "#FFFF00";
                string title = $"主蒸汽压力偏低，当前工况主蒸汽压力为：{steadyStateIC.Zzqyl}MPa，标杆工况主蒸汽压力为：{standardIC.Zzqyl}MPa。主蒸汽压力偏低会影响蒸汽的做功能力，进而影响汽轮机效率和热耗率，" +
                    $"机组的经济性降低，建议通过适当增加燃料量、设置滑压偏置等方式提高主蒸汽压力。\r\n\n";

                string zzqylPercent = "1汽机" + CalcPercent2(standardIC.Zzqyl, steadyStateIC.Zzqyl, sensitivefactorstandard.Zqyl, false);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "燃料量（t/h）",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "滑压偏置",spanCol = 1,spanRow = 1},
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Rll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Hypz,spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                   new ChartRow() {name = standardIC.Rll,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Hypz,spanCol = 1,spanRow = 1}
                                }
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zzqylPercent, GuideIdeaChart = new List<object>() { list } });
            }

            //标杆工况再热蒸汽压力—当前工况再热蒸汽压力>0.5MPa时
            if (standardIC.Zrzqyl - steadyStateIC.Zrzqyl > configInfo.optimizingGuidePara.zrzqyldLowValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zrzqyl"] = "#FFFF00";
                string title = $"再热蒸汽压力偏低，当前工况再热蒸汽压力为：{steadyStateIC.Zrzqyl}MPa，标杆工况再热蒸汽压力为：{standardIC.Zrzqyl}MPa。再热蒸汽压力偏低会影响蒸汽的做功能力，进而影响汽轮机效率和热耗率，" +
                    $"机组的经济性降低，建议向标杆工况压力值调整。\r\n\n";

                string zrzqylPercent = "1汽机" + CalcPercent2(standardIC.Zrzqyl, steadyStateIC.Zrzqyl, sensitivefactorstandard.Zrqyl, false);
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zrzqylPercent, GuideIdeaChart = null });
            }

            //当前工况凝汽器背压—标杆工况凝汽器背压>1MPa时
            if (steadyStateIC.Nqqby - standardIC.Nqqby > configInfo.optimizingGuidePara.nnqbyHighValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["by"] = "#FFFF00";
                string title = $"凝汽器背压偏高，当前工况凝汽器背压为：{steadyStateIC.Nqqby}Kpa，标杆工况凝汽器背压为：{standardIC.Nqqby}Kpa。凝汽器背压偏高会影响蒸汽的做功能力，进而影响汽轮机效率和热耗率，机组的经济性降低，" +
                    $"建议在保证系统严密的前提下，通过改变循环水流量、改变间冷塔百叶窗开度、增启真空泵等方式适当降低凝汽器背压。具体相关操作数据对比如下表：\r\n\n";

                string nqqPercent = "1汽机" + CalcPercent2(steadyStateIC.Nqqby, standardIC.Nqqby, sensitivefactorstandard.By, false);
                List<List<object>> list = new List<List<object>>()
                            {
                                new List<object>()
                                {
                                    new ChartRow() {name = "",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "循环水压力（Mpa）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "循环水温度（℃）",spanCol = 1,spanRow = 2},
                                    new ChartRow() {name = "各真空泵电流（A）",spanCol = 3,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "A",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "B",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = "C",spanCol = 1,spanRow = 1}
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((steadyStateIC.Dynqqxhsjszg1yl + steadyStateIC.Dynqqxhsjszg2yl) / 2).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((steadyStateIC.Dynqqxhsjszg1wd + steadyStateIC.Dynqqxhsjszg2wd)/2).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zkbadl,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zkbbdl,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = steadyStateIC.Zkbcdl,spanCol = 1,spanRow = 1},
                                },
                                new List<object>()
                                {
                                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((standardIC.Dynqqxhsjszg1yl + standardIC.Dynqqxhsjszg2yl) / 2).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = Convert.ToDouble((standardIC.Dynqqxhsjszg1wd + standardIC.Dynqqxhsjszg2wd)/2).To2d(),spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zkbadl,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zkbbdl,spanCol = 1,spanRow = 1},
                                    new ChartRow() {name = standardIC.Zkbcdl,spanCol = 1,spanRow = 1},
                                }
                            };

                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = nqqPercent, GuideIdeaChart = new List<object>() { list } });
            }

            //当前工况再热器减温水流量—标杆工况再热器减温水流量>10t/h时
            if ((steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll) - (standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll) > configInfo.optimizingGuidePara.zrqjwsllHighValue && steadyStateIC.Qjrhhc > 0)
            {
                dictColor["zrjwsll"] = "#FFFF00";
                string title = $"再热器减温水流量偏大，当前工况再热器减温水流量为：{Convert.ToDouble(steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll).To2d()}t/h，标杆工况再热器减温水流量为{Convert.ToDouble(standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll).To2d()}t/h。" +
                    $"大量使用再热器减温水会降低汽轮机的热经济性。建议在保证安全的前提下，通过调整燃烧等方式降低再热蒸汽温度，进而减小再热器减温水流量。\r\n\n";

                string zrzqylPercent = "1汽机" + CalcPercent2(steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll, standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll, sensitivefactorstandard.Zrqjwsll, false);
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zrzqylPercent, GuideIdeaChart = null });
            }

            //当前工况给水流量—标杆工况给水流量>50t/h时
            if (steadyStateIC.Zgsll - standardIC.Zgsll > configInfo.optimizingGuidePara.zgsllHighValue && steadyStateIC.Qjrhhc > 0)
            {
                string title = $"给水流量偏大，当前工况给水流量为{steadyStateIC.Zgsll}t/h，标杆工况给水流量为{standardIC.Zgsll}t/h。给水流量偏大会造成机组经济性能降低。建议在保证安全的前提下，优化蒸汽的初参数和终参数来提高汽轮机的做功能力。\r\n\n";
                string zgsllPercent = "1汽机" + CalcPercent2(steadyStateIC.Zgsll, standardIC.Zgsll, sensitivefactorstandard.Jsll, false);
                guideIdeaContentAndCharts.Add(new GuideIdeaContentAndChart() { GuideIdeaContent = title, Percent = zgsllPercent, GuideIdeaChart = null });
            }

            guideIdeaContentAndCharts = guideIdeaContentAndCharts.OrderByDescending(item => item.Percent)
                                        .Select((item, index) => new GuideIdeaContentAndChart
                                        {
                                            GuideIdeaContent = $"{index + 1}){item.GuideIdeaContent}", // 更新序号
                                            Percent = item.Percent,
                                            GuideIdeaChart = item.GuideIdeaChart
                                        })
                                        .ToList();
        }

        /// <summary>
        /// 获取雷达图数据
        /// </summary>
        /// <param name="steadyStateIC">稳态工况</param>
        /// <param name="standardIC">标杆工况</param>
        /// <returns></returns>
        public static List<RadarChartContent> GetRadarChartContent(CldIndexcondition steadyStateIC, CldIndexcondition standardIC)
        {
            RadarChartContent radarChartContent1 = new RadarChartContent();
            radarChartContent1.Title = "锅炉效率敏感因子对标雷达图";
            //standardIC = null;

            List<Item> radarChartItemList1 = new List<Item>
            {
                new Item { Name = "A侧排烟温度", Value = CalcPercent2(steadyStateIC?.Acpywd, standardIC?.Acpywd,sensitivefactorstandard?.Acpywd,false)},
                new Item { Name = "B测排烟温度", Value = CalcPercent2(steadyStateIC?.Bcpywd, standardIC?.Bcpywd,sensitivefactorstandard?.Bcpywd,false)},
                new Item { Name = "氧量", Value = CalcPercent2(steadyStateIC ?.Yl, standardIC ?.Yl, sensitivefactorstandard?.Yl,true) },
                new Item { Name = "风量", Value =  CalcPercent2(steadyStateIC?.Zfl, standardIC?.Zfl,sensitivefactorstandard?.Fl,true)},
                new Item { Name = "空预器\n出口含氧量", Value = CalcPercent2(steadyStateIC?.KyqAckyqhyl + steadyStateIC?.KyqBckyqhyl , standardIC?.KyqAckyqhyl + standardIC?.KyqBckyqhyl,sensitivefactorstandard?.Kyqckhyl,false) },
                new Item { Name = "燃料量", Value = CalcPercent2(steadyStateIC ?.Rll, standardIC ?.Rll, sensitivefactorstandard?.Rll,true) },
            };
            radarChartContent1.RadarChartItems = radarChartItemList1;


            RadarChartContent radarChartContent2 = new RadarChartContent();
            radarChartContent2.Title = "汽机热耗敏感因子对标雷达图";
            List<Item> radarChartItemList2 = new List<Item>
            {
                new Item { Name = "主汽温度", Value = CalcPercent2(standardIC?.Zzqwd,steadyStateIC?.Zzqwd, sensitivefactorstandard?.Zqwd,false)},
                new Item { Name = "再热器\n减温水流量", Value = CalcPercent2(steadyStateIC?.Lzczrqjwsll + steadyStateIC?.Lyczrqjwsll,standardIC?.Lzczrqjwsll + standardIC?.Lyczrqjwsll,sensitivefactorstandard?.Zrqjwsll,false) },
                new Item { Name = "主汽压力", Value =  CalcPercent2(standardIC?.Zzqyl,steadyStateIC?.Zzqyl, sensitivefactorstandard?.Zqyl,false)},
                new Item { Name = "背压", Value = CalcPercent2(steadyStateIC?.Nqqby, standardIC ?.Nqqby,sensitivefactorstandard?.By,false) },
                new Item { Name = "再热汽温度", Value = CalcPercent2(standardIC?.Zrzqwd,steadyStateIC?.Zrzqwd, sensitivefactorstandard?.Zrqwd,false) },
                new Item { Name = "再热汽压力", Value = CalcPercent2(standardIC?.Zrzqyl,steadyStateIC?.Zrzqyl,sensitivefactorstandard?.Zrqyl,false) },
            };
            radarChartContent2.RadarChartItems = radarChartItemList2;

            return new List<RadarChartContent>() { radarChartContent1, radarChartContent2 };
        }


        public static Dictionary<string, string> dictColor = new Dictionary<string, string>() { { "zfl", null}, { "yl", null }, { "acpywd", null }, { "bcpywd", null }, { "kyqckhyl", null },
            { "zzqwd", null }, { "zrzqwd", null }, { "zzqyl", null }, { "zrzqyl", null }, { "by", null } ,{ "zrqjwsll", null }};

        public static string color = "#FFFF00";

        public static List<List<object>> GetSensitivefactorsChart(CldIndexcondition steadyStateIC, CldIndexcondition standardIC)
        {
            double? kyqckhyl_steadyStateIC = null;
            if (steadyStateIC != null && steadyStateIC.KyqAckyqhyl != null && steadyStateIC.KyqBckyqhyl != null)
            {
                kyqckhyl_steadyStateIC = Convert.ToDouble((steadyStateIC.KyqAckyqhyl + steadyStateIC.KyqBckyqhyl) / 2.0).To2d();
            }

            double? zrqjwsll_steadyStateIC = null;
            if (steadyStateIC != null && steadyStateIC.Lzczrqjwsll != null && steadyStateIC.Lyczrqjwsll != null)
            {
                zrqjwsll_steadyStateIC = Convert.ToDouble(steadyStateIC.Lzczrqjwsll + steadyStateIC.Lyczrqjwsll).To2d();
            }

            double? kyqckhyl_standardIC = null;
            if (standardIC != null && standardIC.KyqAckyqhyl != null && standardIC.KyqBckyqhyl != null)
            {
                kyqckhyl_standardIC = Convert.ToDouble((standardIC.KyqAckyqhyl + standardIC.KyqBckyqhyl) / 2.0).To2d();
            }

            double? zrqjwsll_standardIC = null;
            if (standardIC != null && standardIC.Lzczrqjwsll != null && standardIC.Lyczrqjwsll != null)
            {
                zrqjwsll_standardIC = Convert.ToDouble(standardIC.Lzczrqjwsll + standardIC.Lyczrqjwsll).To2d();
            }


            List<List<object>> list = new List<List<object>>()
            {
                new List<object>()
                {
                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "风量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "氧量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "A侧排烟温度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "B侧排烟温度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "空预器出口含氧量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "燃料量",spanCol = 1,spanRow = 1}
                },
                new List<object>()
                {
                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Zfl,spanCol = 1,spanRow = 1,color = dictColor["zfl"]},
                    new ChartRow() {name = steadyStateIC?.Yl,spanCol = 1,spanRow = 1,color = dictColor["yl"]},
                    new ChartRow() {name = steadyStateIC?.Acpywd,spanCol = 1,spanRow = 1,color = dictColor["acpywd"]},
                    new ChartRow() {name = steadyStateIC?.Bcpywd,spanCol = 1,spanRow = 1,color = dictColor["bcpywd"]},
                    new ChartRow() {name = kyqckhyl_steadyStateIC,spanCol = 1,spanRow = 1,color = dictColor["kyqckhyl"]},
                    new ChartRow() {name = steadyStateIC?.Rll,spanCol = 1,spanRow = 1}
                },
                new List<object>()
                {
                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zfl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Yl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Acpywd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Bcpywd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = kyqckhyl_standardIC,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Rll,spanCol = 1,spanRow = 1}
                },
                new List<object>()
                {
                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "主汽温度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "主汽压力",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "再热温度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "再热压力",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "再热减温水流量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "背压",spanCol = 1,spanRow = 1}
                },
                    new List<object>()
                {
                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Zzqwd,spanCol = 1,spanRow = 1,color = dictColor["zzqwd"]},
                    new ChartRow() {name = steadyStateIC?.Zzqyl,spanCol = 1,spanRow = 1,color = dictColor["zzqyl"]},
                    new ChartRow() {name = steadyStateIC?.Zrzqwd,spanCol = 1,spanRow = 1,color = dictColor["zrzqwd"]},
                    new ChartRow() {name = steadyStateIC?.Zrzqyl,spanCol = 1,spanRow = 1,color = dictColor["zrzqyl"]},
                    new ChartRow() {name = zrqjwsll_steadyStateIC,spanCol = 1,spanRow = 1,color = dictColor["zrqjwsll"]},
                    new ChartRow() {name = steadyStateIC?.Nqqby,spanCol = 1,spanRow = 1,color = dictColor["by"]}
                },
                new List<object>()
                {
                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zzqwd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zzqyl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zrzqwd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zrzqyl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = zrqjwsll_standardIC,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Nqqby,spanCol = 1,spanRow = 1}
                },
                new List<object>()
                {
                    new ChartRow() {name = "",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "负荷",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "环境温度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "低位发热量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "给水流量",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "过热度",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = "时间",spanCol = 1,spanRow = 1},
                },
                    new List<object>()
                {
                    new ChartRow() {name = "当前工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Fh,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Hjwd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Dwfrl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Zgsll,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Grd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = steadyStateIC?.Sj?.ToString("yyyy-MM-dd HH:mm:ss"),spanCol = 1,spanRow = 1},
                },
                new List<object>()
                {
                    new ChartRow() {name = "标杆工况",spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Fh,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Hjwd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Dwfrl,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Zgsll,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Grd,spanCol = 1,spanRow = 1},
                    new ChartRow() {name = standardIC?.Sj?.ToString("yyyy-MM-dd HH:mm:ss"),spanCol = 1,spanRow = 1},

                }
            };


            return list;
        }

        /// <summary>
        /// /获取专家库数据
        /// </summary>
        /// <param name="expertICList"></param>
        /// <returns></returns>
        public static ExpertContent GetExpertIC(List<CldIndexcondition> expertICList)
        {
            if (expertICList != null && expertICList.Count > 0)
            {
                ExpertContent expertContent = new ExpertContent();
                foreach (var item in expertICList)
                {
                    List<Item> expertList1 = new List<Item>
                            {
                                new Item { Name = "负荷", Value = item.Fh },
                                new Item { Name = "环境温度", Value = item.Hjwd },
                                new Item { Name = "低位发热量", Value = item.Dwfrl },
                            };


                    List<Item> expertList2 = new List<Item>
                            {
                                new Item { Name = "氧量", Value = item.Yl },
                                new Item { Name = "风量", Value = item.Zfl },
                                new Item { Name = "A侧排烟温度", Value = item.Acpywd },
                                new Item { Name = "B侧排烟温度", Value = item.Bcpywd },
                                new Item { Name = "飞灰含碳量", Value = item.Fhhtl },
                                new Item { Name = "炉渣含碳量", Value = item.Lzhtl },
                                new Item { Name = "空预器A出口含氧量", Value = item.KyqAckyqhyl },
                                new Item { Name = "空预器B出口含氧量", Value = item.KyqBckyqhyl },
                                new Item { Name = "背压", Value = item.Nqqby },
                                new Item { Name = "给水流量", Value = item.Zgsll },
                                new Item { Name = "过热度", Value = item.Grd },
                                new Item { Name = "再热器减温水流量", Value = item.Lyczrqjwsll + item.Lzczrqjwsll },
                                new Item { Name = "主蒸汽压力", Value = item.Zzqyl },
                                new Item { Name = "主蒸汽温度", Value = item.Zzqyl },
                                new Item { Name = "再热蒸汽压力", Value = item.Zrzqwd },
                                new Item { Name = "再热蒸汽温度", Value = item.Zrzqyl }
                            };
                    expertContent.ExpertItemList1.Add(expertList1);
                    expertContent.ExpertItemList2.Add(expertList2);
                }

                return expertContent;
            }
            return null;
        }

        /// <summary>
        /// 获取雷达因子曲线数据
        /// </summary>
        /// <param name="steadyStateIC">稳态工况</param>
        /// <param name="standardIC">标杆工况</param>
        /// <returns></returns>
        public static List<CurveContent> GetCurveContent(CldIndexcondition steadyStateIC, CldIndexcondition standardIC)
        {
            CurveContent curveContent1 = new CurveContent();
            curveContent1.Title = "锅炉效率敏感因子对标曲线图";
            curveContent1.CompareTime = steadyStateIC?.Sj ?? null;

            curveContent1.indexList = new List<Index>
                {
                    new Index{Desc = "风量",PointName = "dcs_tfa",Unit = "t/h",Operation = "sum",RealTimeValue = steadyStateIC?.Zfl,RefValue = standardIC?.Zfl},
                    new Index{Desc = "氧量",PointName = "dcs_o2",Unit = "%",Operation = "sum",RealTimeValue = steadyStateIC?.Yl,RefValue = standardIC?.Yl},
                    new Index{Desc = "A侧排烟温度",PointName = "dcs_hna10ct305",Operation = "sum",Unit = "℃",RealTimeValue = steadyStateIC?.Acpywd,RefValue = standardIC?.Acpywd},
                    new Index{Desc = "B侧排烟温度",PointName = "dcs_hna20ct305",Operation = "sum",Unit = "℃",RealTimeValue = steadyStateIC?.Bcpywd,RefValue = standardIC?.Bcpywd},
                    //new Index{Desc = "飞灰含碳量",PointName = "PageInput_Cfhc",Operation = "sum",Unit = "%",RealTimeValue = steadyStateIC?.Fhhtl,RefValue = standardIC?.Fhhtl},
                    //new Index{Desc = "炉渣含碳量",PointName = "PageInput_Clzc",Operation = "sum",Unit = "%",RealTimeValue = steadyStateIC?.Lzhtl,RefValue = standardIC?.Lzhtl},
                    new Index{Desc = "空预器出口含氧量",PointName = "dcs_hna10cq111,dcs_hna20cq111",Operation = "avg",Unit = "%",RealTimeValue = Convert.ToDouble((steadyStateIC?.KyqAckyqhyl + steadyStateIC?.KyqBckyqhyl) / 2).To2d(),RefValue = Convert.ToDouble((standardIC?.KyqAckyqhyl + standardIC?.KyqBckyqhyl) / 2).To2d()},
                    new Index{Desc = "燃料量",PointName = "dcs_tffreal".ToTableName(),Unit = "t/h",Operation = "sum",RealTimeValue = steadyStateIC?.Rll,RefValue = standardIC ?.Rll}
                };

            CurveContent curveContent2 = new CurveContent();
            curveContent2.Title = "汽机热耗敏感因子对标曲线图";
            curveContent2.CompareTime = steadyStateIC?.Sj ?? null;


            curveContent2.indexList = new List<Index>
                {
                    new Index{Desc = "主汽温度",PointName = "dcs_mst",Unit = "℃",Operation = "sum",RealTimeValue = steadyStateIC?.Zzqwd,RefValue = standardIC?.Zzqwd},
                    new Index{Desc = "主汽压力",PointName = "dcs_msp",Unit = "MPa",Operation = "sum",RealTimeValue = steadyStateIC?.Zzqyl,RefValue = standardIC?.Zzqyl},
                    new Index{Desc = "再热汽温度",PointName = "dcs_rhte",Unit = "℃",Operation = "sum",RealTimeValue = steadyStateIC?.Zrzqwd,RefValue = standardIC?.Zrzqwd},
                    new Index{Desc = "再热汽压力",PointName = "dcs_rhpres",Unit = "MPa",Operation = "sum",RealTimeValue = steadyStateIC?.Zrzqyl,RefValue = standardIC?.Zrzqyl},
                    new Index{Desc = "背压",PointName = "dcs_t1aivac_b1,dcs_t1aivac_b2,dcs_t1aivac_a1,dcs_t1aivac_a2",Operation = "avg",Unit = "KPa",RealTimeValue = steadyStateIC?.Nqqby,RefValue = standardIC?.Nqqby},
                    //new Index{Desc = "给水流量",PointName = "dcs_fw_flow",Unit = "t/h",Operation = "sum",RealTimeValue = steadyStateIC?.Zgsll,RefValue = standardIC?.Zgsll},
                    //new Index{Desc = "过热度",PointName = "dcs_shdeg",Unit = "℃",Operation = "sum",RealTimeValue = steadyStateIC?.Grd,RefValue = standardIC?.Grd},
                    new Index{Desc = "再热器减温水流量",PointName = "dcs_rha2sprflow,dcs_rha1sprflow,dcs_rhb2sprflow,dcs_rhb1sprflow",Operation = "sum",Unit = "t/h",RealTimeValue = Convert.ToDouble(steadyStateIC?.Lzczrqjwsll + steadyStateIC?.Lyczrqjwsll).To2d(),RefValue = Convert.ToDouble(standardIC?.Lzczrqjwsll + standardIC?.Lyczrqjwsll).To2d()}
                };
            return new List<CurveContent>() { curveContent1, curveContent2 };
        }

        public static BarChartContent GetBarChartContent(CldIndexcondition steadyStateIC, CldIndexcondition standardIC)
        {
            if (steadyStateIC != null)
            {
                if (standardIC != null)
                {
                    double maxQjrh = Math.Max(steadyStateIC.Qjrh ?? 0, standardIC.Qjrh ?? 0);

                    //实际工况的锅炉效率
                    double eb = (double)steadyStateIC.Glxl / 100;
                    //实际工况的汽机热耗
                    double qsr = (double)steadyStateIC.Qjrh;
                    //目标工况的汽机热耗
                    double qsrdst = (double)standardIC.Qjrh;
                    //目标工况的锅炉效率
                    double ebdst = (double)standardIC.Glxl / 100;

                    double qjrhhc = PCalc.ComputeQsr(eb, qsr, qsrdst).To2d();
                    double glxlhc = PCalc.ComputeEb(eb, ebdst, qsr).To2d();
                    double zhhc = (qjrhhc + glxlhc).To2d();



                    logger.InfoLog($"实际工况的锅炉效率:{eb.To2d()};实际工况的汽机热耗:{qsr.To2d()};目标工况的汽机热耗:{qsrdst.To2d()};目标工况的锅炉效率:{ebdst.To2d()};汽机热耗耗差:{qjrhhc};锅炉效率耗差:{glxlhc};实际工况时间：{steadyStateIC.Sj?.ToString("yyyy-MM-dd HH:mm:ss")};目标工况时间：{standardIC.Sj?.ToString("yyyy-MM-dd HH:mm:ss")}");


                    BarChartContent barChartContent = new BarChartContent()
                    {
                        Title = "核心指标参数实时对标",
                        barChartItems = new List<List<BarChartItem>>()
                        {
                            new List<BarChartItem>()
                            {
                                new BarChartItem(){ Title="锅炉效率\n%", RealData = new BarChartItemData(){ Display = Math.Floor(steadyStateIC.Glxl ?? 0),Percent = (double)steadyStateIC.Glxl}, StandardData = new BarChartItemData(){ Display =Math.Floor(standardIC.Glxl ?? 0),Percent = (double)standardIC.Glxl}},
                                new BarChartItem(){ Title="汽机热耗\nkJ/kWh", RealData = new BarChartItemData(){ Display = Math.Floor(steadyStateIC.Qjrh ?? 0),Percent = maxQjrh==0?0:(double)steadyStateIC.Qjrh /maxQjrh*100}, StandardData = new BarChartItemData(){ Display =Math.Floor(standardIC.Qjrh ?? 0),Percent = maxQjrh==0?0:(double)standardIC.Qjrh / maxQjrh*100 }}
                            },
                            new List<BarChartItem>()
                            {
                                new BarChartItem(){ Title="锅炉效率耗差\ng/kWh", RealData = new BarChartItemData(){ Display = glxlhc,Percent = 0} , StandardData = new BarChartItemData(){ Display = glxlhc,Percent = 0 }},
                                new BarChartItem(){ Title="汽机热耗耗差\ng/kWh", RealData = new BarChartItemData(){ Display = qjrhhc,Percent = 0} , StandardData = new BarChartItemData(){ Display = qjrhhc,Percent = 0}},
                                new BarChartItem(){ Title="耗差综合值\ng/kWh", RealData = new BarChartItemData(){ Display = zhhc,Percent = 0 } , StandardData = new BarChartItemData(){ Display = zhhc,Percent = 0}}
                            },
                        }
                    };
                    return barChartContent;
                }
                else
                {

                    BarChartContent barChartContent = new BarChartContent()
                    {
                        Title = "核心指标参数实时对标",
                        barChartItems = new List<List<BarChartItem>>()
                        {
                            new List<BarChartItem>()
                            {
                                new BarChartItem(){ Title="锅炉效率\n%", RealData = new BarChartItemData(){ Display =steadyStateIC.Glxl ?? 0,Percent = steadyStateIC.Glxl ?? 0 },StandardData = new BarChartItemData(){ Display = 0,Percent = 0 } },
                                new BarChartItem(){ Title="汽机热耗\nkJ/kWh", RealData = new BarChartItemData(){ Display =steadyStateIC.Qjrh ?? 0,Percent = 100 },StandardData = new BarChartItemData(){ Display = 0,Percent = 0 } }
                            },
                            new List<BarChartItem>()
                            {
                                new BarChartItem(){ Title="锅炉效率耗差\ng/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0} , StandardData = new BarChartItemData(){ Display = 0,Percent = 0 }},
                                new BarChartItem(){ Title="汽机热耗耗差\ng/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0} , StandardData = new BarChartItemData(){ Display = 0,Percent = 0}},
                                new BarChartItem(){ Title="耗差综合值\ng/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0 } , StandardData = new BarChartItemData(){ Display = 0,Percent = 0}}
                            },
                        }
                    };
                    return barChartContent;
                }
            }
            else
            {
                BarChartContent barChartContent = new BarChartContent()
                {
                    Title = "核心指标参数实时对标",

                    barChartItems = new List<List<BarChartItem>>()
                    {
                        new List<BarChartItem>()
                        {
                            new BarChartItem(){ Title="锅炉效率\n%", RealData = new BarChartItemData(){ Display = 0,Percent = 0 },StandardData = new BarChartItemData(){ Display = 0,Percent = 0 } },
                            new BarChartItem(){ Title="汽机热耗\nkJ/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0 },StandardData = new BarChartItemData(){ Display = 0,Percent = 0 } }
                        },
                        new List<BarChartItem>()
                        {
                            new BarChartItem(){ Title="锅炉效率耗差\ng/kWh", RealData = new BarChartItemData(){ Display =  0,Percent = 0 },StandardData = new BarChartItemData(){ Display = 0,Percent = 0 } },
                            new BarChartItem(){ Title="汽机热耗耗差\ng/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0 } ,StandardData = new BarChartItemData(){ Display = 0,Percent = 0 }},
                            new BarChartItem(){ Title="耗差综合值\ng/kWh", RealData = new BarChartItemData(){ Display = 0,Percent = 0 } ,StandardData = new BarChartItemData(){ Display = 0,Percent = 0 }}
                        },
                    }
                };
                return barChartContent;
            }
        }

        public static double? CalcPercent(double? steadyStateIC, double? standardIC)
        {
            if (steadyStateIC == null || standardIC == null)
            {
                return null;
            }

            if (standardIC == 0)
            {
                return 1;
            }
            double p = Math.Abs(((double)steadyStateIC - (double)standardIC) / (double)steadyStateIC);
            if (p < 0)
            {
                p = 0;
            }

            if (p > 1)
            {
                p = 1;
            }
            p = Math.Round(p * 100, 2);

            return p;
        }


        public static double? CalcPercent2(double? d1, double? d2, double? d, bool isAbs)
        {
            if (d1 == null || d2 == null || d == null)
            {
                return null;
            }

            if (d2 == 0)
            {
                return 1;
            }

            double p;
            if (isAbs)
            {
                p = Math.Abs((double)d1 - (double)d2) / (double)d;
            }
            else
            {
                p = ((double)d1 - (double)d2) / (double)d;
            }

            if (p < 0)
            {
                p = 0;
            }

            if (p > 1)
            {
                p = 1;
            }
            return p;
        }


        /// <summary>
        /// 手动工况对标
        /// </summary>
        public static void ManualCompare()
        {
            if (ExcuteEngine.optimizingFunction != null)
            {
                ICCompare(ExcuteEngine.optimizingFunction.SteadyStateICList);
            }
        }


        public static List<CldIndexcondition> icCompareList = new List<CldIndexcondition>();

        public static List<CldIndexcondition> icCompareOkList = new List<CldIndexcondition>();


        public static ICCompareResult GetICCompareResult()
        {
            return iCCompareResult;
        }

        public static bool CreateExpertICByDt(string dt, out string outstr)
        {
            outstr = "";
            var dict = new Dictionary<string, string>()
            {
                { "fh", "dcs_ammka01ag001ce01"},                                  //机组负荷
                { "hjwd" , "dcs_pan00ct301"},                           //环境温度
                { "dwfrl", "PageInput_Qnetar"},                             //低位发热量
                { "yl" , "dcs_o2"},                                    //氧量
                { "zfl", "dcs_tfa"},                               //总风量
                { "acpywd" , "dcs_hna10ct303"},                         //A侧排烟温度
                { "bcpywd", "dcs_hna20ct303"},                          //B侧排烟温度
                { "kyqackyqhyl" , "dcs_hna10cq111"},                    //空预器A出口烟气含氧量
                { "Kyqbckyqhyl", "dcs_hna20cq111"},                     //空预器B出口烟气含氧量
                { "fhhtl" , "PageInput_Cfhc"},                              //飞灰含碳量
                { "lzhtl", "PageInput_Clzc"},                               //炉渣含碳量
                { "zzqyl" , "dcs_msp"},                          //主蒸汽压力
                { "zrzqyl", "dcs_rhpres"},                       //再热蒸汽压力
                { "zzqwd" , "dcs_mst"},                     //主蒸汽温度
                { "Zrzqwd", "dcs_rhte"},                       //再热蒸汽温度
                { "nqqby" , "dcs_pan00cp101,dcs_ammag10cpse"},                          //凝汽器背压
                { "zgsll", "dcs_fw_flow"},                       //主给水流量
                { "Lzczrqjwsll", "dcs_rha2sprflow,dcs_rha1sprflow"},                         //#1炉左侧再热器减温水流量
                { "Lyczrqjwsll", "dcs_rhb2sprflow,dcs_rhb1sprflow"},                         //#1炉右侧再热器减温水流量
                { "grd", "dcs_shdeg"},                         //过热度
                { "rll", "dcs_tffreal"},                                           //燃料量
                { "sfwd", "dcs_hla21ct304,dcs_hla21ct305,dcs_hla21ct306,dcs_hla22ct304,dcs_hla22ct305,dcs_hla22ct306"},//送风温度
                { "pywd", "dcs_hna10ct305,dcs_hna20ct305"},                         //排烟温度
                { "hf", "PageInput_Aad"},                         //灰分
                { "fxs", "PageInput_Mad"},                         //分析水
                { "qsf", "PageInput_Mar"},                         //全水分
                { "hff", "PageInput_Vad"}                         //挥发分
            };


            DateTime dateTime = Convert.ToDateTime(dt);
            string timeinterval = $"time <= '{dateTime.ToUTCString()}' and time > '{dateTime.AddHours(-1).ToUTCString()}'";
            string strsql = "";
            foreach (var item in dict)
            {
                if (item.Value.Contains(","))
                {
                    List<string> pns = item.Value.Split(',').ToList();
                    foreach (var pn in pns)
                    {
                        strsql += $"select last(pvalue) as pvalue from {pn.ToTableName()} where {timeinterval};";
                    }
                }
                else
                {
                    if (item.Value.ToTableName() == "PageInput_Cfhc".ToTableName() || item.Value.ToTableName() == "PageInput_Clzc".ToTableName() || item.Value.ToTableName() == "PageInput_Mad".ToTableName())
                    {
                        string timeinterval2 = $"time <= '{dateTime.ToUTCString()}'";
                        strsql += $"select last(pvalue) as pvalue from {item.Value.ToTableName()} where {timeinterval2};";
                    }
                    else
                    {
                        strsql += $"select last(pvalue) as pvalue from {item.Value.ToTableName()} where {timeinterval};";
                    }

                }
            }

            using (HttpClient httpClient = new HttpClient())
            {
                try
                {
                    InfluxQuery influxQuery = new InfluxQuery()
                    {
                        sql = strsql
                    };

                    var json = JsonConvert.SerializeObject(influxQuery);
                    var content = new StringContent(json, Encoding.UTF8, "application/json");
                    var response = httpClient.PostAsync(ExcuteEngine.configInfo.InfluxDBQueryApiurl, content).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var responseContent = response.Content.ReadAsStringAsync().Result;
                        var responseMsg = JsonConvert.DeserializeObject<Response2<List<DataItem>>>(responseContent);



                        for (int i = 0; i < dict.Keys.Count; i++)
                        {
                            if (responseMsg.Data[i].series == null)
                            {
                                outstr = "数据获取获取不完整。";
                                return false;
                            }

                        }

                        CldIndexcondition eic = new CldIndexcondition();
                        eic.Fh = Convert.ToDouble(responseMsg.Data[0].series[0].values[0][1]).To2d();
                        eic.Hjwd = Convert.ToDouble(responseMsg.Data[1].series[0].values[0][1]).To2d();
                        eic.Dwfrl = Math.Round(Convert.ToDouble(responseMsg.Data[2].series[0].values[0][1]) * ExcuteEngine.dwfrlCoefficient, 0);
                        eic.Yl = Convert.ToDouble(responseMsg.Data[3].series[0].values[0][1]).To2d();
                        eic.Zfl = Convert.ToDouble(responseMsg.Data[4].series[0].values[0][1]).To2d();
                        eic.Acpywd = Convert.ToDouble(responseMsg.Data[5].series[0].values[0][1]).To2d();
                        eic.Bcpywd = Convert.ToDouble(responseMsg.Data[6].series[0].values[0][1]).To2d();
                        eic.KyqAckyqhyl = Convert.ToDouble(responseMsg.Data[7].series[0].values[0][1]).To2d();
                        eic.KyqBckyqhyl = Convert.ToDouble(responseMsg.Data[8].series[0].values[0][1]).To2d();
                        eic.Fhhtl = Convert.ToDouble(responseMsg.Data[9].series[0].values[0][1]).To2d();
                        eic.Lzhtl = Convert.ToDouble(responseMsg.Data[10].series[0].values[0][1]).To2d();
                        eic.Zzqwd = Convert.ToDouble(responseMsg.Data[11].series[0].values[0][1]).To2d();
                        eic.Zzqyl = Convert.ToDouble(responseMsg.Data[12].series[0].values[0][1]).To2d();
                        eic.Zrzqwd = Convert.ToDouble(responseMsg.Data[13].series[0].values[0][1]).To2d();
                        eic.Zrzqyl = Convert.ToDouble(responseMsg.Data[14].series[0].values[0][1]).To2d();
                        eic.Nqqby = ((Convert.ToDouble(responseMsg.Data[15].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[16].series[0].values[0][1])) / 2).To2d();
                        eic.Zgsll = Convert.ToDouble(responseMsg.Data[17].series[0].values[0][1]).To2d();
                        eic.Lzczrqjwsll = ((Convert.ToDouble(responseMsg.Data[18].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[19].series[0].values[0][1])) / 2).To2d();
                        eic.Lyczrqjwsll = ((Convert.ToDouble(responseMsg.Data[20].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[21].series[0].values[0][1])) / 2).To2d();
                        eic.Grd = Convert.ToDouble(responseMsg.Data[22].series[0].values[0][1]).To2d();
                        eic.Rll = Convert.ToDouble(responseMsg.Data[23].series[0].values[0][1]).To2d();
                        eic.Sfwd = ((Convert.ToDouble(responseMsg.Data[24].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[25].series[0].values[0][1]) +
                                        Convert.ToDouble(responseMsg.Data[26].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[27].series[0].values[0][1]) +
                                        Convert.ToDouble(responseMsg.Data[28].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[29].series[0].values[0][1])) / 6).To2d();
                        eic.Pywd = ((Convert.ToDouble(responseMsg.Data[30].series[0].values[0][1]) + Convert.ToDouble(responseMsg.Data[31].series[0].values[0][1])) / 2).To2d();
                        eic.Hf = Convert.ToDouble(responseMsg.Data[32].series[0].values[0][1]).To2d();
                        eic.Fxs = Convert.ToDouble(responseMsg.Data[33].series[0].values[0][1]).To2d();
                        eic.Qsf = Convert.ToDouble(responseMsg.Data[34].series[0].values[0][1]).To2d();
                        eic.Hff = Convert.ToDouble(responseMsg.Data[35].series[0].values[0][1]).To2d();


                        if (ExcuteEngine.optimizingFunction != null)
                        {
                            List<string> groupInfo = ExcuteEngine.optimizingFunction.FindGroupInfo(eic.Fh, eic.Hjwd, eic.Dwfrl);
                            if (groupInfo != null && groupInfo.Count > 0)
                            {
                                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                                {
                                    List<CldIndexcondition> cldIndexconditions = warnContext.CldIndexconditions.AsQueryable().Where(x => x.Fhqj == groupInfo[0] && x.Hjwdqj == groupInfo[1] && x.Dwfrlqj == groupInfo[2] && x.Type == 1).ToList();
                                    if (cldIndexconditions.Count >= 5)//每个分组的专家库只能添加5条数据
                                    {
                                        outstr = "每个分组的专家库只能添加5条数据";
                                        return false;
                                    }
                                    double jzfh = eic.Fh ?? 0;
                                    double dwfrl = eic.Dwfrl ?? 0;
                                    double rll = eic.Rll ?? 0;
                                    double hql = 4.5;//含氢量   

                                    eic.Fhqj = groupInfo[0];
                                    eic.Hjwdqj = groupInfo[1];
                                    eic.Dwfrlqj = groupInfo[2];
                                    eic.Sj = dateTime;
                                    string jstr = $"{{\"ov\":{eic.Yl},\"tpy\":{eic.Pywd},\"tsf\":{eic.Sfwd},\"D\":{eic.Zgsll},\"Ded\":1857,\"Mar\":{eic.Qsf},\"Har\":{hql},\"Mad\":{eic.Fxs},\"Aad\":{eic.Hf},\"Vad\":{eic.Hff},\"Qnetar\":{dwfrl},\"Clzc\":{eic.Fhhtl},\"Cfhc\":{eic.Lzhtl},\"X\":[1000, 750, 500, 400], \"y\": [0.38,0.37,0.36,0.35], \"pw\": {jzfh}}}";
                                    PerformanceCalc.BoilerData boilerData = PerformanceCalc.PCalc.calcBoilerValue(jstr, out int status);
                                    double glxl = 0;
                                    if (boilerData != null)
                                    {
                                        glxl = boilerData.e;
                                    }

                                    //发电煤耗
                                    double coal = PerformanceCalc.PCalc.ComputeCoal(dwfrl, rll, jzfh);

                                    //汽机热耗
                                    double? qjrh = InfluxDBHelp.GetQjrhValue(eic.Sj);


                                    //锅炉效率目标值
                                    double ebdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 95.18 / 100, 95.23 / 100, 95.28 / 100, 95.13 / 100, 95.10 / 100 });

                                    //锅炉效率耗差
                                    double glxlhc = PerformanceCalc.PCalc.ComputeHC(glxl, ebdst, coal);


                                    if (qjrh.HasValue)
                                    {
                                        //汽机热耗目标值
                                        double qjrhdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 7504d, 7594d, 7877d, 8078d, 8433d });

                                        //汽机热耗耗差
                                        double qjrhhc = PerformanceCalc.PCalc.ComputeHC(3600 / qjrh.Value, 3600 / qjrhdst, coal);

                                        eic.Qjrh = qjrh?.To2d();
                                        eic.Qjrhhc = qjrhhc.To2d();
                                        eic.Zhhc = (qjrhhc + glxlhc).To2d();
                                    }

                                    eic.Glxl = (glxl * 100).To2d();
                                    eic.Glxlhc = glxlhc.To2d();
                                    eic.Type = 1;
                                    warnContext.CldIndexconditions.Add(eic);
                                    warnContext.SaveChanges();

                                    return true;
                                }
                            }
                            else
                            {
                                outstr = "没有找到对应的分组";
                                return false;
                            }

                        }


                        outstr = "没有找寻优计算块";
                        return false;
                    }
                    else
                    {
                        outstr = response.ReasonPhrase + "-" + response.RequestMessage.ToString();
                        return false;
                    }
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }



        public static bool DeleteExpertIC(int icid)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                {
                    CldIndexcondition cldic = warnContext.CldIndexconditions.FirstOrDefault(x => x.Id == icid && x.Type == 1);
                    if (cldic != null)
                    {
                        warnContext.CldIndexconditions.Remove(cldic);
                        warnContext.SaveChanges();

                        return false;
                    }
                }

                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static object UpdateExpertIC(CldIndexcondition eic)
        {
            try
            {
                if (eic.Id > 0)
                {
                    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
                    {
                        double jzfh = eic.Fh ?? 0;
                        double dwfrl = eic.Dwfrl ?? 0;
                        double rll = eic.Rll ?? 0;
                        double hql = 4.5;//含氢量   

                        eic.Sj = DateTime.Now;
                        string jstr = $"{{\"ov\":{eic.Yl},\"tpy\":{eic.Pywd},\"tsf\":{eic.Sfwd},\"D\":{eic.Zgsll},\"Ded\":1857,\"Mar\":{eic.Qsf},\"Har\":{hql},\"Mad\":{eic.Fxs},\"Aad\":{eic.Hf},\"Vad\":{eic.Hff},\"Qnetar\":{dwfrl},\"Clzc\":{eic.Fhhtl},\"Cfhc\":{eic.Lzhtl},\"X\":[1000, 750, 500, 400], \"y\": [0.38,0.37,0.36,0.35], \"pw\": {jzfh}}}";
                        PerformanceCalc.BoilerData boilerData = PerformanceCalc.PCalc.calcBoilerValue(jstr, out int status);
                        double glxl = 0;
                        if (boilerData != null)
                        {
                            glxl = boilerData.e;
                        }

                        ////发电煤耗
                        //double coal = PerformanceCalc.PCalc.ComputeCoal(dwfrl, rll, jzfh);

                        ////汽机热耗
                        //double qjrh = PerformanceCalc.PCalc.ComputeQsr(coal, glxl);

                        ////锅炉效率目标值
                        //double ebdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 95.18 / 100, 95.23 / 100, 95.28 / 100, 95.13 / 100, 95.10 / 100 });

                        ////锅炉效率耗差
                        //double glxlhc = PerformanceCalc.PCalc.ComputeHC(glxl, ebdst, coal);

                        ////汽机热耗目标值
                        //double qjrhdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 7504d, 7594d, 7877d, 8078d, 8433d });

                        ////汽机热耗耗差
                        //double qjrhhc = PerformanceCalc.PCalc.ComputeHC(3600 / qjrh, 3600 / qjrhdst, coal);


                        //eic.Zhhc = (qjrhhc + glxlhc).To2d();
                        //eic.Glxl = (glxl * 100).To2d();
                        //eic.Glxlhc = glxlhc.To2d();
                        //eic.Qjrh = qjrh.To2d();
                        //eic.Qjrhhc = qjrhhc.To2d();

                        //发电煤耗
                        double coal = PerformanceCalc.PCalc.ComputeCoal(dwfrl, rll, jzfh);

                        //汽机热耗
                        double? qjrh = InfluxDBHelp.GetQjrhValue(eic.Sj);

                        //锅炉效率目标值
                        double ebdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 95.18 / 100, 95.23 / 100, 95.28 / 100, 95.13 / 100, 95.10 / 100 });

                        //锅炉效率耗差
                        double glxlhc = PerformanceCalc.PCalc.ComputeHC(glxl, ebdst, coal);

                        if (qjrh.HasValue)
                        {
                            //汽机热耗目标值
                            double qjrhdst = PerformanceCalc.PCalc.compute_dst(jzfh, new List<double>() { 7504d, 7594d, 7877d, 8078d, 8433d });

                            //汽机热耗耗差
                            double qjrhhc = PerformanceCalc.PCalc.ComputeHC(3600 / qjrh.Value, 3600 / qjrhdst, coal);

                            eic.Qjrh = qjrh?.To2d();
                            eic.Qjrhhc = qjrhhc.To2d();
                            eic.Zhhc = (qjrhhc + glxlhc).To2d();
                        }

                        eic.Glxl = (glxl * 100).To2d();
                        eic.Glxlhc = glxlhc.To2d();

                        warnContext.CldIndexconditions.Update(eic);
                        warnContext.SaveChanges();

                        return true;
                    }
                }
                else
                {
                    return false;

                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <summary>
        /// 导出标杆库没有的分组数据
        /// </summary>
        /// <returns></returns>
        public static List<ICGroup> GetICGroup()
        {
            List<ICGroup> iCGroups = new List<ICGroup>();
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                List<CldIndexcondition> cldIndexconditions = warnContext.CldIndexconditions.ToList();
                if (ExcuteEngine.optimizingFunction != null)
                {

                    List<ICSegHeader> listFhGroup = ExcuteEngine.optimizingFunction.fhSegList;
                    List<ICSegHeader> listhjwdGroup = ExcuteEngine.optimizingFunction.hjwdSegList;
                    List<ICSegHeader> listdwfrlGroup = ExcuteEngine.optimizingFunction.dwfrlSegList;

                    foreach (var fh in listFhGroup)
                    {
                        foreach (var hjwd in listhjwdGroup)
                        {
                            foreach (var dwfrl in listdwfrlGroup)
                            {
                                var group = new ICGroup()
                                {
                                    Fhqj = fh.Min + "^" + fh.Max,
                                    Hjwdqj = hjwd.Min + "^" + hjwd.Max,
                                    Dwfrlqj = dwfrl.Min + "^" + dwfrl.Max
                                };

                                CldIndexcondition cldIndexcondition = cldIndexconditions.FirstOrDefault(x => x.Fhqj == group.Fhqj && x.Hjwdqj == group.Hjwdqj && x.Dwfrlqj == group.Dwfrlqj);
                                if (cldIndexcondition == null)
                                {
                                    iCGroups.Add(group);
                                }
                            }
                        }
                    }
                }

            }

            return iCGroups;
        }


        public static bool ICClean(CldIndexcondition ic)
        {
            //1)主汽压力偏差（>0.5MPa）
            if (Math.Abs((ic.Zzqyl - ic.zzqylsdz) ?? 0) > 0.8)
            {
                logger.InfoLog($"对标工况被清理，主汽压力偏差>0.5，被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //2)汽温偏差（主汽温度<585℃或>610℃、再热汽温<580℃或>623℃）
            if ((ic.Zzqwd < 585 || ic.Zzqwd > 610) || (ic.Zrzqwd < 580 || ic.Zrzqwd > 623))
            {
                logger.InfoLog($"对标工况被清理，汽温偏差（主汽温度<585℃或>610℃、再热汽温<580℃或>623℃），被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //3)炉膛负压
            if (ic.ltfy > 100 || ic.ltfy < -200)
            {
                logger.InfoLog($"对标工况被清理，炉膛负压<-200Pa或>100Pa，被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //4)氧量（实际值）<1.5%或者>6.0%,并且偏差>0.5
            if (ic.Yl < 1.5 || ic.Yl > 6 && Math.Abs((double)ic.Yl - (double)ic.Ylsdz) > 0.5)
            {
                logger.InfoLog($"对标工况被清理，氧量（实际值）<1.5%或者>6.0%,并且偏差>0.5，被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //5)高低加未运行（高加：#3高加抽汽电动门开度<10%；低加：#6低加抽汽电动门开度<10%）
            if (ic.gjcqddmkd < 10 || ic.djcqddmkd < 10)
            {
                logger.InfoLog($"对标工况被清理，高加抽汽电动门开度<10%或低加抽汽电动门开度<10%，被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //6)除氧器水位偏差（>200mm）
            if (Math.Abs(ic.cyqyw - ic.cyqywsdz) > 200)
            {
                logger.InfoLog($"对标工况被清理，除氧器水位偏差（>200mm），被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }

            //8)汽机调门总指令（<50%或>95%）
            if (ic.qjtmzzl < 50 || ic.qjtmzzl > 95)
            {
                logger.InfoLog($"对标工况被清理，汽机调门总指令<50%或>95%，被清理工况为{JsonConvert.SerializeObject(ic)}。");
                return true;
            }
            return false;
        }

        /// <summary>
        /// 添加或更新敏感因子
        /// </summary>
        /// <param name="factors"></param>
        /// <returns></returns>
        public static bool AddOrUpdateSensitiveFactors(Sensitivefactorstandard factors)
        {
            using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
            {
                Sensitivefactorstandard sensitivefactorstandard = warnContext.Sensitivefactorstandards.FirstOrDefault(x => x.Id == factors.Id);
                if (sensitivefactorstandard != null)
                {

                    sensitivefactorstandard.Yl = factors.Yl;
                    sensitivefactorstandard.Fl = factors.Fl;
                    sensitivefactorstandard.Acpywd = factors.Acpywd;
                    sensitivefactorstandard.Bcpywd = factors.Bcpywd;

                    sensitivefactorstandard.Fhhtl = factors.Fhhtl;
                    sensitivefactorstandard.Lzhtl = factors.Lzhtl;
                    sensitivefactorstandard.Kyqckhyl = factors.Kyqckhyl;
                    sensitivefactorstandard.Rll = factors.Rll;
                    sensitivefactorstandard.Zqyl = factors.Zqyl;
                    sensitivefactorstandard.Zqwd = factors.Zqwd;
                    sensitivefactorstandard.Zrqyl = factors.Zrqyl;
                    sensitivefactorstandard.Zrqwd = factors.Zrqwd;
                    sensitivefactorstandard.By = factors.By;
                    sensitivefactorstandard.Jsll = factors.Jsll;
                    sensitivefactorstandard.Zrqjwsll = factors.Zrqjwsll;
                    sensitivefactorstandard.Grd = factors.Grd;
                    sensitivefactorstandard.Forget = factors.Forget;

                    warnContext.Sensitivefactorstandards.Update(sensitivefactorstandard);



                }
                else
                {
                    sensitivefactorstandard = new Sensitivefactorstandard();
                    sensitivefactorstandard = factors;
                    warnContext.Sensitivefactorstandards.Add(sensitivefactorstandard);
                }
                warnContext.SaveChanges();

            }
            return true;
        }


public static Sensitivefactorstandard Getsensitivefactorstandards()
{
    using (WarnContext warnContext = new WarnContext(configInfo.mysqlConn))
    {
        var sensitivefactorstandard = warnContext.Sensitivefactorstandards.FirstOrDefault();
        
        if (sensitivefactorstandard == null)
        {
            // 返回默认对象或抛出明确异常
            throw new InvalidOperationException("未找到敏感因子标准数据");
            // 或者 return new Sensitivefactorstandard(); // 返回默认对象
        }
        
        return sensitivefactorstandard;
    }
}


        public static bool AddOrUpdate(warnpointoperationguide warnpointoperationguide)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    if (warnpointoperationguide != null)
                    {
                        if (warnpointoperationguide.Id > 0)
                        {
                            warnContext.warnpointoperationguide.Update(warnpointoperationguide);
                        }
                        else
                        {
                            warnpointoperationguide newwarnpointoperationguide = warnContext.warnpointoperationguide.FirstOrDefault(x => x.WarnPointName == warnpointoperationguide.WarnPointName && x.ModelOrRule == warnpointoperationguide.ModelOrRule);
                            if (newwarnpointoperationguide == null)
                            {
                                warnContext.warnpointoperationguide.Add(warnpointoperationguide);
                            }
                            else
                            {
                                return false;
                            }
                        }
                        warnContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static bool Delete(int id)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    warnpointoperationguide warnpointoperationguide = warnContext.warnpointoperationguide.FirstOrDefault(x => x.Id == id);
                    if (warnpointoperationguide != null)
                    {
                        warnContext.warnpointoperationguide.Remove(warnpointoperationguide);
                        warnContext.SaveChanges();
                        return true;
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public static List<warnpointoperationguide> GetAll()
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    return warnContext.warnpointoperationguide.ToList();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static string GetOperationGuide(string pn, int type)
        {
            try
            {
                using (WarnContext warnContext = new WarnContext(ExcuteEngine.configInfo.mysqlConn))
                {
                    warnpointoperationguide warnpointoperationguide = warnContext.warnpointoperationguide.FirstOrDefault(x => x.WarnPointName == pn && x.ModelOrRule == type);
                    if (warnpointoperationguide != null)
                    {
                        return warnpointoperationguide.OperationGuide;
                    }
                    return "";
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }
    public class getdata
    {
        public string sql { get; set; }
    }
    public class SeriesItem1
    {
        /// <summary>
        /// 
        /// </summary>
        public List<string> columns { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<List<string>> values { get; set; }
    }

    public class DataItem1
    {
        /// <summary>
        /// 
        /// </summary>
        public List<SeriesItem1> series { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int statement_id { get; set; }
    }

    public class Root1
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public List<DataItem1> data { get; set; }
        /// <summary>
        /// 成功
        /// </summary>
        public string msg { get; set; }
    }
    public class standardhc
    {
        /// <summary>
        /// 
        /// </summary>
        public double? glxl { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double? qjrh { get; set; }
    }
}
