using DBServer.LogServer;
using DCSType;
using EngineCore.Models;
using log4net.Repository.Hierarchy;
using System.Data;
using System.Text.RegularExpressions;

namespace TDServer.Service
{
    public class AnalyticalExpression
    {
        private static LoggerService<AnalyticalExpression> logger = new LoggerService<AnalyticalExpression>();
        ///// <summary>
        ///// 设置模型和规则报警的限制报警
        ///// </summary>
        ///// <param name="lAExWarn"></param>
        //public static void SetWarnConstraintAndAlarm(List<CldWarnpoint> cldWarnpoints)
        //{
        //    foreach (var item in cldWarnpoints)
        //    {
        //        LAExWarn lAExWarn = null;

        //        object syspoint =  ExcuteEngine.GetFirstRunableWarn(item.PointName);
        //        if (item.ModelOrrule == 0 && syspoint != null && syspoint is LAExWarn modelWarn)
        //        {
        //            lAExWarn = modelWarn;

        //            if (lAExWarn is not null && lAExWarn.Runable)
        //            {
        //                lAExWarn.HasConstraint = Analytical(lAExWarn.WarnConstraint);
        //                lAExWarn.LimitAlarm = Analytical(lAExWarn.LimitAlarmCondition);
        //            }
        //        }
        //        else if (item.ModelOrrule == 1)//&& ExcuteEngine.RTDDict_Rule.TryGetValue(item.PointName, out var ruleItem) && ruleItem is LAExWarn ruleWarn
        //        {
        //            if (ExcuteEngine.RTDDict_Rule.TryGetValue(item.PointName, out var ruleItem))
        //            {
        //                if (ruleItem is LAExWarn ruleWarnLA)
        //                {
        //                    lAExWarn = ruleWarnLA;

        //                    if (lAExWarn is not null && lAExWarn.Runable)
        //                    {
        //                        lAExWarn.HasConstraint = Analytical(lAExWarn.WarnConstraint);
        //                        lAExWarn.LimitAlarm = Analytical(lAExWarn.LimitAlarmCondition);
        //                    }
        //                }
        //                else if (ruleItem is LDExWarn ruleWarnLD)
        //                {
        //                    LDExWarn lDExWarn = null;
        //                    lDExWarn = ruleWarnLD;
        //                    if (lDExWarn is not null && lDExWarn.Runable)
        //                    {
        //                        lDExWarn.HasConstraint = Analytical(lDExWarn.WarnConstraint);
        //                        lDExWarn.LimitAlarm = Analytical(lDExWarn.LimitAlarmCondition);
        //                    }
        //                }
        //            }

        //        }
        //    }
        //}

        public static void SetWarnConstraintAndAlarm(List<CldWarnpoint> cldWarnpoints)
        {
            foreach (var item in cldWarnpoints)
            {

                // 定义一个通用的接口变量
                IWarnModel warnObject = null;

                if (item.ModelOrrule == 0)
                {
                    warnObject = ExcuteEngine.GetFirstRunableWarn(item.PointName) as IWarnModel;
                }
                else if (item.ModelOrrule == 1)
                {
                    if (ExcuteEngine.RTDDict_Rule.TryGetValue(item.PointName, out var ruleItem))
                    {
                        warnObject = ruleItem as IWarnModel;
                    }
                }

                if (item.PointName == "d1_scnrclgprs")
                {
                    //logger.InfoLog($"d1_10lcb11an001xb11：Runable={warnObject.Runable}");
                }


                // 统一处理逻辑
                if (warnObject != null && warnObject.Runable)
                {
                    warnObject.HasConstraint = Analytical(warnObject.WarnConstraint);
                    warnObject.LimitAlarm = Analytical(warnObject.LimitAlarmCondition);
                }
            }
        }


