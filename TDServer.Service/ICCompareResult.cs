using EngineCore.Models;
using Newtonsoft.Json;

namespace TDServer.Service
{
    public class ICCompareResult
    {
        public ICCompareResult()
        {
            Init();
        }

        public void Init()
        {
            GuideIdeaTitle = "当前工况处于非稳态，请按照AGC指令调整负荷，直至稳态。";
            curveContents = ICCompareService.GetCurveContent(null, null);
            BarChartContent = ICCompareService.GetBarChartContent(null, null);
            RadarChartContents = ICCompareService.GetRadarChartContent(null, null);
            SensitivefactorsCharts = ICCompareService.GetSensitivefactorsChart(null, null);
            guideIdeaContentAndCharts = new List<GuideIdeaContentAndChart>
            {
                new GuideIdeaContentAndChart() { GuideIdeaContent = GuideIdeaTitle, Percent = null, GuideIdeaChart = null }
            };
        }


        public List<GuideIdeaContentAndChart> guideIdeaContentAndCharts { get; set; }


        public CldIndexcondition RealTimeIC { get; set; }

        /// <summary>
        /// 标杆工况
        /// </summary>
        public CldIndexcondition StandardIC { get; set; }

        /// <summary>
        /// 新工况
        /// </summary>
        public CldIndexcondition NewIC { get; set; }

        /// <summary>
        /// 原工况
        /// </summary>
        public CldIndexcondition OldIC { get; set; }

        /// <summary>
        /// 工况对标成功新鲜度
        /// </summary>
        public int Freshness { get; set; } = -1;

        /// <summary>
        /// 对标成功时间
        /// </summary>
        public DateTime CompareOKTime { get; set; } = DateTime.MinValue;

        /// <summary>
        /// 专家工况
        /// </summary>
        public ExpertContent ExpertIC { get; set; }

        /// <summary>
        /// 敏感因子雷达图
        /// </summary>
        public List<RadarChartContent> RadarChartContents { get; set; } = new List<RadarChartContent>();

        /// <summary>
        /// 柱状图
        /// </summary>
        public BarChartContent BarChartContent { get; set; }

        /// <summary>
        /// 雷达因子曲线图
        /// </summary>
        public List<CurveContent> curveContents { get; set; }

        /// <summary>
        /// 指导意见标题
        /// </summary>
        public string GuideIdeaTitle { get; set; }

        ///// <summary>
        ///// 指导意见内容
        ///// </summary>
        //public string GuideIdeaContent { get; set; }



        /// <summary>
        /// 敏感因子表格
        /// </summary>
        public List<List<object>> SensitivefactorsCharts { get; set; } = new List<List<object>>();



        /// <summary>
        /// 对标结果：0：对标成功；1：对标失败；2：新增标杆库
        /// </summary>
        public int CompareResult { get; set; } = -1;

        /// <summary>
        /// 是否处于稳态：false：非稳态；true：稳态
        /// </summary>
        public bool HasSteadyState { get; set; } = false;

        public List<CldIndexcondition> NewAddICList = new List<CldIndexcondition>();

        public bool IsShowGIF { get; set; } = false;


        public CldIndexcondition AGCStandardIC { get; set; } = new CldIndexcondition();
    }

    public class GuideIdeaContentAndChart
    {
        public string GuideIdeaContent { get; set; }

        public string Percent { get; set; }

        public List<object> GuideIdeaChart { get; set; }
    }

    public class ChartRow
    {
        public object? name { get; set; }
        public int spanCol { get; set; }
        public int spanRow { get; set; }

        public string? color { get; set; }
    }

    /// <summary>
    /// 敏感因子表格
    /// </summary>
    public class SensitivefactorsChart
    {
        [JsonProperty("工况名称")]
        public string ICName { get; set; }

        [JsonProperty("风量(t/h)")]
        public double? Zfl { get; set; }

        [JsonProperty("氧量(%)")]
        public double? Yl { get; set; }

        [JsonProperty("A侧排烟温度(°℃)")]
        public double? Acpywd { get; set; }

        [JsonProperty("B侧排烟温度(°℃)")]
        public double? Bcpywd { get; set; }


        [JsonProperty("空预器出口含氧量(%)")]
        public double? Kyqckhyl { get; set; }

        [JsonProperty("燃料量(t/h)")]
        public double? Rll { get; set; }


        [JsonProperty("主汽温度(°℃)")]
        public double? Zzqwd { get; set; }

        [JsonProperty("主汽压力(MPa)")]
        public double? Zzqyl { get; set; }

        [JsonProperty("再热汽温度(℃)")]
        public double? Zrzqwd { get; set; }

        [JsonProperty("再热汽压力(MPa)")]
        public double? Zrzqyl { get; set; }


        [JsonProperty("背压(KPa)")]
        public double? By { get; set; }

        [JsonProperty("再热器减温水流量(t/h)")]
        public double? Zrqjwsll { get; set; }
    }
    public class Item
    {
        public string Name { get; set; }
        public double? Value { get; set; }
    }

    public class ExpertContent
    {
        public List<List<Item>> ExpertItemList1 { get; set; } = new List<List<Item>>();
        public List<List<Item>> ExpertItemList2 { get; set; } = new List<List<Item>>();
    }

    public class RadarChartContent
    {
        public string Title { get; set; }
        public List<Item> RadarChartItems { get; set; } = new List<Item>();
    }

    public class CurveContent
    {
        public string Title { get; set; }

        public DateTime? CompareTime { get; set; } = DateTime.Now;

        public List<Index> indexList { get; set; } = new List<Index>();
    }

    public class BarChartContent
    {
        public string Title { get; set; }

        public List<List<BarChartItem>> barChartItems { get; set; }
    }

    public class BarChartItem
    {
        public string Title { get; set; }

        public BarChartItemData RealData { get; set; }

        public BarChartItemData StandardData { get; set; }
    }


    public class BarChartItemData
    {
        public double Display { get; set; }

        public double Percent { get; set; }
    }


    public class Index
    {
        public string Desc { get; set; }

        public string Operation { get; set; }

        public string Unit { get; set; }

        public string PointName { get; set; }

        public double? RealTimeValue { get; set; }

        public double? RefValue { get; set; }
    }
}