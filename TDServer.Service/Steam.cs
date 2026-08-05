
namespace TDServer.Service;

/// <summary>
/// 燃机性能指标计算
/// </summary>
public class Reverso
{
    private const double G = 9.80665;

    private const double Kc = 1.4;

    private const double Kt = 1.33;

    /// <summary>
    /// 温度区间
    /// </summary>
    private static readonly List<double> Tx = Enumerable.Range(0, 19).Select(x => x * 100.0).ToList();

    /// <summary>
    /// 空气定压比热容区间
    /// </summary>
    private static readonly List<double> CpaY = new List<double>
    {
        1.295, 1.30, 1.308, 1.318, 1.329, 1.343, 1.357, 1.371,
        1.385, 1.398, 1.410, 1.422, 1.433, 1.444, 1.454, 1.463,
        1.472, 1.480, 1.487
    };


    #region 物性计算

    /// <summary>
    /// 计算空气压缩过程中的平均定压比热容, TODO: 需要编译动态库进行计算
    /// </summary>
    /// <param name="t1">开始温度</param>
    /// <param name="t2">结束温度</param>
    /// <returns></returns>
    private static (string, double) ComputeAirCpa(double t1, double t2)
    {

        return (string.Empty, 0.0d);

        // LSQRModel model = new()
        // {
        //     X = Tx,
        //     Y = CpaY,
        //     Pw = (t1 + t2) / 2.0
        // };

        // var ptr = TpriDllImport.ComputeTarget(JsonConvert.SerializeObject(model));

        // var res = Marshal.PtrToStringAnsi(ptr);

        // TpriDllImport.FreeMallocMemory(ref ptr);

        // if (res is null)
        // {

        //     return ($"Cpa{Helper.NULLMessage}", -1);

        // }

        // var r = JsonConvert.DeserializeObject<Response<double>>(res);

        // if (r is null || !string.IsNullOrEmpty(r.Msg))
        // {
        //     return (r is null ? $"Cpa{Helper.NULLMessage}" : $"{r.Msg}", -1);

        // }

        // return (string.Empty, r.Data);

    }

    /// <summary>
    /// 计算燃气定压比热容, TODO: 需要编译动态库进行计算
    /// </summary>
    /// <param name="t1"></param>
    /// <param name="t2"></param>
    /// <returns></returns>
    private static double ComputeSCpa(double t1, double t2)
    {

        return 0.0;

    }

    /// <summary>
    /// 计算水蒸汽的焓值, TODO: 需要编译动态库进行计算
    /// </summary>
    /// <param name="p">压力</param>
    /// <param name="t">温度</param>
    /// <returns></returns>
    private static double ComputeWHPT(double p, double t)
    {
        return 0.0d;
    }

    /// <summary>
    /// 计算对应压力的饱和温度, TODO: 需要编译动态库进行计算
    /// </summary>
    /// <param name="p"></param>
    /// <returns></returns>
    private static double ComputeWTP(double p)
    {

        return 0.0d;

    }

    /// <summary>
    /// 计算熵
    /// </summary>
    /// <param name="p">压力</param>
    /// <param name="t">温度</param>
    /// <returns></returns>
    private static double ComputeWSPT(double p, double t)
    {
        return 0.0d;
    }

    /// <summary>
    /// 计算焓值
    /// </summary>
    /// <param name="p">压力</param>
    /// <param name="s">熵</param>
    /// <returns></returns>
    private static double ComputeWHPS(double p, double s)
    {

        return 0.0d;

    }

    /// <summary>
    /// 计算燃机排气的焓值
    /// </summary>
    /// <param name="p"></param>
    /// <param name="t"></param>
    /// <returns></returns>
    private static double ComputeSHPT(double p, double t)
    {

        return 0.0d;
    }

    #endregion

    #region 压气机
    /// <summary>
    /// 压气机压比, p2为压气机出口压力(kPa), p1为压气机进口压力(kPa)
    /// </summary>
    public static readonly Func<double, double, double> PressureB = (p2, p1) => Math.Round(p2 / p1, 2);

