using DCSType;
using EngineCore.Models;
using System.ComponentModel;

namespace TDServer.Service
{
    public class ConfigInfo
    {

        public int ICCompareTime { get; set; }

        public int RunCycle { get; set; }

        public int rtserverport { get; set; }

        //public string? Prefix { get; set; }

        //public string? OldDcsPrefix  { get; set; }

        //public string? NewDcsPrefix { get; set; }

        //public string? OldDcsSimplePrefix { get; set; }

        //public string? NewDcsSimplePrefix { get; set; }

        //public string? OldTcsPrefix { get; set; }

        //public string? NewTcsPrefix { get; set; }

        //public string? OldTcsSimplePrefix { get; set; }

        //public string? NewTcsSimplePrefix { get; set; }

        //public string? IsTurbinRunningPoint { get; set; }

        //public string? IsSteamRunningPoint { get; set; }

        //public string? PlantEPoint { get; set; }

        //public string? PlantEOtherPoint { get; set; }


        public string dserverlogonurl { get; set; }

        public string dserverdataurl { get; set; }

        public string boilerdataapiurl { get; set; }

        public string dservertag { get; set; }

        public string dserverbrokerlist { get; set; }

        public int dservergroupid { get; set; }

        public int dbinsertitemcount { get; set; }

        public string pvapiurl { get; set; }

        public string eletodaysumapiurl { get; set; }

        public string pageinputapiurl { get; set; }


        public string writebackapiurl { get; set; }

        public string NameSpace { get; set; }

        public string mysqlConn { get; set; }

        public string mysqlConnWay { get; set; }

        public string mysqlEnergyanalySis { get; set; }

        public OptimizingGuidePara optimizingGuidePara { get; set; }

        public Dictionary<string, double> pageInputDefaultValues { get; set; }

        public string InfluxDBUrl { get; set; }

        public string InfluxDBToken { get; set; }

        public string InfluxDBName { get; set; }

        public string InfluxDBOrg { get; set; }

        public string InfluxDBQueryApiurl { get; set; }

        public string UpdatePCalcValuesapiurl { get; set; }

        public string GetLastValuesapiurl { get; set; }

        public bool enableWriteBackDcs { get; set; } = true;
        public bool enableGetBoilerData { get; set; } = true;
        public bool enableGetChAndFqData { get; set; } = true;
        public bool enableEconomicAlarmMonitoring { get; set; } = true;
        public economicConfig economicConfig { get; set; } = new economicConfig();
        public bool enableICCompareService { get; set; } = true;
        public bool enableHealth { get; set; } = true;

        public bool enableDeviceRunCfg { get; set; } = false;

        public bool enableTpriServer { get; set; } = false;

        public string tpriServerUrl { get; set; }

        public string sysUnit { get; set; }

        public string healthUnit { get; set; }

    }

    public class economicConfig
    {
        public string redisConnectionString { get; set; } = string.Empty;

        public int redisDatabase { get; set; }

        public string redisStablePoint { get; set; }

        public string lsqrResultApiUrl { get; set; }
    }

    public class OptimizingGuidePara
    {
        /// <summary>
        /// 氧量值偏高
        /// </summary>
        public double ylHighValue { get; set; }

        /// <summary>
        /// 氧量值偏低
        /// </summary>
        public double ylLowValue { get; set; }

        /// <summary>
        /// A侧排烟温度较高
        /// </summary>
        public double acpywdHighValue { get; set; }

        /// <summary>
        /// B侧排烟温度较高
        /// </summary>
        public double bcpywdHighValue { get; set; }

        /// <summary>
        /// 飞灰含碳量较大
        /// </summary>
        public double fhhtlHighValue { get; set; }

        /// <summary>
        /// 炉渣含碳量较大
        /// </summary>
        public double lzhtlHighValue { get; set; }

        /// <summary>
        /// 炉膛总风量较大
        /// </summary>
        public double zflHighValue { get; set; }

        /// <summary>
        /// 空预器出口含氧量偏大
        /// </summary>
        public double kyqckyqhylValue { get; set; }

        /// <summary>
        /// 主蒸汽温度偏低
        /// </summary>
        public double zzqwdLowValue { get; set; }

        /// <summary>
        /// 主蒸汽温度偏高
        /// </summary>
        public double zzqwdHighValue { get; set; }

