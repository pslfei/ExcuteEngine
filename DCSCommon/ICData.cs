using EngineCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DCSCommon
{
    public class ICData
    {
        public CldIndexcondition IC = new CldIndexcondition();

        /// <summary>
        /// 主蒸汽压力设定值
        /// </summary>
        public double zzqylsdz;

        /// <summary>
        /// 炉膛负压
        /// </summary>
        public double ltfy;

        /// <summary>
        /// 氧量设定值
        /// </summary>
        public double ylsdz;

        /// <summary>
        /// #3高加抽汽电动门开度
        /// </summary>
        public double gjcqddmkd;

        /// <summary>
        /// #6低加抽汽电动门开度
        /// </summary>
        public double djcqddmkd;

        /// <summary>
        /// 除氧器液位
        /// </summary>
        public double cyqyw;

        /// <summary>
        /// 除氧器液位设定值
        /// </summary>
        public double cyqywsdz;

        /// <summary>
        /// 过热度
        /// </summary>
        public double grd;

        /// <summary>
        /// 过热度设定值
        /// </summary>
        public double grdsdz;

        /// <summary>
        /// 汽机调门总指令
        /// </summary>
        public double qjtmzzl;
    }
}