    /// <summary>
    /// 压气机等熵压缩效率
    /// </summary>
    /// <param name="t1">进口空气温度(K)</param>
    /// <param name="t2">出口空气温度(K)</param>
    /// <param name="p1">进口空气压力(kPa)</param>
    /// <param name="p2">出口空气压力(kPa)</param>
    /// <returns></returns>
    public double ComputeEp(double t1, double t2, double p1, double p2)
    {

        double mc = (Kc - 1) / Kc;
        double pic = PressureB(p2, p1);
        return (Math.Pow(pic, mc) - 1) / ((t2 / t1) - 1);

    }

    /// <summary>
    /// 压气机压缩比功
    /// </summary>
    /// <param name="t1">进口空气温度(K)</param>
    /// <param name="t2">出口空气温度(K)</param>
    /// <param name="p1">进口空气压力(kPa)</param>
    /// <param name="p2">出口空气压力(kPa)</param>
    /// <returns></returns>
    public (string, double) CompuetWp(double t1, double t2, double p1, double p2)
    {

        double ep = ComputeEp(t1, t2, p1, p2);
        double mc = (Kc - 1) / Kc;
        double pic = PressureB(p2, p1);
        var (msg, cpa) = ComputeAirCpa(p1, p2);
        if (!string.IsNullOrEmpty(msg)) return (msg, -1);
        return (string.Empty, cpa * t1 * (Math.Pow(pic, mc) - 1) / ep);

    }

    #endregion

    #region  燃机透平
    /// <summary>
    /// 燃机温比，T3为透平前温度,T1为燃机进气温度(K)
    /// </summary>
    public readonly Func<double, double, double> TemperatureB = (t3, t1) => Math.Round(t3 / t1, 2);

    /// <summary>
    /// 燃机膨胀比,p1为压气机进气压力,p2为出口压力,p3为燃烧室压力,p4为燃机排气压力,pa为大气压,单位均为kPa
    /// </summary>
    public readonly Func<double, double, double, double, double, double> ExpandB = (p1, p2, p3, p4, pa) => p1 / pa * (p3 / p2) * (pa / p4) * PressureB(p1, p2);

    /// <summary>
    /// 燃机热耗率,d为燃料流量(kg/h),qnetar为燃料低位发热量(kJ/kg),pw为机组功率(kw)
    /// kg/h * kj/kg=>kj/h * kw=>kJ/kwh
    /// </summary>
    public readonly Func<double, double, double, double> Qsr = (d, qnetar, pw) => Math.Round(d * qnetar / pw);

    /// <summary>
    /// 燃机内效率,qsr为热耗(kJ/kWh)
    /// </summary>
    public readonly Func<double, double> E = (qsr) => 3600 / qsr;

    /// <summary>
    /// 燃机效率
    /// </summary>
    /// <param name="t3">透平进口温度(K)</param>
    /// <param name="t4">透平出口温度(K)</param>
    /// <returns></returns>
    public double ComputeEt(double p1, double p2, double p3, double p4, double pa, double t3, double t4)
    {

        double mt = (Kt - 1) / Kt;
        double pit = ExpandB(p1, p2, p3, p4, pa);

        return (1 - t4 / t3) / (1 - Math.Pow(pit, -1 * mt));

    }

    /// <summary>
    /// 燃机发电气耗率, d为燃料流量(kg/h),pw为机组功率(kw)
    /// </summary>
    public readonly Func<double, double, double> ComputeEd = (d, pw) => Math.Round(d / pw, 2);

    /// <summary>
    /// 燃机供电气耗率,d为燃料流量(kg/h),pw为机组功率(kw),e为厂用电率
    /// </summary>
    public readonly Func<double, double, double, double> ComputeEde = (d, pw, e) => Math.Round(d / pw / (1 - e / 100.0), 2);

