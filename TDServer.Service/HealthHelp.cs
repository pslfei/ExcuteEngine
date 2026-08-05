using DBServer.LogServer;
using DCSCommon;
using DCSType;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Collections;
using System.Data;

namespace TDServer.Service
{
    public class HealthHelp
    {
        private static LoggerService<HealthHelp> logger = new LoggerService<HealthHelp>();


        public class HealthSystemScore
        {
            /// <summary>
            /// 系统编号
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// 系统名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 系统得分
            /// </summary>
            public float Score { get; set; }


            public List<HealthDeviceScore> HealthDeviceScores { get; set; } = new List<HealthDeviceScore>();
        }


        public class HealthDeviceScore
        {
            /// <summary>
            /// 设备编号
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 设备得分
            /// </summary>
            public float Score { get; set; }

            public List<HealthIndicatorScore> HealthIndicatorScores { get; set; } = new List<HealthIndicatorScore>();
        }


        public class HealthIndicatorScore
        {
            /// <summary>
            /// 指标编号
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// 指标名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 指标得分
            /// </summary>
            public float Score { get; set; }

            /// <summary>
            /// tdengine实例化名称
            /// </summary>
            public string InstanceName { get; set; }


            /// <summary>
            /// 报警值1
            /// </summary>
            public float AlarmValue1 { get; set; }

            /// <summary>
            /// 跳闸值1
            /// </summary>
            public float TripValue1 { get; set; }


            /// <summary>
            /// 报警值2
            /// </summary>
            public float? AlarmValue2 { get; set; }

            /// <summary>
            /// 跳闸值2
            /// </summary>
            public float? TripValue2 { get; set; }

            public List<PointScore> PointScores { get; set; } = new List<PointScore>();
        }



        public class DSystem
        {
            /// <summary>
            /// 系统编号
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// 系统名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 健康度聚合模式（0：取最低，1：取最高，2：平均……）
            /// </summary>
            public int AggregationPattren { get; set; }

            public float Score { get; set; }

            public List<DDevice> Devices { get; set; } = new List<DDevice>();

        }


        public class DDevice
        {
            /// <summary>
            /// 设备编号
            /// </summary>
            public int ID { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            public string Name { get; set; }

            /// <summary>
            /// 系统编号
            /// </summary>
            public int SystemID { get; set; }

            public float Score { get; set; }

            public double weight { get; set; }

            public List<DHealthIndicator> HealthIndicators { get; set; } = new List<DHealthIndicator>();

        }

        public class PointScore
        {
            public string PN { get; set; }
            public float Score { get; set; }

            public string Desc { get; set; }
        }

        public class DHealthIndicator
        {
            /// <summary>
            /// 设备编号
            /// </summary>
            public int DeviceID { get; set; }

            /// <summary>
            /// 设备名称
            /// </summary>
            public string DeviceName { get; set; }

            /// <summary>
            /// 指标编号
            /// </summary>
            public int IndicatorID { get; set; }

            /// <summary>
            /// 指标名称
            /// </summary>
            public string IndicatorName { get; set; }

            /// <summary>
            /// 使用点名
            /// </summary>
            public List<string> UsePoint { get; set; }

            /// <summary>
            /// 模式
            /// </summary>
            public string Mode { get; set; }

            /// <summary>
            /// 正常值1
            /// </summary>
            public float NormalValue1 { get; set; }

            /// <summary>
            /// 报警值1
            /// </summary>
            public float AlarmValue1 { get; set; }

            /// <summary>
            /// 跳闸值1
            /// </summary>
            public float TripValue1 { get; set; }

            /// <summary>
            /// 正常值2
            /// </summary>
            public float? NormalValue2 { get; set; }

            /// <summary>
            /// 报警值2
            /// </summary>
            public float? AlarmValue2 { get; set; }

            /// <summary>
            /// 跳闸值2
            /// </summary>
            public float? TripValue2 { get; set; }

            /// <summary>
            /// Enable条件点名
            /// </summary>
            public string EnablePoint { get; set; }

            /// <summary>
            /// 聚合模式
            /// </summary>
            public string AggregationPattren { get; set; }

            /// <summary>
            /// 得分
            /// </summary>
            public LA Score { get; set; }

            public double weight { get; set; }

            /// <summary>
            /// 实例化名称
            /// </summary>
            public string InstanceName { get; set; }

            /// <summary>
            /// 设备运行条件
            /// </summary>
            public string DeviceRunCondition { get; set; }

            public Function InstanceFc { get; set; }

            public List<PointScore> PointScoreList { get; set; }

        }


