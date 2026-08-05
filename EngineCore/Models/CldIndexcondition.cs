using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace EngineCore.Models;

public partial class CldIndexcondition
{
    public int Id { get; set; }


    /// <summary>
    /// AGC负荷区间
    /// </summary>
    [NotMapped]
    public double? AGCJzhf { get; set; }



    /// <summary>
    /// 主蒸汽压力设定值
    /// </summary>
    [NotMapped]
    public double zzqylsdz { get; set; }

    /// <summary>
    /// 炉膛负压
    /// </summary>
    [NotMapped]
    public double ltfy { get; set; }


    /// <summary>
    /// #3高加抽汽电动门开度
    /// </summary>
    [NotMapped]
    public double gjcqddmkd { get; set; }

    /// <summary>
    /// #6低加抽汽电动门开度
    /// </summary>
    [NotMapped]
    public double djcqddmkd { get; set; }

    /// <summary>
    /// 除氧器液位
    /// </summary>
    [NotMapped]
    public double cyqyw { get; set; }

    /// <summary>
    /// 除氧器液位设定值
    /// </summary>
    [NotMapped]
    public double cyqywsdz { get; set; }


    /// <summary>
    /// 过热度设定值
    /// </summary>
    [NotMapped]
    public double grdsdz { get; set; }

    /// <summary>
    /// 汽机调门总指令
    /// </summary>
    [NotMapped]
    public double qjtmzzl { get; set; }




    /// <summary>
    /// 负荷区间
    /// </summary>
    public string? Fhqj { get; set; }

    /// <summary>
    /// 环境温度区间
    /// </summary>
    public string? Hjwdqj { get; set; }

    /// <summary>
    /// 低位发热量区间
    /// </summary>
    public string? Dwfrlqj { get; set; }

    /// <summary>
    /// 工况时间范围
    /// </summary>
    public string? Gksjfw { get; set; }

    /// <summary>
    /// 指标数据时间
    /// </summary>
    public DateTime? Sj { get; set; }

    /// <summary>
    /// 综合耗差
    /// </summary>
    public double? Zhhc { get; set; } = 0;

    /// <summary>
    /// 锅炉效率耗差
    /// </summary>
    public double? Glxlhc { get; set; } = 0;

    /// <summary>
    /// 汽机热耗耗差
    /// </summary>
    public double? Qjrhhc { get; set; } = 0;

    /// <summary>
    /// 锅炉效率
    /// </summary>
    public double? Glxl { get; set; }

    /// <summary>
    /// 汽机热耗
    /// </summary>
    public double? Qjrh { get; set; }

    /// <summary>
    /// 负荷
    /// </summary>
    public double? Fh { get; set; }

    /// <summary>
    /// 环境温度
    /// </summary>
    public double? Hjwd { get; set; }

    /// <summary>
    /// 低位发热量
    /// </summary>
    public double? Dwfrl { get; set; }

    /// <summary>
    /// 氧量
    /// </summary>
    public double? Yl { get; set; }

    /// <summary>
    /// 总风量
    /// </summary>
    public double? Zfl { get; set; }

    /// <summary>
    /// A侧排烟温度
    /// </summary>
    public double? Acpywd { get; set; }

    /// <summary>
    /// B侧排烟温度
    /// </summary>
    public double? Bcpywd { get; set; }

    /// <summary>
    /// 飞灰含碳量
    /// </summary>
    public double? Fhhtl { get; set; }

    /// <summary>
    /// 炉渣含碳量
    /// </summary>
    public double? Lzhtl { get; set; }

    /// <summary>
    /// 空预器A出口烟气含氧量
    /// </summary>
    public double? KyqAckyqhyl { get; set; }

    /// <summary>
    /// 空预器B出口烟气含氧量
    /// </summary>
    public double? KyqBckyqhyl { get; set; }

    /// <summary>
    /// 凝汽器背压
    /// </summary>
    public double? Nqqby { get; set; }

    /// <summary>
    /// 主给水流量
    /// </summary>
    public double? Zgsll { get; set; }