        /// <summary>
        /// 再热蒸汽温度偏低
        /// </summary>
        public double zrzqwdLowValue { get; set; }

        /// <summary>
        /// 再热蒸汽温度偏高
        /// </summary>
        public double zrzqwdHighValue { get; set; }

        /// <summary>
        /// 主蒸汽压力偏低
        /// </summary>
        public double zzqyldLowValue { get; set; }

        /// <summary>
        /// 再热蒸汽压力偏低
        /// </summary>
        public double zrzqyldLowValue { get; set; }

        /// <summary>
        /// 凝汽器背压偏高
        /// </summary>
        public double nnqbyHighValue { get; set; }

        /// <summary>
        /// 再热器减温水流量偏大
        /// </summary>
        public double zrqjwsllHighValue { get; set; }

        /// <summary>
        /// 给水流量偏大
        /// </summary>
        public double zgsllHighValue { get; set; }

        /// <summary>
        /// 过热度偏低
        /// </summary>
        public double grdLowValue { get; set; }

        /// <summary>
        /// 过热度偏高
        /// </summary>
        public double grdHighValue { get; set; }
    }
    public class economichistorycfgdto
    {
        public int Id { get; set; } = 0;

        public string pointName { get; set; }

        public string startTime { get; set; }

        public string endTime { get; set; }

        public string? duration { get; set; }

        public string level { get; set; }
    }

    public class ICGroup
    {
        public string Fhqj { get; set; }

        public string Hjwdqj { get; set; }

        public string Dwfrlqj { get; set; }
    }


    public class WarnPointUpdateInfo
    {
        /// <summary>
        /// 0：新增；1：修改；2：删除
        /// </summary>
        public int DbAction { get; set; }
        public CldWarnpoint cldWarnpoint { get; set; }
    }


    public class WriteBackPoint
    {
        public List<items> items { get; set; }

        public string @namespace { get; set; }

        public string tag { get; set; }
    }

    public class items
    {
        public string item { get; set; }

        public float value { get; set; }
    }

    public class WarnRValue
    {
        public string AlgorithmName { get; set; }
        public string WarnRTableName { get; set; }
        public string OutPinName { get; set; }

        public LA RValue { get; set; }
    }


    #region 预警统计

    public class AlarmTotal
    {
        public string UnitName { get; set; }
        public int Count { get; set; }
    }

    public class WarnAlarmData
    {
        public int Id { get; set; }
        public string PointName { get; set; }
        public string SysName { get; set; }
        public string Description { get; set; }
        public DateTime BeginTime { get; set; }
        public DateTime EndTime { get; set; }
        public double Duration { get; set; }

        public double UpUpLimitDuration { get; set; }

        public double? ExceedLimitMaximum { get; set; }

        public int? Level { get; set; }

        public int? AlarmType { get; set; }

        public int IsAlarmSuspended { get; set; }
    }


    public class WarnAlarmRequest
    {
        [DefaultValue(null)]
        public string? SearceName { get; set; }

        [DefaultValue(null)]
        public string? SearchDescription { get; set; }  // 新增

        /// <summary>
        /// 0：本日，1：本周，2：本月
        /// </summary>
        public int? TimeDelta { get; set; }

    }
    public class HdlRequest
    {
        [DefaultValue(null)]
        /// 0：本月，1：本季度，2,：本年
        /// </summary>
        public int? TimeDelta { get; set; }
    }
    public class xunyoudataRequest
    {
        [DefaultValue(null)]
        public string? Starttime { get; set; }
        public string? Endtime { get; set; }
    }
    public class adviseRequest
    {
        [DefaultValue(null)]
        public string? Steadytime { get; set; }
    }
    #endregion

    #region 故障诊断

    public class FaultDiagnosisData
    {
        public int Id { get; set; }
        public int FaultCode { get; set; }
        public string FaultName { get; set; }
        public string BeginTime { get; set; }
        public string EndTime { get; set; }
        public double Duration { get; set; }
    }


    #endregion

    public class experticdata
    {
        public long index { get; set; }

        public long time { get; set; }

        public string lable { get; set; }

        public string tablename { get; set; }

        public double pvalue { get; set; }
    }

    public class PointValue
    {
        public string ts { get; set; }

        public string pvalue { get; set; }
    }