        public static bool Analytical(string condition)
        {
            try
            {
                if (string.IsNullOrEmpty(condition))
                {
                    return false;
                }
                if (condition.Contains("d1_10lhb31ap001xq01"))
                {

                }
                bool result = false;
                if (condition != "" && condition != "1=1")
                {
                    List<string> constraintPoint = new List<string>();
                    if (!string.IsNullOrEmpty(condition))
                    {
                        condition = condition.Replace("\\n", "").Replace("\t", "").Replace(" ", "");
                        Regex r = new Regex(@"(?<=\[)(.+?)(?=\])");
                        MatchCollection matchCollection = r.Matches(condition);

                        for (int i = 0; i < matchCollection.Count; i++)
                        {
                            string pointName = matchCollection[i].ToString();
                            constraintPoint.Add(pointName);


                            object syspoint = ExcuteEngine.GetFirstRunableWarn(pointName);
                            if (syspoint != null)
                            {
                                string val = (syspoint is bool b) ? (b ? "1" : "0") : syspoint?.ToString();
                 
                                // 优化替换顺序：先替换特定变量 -> 再替换逻辑符 -> 最后去空格
                                condition = condition.Replace(pointName, val)
                                                     .Replace("or", "||", StringComparison.OrdinalIgnoreCase)
                                                     .Replace("and", "&&", StringComparison.OrdinalIgnoreCase)
                                                     .Replace(" ", "")
                                                     .Replace("[", "")
                                                     .Replace("]", "");
                            }
                        }
                        ExcuteEngine.AddCommPoints(constraintPoint);
                    }

                    result = ExpressionWithParentheseResult(condition);
                }
                return result;
            }
            catch (Exception ex)
            {
                logger.ErrorLog($"Analytical:{condition} error:{ex.Message}");
                return false;
            }

        }

        public static bool HasDeviceStop(string deviceRunCondition, float[] pv)
        {
            if (!string.IsNullOrEmpty(deviceRunCondition))
            {
                deviceRunCondition = deviceRunCondition.Replace("\\n", "").Replace("\t", "").Replace(" ", "");
                Regex r = new Regex(@"(?<=\[)(.+?)(?=\])");
                MatchCollection matchCollection = r.Matches(deviceRunCondition);

                for (int i = 0; i < matchCollection.Count; i++)
                {
                    string pointName = matchCollection[i].ToString();
                    deviceRunCondition = deviceRunCondition.Replace(" ", "").Replace("[", "").Replace("]", "").Replace("or", "||").Replace("and", "&&").Replace(pointName, pv[i].ToString());
                }

                return ExpressionWithParentheseResult(deviceRunCondition);
            }
            else
            {
                return true;
            }
        }

        /// <summary>
        /// 包含括号的逻辑表达式处理
        /// </summary>
        /// <param name="str">包含括号或未包含括号的字符串表达式 1>0&&(3<4)&&(5>4)</param>
        /// <returns></returns>
        private static bool ExpressionWithParentheseResult(string str)
        {
            bool result = false;
            //首先判断括号，有多少个
            string[] parentheses = str.Split('(');
            //创建表达式判断函数
            DataTable dt = new DataTable();
            //有括号的情况
            if (parentheses.Length > 1)
            {
                //先判断括号里面的
                for (int parenthesesIndex = 1; parenthesesIndex < parentheses.Length; parenthesesIndex++)
                {
                    //括号里面的内容
                    string ParenthData = parentheses[parenthesesIndex].Split(')')[0];
                    //进行替换(括号结果替换整个括号的内容)
                    string reParenth = "(" + ParenthData + ")";
                    str = str.Replace(reParenth, ExpressionResult(ParenthData).ToString());
                }
            }
            result = ExpressionResult(str);
            return result;
        }


        /// <summary>
        /// 非括号表达式处理
        /// </summary>
        /// <param name="logicStr">逻辑表达式如 1<2&&3>4</param>
        /// <param name="val"></param>
        /// <returns></returns>
        private static bool ExpressionResult(string logicStr)
        {
            if (string.IsNullOrEmpty(logicStr))
            {
                return true;
            }
            try
            {
                bool result = false;
                DataTable dt = new DataTable();
                var data = Regex.Split(logicStr, @"\|\||&&", RegexOptions.IgnoreCase);
                var operatorStr = "||";
                for (int i = 0; i < data.Length; i++)
                {
                    if (i != 0)
                    {
                        operatorStr = logicStr.Substring(logicStr.IndexOf(data[i - 1]) + data[i - 1].Length, 2);
                    }
                    var res = (bool)dt.Compute(data[i], "");
                    result = LogicEx(result, res, operatorStr);
                }
                return result;
            }
            catch (Exception)
            {

                return false;
            }

        }

        /// <summary>
        /// 逻辑判断
        /// </summary>
        /// <param name="a1">结果1</param>
        /// <param name="a2">结果2</param>
        /// <param name="re">运算符</param>
        /// <returns></returns>
        private static bool LogicEx(bool a1, bool a2, string re)
        {
            bool result = false;
            switch (re)
            {
                case "&&": result = a1 && a2; break;
                case "||": result = a1 || a2; break;
            }
            return result;
        }
    }
}