    /// <summary>
    /// 主蒸汽温度
    /// </summary>
    public double? Zzqwd { get; set; }

    /// <summary>
    /// 再热蒸汽压力
    /// </summary>
    public double? Zrzqyl { get; set; }

    /// <summary>
    /// 再热蒸汽温度
    /// </summary>
    public double? Zrzqwd { get; set; }

    /// <summary>
    /// 主蒸汽压力
    /// </summary>
    public double? Zzqyl { get; set; }

    /// <summary>
    /// #1炉左侧再热器减温水流量
    /// </summary>
    public double? Lzczrqjwsll { get; set; }

    /// <summary>
    /// #1炉右侧再热器减温水流量
    /// </summary>
    public double? Lyczrqjwsll { get; set; }

    /// <summary>
    /// 送风温度
    /// </summary>
    public double? Sfwd { get; set; }

    /// <summary>
    /// 排烟温度
    /// </summary>
    public double? Pywd { get; set; }

    /// <summary>
    /// 燃料量
    /// </summary>
    public double? Rll { get; set; }

    /// <summary>
    /// 灰分
    /// </summary>
    public double? Hf { get; set; }

    /// <summary>
    /// 分析水
    /// </summary>
    public double? Fxs { get; set; }

    /// <summary>
    /// 全水分
    /// </summary>
    public double? Qsf { get; set; }

    /// <summary>
    /// 挥发分
    /// </summary>
    public double? Hff { get; set; }

    /// <summary>
    /// 过热度
    /// </summary>
    public double? Grd { get; set; }

    /// <summary>
    /// 氧量设定值
    /// </summary>
    public double? Ylsdz { get; set; }

    /// <summary>
    /// 送风机A动叶开度
    /// </summary>
    public double? Sfjadykd { get; set; }

    /// <summary>
    /// 送风机B动叶开度
    /// </summary>
    public double? Sfjbdykd { get; set; }

    /// <summary>
    /// A给煤机煤量
    /// </summary>
    public double? Agmjml { get; set; }

    /// <summary>
    /// B给煤机煤量
    /// </summary>
    public double? Bgmjml { get; set; }

    /// <summary>
    /// C给煤机煤量
    /// </summary>
    public double? Cgmjml { get; set; }

    /// <summary>
    /// D给煤机煤量
    /// </summary>
    public double? Dgmjml { get; set; }

    /// <summary>
    /// E给煤机煤量
    /// </summary>
    public double? Egmjml { get; set; }

    /// <summary>
    /// F给煤机煤量
    /// </summary>
    public double? Fgmjml { get; set; }

    /// <summary>
    /// 前墙左下二次风流量
    /// </summary>
    public double? Qqzxecfll { get; set; }

    /// <summary>
    /// 前墙右下二次风流量
    /// </summary>
    public double? Qqyxecfll { get; set; }

    /// <summary>
    /// 后墙左下二次风流量
    /// </summary>
    public double? Hqzxecfll { get; set; }

    /// <summary>
    /// 后墙右下二次风流量
    /// </summary>
    public double? Hqyxecfll { get; set; }

    /// <summary>
    /// 前墙左中二次风流量
    /// </summary>
    public double? Qqzzecfll { get; set; }

    /// <summary>
    /// 前墙右中二次风流量
    /// </summary>
    public double? Qqyzecfll { get; set; }

    /// <summary>
    /// 后墙左中二次风流量
    /// </summary>
    public double? Hqzzecfll { get; set; }

    /// <summary>
    /// 后墙右中二次风流量
    /// </summary>
    public double? Hqyzecfll { get; set; }

    /// <summary>
    /// 前墙左上二次风流量
    /// </summary>
    public double? Qqzsecfll { get; set; }

    /// <summary>
    /// 前墙右上二次风流量
    /// </summary>
    public double? Qqysecfll { get; set; }

    /// <summary>
    /// 后墙左上二次风流量
    /// </summary>
    public double? Hqzsecfll { get; set; }

    /// <summary>
    /// 后墙右上二次风流量
    /// </summary>
    public double? Hqysecfll { get; set; }