    /// <summary>
    /// 燃机透平比功(kJ/kg)
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="p3"></param>
    /// <param name="p4"></param>
    /// <param name="pa"></param>
    /// <param name="t3"></param>
    /// <param name="t4"></param>
    /// <returns></returns>
    public double ComputeEp(double p1, double p2, double p3, double p4, double pa, double t3, double t4)
    {

        double cpg = ComputeSCpa(t3, t4);
        double mt = (Kt - 1) / Kt;
        double pit = ExpandB(p1, p2, p3, p4, pa);

        double et = ComputeEt(p1, p1, p3, p4, pa, t3, t4);

        return cpg * t3 * (1 - Math.Pow(pit, -1 * mt)) * et;

    }

    /// <summary>
    /// 燃机循环比功
    /// </summary>
    /// <param name="p1"></param>
    /// <param name="p2"></param>
    /// <param name="p3"></param>
    /// <param name="p4"></param>
    /// <param name="pa"></param>
    /// <param name="t3"></param>
    /// <param name="t4"></param>
    /// <param name="t1"></param>
    /// <param name="t2"></param>
    /// <param name="ga">压气机进口空气流量(kg/s)</param>
    /// <param name="gcla">冷却空气流量(kg/s)</param>
    /// <param name="gf">天然气流量(kg/s)</param>
    /// <returns>(燃机比功,燃机功率)</returns>
    public (double, double) ComputeEcp(double p1, double p2, double p3, double p4, double pa, double t3, double t4, double t1, double t2,
    double ga, double gcla, double gf)
    {

        // 计算燃机透平比功
        double wt = ComputeEp(p1, p2, p3, p4, pa, t3, t4);
        var (_, wc) = CompuetWp(t1, t2, p1, p2);
        var wgt = (ga - gcla + gf) / ga * wt - wc;
        return (wgt, wgt * ga);

    }


    #endregion

    #region 余热锅炉

    /// <summary>
    /// 正平衡余热锅炉效率
    /// </summary>
    /// <param name="pg">高压蒸汽压力(Mpa)</param>
    /// <param name="tg">高压蒸汽温度(摄氏度)</param>
    /// <param name="dg">高压蒸汽流量(kg/s)</param>
    /// <param name="dgj">高压过热器减温水流量(kg/s)</param>
    /// <param name="pgj">高压过热器减温水压力</param>
    /// <param name="tgj">高压过热器减温水流量</param>
    /// <param name="pgs">高压给水压力</param>
    /// <param name="tgs">高压给水温度</param>
    /// <param name="pd">低压蒸汽压力</param>
    /// <param name="td">低压蒸汽温度</param>
    /// <param name="dd">低压蒸汽流量</param>
    /// <param name="pdgs">低压给水压力</param>
    /// <param name="tdgs">低压给水温度</param>
    /// <param name="ds">燃机排气流量</param>
    /// <param name="ps">燃机排气压力</param>
    /// <param name="ts">燃机排气温度</param>
    /// <returns>(蒸汽吸热量，锅炉效率)</returns>
    public (double, double) CompueEb(double pg, double tg, double dg, double dgj, double pgj, double tgj, double pgs, double tgs, double pd, double td, double dd, double pdgs, double tdgs,
    double ds, double ps, double ts)
    {


        double hgp = ComputeWHPT(pg, tg);
        double hgs = ComputeWHPT(pgs, tgs);
        double hgj = ComputeWHPT(pgj, tgj);
        double hdq = ComputeWHPT(pd, td);
        double hds = ComputeWHPT(pdgs, tdgs);

        double Q = dg * (hgp - hgs) + dgj * (hgs - hgj) + dd * (hdq - hds);

        double Qr = ds * ComputeSHPT(ps, ts);

        return (Q, Q / Qr);


    }

    /// <summary>
    /// 锅炉热端差,tyq为高压过热器烟气入口的烟气温度,t2为主蒸汽温度
    /// </summary>
    public readonly Func<double, double, double> ComputeDeltaT = (tyq, t2) => tyq - t2;

