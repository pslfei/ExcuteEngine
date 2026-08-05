using DBServer.LogServer;
using DCSCommon;
using DCSType;
using EngineCore.Models;
using Newtonsoft.Json;
using PerformanceCalc;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("ICOptimizing")]
    [FCDisplay("工况寻优")]
    public partial class ICOptimizing : OptimizingFunction
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("调频动作")]
        public LD tpdz = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("汽机热耗")]
        public LA qsr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA jzfh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("AGC机组负荷")]
        public LA agcjzfh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("环境温度")]
        public LA hjwd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("低位发热量")]
        public LA dwfrl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("氧量")]
        public LA yl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("总风量")]
        public LA zfl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("飞灰可燃物")]
        public LA fhhtl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("炉渣可燃物")]
        public LA lzhtl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A侧排烟温度")]
        public LA Acpywd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("B侧排烟温度")]
        public LA Bcpywd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器A出口烟气含氧量")]
        public LA kyqAckyqhyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("空预器B出口烟气含氧量")]
        public LA kyqBckyqhyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝汽器背压1")]
        public LA nqqby1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("凝汽器背压2")]
        public LA nqqby2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水流量")]
        public LA zgsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("主蒸汽温度")]
        public LA zzqwd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("主蒸汽压力")]
        public LA zzqyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热蒸汽温度")]
        public LA zrzqwd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热蒸汽压力")]
        public LA zrzqyl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1炉左侧再热器减温水流量1")]
        public LA lzczrqjwsll1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1炉左侧再热器减温水流量2")]
        public LA lzczrqjwsll2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1炉右侧再热器减温水流量1")]
        public LA lyczrqjwsll1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#1炉右侧再热器减温水流量2")]
        public LA lyczrqjwsll2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风温度")]
        public LA sfwd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排烟温度")]
        public LA pywd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("燃料量")]
        public LA rll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("灰分")]
        public LA hf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("分析水")]
        public LA fxs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("全水分")]
        public LA qsf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("挥发分")]
        public LA hff = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("主蒸汽压力设定值")]
        public LA zzqylsdz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("炉膛负压")]
        public LA ltfy = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("氧量设定值")]
        public LA ylsdz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("#3高加抽汽电动门开度")]
        public LA gjcqddmkd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" #6低加抽汽电动门开度")]
        public LA djcqddmkd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" 除氧器液位")]
        public LA cyqyw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" 除氧器液位设定值")]
        public LA cyqywsdz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" 过热度")]
        public LA grd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" 过热度设定值")]
        public LA grdsdz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay(" 汽机调门总指令")]
        public LA qjtmzzl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);




        [PinType(PinTypes.Input)]
        [PinDisplay("送风机A动叶开度")]
        public LA sfjadykd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("送风机B动叶开度")]
        public LA sfjbdykd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("A给煤机煤量")]
        public LA agmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("B给煤机煤量")]
        public LA bgmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("C给煤机煤量")]
        public LA cgmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("D给煤机煤量")]
        public LA dgmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("E给煤机煤量")]
        public LA egmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("F给煤机煤量")]
        public LA fgmjml = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙左下二次风流量")]
        public LA qqzxecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙右下二次风流量")]
        public LA qqyxecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙左下二次风流量")]
        public LA hqzxecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙右下二次风流量")]
        public LA hqyxecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙左中二次风流量")]
        public LA qqzzecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙右中二次风流量")]
        public LA qqyzecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙左中二次风流量")]
        public LA hqzzecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙右中二次风流量")]
        public LA hqyzecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙左上二次风流量")]
        public LA qqzsecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙右上二次风流量")]
        public LA qqysecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙左上二次风流量")]
        public LA hqzsecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙右上二次风流量")]
        public LA hqysecfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙左下燃烬风流量")]
        public LA qqzxrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙右下燃烬风流量")]
        public LA qqyxrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙左下燃烬风流量")]
        public LA hqzxrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙右下燃烬风流量")]
        public LA hqyxrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙左上燃烬风流量")]
        public LA qqzsrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("前墙右上燃烬风流量")]
        public LA qqysrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙左上燃烬风流量")]
        public LA hqzsrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("后墙右上燃烬风流量")]
        public LA hqysrjfll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("过热器左侧一级减温水流量")]
        public LA grqzcyjjwsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器右侧一级减温水流量")]
        public LA grqycyjjwsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器左侧二级减温水流量")]
        public LA grqzcejjwsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器右侧二级减温水流量")]
        public LA grqycejjwsll = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器烟气挡板5")]
        public LA grqyqdb5 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器烟气挡板6")]
        public LA grqyqdb6 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器烟气挡板7")]
        public LA grqyqdb7 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热器烟气挡板8")]
        public LA grqyqdb8 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("再热器烟气挡板1")]
        public LA zrqyqdb1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热器烟气挡板2")]
        public LA zrqyqdb2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热器烟气挡板3")]
        public LA zrqyqdb3 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热器烟气挡板4")]
        public LA zrqyqdb4 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);




        [PinType(PinTypes.Input)]
        [PinDisplay("滑压偏置")]
        public LA hypz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("真空泵A电流")]
        public LA zkbadl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("真空泵B电流")]
        public LA zkbbdl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("真空泵C电流")]
        public LA zkbcdl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("低压凝汽器循环水进水支管1温度")]
        public LA dynqqxhsjszg1wd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("低压凝汽器循环水进水支管2温度")]
        public LA dynqqxhsjszg2wd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("低压凝汽器循环水进水支管1压力")]
        public LA dynqqxhsjszg1yl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("低压凝汽器循环水进水支管2压力")]
        public LA dynqqxhsjszg2yl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("水煤比")]
        public LA smb = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);



        [PinType(PinTypes.Internal)]
        [PinDisplay("输出管脚1")]
        public LA AVG = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("输出管脚1")]
        public LA MIN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Internal)]
        [PinDisplay("输出管脚1")]
        public LA MAX = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        //输出
        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率")]
        public LA glxl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("锅炉效率耗差")]
        public LA glxlhc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("汽机热耗")]
        public LA qjrh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("汽机热耗耗差")]
        public LA qjrhhc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        

        //规格数
        [PinType(PinTypes.Constant)]
        [PinDisplay("负荷波动偏差")]
        public int FhDeviation = 15;

        [PinType(PinTypes.Constant)]
        [PinDisplay("采样间隔(单位秒)")]
        public int SampleInterval = 10;

        [PinType(PinTypes.Constant)]
        [PinDisplay("采样时间单位秒")]
        public int SampleTime = 1200;

        [PinType(PinTypes.Constant)]
        [PinDisplay("机组负荷高限")]
        public int FhHightLimit = 1065;

        [PinType(PinTypes.Constant)]
        [PinDisplay("机组负荷低限")]
        public int FhLowLimit = 385;

        [PinType(PinTypes.Constant)]
        [PinDisplay("机组负荷步长")]
        public int FhStep = 10;

        [PinType(PinTypes.Constant)]
        [PinDisplay("环境温度高限")]
        public int HjwdHightLimit = 40;

        [PinType(PinTypes.Constant)]
        [PinDisplay("环境温度低限")]
        public int HjwdLowLimit = -20;

        [PinType(PinTypes.Constant)]
        [PinDisplay("环境温度步长")]
        public int HjwdStep = 5;

        [PinType(PinTypes.Constant)]
        [PinDisplay("低位发热量高限")]
        public int DwfrlHightLimit = 7000;

        [PinType(PinTypes.Constant)]
        [PinDisplay("低位发热量低限")]
        public int DwfrlLowLimit = 4000;

        [PinType(PinTypes.Constant)]
        [PinDisplay("低位发热量步长")]
        public int DwfrlStep = 200;

        //[PinType(PinTypes.Constant)]
        //[PinDisplay("含氢量")]
        //public double hql = 4.5;

        [PinType(PinTypes.Input)]
        [PinDisplay("含氢量")]
        public LA har = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        private static LoggerService<ICOptimizing> logger = new LoggerService<ICOptimizing>();
        Queue<CldIndexcondition> SampleQueue = new Queue<CldIndexcondition>();
       


        public ICOptimizing()
        {
            fhSegList.Clear();
            dwfrlSegList.Clear();
            hjwdSegList.Clear();

            FcType = enumType.ICO;
            List<int> fhNumbers = new List<int>();
            for (int i = FhLowLimit; i <= FhHightLimit; i += FhStep)
            {
                fhNumbers.Add(i);
            }


            for (int i = 0; i < fhNumbers.Count - 1; i++)
            {
                fhSegList.Add(new ICSegHeader
                {
                    Max = fhNumbers[i + 1],
                    Min = fhNumbers[i]
                });
            }

            List<int> hjwdNumbers = new List<int>();
            for (int i = HjwdLowLimit; i <= HjwdHightLimit; i += HjwdStep)
            {
                hjwdNumbers.Add(i);
            }

            for (int i = 0; i < hjwdNumbers.Count - 1; i++)
            {
                hjwdSegList.Add(new ICSegHeader
                {
                    Max = hjwdNumbers[i + 1],
                    Min = hjwdNumbers[i]
                });
            }

            List<int> dwfrlNumbers = new List<int>();
            for (int i = DwfrlLowLimit; i <= DwfrlHightLimit; i += DwfrlStep)
            {
                dwfrlNumbers.Add(i);
            }

            for (int i = 0; i < dwfrlNumbers.Count - 1; i++)
            {
                dwfrlSegList.Add(new ICSegHeader
                {
                    Max = dwfrlNumbers[i + 1],
                    Min = dwfrlNumbers[i]
                });
            }
        }

        //public class ICSegHeader
        //{
        //    /// <summary>
        //    /// 工况上限值
        //    /// </summary>
        //    public double Max;
        //    /// <summary>
        //    /// 工况下限值
        //    /// </summary>
        //    public double Min;
        //}


        public override List<string>? FindGroupInfo(double? fh, double? hjwd, double? dwfrl)
        {
            if (fh == null || hjwd == null || dwfrl == null)
            {
                return null;
            }

            List<string> list = new List<string>();
            foreach (var item in fhSegList)
            {
                if (fh >= item.Min && fh < item.Max)
                {
                    list.Add(item.Min + "^" + item.Max);
                    break;
                }
            }

            foreach (var item in hjwdSegList)
            {
                if (hjwd >= item.Min && hjwd < item.Max)
                {
                    list.Add(item.Min + "^" + item.Max);
                    break;
                }
            }

            foreach (var item in dwfrlSegList)
            {
                double dwfrlMin = item.Min * ExcuteEngine.dwfrlCoefficient;
                double dwfrlMax = item.Max * ExcuteEngine.dwfrlCoefficient;

                if (dwfrl >= dwfrlMin && dwfrl < dwfrlMax)
                {
                    list.Add(Math.Round(dwfrlMin, 0) + "^" + Math.Round(dwfrlMax, 0));
                    break;
                }
            }

            return list.Count == 3 ? list : null;
        }

        protected override void Run(ICommand cmd)
        {
            if (jzfh < 100)
            {
                HasSteadyState = false;
                return;
            }

            string jstr = $"{{\"ov\":{yl},\"tpy\":{pywd},\"tsf\":{sfwd},\"D\":{zgsll},\"Ded\":2875.2,\"Mar\":{qsf},\"Har\":{har},\"Mad\":{fxs},\"Aad\":{hf},\"Vad\":{hff},\"Qnetar\":{dwfrl},\"Clzc\":{lzhtl},\"Cfhc\":{fhhtl},\"X\":[1000, 750, 500, 400], \"y\": [0.38,0.37,0.36,0.35], \"pw\": {jzfh}}}";
            PerformanceCalc.BoilerData boilerData = PCalc.calcBoilerValue(jstr, out int status);
            double _glxl = 0;
            if (boilerData != null)
            {
                _glxl = boilerData.e;
                
            }

            //发电煤耗
            double coal = PCalc.ComputeCoal(dwfrl, rll, jzfh);
            //汽机热耗
            //double _qjrh = Math.Floor(PCalc.ComputeQsr(coal, _glxl).To2d());
            double _qjrh = qsr;


            ////锅炉效率目标值
            //double ebdst = PCalc.compute_dst(jzfh, new List<double>() { 95.18 / 100, 95.23 / 100, 95.28 / 100, 95.13 / 100, 95.10 / 100 });
            ////锅炉效率耗差
            //double _glxlhc = PCalc.ComputeHC(_glxl, ebdst, coal).To2d();
            ////汽机热耗目标值
            //double qjrhdst = PCalc.compute_dst(jzfh, new List<double>() { 7504d, 7594d, 7877d, 8078d, 8433d });

            ////汽机热耗耗差
            //double _qjrhhc = PCalc.ComputeHC(3600 / _qjrh, 3600 / qjrhdst, coal).To2d();

            

            glxl[0] = (_glxl * 100).To2d();
            //glxlhc[0] = _glxlhc;
            qjrh[0] = _qjrh;

            //qjrhhc[0] = _qjrhhc;

            int SampleCount = SampleTime / SampleInterval;//采样个数

            int SampleCycle = (int)(SampleInterval * 1000 / ExcuteEngine.cycle);//采样周期

            if (ExcuteEngine.cycleCount % SampleCycle == 0)
            {
                //ICData iCData = new ICData();

                CldIndexcondition indexcondition = new CldIndexcondition();
                
                indexcondition.Fh = jzfh.To2d();
                indexcondition.Hjwd = hjwd.To2d();
                indexcondition.Dwfrl = Math.Round(dwfrl * ExcuteEngine.dwfrlCoefficient, 0);

                indexcondition.Yl = yl.To2d();
                indexcondition.Zfl = zfl.To2d();
                indexcondition.Fhhtl = fhhtl.To2d();
                indexcondition.Lzhtl = lzhtl.To2d();

                indexcondition.Acpywd = Acpywd.To2d();
                indexcondition.Bcpywd = Bcpywd.To2d();

                indexcondition.KyqAckyqhyl = kyqAckyqhyl.To2d();
                indexcondition.KyqBckyqhyl = kyqBckyqhyl.To2d();
                indexcondition.Nqqby = ((double)nqqby1.buffer + nqqby2.buffer).To2d();
                indexcondition.Zgsll = zgsll.To2d();
                indexcondition.Zzqwd = zzqwd.To2d();
                indexcondition.Zzqyl = zzqyl.To2d();
                indexcondition.Zrzqwd = zrzqwd.To2d();
                indexcondition.Zrzqyl = zrzqyl.To2d();

                indexcondition.Lzczrqjwsll = ((double)lzczrqjwsll1.buffer + lzczrqjwsll2.buffer).To2d();
                indexcondition.Lyczrqjwsll = ((double)lyczrqjwsll1.buffer + lyczrqjwsll2.buffer).To2d();

                indexcondition.Sfwd = sfwd.To2d();
                indexcondition.Pywd = pywd.To2d();
                indexcondition.Rll = rll.To2d();
                indexcondition.Hf = hf.To2d();
                indexcondition.Fxs = fxs.To2d();
                indexcondition.Qsf = qsf.To2d();
                indexcondition.Hff = hff.To2d();
                indexcondition.Sj = Convert.ToDateTime(DateTime.Now.ToFormatString());
                indexcondition.Grd = grd.To2d();

                indexcondition.Sfjadykd = sfjadykd.To2d();
                indexcondition.Sfjbdykd = sfjbdykd.To2d();
                indexcondition.Agmjml = agmjml.To2d();
                indexcondition.Bgmjml = bgmjml.To2d();
                indexcondition.Cgmjml = cgmjml.To2d();
                indexcondition.Dgmjml = dgmjml.To2d();
                indexcondition.Egmjml = egmjml.To2d();
                indexcondition.Fgmjml = fgmjml.To2d();
                indexcondition.Qqzxecfll = qqzsecfll.To2d();
                indexcondition.Qqyxecfll = qqyxecfll.To2d();
                indexcondition.Hqzxecfll = hqzxecfll.To2d();
                indexcondition.Hqyxecfll = hqyxecfll.To2d();
                indexcondition.Qqzzecfll = qqzzecfll.To2d();
                indexcondition.Qqyzecfll = qqyzecfll.To2d();
                indexcondition.Hqzzecfll = hqzzecfll.To2d();
                indexcondition.Hqyzecfll = hqyzecfll.To2d();
                indexcondition.Qqzsecfll = qqzzecfll.To2d();
                indexcondition.Qqysecfll = qqyzecfll.To2d();
                indexcondition.Hqzsecfll = hqzzecfll.To2d();
                indexcondition.Hqysecfll = hqyzecfll.To2d();
                indexcondition.Qqzxrjfll = qqzxrjfll.To2d();
                indexcondition.Qqyxrjfll = qqyxrjfll.To2d();
                indexcondition.Hqzxrjfll = hqzxrjfll.To2d();
                indexcondition.Hqyxrjfll = hqyxrjfll.To2d();
                indexcondition.Qqzsrjfll = qqzsrjfll.To2d();
                indexcondition.Qqysrjfll = qqysrjfll.To2d();
                indexcondition.Hqzsrjfll = hqzsrjfll.To2d();
                indexcondition.Hqysrjfll = hqysrjfll.To2d();
                indexcondition.Grqzcyjjwsll = grqzcyjjwsll.To2d();
                indexcondition.Grqycyjjwsll = grqycyjjwsll.To2d();
                indexcondition.Grqzcejjwsll = grqzcejjwsll.To2d();
                indexcondition.Grqycejjwsll = grqycejjwsll.To2d();
                indexcondition.Grqyqdb5 = grqyqdb5.To2d();
                indexcondition.Grqyqdb6 = grqyqdb6.To2d();
                indexcondition.Grqyqdb7 = grqyqdb7.To2d();
                indexcondition.Grqyqdb8 = grqyqdb8.To2d();
                indexcondition.Zrqyqdb1 = zrqyqdb1.To2d();
                indexcondition.Zrqyqdb2 = zrqyqdb2.To2d();
                indexcondition.Zrqyqdb3 = zrqyqdb3.To2d();
                indexcondition.Zrqyqdb4 = zrqyqdb4.To2d();
                indexcondition.Hypz = hypz.To2d();
                indexcondition.Zkbadl = zkbadl.To2d();
                indexcondition.Zkbbdl = zkbbdl.To2d();
                indexcondition.Zkbcdl = zkbcdl.To2d();
                indexcondition.Dynqqxhsjszg1wd = dynqqxhsjszg1wd.To2d();
                indexcondition.Dynqqxhsjszg2wd = dynqqxhsjszg2wd.To2d();
                indexcondition.Dynqqxhsjszg1yl = dynqqxhsjszg1yl.To2d();
                indexcondition.Dynqqxhsjszg2yl = dynqqxhsjszg2yl.To2d();
                indexcondition.Smb = smb.To2d();
                indexcondition.Ylsdz = ylsdz.To2d();
                indexcondition.Type = 0;

                indexcondition.AGCJzhf = agcjzfh.To2d();

                ////锅炉效率耗差
                //iCData.IC.Glxlhc = _glxlhc.To2d();
                ////汽机热耗耗差
                //iCData.IC.Qjrhhc = _qjrhhc.To2d();
                ////综合耗差
                //iCData.IC.Zhhc = (_glxlhc + _qjrhhc).To2d();
                //锅炉效率
                indexcondition.Glxl = (_glxl * 100).To2d();
                //汽机热耗
                indexcondition.Qjrh = _qjrh.To2d();

                indexcondition.zzqylsdz = zzqylsdz.To2d();
                indexcondition.ltfy = ltfy.To2d();
                indexcondition.gjcqddmkd = gjcqddmkd.To2d();
                indexcondition.djcqddmkd = djcqddmkd.To2d();
                indexcondition.cyqyw = cyqyw.To2d();
                indexcondition.cyqywsdz = cyqywsdz.To2d();

                indexcondition.grdsdz = grdsdz.To2d();
                indexcondition.qjtmzzl = qjtmzzl.To2d();

                RealTimeIC = indexcondition;
                SampleQueue.Enqueue(indexcondition);

                if (SampleQueue.Count >= SampleCount)
                {
                    SampleQueue.Dequeue();
                    SteadyStateIC = null;

                    //if (tpdz & HasSteadyState)
                    //{
                    //    AddToSteadyStateList(indexcondition);
                    //    HasSteadyState = true;
                    //}
                    //else
                    //{
                        AVG[0] = SampleQueue.Select(x => x.Fh).Average() ?? 0;
                        MIN[0] = SampleQueue.Select(x => x.Fh).Min() ?? 0;
                        MAX[0] = SampleQueue.Select(x => x.Fh).Max() ?? 0;
                        if (MAX > (AVG + FhDeviation) || MIN < (AVG - FhDeviation))
                        {
                            HasSteadyState = false;
                            _steadyStateICList.Clear();
                        }
                        else
                        {
                            AddToSteadyStateList(indexcondition);
                            HasSteadyState = true;
                        }
                    //}
                }
            }
        }

        void AddToSteadyStateList(CldIndexcondition condition)
        {
            bool hasClean = ICClean(condition);
            if (hasClean) return;

            lock (_steadyStateICListLock)
            {
                List<string> groupInfo = FindGroupInfo(condition.Fh, condition.Hjwd, condition.Dwfrl);
                if (groupInfo == null || groupInfo.Count == 0) return;

                condition.Fhqj = groupInfo[0];
                condition.Hjwdqj = groupInfo[1];
                condition.Dwfrlqj = groupInfo[2];

                _steadyStateICList.Add(condition);
                SteadyStateIC = condition;
            }
        }

        public bool ICClean(CldIndexcondition indexcondition)
        {
            cleanlog = "";
            //1)主汽压力偏差（>0.5MPa）
            if (Math.Abs((indexcondition.Zzqyl - indexcondition.zzqylsdz) ?? 0) > 0.8)
            {
                cleanlog = $"因主汽压力偏差大于0.8,主汽压力为{indexcondition.Zzqyl},主汽压力设定值为{indexcondition.zzqylsdz}。";
                logger.InfoLog($"采集工况被清洗，主汽压力偏差大于0.8，被清理工况为{JsonConvert.SerializeObject(indexcondition)}。");
                return true;
            }

            ////2)汽温偏差（主汽温度<585℃或>613℃、再热汽温<580℃或>630℃）
            //if ((icdata.IC.Zzqwd < 591 || icdata.IC.Zzqwd > 613) || (icdata.IC.Zrzqwd < 600 || icdata.IC.Zrzqwd > 630))
            //{
            //    return true;
            //}

            //3)炉膛负压
            if (indexcondition.ltfy > 100 || indexcondition.ltfy < -200)
            {
                cleanlog = $"因炉膛负压大于100或小于-200,炉膛负压为{indexcondition.ltfy}。";
                logger.InfoLog($"采集工况被清洗，炉膛负压>100或<-200，被清理工况为{JsonConvert.SerializeObject(indexcondition)}。");
                return true;
            }

            ////4)氧量及其偏差（负荷>330MW时，（实际值）<2.0%或者>6.0%、负荷<330MW时，（实际值）<2.0%或者>8.0%；偏差>0.5%）
            //if (icdata.IC.Fh > 330)
            //{
            //    if (icdata.IC.Yl < 2 || icdata.IC.Yl > 6)
            //    {
            //        return true;
            //    }
            //}
            //else
            //{
            //    if (icdata.IC.Yl < 2 || icdata.IC.Yl > 8)
            //    {
            //        return true;
            //    }
            //}

            ////氧量偏差>0.5%
            //if (Math.Abs((icdata.IC.Yl - icdata.ylsdz) ?? 0) > 0.5)
            //{
            //    return true;
            //}

            //5)高低加未运行（高加：#3高加抽汽电动门开度<10%；低加：#6低加抽汽电动门开度<10%）
            if (indexcondition.gjcqddmkd < 10 || indexcondition.djcqddmkd < 10)
            {
                cleanlog = $"高加抽汽电动门开度<10或低加抽汽电动门开度<10,#3高加抽汽电动门开度为{indexcondition.gjcqddmkd},#6低加抽汽电动门开度为{indexcondition.djcqddmkd}";
                logger.InfoLog($"采集工况被清洗，高加抽汽电动门开度<10或低加抽汽电动门开度<10，被清理工况为{JsonConvert.SerializeObject(indexcondition)}。");
                return true;
            }

            //6)除氧器水位偏差（>200mm）
            if (Math.Abs(indexcondition.cyqyw - indexcondition.cyqywsdz) > 200)
            {
                cleanlog = $"除氧器水位偏差大于200mm,除氧器液位为{indexcondition.cyqyw},除氧器液位设定值为{indexcondition.cyqywsdz}";
                logger.InfoLog($"采集工况被清洗，除氧器水位偏差>200，被清理工况为{JsonConvert.SerializeObject(indexcondition)}。");
                return true;
            }

            ////7)过热度偏差（>15℃）
            //if (Math.Abs(icdata.grd - icdata.grdsdz) > 15)
            //{
            //    return true;
            //}

            //8)汽机调门总指令（<60%或>95%）
            if (indexcondition.qjtmzzl < 58 || indexcondition.qjtmzzl > 95)
            {
                cleanlog = $"汽机调门总指令（<58%或>95%,汽机调门总指令为{indexcondition.qjtmzzl}";
                logger.InfoLog($"采集工况被清洗，汽机调门总指令<58或>95，被清理工况为{JsonConvert.SerializeObject(indexcondition)}。");
                return true;
            }

            return false;
        }
    }
}