    public class CurveData
    {
        public string tag { get; set; }

        public List<string> tslist { get; set; }

        public List<double> pvalueList { get; set; }
    }

    public class EconomicCurve
    {
        public string title { get; set; }

        public List<CurveData> curveData { get; set; }
    }

    public class ControlCurve
    {
        public string title { get; set; }

        public List<CurveData> curveData { get; set; }
    }


    public class ControlInfoData
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string PointName { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }

        /// <summary>
        /// 最大超调量
        /// </summary>
        public string MaxDeviation { get; set; }

        /// <summary>
        /// 调节时长
        /// </summary>
        public string Time { get; set; }

        /// <summary>
        /// 衰减率
        /// </summary>
        public string DecayRate { get; set; }

        /// <summary>
        /// 残余偏差
        /// </summary>
        public string Residual { get; set; }

        /// <summary>
        /// 超高限次数
        /// </summary>
        public string UpperCount { get; set; }

        /// <summary>
        /// 超低限次数
        /// </summary>
        public string LowerCount { get; set; }

        public string Qos { get; set; }

        public string Performance { get; set; }

        public string Score { get; set; }

        public string Upper { get; set; }

        public string Lower { get; set; }

        public double? SetPoint { get; set; }

        public int? Firsttime { get; set; }

        public int? Secondtime { get; set; }

        public int? ControlEndtime { get; set; }

        public string Pointevaluate { get; set; }

        public string Deviceevaluate { get; set; }

        public string? decayratescore { get; set; }

        public string? resscore { get; set; }
        public string? kpiscore { get; set; }
        public string? timescore { get; set; }
        public int? level { get; set; }
        public string? faultcodedes { get; set; }
    }

    public class AgcControlInfoData
    {
        public int Id { get; set; }

        public string startTime { get; set; }
        public string endTime { get; set; }

        public string Qualified { get; set; }

        public string LoadValue { get; set; }

        public string AgcValue { get; set; }

        public string LoadValueSteady { get; set; }

        public string Time { get; set; }

        public string ControlRate { get; set; }

        public string ControlRateSp { get; set; }

        public string ResponseTime { get; set; }

        public string ResponseTimeStandard { get; set; }
    }

    public class AgcMonthInfoData
    {
        public int Id { get; set; }
        public string Time { get; set; }

        public string Availability { get; set; }

        public string AvailabilityStandard { get; set; }

        public string MonthlyControlrate { get; set; }

        public string MonthlyControlrateStandard { get; set; }

        public string Qualified { get; set; }

        public string MonthlyQualified { get; set; }

        public string MonthlyQualifiedStandard { get; set; }
    }


    public class DehcontrolinfoData
    {
        public int Id { get; set; }

        public string startTime { get; set; }
        public string endTime { get; set; }
        public string time { get; set; }
        public string LoadValue { get; set; }
        public string Loadchange { get; set; }
        public string ResponseValue { get; set; }
        public string ResponseDeviation { get; set; }
        public string ResponseQualified { get; set; }
        public string EleQualified { get; set; }
        public string DehQualified { get; set; }
        public string Ele { get; set; }
        public string Elesum { get; set; }

    }
    public class ControlQueryModel
    {
        public string UnitName { get; set; }

        public string PointName { get; set; }

        public string StartTime { get; set; }

        public string EndTime { get; set; }
    }
    public class click
    {
        public int part { get; set; }
    }
    public class controlweighunit
    {
        public string Unit { get; set; }
    }

    public class pointshow
    {
        public int pointname { get; set; }


    }

    public class InputPinChange
    {
        public string PinName { get; set; }
        public string OldPointName { get; set; }
        public string NewPointName { get; set; }
        public string OldInitialValue { get; set; }
        public string NewInitialValue { get; set; }
        public bool IsPointNameChanged => OldPointName != NewPointName;
        public bool IsInitialValueChanged => string.IsNullOrEmpty(OldPointName) &&
                                            string.IsNullOrEmpty(NewPointName) &&
                                            OldInitialValue != NewInitialValue;
        public bool HasAnyChange => IsPointNameChanged || IsInitialValueChanged;
    }

    public class SuspendedAlarmPointData
    {
        public string PointName { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// 报警类型：0-模型，1-规则
        /// </summary>
        public int? AlarmType { get; set; }
    }

}
