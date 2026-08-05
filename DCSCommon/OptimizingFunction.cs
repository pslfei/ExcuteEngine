/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：Function.cs
// 文件功能描述：功能码的抽象模型
// 
//
// 创建标识：赵明明200903
//
// 修改标识：
// 修改描述：
//
// 修改标识：
// 修改描述：
//----------------------------------------------------------------*/
using EngineCore.Models;
using System.Runtime.InteropServices;

namespace DCSCommon
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Block)]
    [FCName("AbstractFunction")]
    [FCDisplay("功能码的抽象模型")]
    public abstract class OptimizingFunction : Function
    {
        public static string cleanlog = null;
        public bool HasSteadyState = false;
        public CldIndexcondition SteadyStateIC = null;
        public CldIndexcondition RealTimeIC = new CldIndexcondition();
        public double SteadyStateDurationTime = 0;
        public abstract List<string>? FindGroupInfo(double? fh, double? hjwd, double? dwfrl);

        //public abstract CldIndexcondition GetRealTimeIC();
        public readonly object _steadyStateICListLock = new object();

        public List<CldIndexcondition> _steadyStateICList = new List<CldIndexcondition>();

        public List<ICSegHeader> fhSegList = new List<ICSegHeader>();
        public List<ICSegHeader> hjwdSegList = new List<ICSegHeader>();
        public List<ICSegHeader> dwfrlSegList = new List<ICSegHeader>();

        public List<CldIndexcondition> SteadyStateICList
        {
            get
            {
                lock (_steadyStateICListLock)
                {
                    List<CldIndexcondition> list = new List<CldIndexcondition>(_steadyStateICList);
                    _steadyStateICList.Clear();
                    return list;
                }
            }
        }

    }


    public class ICSegHeader
    {
        /// <summary>
        /// 工况上限值
        /// </summary>
        public double Max;
        /// <summary>
        /// 工况下限值
        /// </summary>
        public double Min;
    }
}
