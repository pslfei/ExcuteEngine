using DBServer.LogServer;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using System.Globalization;
using System.Text.RegularExpressions;

namespace TDServer.Service
{
    public class AlarmHelp
    {
        private static readonly LoggerService<AlarmHelp> logger = new LoggerService<AlarmHelp>();

        public class AlarmConfigData
        {
            public List<DevAlarmConfig> DevAlarmConfigs { get; set; } = new List<DevAlarmConfig>();

            public List<AnalogFluctuationAlarmConfig> AnalogFluctuationAlarmConfigs { get; set; } = new List<AnalogFluctuationAlarmConfig>();

            public bool HasData => DevAlarmConfigs.Count > 0 || AnalogFluctuationAlarmConfigs.Count > 0;
        }

        public class DevAlarmConfig
        {
            public int ExcelRowNumber { get; set; }

            public int FaultCode { get; set; }

            public string In1PointName { get; set; } = string.Empty;

            public string In2PointName { get; set; } = string.Empty;

            public float AlarmThreshold { get; set; }

            public int DelayTime { get; set; }

            public string Condition { get; set; } = string.Empty;

            public string InstanceName { get; set; } = string.Empty;
        }

        public class AnalogFluctuationAlarmConfig
        {
            public int ExcelRowNumber { get; set; }

            public string PointName { get; set; } = string.Empty;

            public int SampleTime { get; set; }

            public float AlarmThreshold { get; set; }

            public int DelayTime { get; set; }

            public string Condition { get; set; } = string.Empty;

            public string InstanceName { get; set; } = string.Empty;
        }

        public static AlarmConfigData? GetAlarmInfo(string filePath)
        {
            try
            {
                string fullPath = $"./{filePath}";
                if (!File.Exists(fullPath))
                {
                    logger.InfoLog($"报警配置文件不存在：{fullPath}");
                    return null;
                }

                using FileStream fsRead = File.OpenRead(fullPath);
                IWorkbook? workbook = CreateWorkbook(fsRead, fullPath);
                if (workbook == null)
                {
                    return null;
                }

                AlarmConfigData alarmConfigData = new AlarmConfigData();
                ParseDevAlarmSheet(workbook.GetSheet("偏差报警"), alarmConfigData.DevAlarmConfigs);
                ParseAnalogFluctuationAlarmSheet(workbook.GetSheet("波动报警"), alarmConfigData.AnalogFluctuationAlarmConfigs);

                return alarmConfigData.HasData ? alarmConfigData : null;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"读取报警配置失败：{ex.Message}");
                return null;
            }
        }