        /// <summary>
        /// 获取excel内容（.xlsx .xls）
        /// 备注：这个方法只读取了第一个sheet的数据
        /// </summary>
        /// <param name="filePath">excel文件路径 eg：D:\A.xlsx</param>
        /// <param name="dt">excel内数据（无标题）</param>
        /// <param name="excelTitles">excel内标题</param>
        /// <param name="startIndex">数据开始读取的行数位置（值为1默认有标题，excelTitles为空，值为0有标题，且赋值excelTitles）</param>
        private static bool ReadExcelToDataSet(string filePath, out DataSet ds)
        {
            ArrayList excelTitles;
            int startIndex = 1;


            //excel内数据（无标题）
            ds = new DataSet();
            //excel内标题
            excelTitles = new ArrayList();
            try
            {
                using (FileStream fsRead = File.OpenRead(filePath))
                {
                    IWorkbook wk = null;
                    //获取后缀名
                    string extension = filePath.Substring(filePath.LastIndexOf(".")).ToString().ToLower();
                    //判断是否是excel文件
                    if (extension == ".xlsx" || extension == ".xls")
                    {
                        try
                        {
                            wk = new XSSFWorkbook(fsRead);
                        }
                        catch (Exception error)
                        {
                            wk = new HSSFWorkbook(fsRead);
                        }

                        for (int k = 0; k < wk.NumberOfSheets; k++)
                        {
                            //获取第一个sheet TODO 若有多个Sheet这里需要循环
                            ISheet sheet = wk.GetSheetAt(k);
                            //获取第一行
                            IRow headrow = sheet.GetRow(0);
                            DataTable dt = new DataTable();
                            for (int i = headrow.FirstCellNum; i < headrow.Cells.Count; i++)
                            {
                                ICell cell = headrow.GetCell(i);
                                var tempV = GetCellValue(cell);
                                //创建列
                                DataColumn datacolum = new DataColumn(tempV);
                                dt.Columns.Add(datacolum);
                                //读取标题
                                if ((!string.IsNullOrEmpty(tempV)) && startIndex != 0)
                                {
                                    excelTitles.Add(tempV);
                                }
                            }

                            //读取每行
                            for (int r = startIndex; r <= sheet.LastRowNum; r++)
                            {
                                bool result = false;
                                DataRow dr = dt.NewRow();
                                //获取当前行
                                IRow row = sheet.GetRow(r);
                                //读取每列 采用headrow行数原因为，row.Cells.Count遇空会跳过
                                for (int j = 0; j < headrow.Cells.Count; j++)
                                {
                                    //获取单元格的值
                                    dr[j] = GetCellValue(row.GetCell(j));
                                    //全为空则不取
                                    if (dr[j].ToString() != "") result = true;
                                }
                                if (result == true)
                                {
                                    dt.Rows.Add(dr); //把每行追加到DataTable
                                }
                            }

                            ds.Tables.Add(dt);
                        }
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex);
                return false;
            }
        }

        /// <summary>
        /// 读取Cell数据
        /// </summary>
        private static string GetCellValue(ICell cell)
        {
            if (cell == null) return string.Empty;
            switch (cell.CellType)
            {
                case CellType.Blank: //空数据类型 这里类型注意一下，不同版本NPOI大小写可能不一样,有的版本是Blank（首字母大写)
                    return string.Empty;
                case CellType.Boolean: //bool类型
                    return cell.BooleanCellValue.ToString();
                case CellType.Error:
                    return cell.ErrorCellValue.ToString();
                case CellType.Numeric: //数字类型
                                       //日期类型 其它数字
                    return (DateUtil.IsCellDateFormatted(cell) ? cell.DateCellValue.ToString() : cell.NumericCellValue.ToString());
                case CellType.String: //string 类型
                    return cell.StringCellValue;
                case CellType.Formula: //带公式类型
                    try
                    {
                        HSSFFormulaEvaluator e = new HSSFFormulaEvaluator(cell.Sheet.Workbook);
                        e.EvaluateInCell(cell);
                        return cell.ToString();
                    }
                    catch
                    {
                        return cell.NumericCellValue.ToString();
                    }
                case CellType.Unknown: //无法识别类型
                default: //默认类型
                    return cell.ToString();//
            }
        }


        public static List<DSystem> GetHealthInfo(string filePath)
        {
            try
            {
                if (!File.Exists($"./{filePath}"))
                {
                    return null;
                }
                DataSet ds;
                bool bResult = ReadExcelToDataSet($"./{filePath}", out ds);
                if (bResult)
                {
                    if (ds.Tables.Count == 3)
                    {
                        DataTable dtSystem = ds.Tables[0];
                        DataTable dtDevice = ds.Tables[1];
                        DataTable dtHealthIndicator = ds.Tables[2];

                        List<DSystem> systemList = new List<DSystem>();
                        for (int i = 0; i < dtSystem.Rows.Count; i++)
                        {
                            DSystem dSystem = new DSystem();
                            dSystem.ID = Convert.ToInt32(dtSystem.Rows[i].ItemArray[0].ToString());
                            dSystem.Name = dtSystem.Rows[i].ItemArray[1].ToString();
                            dSystem.AggregationPattren = Convert.ToInt32(dtSystem.Rows[i].ItemArray[2].ToString());

                            List<DDevice> deviceList = new List<DDevice>();
                            for (int j = 0; j < dtDevice.Rows.Count; j++)
                            {
                                DDevice dDevice = new DDevice();
                                int deciceSysID = Convert.ToInt32(dtDevice.Rows[j].ItemArray[0].ToString());
                                if (dSystem.ID == deciceSysID)
                                {
                                    dDevice.ID = Convert.ToInt32(dtDevice.Rows[j].ItemArray[1].ToString());
                                    dDevice.Name = dtDevice.Rows[j].ItemArray[2].ToString();
                                    dDevice.SystemID = deciceSysID;
                                    deviceList.Add(dDevice);

                                    List<DHealthIndicator> healthIndicatorList = new List<DHealthIndicator>();
                                    for (int k = 0; k < dtHealthIndicator.Rows.Count; k++)
                                    {
                                        DHealthIndicator dHealthIndicator = new DHealthIndicator();

                                        object[] rowItem = dtHealthIndicator.Rows[k].ItemArray;
                                        int healthIndicatorDeviceID = Convert.ToInt32(rowItem[0].ToString());
                                        if (dDevice.ID == healthIndicatorDeviceID)
                                        {
                                            dHealthIndicator.DeviceID = healthIndicatorDeviceID;
                                            dHealthIndicator.DeviceName = rowItem[1].ToString();
                                            dHealthIndicator.IndicatorID = Convert.ToInt32(rowItem[2].ToString());

                                            dHealthIndicator.IndicatorName = rowItem[3].ToString();

                                            if (!string.IsNullOrEmpty(rowItem[4].ToString()))
                                            {
                                                dHealthIndicator.UsePoint = rowItem[4].ToString().Split(',').ToList();
                                            }


                                            dHealthIndicator.Mode = rowItem[5].ToString();

                                            string normalValue1 = rowItem[6].ToString();
                                            if (!string.IsNullOrEmpty(normalValue1))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(normalValue1, out fv))
                                                {
                                                    dHealthIndicator.NormalValue1 = fv;
                                                }
                                            }

                                            string alarmValue1 = rowItem[7].ToString();
                                            if (!string.IsNullOrEmpty(alarmValue1))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(alarmValue1, out fv))
                                                {
                                                    dHealthIndicator.AlarmValue1 = fv;
                                                }
                                            }

                                            string tripValue1 = rowItem[8].ToString();
                                            if (!string.IsNullOrEmpty(tripValue1))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(tripValue1, out fv))
                                                {
                                                    dHealthIndicator.TripValue1 = fv;
                                                }
                                            }

                                            string normalValue2 = rowItem[9].ToString();
                                            if (!string.IsNullOrEmpty(normalValue2))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(normalValue2, out fv))
                                                {
                                                    dHealthIndicator.NormalValue2 = fv;
                                                }
                                            }

                                            string alarmValue2 = rowItem[10].ToString();
                                            if (!string.IsNullOrEmpty(alarmValue2))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(alarmValue2, out fv))
                                                {
                                                    dHealthIndicator.AlarmValue2 = fv;
                                                }
                                            }

                                            string tripValue2 = rowItem[11].ToString();

                                            if (!string.IsNullOrEmpty(tripValue2))
                                            {
                                                float fv = 0;
                                                if (float.TryParse(tripValue2, out fv))
                                                {
                                                    dHealthIndicator.TripValue2 = fv;
                                                }
                                            }

                                            dHealthIndicator.EnablePoint = rowItem[12].ToString();
                                            dHealthIndicator.AggregationPattren = rowItem[13].ToString();
                                            dHealthIndicator.DeviceRunCondition = rowItem[14].ToString();


                                            healthIndicatorList.Add(dHealthIndicator);
                                        }
                                    }

                                    dDevice.HealthIndicators = healthIndicatorList;
                                }
                            }
                            dSystem.Devices = deviceList;
                            systemList.Add(dSystem);
                        }

                        return systemList;
                    }
                    else
                    {
                        return null;
                    }
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
                return null;
            }
        }
    }
}