    /// <summary>
    /// 锅炉节点温差
    /// </summary>
    /// <param name="ty">烟气温度</param>
    /// <param name="p">压力</param>
    /// <returns></returns>
    public double ComputeNodeDeltaT(double ty, double p)
    {

        return ty - ComputeWTP(p);

    }

    #endregion

    #region 蒸汽轮机

    /// <summary>
    /// 汽机热耗
    /// </summary>
    /// <param name="pg">高压蒸汽压力</param>
    /// <param name="tg">高压蒸汽温度</param>
    /// <param name="dg">高压蒸汽流量</param>
    /// <param name="pd">低压蒸汽压力</param>
    /// <param name="td">低压蒸汽温度</param>
    /// <param name="dd">低压蒸汽流量</param>
    /// <param name="pn">凝结水压力</param>
    /// <param name="tn">凝结水温度</param>
    /// <param name="dn">凝结水温度</param>
    /// <param name="pc">排汽压力</param>
    /// <param name="tc">排汽温度</param>
    /// <param name="pb">补水压力</param>
    /// <param name="tb">补水温度</param>
    /// <param name="db">补水流量</param>
    /// <returns>(汽机功率,汽机热耗)</returns>
    public static (double, double) ComputeSteamQsr(double pg, double tg, double dg, double pd, double td, double dd, double pn,
    double tn, double dn, double pc, double tc, double pb, double tb, double db)
    {

        double hgp = ComputeWHPT(pg, tg);
        double hdp = ComputeWHPT(pd, td);
        double hn = ComputeWHPT(pn, tn);
        double hc = ComputeWHPT(pc, tc);

        double w = dg * (hgp - hc) + dd * (hdp - hc);

        return (w, (dg * hgp + dd * hdp - dn * hn + db == 0.0 ? 0.0 : db * ComputeWHPT(pb, tb)) / w);

    }

    /// <summary>
    /// 汽机汽耗,其中dg为高压蒸汽流量,dd为低压蒸汽流量,pw为汽机功率(ComputeSteamQsr的输出)
    /// </summary>
    public static readonly Func<double, double, double, double> ComputeSteamD = (dg, dd, pw) => (dd + dg) / pw;

    /// <summary>
    /// 汽机效率,qsr为热耗
    /// </summary>
    public static readonly Func<double, double> ComputeSteamE = (qsr) => 3600 / qsr;

    /// <summary>
    /// 汽机缸效率,pin为进汽压力,tin为进汽温度,pwout为出汽压力,twout为出汽温度
    /// </summary>
    public readonly Func<double, double, double, double, double> ComputeSteamEb = (pin, tin, pwout, twout) =>
    {

        double hin = ComputeWHPT(pin, tin);
        double hwout = ComputeWHPT(pwout, twout);
        double sin = ComputeWSPT(p: pin, t: tin);
        double hwout_ = ComputeWHPS(pwout, sin);

        return (hin - hwout) / (hin - hwout_);

    };

    #endregion

    #region 联合循环

    /// <summary>
    /// 联合循环机组功率,wgt为燃机功率,wst为汽机功率
    /// </summary>
    public static readonly Func<double, double, double> ComputeCircleW = (wgt, wst) => wgt + wst;

    /// <summary>
    /// 联合循环燃功比
    /// </summary>
    public readonly Func<double, double, double> ComputeCircleWgtRate = (wgt, wst) => wgt / ComputeCircleW(wgt, wst);

    /// <summary>
    /// 联合循环蒸功比
    /// </summary>
    public readonly Func<double, double, double> ComputeCircleWstRate = (wgt, wst) => wst / ComputeCircleW(wgt, wst);

    /// <summary>
    /// 联合循环机组热耗, gf为天然气流量(kg/h),qnetar为燃料低位发热量(kJ/kg), wcc为联合循环机组功率(kw)
    /// </summary>
    public readonly Func<double, double, double, double> ComputeCircleQsr = (gf, qnetar, wcc) => gf * qnetar / wcc;