        private static IWorkbook? CreateWorkbook(Stream stream, string filePath)
        {
            string extension = Path.GetExtension(filePath).ToLowerInvariant();

            try
            {
                return extension switch
                {
                    ".xls" => new HSSFWorkbook(stream),
                    ".xlsx" => new XSSFWorkbook(stream),
                    _ => null
                };
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"打开报警Excel失败：{filePath}，{ex.Message}");
                return null;
            }
        }

        private static void ParseDevAlarmSheet(ISheet? sheet, List<DevAlarmConfig> devAlarmConfigs)
        {
            if (sheet == null)
            {
                logger.InfoLog("报警Excel缺少【偏差报警】Sheet。");
                return;
            }

            Dictionary<string, int> headerIndex = BuildHeaderIndex(sheet);
            if (!HasRequiredHeaders(headerIndex, "偏差报警", "故障码", "调门指令点名", "反馈偏差点名", "报警阈值", "延时（秒）", "报警条件"))
            {
                return;
            }

            for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
            {
                IRow? row = sheet.GetRow(rowIndex);
                if (row == null || IsRowEmpty(row))
                {
                    continue;
                }

                string faultCodeText = GetCellValue(row.GetCell(headerIndex["故障码"]));
                string in1PointName = GetCellValue(row.GetCell(headerIndex["调门指令点名"]));
                string in2PointName = GetCellValue(row.GetCell(headerIndex["反馈偏差点名"]));
                string alarmThresholdText = GetCellValue(row.GetCell(headerIndex["报警阈值"]));
                string delayTimeText = GetCellValue(row.GetCell(headerIndex["延时（秒）"]));
                string condition = GetCellValue(row.GetCell(headerIndex["报警条件"]));

                if (string.IsNullOrWhiteSpace(faultCodeText) ||
                    string.IsNullOrWhiteSpace(in1PointName) ||
                    string.IsNullOrWhiteSpace(in2PointName) ||
                    string.IsNullOrWhiteSpace(alarmThresholdText) ||
                    string.IsNullOrWhiteSpace(delayTimeText))
                {
                    logger.InfoLog($"偏差报警第 {rowIndex + 1} 行存在必填列为空，已跳过。");
                    continue;
                }

                if (!int.TryParse(faultCodeText, out int faultCode) ||
                    !float.TryParse(alarmThresholdText, NumberStyles.Float, CultureInfo.InvariantCulture, out float alarmThreshold) ||
                    !int.TryParse(delayTimeText, out int delayTime))
                {
                    logger.InfoLog($"偏差报警第 {rowIndex + 1} 行数值列解析失败，已跳过。");
                    continue;
                }

                devAlarmConfigs.Add(new DevAlarmConfig
                {
                    ExcelRowNumber = rowIndex + 1,
                    FaultCode = faultCode,
                    In1PointName = in1PointName.Trim(),
                    In2PointName = in2PointName.Trim(),
                    AlarmThreshold = alarmThreshold,
                    DelayTime = delayTime,
                    Condition = condition.Trim(),
                    InstanceName = $"alarm_dev_{rowIndex + 1}_{faultCode}"
                });
            }
        }

        private static void ParseAnalogFluctuationAlarmSheet(ISheet? sheet, List<AnalogFluctuationAlarmConfig> analogFluctuationAlarmConfigs)
        {
            if (sheet == null)
            {
                logger.InfoLog("报警Excel缺少【波动报警】Sheet。");
                return;
            }

            Dictionary<string, int> headerIndex = BuildHeaderIndex(sheet);
            if (!HasRequiredHeaders(headerIndex, "波动报警", "模拟量波动点名", "采样时间", "报警阈值", "延时（秒）", "报警条件"))
            {
                return;
            }

            for (int rowIndex = 1; rowIndex <= sheet.LastRowNum; rowIndex++)
            {
                IRow? row = sheet.GetRow(rowIndex);
                if (row == null || IsRowEmpty(row))
                {
                    continue;
                }

                string pointName = GetCellValue(row.GetCell(headerIndex["模拟量波动点名"]));
                string sampleTimeText = GetCellValue(row.GetCell(headerIndex["采样时间"]));
                string alarmThresholdText = GetCellValue(row.GetCell(headerIndex["报警阈值"]));
                string delayTimeText = GetCellValue(row.GetCell(headerIndex["延时（秒）"]));
                string condition = GetCellValue(row.GetCell(headerIndex["报警条件"]));

                if (string.IsNullOrWhiteSpace(pointName) ||
                    string.IsNullOrWhiteSpace(sampleTimeText) ||
                    string.IsNullOrWhiteSpace(alarmThresholdText) ||
                    string.IsNullOrWhiteSpace(delayTimeText))
                {
                    logger.InfoLog($"波动报警第 {rowIndex + 1} 行存在必填列为空，已跳过。");
                    continue;
                }

                if (!int.TryParse(sampleTimeText, out int sampleTime) ||
                    !float.TryParse(alarmThresholdText, NumberStyles.Float, CultureInfo.InvariantCulture, out float alarmThreshold) ||
                    !int.TryParse(delayTimeText, out int delayTime))
                {
                    logger.InfoLog($"波动报警第 {rowIndex + 1} 行数值列解析失败，已跳过。");
                    continue;
                }

                analogFluctuationAlarmConfigs.Add(new AnalogFluctuationAlarmConfig
                {
                    ExcelRowNumber = rowIndex + 1,
                    PointName = pointName.Trim(),
                    SampleTime = sampleTime,
                    AlarmThreshold = alarmThreshold,
                    DelayTime = delayTime,
                    Condition = condition.Trim(),
                    InstanceName = $"alarm_fluc_{rowIndex + 1}_{NormalizeInstanceName(pointName)}"
                });
            }
        }

        private static Dictionary<string, int> BuildHeaderIndex(ISheet sheet)
        {
            Dictionary<string, int> headerIndex = new Dictionary<string, int>(StringComparer.OrdinalIgnoreCase);
            IRow? headerRow = sheet.GetRow(0);
            if (headerRow == null)
            {
                return headerIndex;
            }

            for (int i = headerRow.FirstCellNum; i < headerRow.LastCellNum; i++)
            {
                string headerName = GetCellValue(headerRow.GetCell(i));
                if (!string.IsNullOrWhiteSpace(headerName) && !headerIndex.ContainsKey(headerName))
                {
                    headerIndex.Add(headerName, i);
                }
            }

            return headerIndex;
        }

        private static bool HasRequiredHeaders(Dictionary<string, int> headerIndex, string sheetName, params string[] requiredHeaders)
        {
            foreach (string requiredHeader in requiredHeaders)
            {
                if (!headerIndex.ContainsKey(requiredHeader))
                {
                    logger.ErrorLog($"报警Excel的【{sheetName}】Sheet缺少表头：{requiredHeader}");
                    return false;
                }
            }

            return true;
        }

        private static bool IsRowEmpty(IRow row)
        {
            for (int i = row.FirstCellNum; i < row.LastCellNum; i++)
            {
                if (!string.IsNullOrWhiteSpace(GetCellValue(row.GetCell(i))))
                {
                    return false;
                }
            }

            return true;
        }

        private static string GetCellValue(ICell? cell)
        {
            if (cell == null)
            {
                return string.Empty;
            }

            return cell.CellType switch
            {
                CellType.Blank => string.Empty,
                CellType.Boolean => cell.BooleanCellValue ? "1" : "0",
                CellType.Numeric => DateUtil.IsCellDateFormatted(cell)
                    ? cell.DateCellValue.ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)
                    : cell.NumericCellValue.ToString(CultureInfo.InvariantCulture),
                CellType.String => cell.StringCellValue?.Trim() ?? string.Empty,
                CellType.Formula => GetFormulaCellValue(cell),
                _ => cell.ToString()?.Trim() ?? string.Empty
            };
        }

        private static string GetFormulaCellValue(ICell cell)
        {
            try
            {
                IFormulaEvaluator evaluator = cell.Sheet.Workbook.GetCreationHelper().CreateFormulaEvaluator();
                CellValue evaluatedValue = evaluator.Evaluate(cell);
                return evaluatedValue.CellType switch
                {
                    CellType.Boolean => evaluatedValue.BooleanValue ? "1" : "0",
                    CellType.Numeric => evaluatedValue.NumberValue.ToString(CultureInfo.InvariantCulture),
                    CellType.String => evaluatedValue.StringValue?.Trim() ?? string.Empty,
                    _ => cell.ToString()?.Trim() ?? string.Empty
                };
            }
            catch
            {
                return cell.ToString()?.Trim() ?? string.Empty;
            }
        }

        private static string NormalizeInstanceName(string pointName)
        {
            string normalizedName = Regex.Replace(pointName.Trim(), @"[^0-9A-Za-z_]+", "_");
            return normalizedName.Trim('_');
        }
    }
}
