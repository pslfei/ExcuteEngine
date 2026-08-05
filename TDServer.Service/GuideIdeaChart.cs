using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace TDServer.Service
{
    public class GuideIdeaChart
    {
        public class YlChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("氧量设定值（%）")]
            public double? Ylsdz { get; set; }

            [JsonProperty("送风机A动叶开度（%）")]
            public double? Sfjadykd { get; set; }

            [JsonProperty("送风机B动叶开度（%）")]
            public double? Sfjbdykd { get; set; }
        }



        /// <summary>
        /// 排烟温度表格
        /// </summary>
        public class PywdChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("各台给煤机给煤量（t/h）")]
            public Gmjgml gmjgml { get; set; }
        }

        public class Gmjgml
        {
            [JsonProperty("A")]
            public double? A { get; set; }

            [JsonProperty("B")]
            public double? B { get; set; }

            [JsonProperty("C")]
            public double? C { get; set; }

            [JsonProperty("D")]
            public double? D { get; set; }

            [JsonProperty("E")]
            public double? E { get; set; }

            [JsonProperty("F")]
            public double? F { get; set; }
        }


        /// <summary>
        /// 二次风表格
        /// </summary>
        public class EcfChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("各二次风流量（t/h）")]
            public Ecfll ecfll { get; set; }
        }

        /// <summary>
        /// 二次风流量
        /// </summary>
        public class Ecfll
        {
            [JsonProperty("前墙左下")]
            public double? Qqzx { get; set; }

            [JsonProperty("前墙右下")]
            public double? Qqyx { get; set; }

            [JsonProperty("后墙左下")]
            public double? Hqzx { get; set; }

            [JsonProperty("后墙右下")]
            public double? Hqyx { get; set; }

            [JsonProperty("前墙左中")]
            public double? Qqzz { get; set; }

            [JsonProperty("前墙右中")]
            public double? Qqyz { get; set; }

            [JsonProperty("后墙左中")]
            public double? Hqzz { get; set; }

            [JsonProperty("后墙右中")]
            public double? Hqyz { get; set; }


            [JsonProperty("前墙左上")]
            public double? Qqzs { get; set; }

            [JsonProperty("前墙右上")]
            public double? Qqys { get; set; }

            [JsonProperty("后墙左上")]
            public double? Hqzs { get; set; }

            [JsonProperty("后墙右上")]
            public double? Hqys { get; set; }
        }


        /// <summary>
        /// 燃烬风表格
        /// </summary>
        public class RjfChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("各燃烬风流量（t/h）")]
            public Rjfll rjfll { get; set; }
        }


        /// <summary>
        /// 燃烬风流量
        /// </summary>
        public class Rjfll
        {
            [JsonProperty("前墙左下")]
            public double? Qqzx { get; set; }

            [JsonProperty("前墙右下")]
            public double? Qqyx { get; set; }

            [JsonProperty("后墙左下")]
            public double? Hqzx { get; set; }

            [JsonProperty("后墙右下")]
            public double? Hqyx { get; set; }

            [JsonProperty("前墙左上")]
            public double? Qqzs { get; set; }

            [JsonProperty("前墙右上")]
            public double? Qqys { get; set; }

            [JsonProperty("后墙左上")]
            public double? Hqzs { get; set; }

            [JsonProperty("后墙右上")]
            public double? Hqys { get; set; }
        }

        /// <summary>
        /// 主蒸汽温度表格
        /// </summary>
        public class ZzqwdChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("过热度（℃）")]
            public double? Grd { get; set; }


            [JsonProperty("各级减温水流量（t/h）")]
            public Jwsll jwsll { get; set; }

            [JsonProperty("各烟气挡板开度（%）")]
            public Yqdbkd5_8 yqdbkd { get; set; }
        }



        public class Jwsll
        {
            [JsonProperty("一级左侧")]
            public double? Yjzc { get; set; }

            [JsonProperty("一级右侧")]
            public double? Yjyc { get; set; }

            [JsonProperty("二级左侧")]
            public double? Ejzc { get; set; }

            [JsonProperty("二级右侧")]
            public double? Ejyc { get; set; }
        }

        public class Yqdbkd5_8
        {
            [JsonProperty("挡板5")]
            public double? Db5 { get; set; }

            [JsonProperty("挡板6")]
            public double? Db6 { get; set; }

            [JsonProperty("挡板7")]
            public double? Db7 { get; set; }

            [JsonProperty("挡板8")]
            public double? Db8 { get; set; }
        }



        /// <summary>
        /// 再热蒸汽温度表格
        /// </summary>
        public class ZrzqwdChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }

            [JsonProperty("各烟气挡板开度（%）")]
            public Yqdbkd1_4 yqdbkd { get; set; }

            [JsonProperty("再热汽减温水流量（t/h）")]
            public double? Zrjwsll { get; set; }

            [JsonProperty("各给煤机给煤量")]
            public Gmjgml gmjgml { get; set; }
        }



        public class Yqdbkd1_4
        {
            [JsonProperty("挡板1")]
            public double? Db1 { get; set; }

            [JsonProperty("挡板2")]
            public double? Db2 { get; set; }

            [JsonProperty("挡板3")]
            public double? Db3 { get; set; }

            [JsonProperty("挡板4")]
            public double? Db4 { get; set; }
        }


        /// <summary>
        /// 凝汽器表格
        /// </summary>
        public class NqqChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }


            [JsonProperty("循环水压力（Mpa）")]
            public double? Xhsyl { get; set; }

            [JsonProperty("循环水温度（℃）")]
            public double? Xhswd { get; set; }

            [JsonProperty("各真空泵电流（A）")]
            public Zkbdl zkbdl { get; set; }   

        }


        public class Zkbdl
        {
            [JsonProperty("A")]
            public double? A { get; set; }

            [JsonProperty("B")]
            public double? B { get; set; }

            [JsonProperty("C")]
            public double? C { get; set; }
        }


        /// <summary>
        /// 主蒸汽压力表格
        /// </summary>
        public class ZzqylChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }


            [JsonProperty("燃料量（t/h）")]
            public double? Rll { get; set; }

            [JsonProperty("滑压偏置")]
            public double? Hypz { get; set; }
        }


        /// <summary>
        /// 过热度表格
        /// </summary>
        public class GrdChart
        {
            [JsonProperty("工况名称")]
            public string ICName { get; set; }


            [JsonProperty("水煤比")]
            public double? Smb { get; set; }
        }
    }
}