    /// <summary>
    /// 前墙左下燃烬风流量
    /// </summary>
    public double? Qqzxrjfll { get; set; }

    /// <summary>
    /// 前墙右下燃烬风流量
    /// </summary>
    public double? Qqyxrjfll { get; set; }

    /// <summary>
    /// 后墙左下燃烬风流量
    /// </summary>
    public double? Hqzxrjfll { get; set; }

    /// <summary>
    /// 后墙右下燃烬风流量
    /// </summary>
    public double? Hqyxrjfll { get; set; }

    /// <summary>
    /// 前墙左上燃烬风流量
    /// </summary>
    public double? Qqzsrjfll { get; set; }

    /// <summary>
    /// 前墙右上燃烬风流量
    /// </summary>
    public double? Qqysrjfll { get; set; }

    /// <summary>
    /// 后墙左上燃烬风流量
    /// </summary>
    public double? Hqzsrjfll { get; set; }

    /// <summary>
    /// 后墙右上燃烬风流量
    /// </summary>
    public double? Hqysrjfll { get; set; }

    /// <summary>
    /// 过热器左侧一级减温水流量
    /// </summary>
    public double? Grqzcyjjwsll { get; set; }

    /// <summary>
    /// 过热器右侧一级减温水流量
    /// </summary>
    public double? Grqycyjjwsll { get; set; }

    /// <summary>
    /// 过热器左侧二级减温水流量
    /// </summary>
    public double? Grqzcejjwsll { get; set; }

    /// <summary>
    /// 过热器右侧二级减温水流量
    /// </summary>
    public double? Grqycejjwsll { get; set; }

    /// <summary>
    /// 过热器烟气挡板5
    /// </summary>
    public double? Grqyqdb5 { get; set; }

    /// <summary>
    /// 过热器烟气挡板6
    /// </summary>
    public double? Grqyqdb6 { get; set; }

    /// <summary>
    /// 过热器烟气挡板7
    /// </summary>
    public double? Grqyqdb7 { get; set; }

    /// <summary>
    /// 过热器烟气挡板8
    /// </summary>
    public double? Grqyqdb8 { get; set; }

    /// <summary>
    /// 再热器烟气挡板1
    /// </summary>
    public double? Zrqyqdb1 { get; set; }

    /// <summary>
    /// 再热器烟气挡板2
    /// </summary>
    public double? Zrqyqdb2 { get; set; }

    /// <summary>
    /// 再热器烟气挡板3
    /// </summary>
    public double? Zrqyqdb3 { get; set; }

    /// <summary>
    /// 再热器烟气挡板4
    /// </summary>
    public double? Zrqyqdb4 { get; set; }

    /// <summary>
    /// 滑压偏置
    /// </summary>
    public double? Hypz { get; set; }

    /// <summary>
    /// 真空泵A电流
    /// </summary>
    public double? Zkbadl { get; set; }

    /// <summary>
    /// 真空泵B电流
    /// </summary>
    public double? Zkbbdl { get; set; }

    /// <summary>
    /// 真空泵C电流
    /// </summary>
    public double? Zkbcdl { get; set; }

    /// <summary>
    /// 低压凝汽器循环水进水支管1温度
    /// </summary>
    public double? Dynqqxhsjszg1wd { get; set; }

    /// <summary>
    /// 低压凝汽器循环水进水支管2温度
    /// </summary>
    public double? Dynqqxhsjszg2wd { get; set; }

    /// <summary>
    /// 低压凝汽器循环水进水支管1压力
    /// </summary>
    public double? Dynqqxhsjszg1yl { get; set; }

    /// <summary>
    /// 低压凝汽器循环水进水支管2压力
    /// </summary>
    public double? Dynqqxhsjszg2yl { get; set; }

    /// <summary>
    /// 水煤比
    /// </summary>
    public double? Smb { get; set; }

    /// <summary>
    /// 0：标杆工况；1：专家工况
    /// </summary>
    public int? Type { get; set; }

    /// <summary>
    /// 备注
    /// </summary>
    public string? Remarks { get; set; }
    public DateTime? comparetime { get; set; }
}