    /// <summary>
    /// 联合循环机组发电气耗,vf为天然气流量m3/h
    /// </summary>
    public static readonly Func<double, double, double> ComputeCircleD = (vf, wcc) => vf / wcc;

    /// <summary>
    /// 联合循环供电气耗,e为厂用电率
    /// </summary>
    public readonly Func<double, double, double, double> ComputeCircleDG = (vf, wcc, e) => ComputeCircleD(vf, wcc) / (1 - e / 100.0);

    /// <summary>
    /// 联合循环折算标准发电煤耗, qsr为联合循环机组热耗
    /// </summary>
    public static readonly Func<double, double> ComputeCircleB = (qsr) => 1000 * qsr / 29.3076;

    /// <summary>
    /// 联合循环折算标准供电煤耗, qsr为联合循环机组热耗
    /// </summary>
    public readonly Func<double, double, double> ComputeCircleBG = (qsr, e) => ComputeCircleB(qsr) / (1 - e / 100.0);

    /// <summary>
    /// 联合循环发电效率
    /// </summary>
    public static readonly Func<double, double> ComputeCircleE = (qsr) => 3600 / qsr;

    /// <summary>
    /// 联合循环供电效率
    /// </summary>
    public readonly Func<double, double, double> ComputeCircleEG = (qsr, e) => ComputeCircleE(qsr) / (1 - e / 100);

    /// <summary>
    /// 联合循环机组厂用电率
    /// </summary>
    /// <param name="p">发电量</param>
    /// <param name="others">用电量</param>
    /// <returns></returns>
    public double ComputePlantE(double p, params double[] others)
    {

        return (p - others.Sum()) / p;

    }

    #endregion

    #region 辅机设备
    /// <summary>
    /// 计算设备耗电率,p为发电量,p1为设备耗电率
    /// </summary>
    public readonly Func<double, double, double> ComputeDeviceE = (p, p1) => p1 / p;

    /// <summary>
    /// 计算设备单耗,p为发电量,d为流量等
    /// </summary>
    public static readonly Func<double, double, double> ComputeDeviceD = (p, d) => p / d;

    /// <summary>
    /// 泵的扬程,此处使用简化公式
    /// </summary>
    /// <param name="pin">进口压力</param>
    /// <param name="tin">进口温度</param>
    /// <param name="pwout">出口压力</param>
    /// <param name="twout">出口温度</param>
    /// <param name="d">流量</param>
    /// <param name="a">泵的流量电流</param>
    /// <param name="v">泵的电压</param>
    /// <returns>(扬程,效率)</returns>
    public static (double, double) ComputePumbH(double pin, double tin, double pwout, double d, double a, double v)
    {
        double density = 1000 - 0.0178 * Math.Pow(tin - 4, 1.7);

        double h = (pwout - pin) / density / G;

        double pw = a * v * Math.Sqrt(3) * a * v;

        return (h, d * G * h / pw);

    }

    /// <summary>
    /// 计算凝汽器热负荷
    /// </summary>
    public readonly Func<double, double, double, double, double, double> ComputeSteamLoad = (pin, tin, pwout, twout, d) => d * (ComputeWHPT(pin, tin) - ComputeWHPT(pwout, twout));

    /// <summary>
    /// 计算冷却水温升,tin为进口水温,twout为出口水温
    /// </summary>
    public static readonly Func<double, double, double> ComputeSteamT = (tin, twout) => twout - tin;

    /// <summary>
    /// 计算对数平均温差, p为凝汽器压力
    /// </summary>
    public static readonly Func<double, double, double, double> ComputeSteamLogT = (p, tin, twout) =>
    {

        double dt = ComputeSteamT(tin, twout);
        double ts = ComputeWTP(p);
        return dt / Math.Log((ts - tin) / (ts - twout));

    };

    #endregion


}