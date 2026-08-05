using DCSCommon;
using DCSType;
using PerformanceCalc;
using System.Runtime.InteropServices;
using TDServer.Service;

namespace FunctionCode
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [FCName("TurbinCalculator")]
    [FCDisplay("汽机性能计算")]
    public partial class TurbinCalculator : Function
    {
        [PinType(PinTypes.Input)]
        [PinDisplay("是否可用输入")]
        public LD _EN = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("大气压力")]
        public LA atm = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Input)]
        [PinDisplay("机组负荷")]
        public LA pw = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热蒸汽压力")]
        public LA pgr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热蒸汽温度")]
        public LA tgr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("主蒸汽流量kg/h ")]
        public LA dgr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水压力")]
        public LA pgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水温度")]
        public LA tgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("给水流量")]
        public LA dgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热蒸汽压力")]
        public LA pzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热蒸汽温度")]
        public LA tzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热减温水压力")]
        public LA pzrj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热减温水温度")]
        public LA tzrj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("再热减温水流量")]
        public LA dzrj = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水压力1")]
        public LA pgrj1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水压力2")]
        public LA pgrj2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水温度1")]
        public LA tgrj1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水温度2")]
        public LA tgrj2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水流量1")]
        public LA dgrj1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("过热减温水流量2")]
        public LA dgrj2 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("小机进汽流量")]
        public LA dst = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("排汽压力")]
        public LA pp = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1抽汽压力")]
        public LA heater1_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1抽汽温度")]
        public LA heater1_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1进汽压力")]
        public LA heater1_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1进汽温度")]
        public LA heater1_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1进水压力")]
        public LA heater1_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1进水温度")]
        public LA heater1_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1出水压力")]
        public LA heater1_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1出水温度")]
        public LA heater1_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1进水流量")]
        public LA heater1_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1出水流量")]
        public LA heater1_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1疏水温度")]
        public LA heater1_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1加热器类型")]
        public LA heater1_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1其他流量")]
        public LA heater1_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1其他流量的焓值")]
        public LA heater1_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1是否再热")]
        public LD heater1_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器1是否是最后一级抽汽")]
        public LD heater1_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2抽汽压力")]
        public LA heater2_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2抽汽温度")]
        public LA heater2_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2进汽压力")]
        public LA heater2_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2进汽温度")]
        public LA heater2_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2进水压力")]
        public LA heater2_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2进水温度")]
        public LA heater2_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2出水压力")]
        public LA heater2_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2出水温度")]
        public LA heater2_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2进水流量")]
        public LA heater2_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2出水流量")]
        public LA heater2_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2疏水温度")]
        public LA heater2_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2加热器类型")]
        public LA heater2_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2其他流量")]
        public LA heater2_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2其他流量的焓值")]
        public LA heater2_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2是否再热")]
        public LD heater2_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器2是否是最后一级抽汽")]
        public LD heater2_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3抽汽压力")]
        public LA heater3_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3抽汽温度")]
        public LA heater3_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3进汽压力")]
        public LA heater3_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3进汽温度")]
        public LA heater3_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3进水压力")]
        public LA heater3_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3进水温度")]
        public LA heater3_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3出水压力")]
        public LA heater3_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3出水温度")]
        public LA heater3_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3进水流量")]
        public LA heater3_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3出水流量")]
        public LA heater3_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3疏水温度")]
        public LA heater3_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3加热器类型")]
        public LA heater3_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3其他流量")]
        public LA heater3_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3其他流量的焓值")]
        public LA heater3_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3是否再热")]
        public LD heater3_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器3是否是最后一级抽汽")]
        public LD heater3_i_last = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4抽汽压力")]
        public LA heater4_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4抽汽温度")]
        public LA heater4_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4进汽压力")]
        public LA heater4_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4进汽温度")]
        public LA heater4_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4进水压力")]
        public LA heater4_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4进水温度")]
        public LA heater4_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4出水压力")]
        public LA heater4_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4出水温度")]
        public LA heater4_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4进水流量")]
        public LA heater4_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4出水流量")]
        public LA heater4_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4疏水温度")]
        public LA heater4_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4加热器类型")]
        public LA heater4_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4其他流量")]
        public LA heater4_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4其他流量的焓值")]
        public LA heater4_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4是否再热")]
        public LD heater4_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器4是否是最后一级抽汽")]
        public LD heater4_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5抽汽压力")]
        public LA heater5_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5抽汽温度")]
        public LA heater5_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5进汽压力")]
        public LA heater5_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5进汽温度")]
        public LA heater5_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5进水压力")]
        public LA heater5_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5进水温度")]
        public LA heater5_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5出水压力")]
        public LA heater5_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5出水温度")]
        public LA heater5_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5进水流量")]
        public LA heater5_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5出水流量")]
        public LA heater5_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5疏水温度")]
        public LA heater5_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5加热器类型")]
        public LA heater5_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5其他流量")]
        public LA heater5_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5其他流量的焓值")]
        public LA heater5_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5是否再热")]
        public LD heater5_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器5是否是最后一级抽汽")]
        public LD heater5_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6抽汽压力")]
        public LA heater6_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6抽汽温度")]
        public LA heater6_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6进汽压力")]
        public LA heater6_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6进汽温度")]
        public LA heater6_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6进水压力")]
        public LA heater6_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6进水温度")]
        public LA heater6_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6出水压力")]
        public LA heater6_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6出水温度")]
        public LA heater6_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6进水流量")]
        public LA heater6_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6出水流量")]
        public LA heater6_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6疏水温度")]
        public LA heater6_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6加热器类型")]
        public LA heater6_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6其他流量")]
        public LA heater6_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6其他流量的焓值")]
        public LA heater6_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6是否再热")]
        public LD heater6_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器6是否是最后一级抽汽")]
        public LD heater6_i_last = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7抽汽压力")]
        public LA heater7_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7抽汽温度")]
        public LA heater7_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7进汽压力")]
        public LA heater7_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7进汽温度")]
        public LA heater7_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7进水压力")]
        public LA heater7_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7进水温度")]
        public LA heater7_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7出水压力")]
        public LA heater7_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7出水温度")]
        public LA heater7_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7进水流量")]
        public LA heater7_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7出水流量")]
        public LA heater7_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7疏水温度")]
        public LA heater7_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7加热器类型")]
        public LA heater7_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7其他流量")]
        public LA heater7_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7其他流量的焓值")]
        public LA heater7_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7是否再热")]
        public LD heater7_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器7是否是最后一级抽汽")]
        public LD heater7_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8抽汽压力")]
        public LA heater8_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8抽汽温度")]
        public LA heater8_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8进汽压力")]
        public LA heater8_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8进汽温度")]
        public LA heater8_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8进水压力")]
        public LA heater8_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8进水温度")]
        public LA heater8_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8出水压力")]
        public LA heater8_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8出水温度")]
        public LA heater8_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8进水流量")]
        public LA heater8_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8出水流量")]
        public LA heater8_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8疏水温度")]
        public LA heater8_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8加热器类型")]
        public LA heater8_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8其他流量")]
        public LA heater8_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8其他流量的焓值")]
        public LA heater8_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8是否再热")]
        public LD heater8_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器8是否是最后一级抽汽")]
        public LD heater8_i_last = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9抽汽压力")]
        public LA heater9_i_pc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9抽汽温度")]
        public LA heater9_i_tc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9进汽压力")]
        public LA heater9_i_pin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9进汽温度")]
        public LA heater9_i_tin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9进水压力")]
        public LA heater9_i_pwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9进水温度")]
        public LA heater9_i_twin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9出水压力")]
        public LA heater9_i_pwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9出水温度")]
        public LA heater9_i_twout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9进水流量")]
        public LA heater9_i_dwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9出水流量")]
        public LA heater9_i_dwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9疏水温度")]
        public LA heater9_i_tss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9加热器类型")]
        public LA heater9_i_type = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9其他流量")]
        public LA heater9_i_dother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9其他流量的焓值")]
        public LA heater9_i_hother = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9是否再热")]
        public LD heater9_i_reheater = new LD(QualityTypes.Good, false, false, false, 0, false);

        [PinType(PinTypes.Input)]
        [PinDisplay("加热器9是否是最后一级抽汽")]
        public LD heater9_i_last = new LD(QualityTypes.Good, false, false, false, 0, true);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA count1 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA d0 = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA e = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater1_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater2_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater3_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater4_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater5_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater6_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater7_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater8_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_dss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_dssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hcs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hd = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hss = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hwin = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_hwout = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_index = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_lower = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_sc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_tssn = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("")]
        public LA heater9_o_upper = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("排汽焓值")]
        public LA hp = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("排汽理想焓值")]
        public LA hps = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("高压缸效率")]
        public LA peH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("中压缸效率")]
        public LA peM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("低压缸效率")]
        public LA peL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("pwc")]
        public LA pwc = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("qsr")]
        public LA qsr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("time")]
        public LA time = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("高压缸排汽流量")]
        public LA qh = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("高压缸等熵焓降")]
        public LA hohH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("中压缸等熵焓降")]
        public LA hohM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("低压缸等熵焓降")]
        public LA hohL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("高压缸折算流量")]
        public LA qhsH = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("中压缸折算流量")]
        public LA qhsM = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("低压缸折算流量")]
        public LA qhsL = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);


        [PinType(PinTypes.Output)]
        [PinDisplay("主蒸汽焓值")]
        public LA hz = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f); 

        [PinType(PinTypes.Output)]
        [PinDisplay("给水焓值")]
        public LA hgs = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热焓值")]
        public LA hzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热冷段流量")]
        public LA dzrl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热冷段焓值")]
        public LA hzrl = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热流量")]
        public LA dzr = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

        [PinType(PinTypes.Output)]
        [PinDisplay("再热减温水焓值")]
        public LA dzrg = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

 
        public TurbinCalculator()
        {
            FcType = enumType.SC;
        }

        Queue<float> dgsSampleQueue = new Queue<float>();
        Queue<float> dgrSampleQueue = new Queue<float>();
        Queue<float> qsrSampleQueue = new Queue<float>();
        int qsrCacheCount = 300;


        protected override void Run(ICommand cmd)
        {

            float tmpdgs;
            float tmpdgr;

            if (ICCompareService.iCCompareResult?.HasSteadyState == true)
            {
                dgrSampleQueue.Enqueue(dgr.buffer);
                dgsSampleQueue.Enqueue(dgs.buffer);
                tmpdgs = dgsSampleQueue.Average();
                tmpdgr = dgrSampleQueue.Average();
            }
            else
            {
                tmpdgs = dgs.buffer;
                tmpdgr = dgr.buffer;
                dgsSampleQueue.Clear();
                dgrSampleQueue.Clear();
            }

            LA[] heaterpcs = { heater1_i_pc, heater2_i_pc, heater3_i_pc, heater4_i_pc, heater5_i_pc, heater6_i_pc, heater7_i_pc, heater8_i_pc, heater9_i_pc };
            float[] pcValues = new float[9];
            //for (int i = 0; i < heaterpcs.Length; i++)
            //{
            //    if (i == 7)
            //    {
            //        pcValues[i] = Math.Abs(heaterpcs[i].buffer) / 1000;
            //    }
            //    else
            //    {
            //        if (heaterpcs[i].buffer < 0)
            //        {
            //            pcValues[i] = Math.Abs(heaterpcs[i].buffer) / 1000;
            //        }
            //        else
            //        {
            //            pcValues[i] = heaterpcs[i].buffer;
            //        }
            //    }
            //}

            for (int i = 0; i < heaterpcs.Length; i++)
            {
                if (i >= heaterpcs.Length - 2)
                {
                    pcValues[i] = (atm + heaterpcs[i].buffer) / 1000;


                }
                else
                {
                    pcValues[i] = atm / 1000 + heaterpcs[i].buffer;
                }
            }

            LA[] heaterpins = { heater1_i_pin, heater2_i_pin, heater3_i_pin, heater4_i_pin, heater5_i_pin, heater6_i_pin, heater7_i_pin, heater8_i_pin, heater9_i_pin };
            float[] pinValues = new float[9];
            //for (int i = 0; i < heaterpins.Length; i++)
            //{
            //    if (i == 7)
            //    {
            //        pinValues[i] = Math.Abs(heaterpins[i].buffer) / 1000;
            //    }
            //    else
            //    {
            //        if (heaterpins[i].buffer < 0)
            //        {
            //            pinValues[i] = Math.Abs(heaterpins[i].buffer) / 1000;
            //        }
            //        else
            //        {
            //            pinValues[i] = heaterpcs[i].buffer;
            //        }
            //    }
            //}


            for (int i = 0; i < heaterpins.Length; i++)
            {
                if (i >= heaterpins.Length - 2)
                {
                    pinValues[i] = (atm + heaterpins[i].buffer) / 1000;


                }
                else
                {
                    pinValues[i] = atm / 1000 + heaterpins[i].buffer;
                }
            }

            string jstr = $"{{\"pw\":{pw},\"pgr\":{pgr},\"tgr\":{tgr},\"dgr\":{tmpdgr * 1000},\"pgs\":{pgs},\"tgs\":{tgs},\"dgs\":{tmpdgs * 1000},\"pzr\":[{pzr}],\"tzr\":[{tzr}]," +
                $"\"pzrj\":[{pzrj}],\"tzrj\":[{tzrj}],\"dzrj\":[{dzrj * 1000}],\"pgrj\":[{pgrj1},{pgrj2}],\"tgrj\":[{tgrj1},{tgrj2}],\"dgrj\":[{dgrj1 * 1000},{dgrj2 * 1000}],\"dst\":{dst * 1000},\"pp\":{pp / 1000.0},\"dch\":{ExcuteEngine.dch},\"dfq\":{ExcuteEngine.dfq}," +
                $"\"heaters\":[{{\"pc\":{pcValues[0]},\"tc\":{heater1_i_tc},\"pin\":{pinValues[0]},\"tin\":{heater1_i_tin},\"pwin\":{heater1_i_pwin},\"twin\":{heater1_i_twin}," +
                $"\"pwout\":{heater1_i_pwout},\"twout\":{heater1_i_twout},\"dwin\":{heater1_i_dwin * 1000},\"dwout\":{heater1_i_dwout * 1000},\"tss\":{heater1_i_tss},\"type\":{heater1_i_type}," +
                $"\"dother\":{heater1_i_dother * 1000},\"hother\":{heater1_i_hother},\"reheater\":{heater1_i_reheater.Value},\"last\":{heater1_i_last.Value}}}," +
                $"{{\"pc\":{pcValues[1]},\"tc\":{heater2_i_tc},\"pin\":{pinValues[1]},\"tin\":{heater2_i_tin},\"pwin\":{heater2_i_pwin},\"twin\":{heater2_i_twin}," +
                $"\"pwout\":{heater2_i_pwout},\"twout\":{heater2_i_twout},\"dwin\":{heater2_i_dwin * 1000},\"dwout\":{heater2_i_dwout * 1000},\"tss\":{heater2_i_tss},\"type\":{heater2_i_type}," +
                $"\"dother\":{heater2_i_dother * 1000},\"hother\":{heater2_i_hother},\"reheater\":{heater2_i_reheater.Value},\"last\":{heater2_i_last.Value}}}," +
                $"{{\"pc\":{pcValues[2]},\"tc\":{heater3_i_tc},\"pin\":{pinValues[2]},\"tin\":{heater3_i_tin},\"pwin\":{heater3_i_pwin},\"twin\":{heater3_i_twin},\"pwout\":{heater3_i_pwout}," +
                $"\"twout\":{heater3_i_twout},\"dwin\":{heater3_i_dwin * 1000},\"dwout\":{heater3_i_dwout * 1000},\"tss\":{heater3_i_tss},\"type\":{heater3_i_type},\"dother\":{heater3_i_dother * 1000},\"hother\":{heater3_i_hother}," +
                $"\"reheater\":{heater3_i_reheater.Value},\"last\":{heater3_i_last.Value}}},{{\"pc\":{pcValues[3]},\"tc\":{heater4_i_tc},\"pin\":{pinValues[3]},\"tin\":{heater4_i_tin},\"pwin\":{heater4_i_pwin}," +
                $"\"twin\":{heater4_i_twin},\"pwout\":{heater4_i_pwout},\"twout\":{heater4_i_twout},\"dwin\":{heater4_i_dwin * 1000},\"dwout\":{heater4_i_dwout * 1000},\"tss\":{heater4_i_tss},\"type\":{heater4_i_type}," +
                $"\"dother\":{heater4_i_dother * 1000},\"hother\":{heater4_i_hother},\"reheater\":{heater4_i_reheater.Value},\"last\":{heater4_i_last.Value}}}," +
                $"{{\"pc\":{pcValues[4]},\"tc\":{heater5_i_tc},\"pin\":{pinValues[4]},\"tin\":{heater5_i_tin},\"pwin\":{heater5_i_pwin},\"twin\":{heater5_i_twin},\"pwout\":{heater5_i_pwout}," +
                $"\"twout\":{heater5_i_twout},\"dwout\":{heater5_i_dwout * 1000},\"tss\":{heater5_i_tss},\"type\":{heater5_i_type},\"dother\":{heater5_i_dother * 1000},\"hother\":{heater5_i_hother}," +
                $"\"reheater\":{heater5_i_reheater.Value},\"last\":{heater5_i_last.Value}}},{{\"pc\":{pcValues[5]},\"tc\":{heater6_i_tc},\"pin\":{pinValues[5]},\"tin\":{heater6_i_tin},\"pwin\":{heater6_i_pwin}," +
                $"\"twin\":{heater6_i_twin},\"pwout\":{heater6_i_pwout},\"twout\":{heater6_i_twout},\"dwout\":{heater6_i_dwout * 1000},\"tss\":{heater6_i_tss},\"type\":{heater6_i_type}," +
                $"\"dother\":{heater6_i_dother * 1000},\"hother\":{heater6_i_hother},\"reheater\":{heater6_i_reheater.Value},\"last\":{heater6_i_last.Value}}},{{\"pc\":{pcValues[6]},\"tc\":{heater7_i_tc},\"pin\":{pinValues[6]}," +
                $"\"tin\":{heater7_i_tin},\"pwin\":{heater7_i_pwin},\"twin\":{heater7_i_twin},\"pwout\":{heater7_i_pwout},\"twout\":{heater7_i_twout},\"dwout\":{heater7_i_dwout * 1000}," +
                $"\"tss\":{heater7_i_tss},\"type\":{heater7_i_type},\"dother\":{heater7_i_dother * 1000},\"hother\":{heater7_i_hother},\"reheater\":{heater7_i_reheater.Value},\"last\":{heater7_i_last.Value}}}," +
                $"{{\"pc\":{pcValues[7]},\"tc\":{heater8_i_tc},\"pin\":{pinValues[7]},\"tin\":{heater8_i_tin},\"pwin\":{heater8_i_pwin},\"twin\":{heater8_i_twin},\"pwout\":{heater8_i_pwout}," +
                $"\"twout\":{heater8_i_twout},\"dwout\":{heater8_i_dwout * 1000},\"tss\":{heater8_i_tss},\"type\":{heater8_i_type},\"dother\":{heater8_i_dother * 1000},\"hother\":{heater8_i_hother}," +
                $"\"reheater\":{heater8_i_reheater.Value},\"last\":{heater8_i_last.Value}}},{{\"pc\":{pcValues[8]},\"tc\":{heater9_i_tc},\"hc\":2558.6,\"pin\":{pinValues[8]},\"tin\":{heater9_i_tin},\"pwin\":{heater9_i_pwin}," +
                $"\"twin\":{heater9_i_twin},\"pwout\":{heater9_i_pwout},\"twout\":{heater9_i_twout},\"dwout\":{heater9_i_dwout * 1000},\"tss\":{heater9_i_tss},\"type\":{heater9_i_type}," +
                $"\"dother\":{heater9_i_dother * 1000},\"hother\":{heater9_i_hother},\"reheater\":{heater9_i_reheater.Value},\"last\":{heater9_i_last.Value}}}]}}";

            jstr = jstr.Replace("False", "false").Replace("True", "true");

            ExcuteEngine.turbinJson = jstr;
            int calcStatus = 0;
            PerformanceCalc.TurbinData turbinData = PerformanceCalc.PCalc.calcTurbinValue(jstr, out calcStatus);
            CalcStatus = (enumCalcType)calcStatus;

            if (turbinData != null)
            {

                count1[0] = turbinData.count;
                d0[0] = turbinData.d0;
                e[0] = turbinData.e;

                heater1_o_dss[0] = turbinData.heaters[0].dss != null ? turbinData.heaters[0].dss : heater1_o_dss;
                heater1_o_dssn[0] = turbinData.heaters[0].dssn != null ? turbinData.heaters[0].dssn : heater1_o_dssn;
                heater1_o_hc[0] = turbinData.heaters[0].hc != null ? turbinData.heaters[0].hc : heater1_o_hc;
                heater1_o_hcs[0] = turbinData.heaters[0].hcs != null ? turbinData.heaters[0].hcs : heater1_o_hcs;
                heater1_o_hd[0] = turbinData.heaters[0].hd != null ? turbinData.heaters[0].hd : heater1_o_hd;
                heater1_o_hin[0] = turbinData.heaters[0].hin != null ? turbinData.heaters[0].hin : heater1_o_hin;
                heater1_o_hss[0] = turbinData.heaters[0].hss != null ? turbinData.heaters[0].hss : heater1_o_hss;
                heater1_o_hssn[0] = turbinData.heaters[0].hssn != null ? turbinData.heaters[0].hssn : heater1_o_hssn;
                heater1_o_hwin[0] = turbinData.heaters[0].hwin != null ? turbinData.heaters[0].hwin : heater1_o_hwin;
                heater1_o_hwout[0] = turbinData.heaters[0].hwout != null ? turbinData.heaters[0].hwout : heater1_o_hwout;
                heater1_o_index[0] = turbinData.heaters[0].index != null ? turbinData.heaters[0].index : heater1_o_index;
                heater1_o_lower[0] = turbinData.heaters[0].lower != null ? turbinData.heaters[0].lower : heater1_o_lower;
                heater1_o_sc[0] = turbinData.heaters[0].sc != null ? turbinData.heaters[0].sc : heater1_o_sc;
                heater1_o_tssn[0] = turbinData.heaters[0].tssn != null ? turbinData.heaters[0].tssn : heater1_o_tssn;
                heater1_o_upper[0] = turbinData.heaters[0].upper != null ? turbinData.heaters[0].upper : heater1_o_upper;

                heater2_o_dss[0] = turbinData.heaters[1].dss != null ? turbinData.heaters[1].dss : heater2_o_dss;
                heater2_o_dssn[0] = turbinData.heaters[1].dssn != null ? turbinData.heaters[1].dssn : heater2_o_dssn;
                heater2_o_hc[0] = turbinData.heaters[1].hc != null ? turbinData.heaters[1].hc : heater2_o_hc;
                heater2_o_hcs[0] = turbinData.heaters[1].hcs != null ? turbinData.heaters[1].hcs : heater2_o_hcs;
                heater2_o_hd[0] = turbinData.heaters[1].hd != null ? turbinData.heaters[1].hd : heater2_o_hd;
                heater2_o_hin[0] = turbinData.heaters[1].hin != null ? turbinData.heaters[1].hin : heater2_o_hin;
                heater2_o_hss[0] = turbinData.heaters[1].hss != null ? turbinData.heaters[1].hss : heater2_o_hss;
                heater2_o_hssn[0] = turbinData.heaters[1].hssn != null ? turbinData.heaters[1].hssn : heater2_o_hssn;
                heater2_o_hwin[0] = turbinData.heaters[1].hwin != null ? turbinData.heaters[1].hwin : heater2_o_hwin;
                heater2_o_hwout[0] = turbinData.heaters[1].hwout != null ? turbinData.heaters[1].hwout : heater2_o_hwout;
                heater2_o_index[0] = turbinData.heaters[1].index != null ? turbinData.heaters[1].index : heater2_o_index;
                heater2_o_lower[0] = turbinData.heaters[1].lower != null ? turbinData.heaters[1].lower : heater2_o_lower;
                heater2_o_sc[0] = turbinData.heaters[1].sc != null ? turbinData.heaters[1].sc : heater2_o_sc;
                heater2_o_tssn[0] = turbinData.heaters[1].tssn != null ? turbinData.heaters[1].tssn : heater2_o_tssn;
                heater2_o_upper[0] = turbinData.heaters[1].upper != null ? turbinData.heaters[1].upper : heater2_o_upper;

                heater3_o_dss[0] = turbinData.heaters[2].dss != null ? turbinData.heaters[2].dss : heater3_o_dss;
                heater3_o_dssn[0] = turbinData.heaters[2].dssn != null ? turbinData.heaters[2].dssn : heater3_o_dssn;
                heater3_o_hc[0] = turbinData.heaters[2].hc != null ? turbinData.heaters[2].hc : heater3_o_hc;
                heater3_o_hcs[0] = turbinData.heaters[2].hcs != null ? turbinData.heaters[2].hcs : heater3_o_hcs;
                heater3_o_hd[0] = turbinData.heaters[2].hd != null ? turbinData.heaters[2].hd : heater3_o_hd;
                heater3_o_hin[0] = turbinData.heaters[2].hin != null ? turbinData.heaters[2].hin : heater3_o_hin;
                heater3_o_hss[0] = turbinData.heaters[2].hss != null ? turbinData.heaters[2].hss : heater3_o_hss;
                heater3_o_hssn[0] = turbinData.heaters[2].hssn != null ? turbinData.heaters[2].hssn : heater3_o_hssn;
                heater3_o_hwin[0] = turbinData.heaters[2].hwin != null ? turbinData.heaters[2].hwin : heater3_o_hwin;
                heater3_o_hwout[0] = turbinData.heaters[2].hwout != null ? turbinData.heaters[2].hwout : heater3_o_hwout;
                heater3_o_index[0] = turbinData.heaters[2].index != null ? turbinData.heaters[2].index : heater3_o_index;
                heater3_o_lower[0] = turbinData.heaters[2].lower != null ? turbinData.heaters[2].lower : heater3_o_lower;
                heater3_o_sc[0] = turbinData.heaters[2].sc != null ? turbinData.heaters[2].sc : heater3_o_sc;
                heater3_o_tssn[0] = turbinData.heaters[2].tssn != null ? turbinData.heaters[2].tssn : heater3_o_tssn;
                heater3_o_upper[0] = turbinData.heaters[2].upper != null ? turbinData.heaters[2].upper : heater3_o_upper;

                heater4_o_dss[0] = turbinData.heaters[3].dss != null ? turbinData.heaters[3].dss : heater4_o_dss;
                heater4_o_dssn[0] = turbinData.heaters[3].dssn != null ? turbinData.heaters[3].dssn : heater4_o_dssn;
                heater4_o_hc[0] = turbinData.heaters[3].hc != null ? turbinData.heaters[3].hc : heater4_o_hc;
                heater4_o_hcs[0] = turbinData.heaters[3].hcs != null ? turbinData.heaters[3].hcs : heater4_o_hcs;
                heater4_o_hd[0] = turbinData.heaters[3].hd != null ? turbinData.heaters[3].hd : heater4_o_hd;
                heater4_o_hin[0] = turbinData.heaters[3].hin != null ? turbinData.heaters[3].hin : heater4_o_hin;
                heater4_o_hss[0] = turbinData.heaters[3].hss != null ? turbinData.heaters[3].hss : heater4_o_hss;
                heater4_o_hssn[0] = turbinData.heaters[3].hssn != null ? turbinData.heaters[3].hssn : heater4_o_hssn;
                heater4_o_hwin[0] = turbinData.heaters[3].hwin != null ? turbinData.heaters[3].hwin : heater4_o_hwin;
                heater4_o_hwout[0] = turbinData.heaters[3].hwout != null ? turbinData.heaters[3].hwout : heater4_o_hwout;
                heater4_o_index[0] = turbinData.heaters[3].index != null ? turbinData.heaters[3].index : heater4_o_index;
                heater4_o_lower[0] = turbinData.heaters[3].lower != null ? turbinData.heaters[3].lower : heater4_o_lower;
                heater4_o_sc[0] = turbinData.heaters[3].sc != null ? turbinData.heaters[3].sc : heater4_o_sc;
                heater4_o_tssn[0] = turbinData.heaters[3].tssn != null ? turbinData.heaters[3].tssn : heater4_o_tssn;
                heater4_o_upper[0] = turbinData.heaters[3].upper != null ? turbinData.heaters[3].upper : heater4_o_upper;

                heater5_o_dss[0] = turbinData.heaters[4].dss != null ? turbinData.heaters[4].dss : heater5_o_dss;
                heater5_o_dssn[0] = turbinData.heaters[4].dssn != null ? turbinData.heaters[4].dssn : heater5_o_dssn;
                heater5_o_hc[0] = turbinData.heaters[4].hc != null ? turbinData.heaters[4].hc : heater5_o_hc;
                heater5_o_hcs[0] = turbinData.heaters[4].hcs != null ? turbinData.heaters[4].hcs : heater5_o_hcs;
                heater5_o_hd[0] = turbinData.heaters[4].hd != null ? turbinData.heaters[4].hd : heater5_o_hd;
                heater5_o_hin[0] = turbinData.heaters[4].hin != null ? turbinData.heaters[4].hin : heater5_o_hin;
                heater5_o_hss[0] = turbinData.heaters[4].hss != null ? turbinData.heaters[4].hss : heater5_o_hss;
                heater5_o_hssn[0] = turbinData.heaters[4].hssn != null ? turbinData.heaters[4].hssn : heater5_o_hssn;
                heater5_o_hwin[0] = turbinData.heaters[4].hwin != null ? turbinData.heaters[4].hwin : heater5_o_hwin;
                heater5_o_hwout[0] = turbinData.heaters[4].hwout != null ? turbinData.heaters[4].hwout : heater5_o_hwout;
                heater5_o_index[0] = turbinData.heaters[4].index != null ? turbinData.heaters[4].index : heater5_o_index;
                heater5_o_lower[0] = turbinData.heaters[4].lower != null ? turbinData.heaters[4].lower : heater5_o_lower;
                heater5_o_sc[0] = turbinData.heaters[4].sc != null ? turbinData.heaters[4].sc : heater5_o_sc;
                heater5_o_tssn[0] = turbinData.heaters[4].tssn != null ? turbinData.heaters[4].tssn : heater5_o_tssn;
                heater5_o_upper[0] = turbinData.heaters[4].upper != null ? turbinData.heaters[4].upper : heater5_o_upper;

                heater6_o_dss[0] = turbinData.heaters[5].dss != null ? turbinData.heaters[5].dss : heater6_o_dss;
                heater6_o_dssn[0] = turbinData.heaters[5].dssn != null ? turbinData.heaters[5].dssn : heater6_o_dssn;
                heater6_o_hc[0] = turbinData.heaters[5].hc != null ? turbinData.heaters[5].hc : heater6_o_hc;
                heater6_o_hcs[0] = turbinData.heaters[5].hcs != null ? turbinData.heaters[5].hcs : heater6_o_hcs;
                heater6_o_hd[0] = turbinData.heaters[5].hd != null ? turbinData.heaters[5].hd : heater6_o_hd;
                heater6_o_hin[0] = turbinData.heaters[5].hin != null ? turbinData.heaters[5].hin : heater6_o_hin;
                heater6_o_hss[0] = turbinData.heaters[5].hss != null ? turbinData.heaters[5].hss : heater6_o_hss;
                heater6_o_hssn[0] = turbinData.heaters[5].hssn != null ? turbinData.heaters[5].hssn : heater6_o_hssn;
                heater6_o_hwin[0] = turbinData.heaters[5].hwin != null ? turbinData.heaters[5].hwin : heater6_o_hwin;
                heater6_o_hwout[0] = turbinData.heaters[5].hwout != null ? turbinData.heaters[5].hwout : heater6_o_hwout;
                heater6_o_index[0] = turbinData.heaters[5].index != null ? turbinData.heaters[5].index : heater6_o_index;
                heater6_o_lower[0] = turbinData.heaters[5].lower != null ? turbinData.heaters[5].lower : heater6_o_lower;
                heater6_o_sc[0] = turbinData.heaters[5].sc != null ? turbinData.heaters[5].sc : heater6_o_sc;
                heater6_o_tssn[0] = turbinData.heaters[5].tssn != null ? turbinData.heaters[5].tssn : heater6_o_tssn;
                heater6_o_upper[0] = turbinData.heaters[5].upper != null ? turbinData.heaters[5].upper : heater6_o_upper;

                heater7_o_dss[0] = turbinData.heaters[6].dss != null ? turbinData.heaters[6].dss : heater7_o_dss;
                heater7_o_dssn[0] = turbinData.heaters[6].dssn != null ? turbinData.heaters[6].dssn : heater7_o_dssn;
                heater7_o_hc[0] = turbinData.heaters[6].hc != null ? turbinData.heaters[6].hc : heater7_o_hc;
                heater7_o_hcs[0] = turbinData.heaters[6].hcs != null ? turbinData.heaters[6].hcs : heater7_o_hcs;
                heater7_o_hd[0] = turbinData.heaters[6].hd != null ? turbinData.heaters[6].hd : heater7_o_hd;
                heater7_o_hin[0] = turbinData.heaters[6].hin != null ? turbinData.heaters[6].hin : heater7_o_hin;
                heater7_o_hss[0] = turbinData.heaters[6].hss != null ? turbinData.heaters[6].hss : heater7_o_hss;
                heater7_o_hssn[0] = turbinData.heaters[6].hssn != null ? turbinData.heaters[6].hssn : heater7_o_hssn;
                heater7_o_hwin[0] = turbinData.heaters[6].hwin != null ? turbinData.heaters[6].hwin : heater7_o_hwin;
                heater7_o_hwout[0] = turbinData.heaters[6].hwout != null ? turbinData.heaters[6].hwout : heater7_o_hwout;
                heater7_o_index[0] = turbinData.heaters[6].index != null ? turbinData.heaters[6].index : heater7_o_index;
                heater7_o_lower[0] = turbinData.heaters[6].lower != null ? turbinData.heaters[6].lower : heater7_o_lower;
                heater7_o_sc[0] = turbinData.heaters[6].sc != null ? turbinData.heaters[6].sc : heater7_o_sc;
                heater7_o_tssn[0] = turbinData.heaters[6].tssn != null ? turbinData.heaters[6].tssn : heater7_o_tssn;
                heater7_o_upper[0] = turbinData.heaters[6].upper != null ? turbinData.heaters[6].upper : heater7_o_upper;


                heater8_o_dss[0] = turbinData.heaters[7].dss != null ? turbinData.heaters[7].dss : heater8_o_dss;
                heater8_o_dssn[0] = turbinData.heaters[7].dssn != null ? turbinData.heaters[7].dssn : heater8_o_dssn;
                heater8_o_hc[0] = turbinData.heaters[7].hc != null ? turbinData.heaters[7].hc : heater8_o_hc;
                heater8_o_hcs[0] = turbinData.heaters[7].hcs != null ? turbinData.heaters[7].hcs : heater8_o_hcs;
                heater8_o_hd[0] = turbinData.heaters[7].hd != null ? turbinData.heaters[7].hd : heater8_o_hd;
                heater8_o_hin[0] = turbinData.heaters[7].hin != null ? turbinData.heaters[7].hin : heater8_o_hin;
                heater8_o_hss[0] = turbinData.heaters[7].hss != null ? turbinData.heaters[7].hss : heater8_o_hss;
                heater8_o_hssn[0] = turbinData.heaters[7].hssn != null ? turbinData.heaters[7].hssn : heater8_o_hssn;
                heater8_o_hwin[0] = turbinData.heaters[7].hwin != null ? turbinData.heaters[7].hwin : heater8_o_hwin;
                heater8_o_hwout[0] = turbinData.heaters[7].hwout != null ? turbinData.heaters[7].hwout : heater8_o_hwout;
                heater8_o_index[0] = turbinData.heaters[7].index != null ? turbinData.heaters[7].index : heater8_o_index;
                heater8_o_lower[0] = turbinData.heaters[7].lower != null ? turbinData.heaters[7].lower : heater8_o_lower;
                heater8_o_sc[0] = turbinData.heaters[7].sc != null ? turbinData.heaters[7].sc : heater8_o_sc;
                heater8_o_tssn[0] = turbinData.heaters[7].tssn != null ? turbinData.heaters[7].tssn : heater8_o_tssn;
                heater8_o_upper[0] = turbinData.heaters[7].upper != null ? turbinData.heaters[7].upper : heater8_o_upper;

                heater9_o_dss[0] = turbinData.heaters[8].dss != null ? turbinData.heaters[8].dss : heater9_o_dss;
                heater9_o_dssn[0] = turbinData.heaters[8].dssn != null ? turbinData.heaters[8].dssn : heater9_o_dssn;
                heater9_o_hc[0] = turbinData.heaters[8].hc != null ? turbinData.heaters[8].hc : heater9_o_hc;
                heater9_o_hcs[0] = turbinData.heaters[8].hcs != null ? turbinData.heaters[8].hcs : heater9_o_hcs;
                heater9_o_hd[0] = turbinData.heaters[8].hd != null ? turbinData.heaters[8].hd : heater9_o_hd;
                heater9_o_hin[0] = turbinData.heaters[8].hin != null ? turbinData.heaters[8].hin : heater9_o_hin;
                heater9_o_hss[0] = turbinData.heaters[8].hss != null ? turbinData.heaters[8].hss : heater9_o_hss;
                heater9_o_hssn[0] = turbinData.heaters[8].hssn != null ? turbinData.heaters[8].hssn : heater9_o_hssn;
                heater9_o_hwin[0] = turbinData.heaters[8].hwin != null ? turbinData.heaters[8].hwin : heater9_o_hwin;
                heater9_o_hwout[0] = turbinData.heaters[8].hwout != null ? turbinData.heaters[8].hwout : heater9_o_hwout;
                heater9_o_index[0] = turbinData.heaters[8].index != null ? turbinData.heaters[8].index : heater9_o_index;
                heater9_o_lower[0] = turbinData.heaters[8].lower != null ? turbinData.heaters[8].lower : heater9_o_lower;
                heater9_o_sc[0] = turbinData.heaters[8].sc != null ? turbinData.heaters[8].sc : heater9_o_sc;
                heater9_o_tssn[0] = turbinData.heaters[8].tssn != null ? turbinData.heaters[8].tssn : heater9_o_tssn;
                heater9_o_upper[0] = turbinData.heaters[8].upper != null ? turbinData.heaters[8].upper : heater9_o_upper;

                hp[0] = turbinData.hp;
                hps[0] = turbinData.hps;
                peH[0] = turbinData.pe[0];
                peM[0] = turbinData.pe[1];
                peL[0] = turbinData.pe[2];
                pwc[0] = turbinData.pwc;
                qsr[0] = turbinData.qsr;
                time[0] = turbinData.time;

                qh[0] = turbinData.qh;
                hohH[0] = turbinData.hoh[0];
                hohM[0] = turbinData.hoh[1];
                hohL[0] = turbinData.hoh[2];

                qhsH[0] = turbinData.qhs[0];
                qhsM[0] = turbinData.qhs[1];
                qhsL[0] = turbinData.qhs[2];

                hz[0] = turbinData.hz;
                hgs[0] = turbinData.hgs;
                hzr[0] = turbinData.hzr;
                dzrl[0] = turbinData.dzrl;
                hzrl[0] = turbinData.hzrl;
                dzr[0] = turbinData.dzr;
                dzrg[0] = turbinData.dzrg;


                //if (ICCompareService.iCCompareResult?.HasSteadyState == true)
                //{
                //    PCalc.WriterLog($"给水流量:{tmpdgs};汽机热耗:{qsr};负荷:{pw};汽机输入:{jstr};");
                //}

                InputModel inputModel = new InputModel()
                {
                    Pin = ((double)ExcuteEngine.GetLAValue("dcs_MSP")),//主汽压力
                    Tin = ((double)ExcuteEngine.GetLAValue("dcs_MST")),//主汽温度
                    Pwout = ((double)ExcuteEngine.GetLAValue("dcs_LBQ20CP101")),//高排压力
                    Twout = ((double)ExcuteEngine.GetLAValue("dcs_LBQ20CT601")),//高排温度
                    T = "h"
                };

                peH[0] = Math.Round(PCalc.calcComputepeH(inputModel), 4);


                inputModel = new InputModel()
                {
                    Pin = ((double)ExcuteEngine.GetLAValue("dcs_RHPRES")),//再热压力
                    Tin = ((double)ExcuteEngine.GetLAValue("dcs_RHTE")),//再热温度
                    Pwout = ((double)ExcuteEngine.GetLAValue("dcs_LBS50CP101")),//中压缸排气
                    Twout = ((double)ExcuteEngine.GetLAValue("dcs_LBS50CT601")),//中排温度
                    T = "m"
                };

                peM[0] = Math.Round(PCalc.calcComputepeH(inputModel), 4);


                inputModel = new InputModel()
                {
                    Pin = ((double)ExcuteEngine.GetLAValue("dcs_LBS50CP101")),//中压缸排气
                    Tin = ((double)ExcuteEngine.GetLAValue("dcs_LBS50CT601")),//中排温度
                    Pwout = ((double)ExcuteEngine.GetLAValue("dcs_pan00cp101") + (double)ExcuteEngine.GetLAValue("dcs_lcc80cp108")) / 1000,//(大气压力+低压缸抽气)/1000
                    Twout = ((double)ExcuteEngine.GetLAValue("dcs_lcc80ct608")),//低排温度 
                    T = "l"
                };

                peL[0] = Math.Round(PCalc.calcComputepeH(inputModel), 4);


            }
            else
            {
                count1[0] = 0;
                d0[0] = 0;
                e[0] = 0;

                heater1_o_dss[0] = 0;
                heater1_o_dssn[0] = 0;
                heater1_o_hc[0] = 0;
                heater1_o_hcs[0] = 0;
                heater1_o_hd[0] = 0;
                heater1_o_hin[0] = 0;
                heater1_o_hss[0] = 0;
                heater1_o_hssn[0] = 0;
                heater1_o_hwin[0] = 0;
                heater1_o_hwout[0] = 0;
                heater1_o_index[0] = 0;
                heater1_o_lower[0] = 0;
                heater1_o_sc[0] = 0;
                heater1_o_tssn[0] = 0;
                heater1_o_upper[0] = 0;

                heater2_o_dss[0] = 0;
                heater2_o_dssn[0] = 0;
                heater2_o_hc[0] = 0;
                heater2_o_hcs[0] = 0;
                heater2_o_hd[0] = 0;
                heater2_o_hin[0] = 0;
                heater2_o_hss[0] = 0;
                heater2_o_hssn[0] = 0;
                heater2_o_hwin[0] = 0;
                heater2_o_hwout[0] = 0;
                heater2_o_index[0] = 0;
                heater2_o_lower[0] = 0;
                heater2_o_sc[0] = 0;
                heater2_o_tssn[0] = 0;
                heater2_o_upper[0] = 0;

                heater3_o_dss[0] = 0;
                heater3_o_dssn[0] = 0;
                heater3_o_hc[0] = 0;
                heater3_o_hcs[0] = 0;
                heater3_o_hd[0] = 0;
                heater3_o_hin[0] = 0;
                heater3_o_hss[0] = 0;
                heater3_o_hssn[0] = 0;
                heater3_o_hwin[0] = 0;
                heater3_o_hwout[0] = 0;
                heater3_o_index[0] = 0;
                heater3_o_lower[0] = 0;
                heater3_o_sc[0] = 0;
                heater3_o_tssn[0] = 0;
                heater3_o_upper[0] = 0;

                heater4_o_dss[0] = 0;
                heater4_o_dssn[0] = 0;
                heater4_o_hc[0] = 0;
                heater4_o_hcs[0] = 0;
                heater4_o_hd[0] = 0;
                heater4_o_hin[0] = 0;
                heater4_o_hss[0] = 0;
                heater4_o_hssn[0] = 0;
                heater4_o_hwin[0] = 0;
                heater4_o_hwout[0] = 0;
                heater4_o_index[0] = 0;
                heater4_o_lower[0] = 0;
                heater4_o_sc[0] = 0;
                heater4_o_tssn[0] = 0;
                heater4_o_upper[0] = 0;

                heater5_o_dss[0] = 0;
                heater5_o_dssn[0] = 0;
                heater5_o_hc[0] = 0;
                heater5_o_hcs[0] = 0;
                heater5_o_hd[0] = 0;
                heater5_o_hin[0] = 0;
                heater5_o_hss[0] = 0;
                heater5_o_hssn[0] = 0;
                heater5_o_hwin[0] = 0;
                heater5_o_hwout[0] = 0;
                heater5_o_index[0] = 0;
                heater5_o_lower[0] = 0;
                heater5_o_sc[0] = 0;
                heater5_o_tssn[0] = 0;
                heater5_o_upper[0] = 0;

                heater6_o_dss[0] = 0;
                heater6_o_dssn[0] = 0;
                heater6_o_hc[0] = 0;
                heater6_o_hcs[0] = 0;
                heater6_o_hd[0] = 0;
                heater6_o_hin[0] = 0;
                heater6_o_hss[0] = 0;
                heater6_o_hssn[0] = 0;
                heater6_o_hwin[0] = 0;
                heater6_o_hwout[0] = 0;
                heater6_o_index[0] = 0;
                heater6_o_lower[0] = 0;
                heater6_o_sc[0] = 0;
                heater6_o_tssn[0] = 0;
                heater6_o_upper[0] = 0;

                heater7_o_dss[0] = 0;
                heater7_o_dssn[0] = 0;
                heater7_o_hc[0] = 0;
                heater7_o_hcs[0] = 0;
                heater7_o_hd[0] = 0;
                heater7_o_hin[0] = 0;
                heater7_o_hss[0] = 0;
                heater7_o_hssn[0] = 0;
                heater7_o_hwin[0] = 0;
                heater7_o_hwout[0] = 0;
                heater7_o_index[0] = 0;
                heater7_o_lower[0] = 0;
                heater7_o_sc[0] = 0;
                heater7_o_tssn[0] = 0;
                heater7_o_upper[0] = 0;


                heater8_o_dss[0] = 0;
                heater8_o_dssn[0] = 0;
                heater8_o_hc[0] = 0;
                heater8_o_hcs[0] = 0;
                heater8_o_hd[0] = 0;
                heater8_o_hin[0] = 0;
                heater8_o_hss[0] = 0;
                heater8_o_hssn[0] = 0;
                heater8_o_hwin[0] = 0;
                heater8_o_hwout[0] = 0;
                heater8_o_index[0] = 0;
                heater8_o_lower[0] = 0;
                heater8_o_sc[0] = 0;
                heater8_o_tssn[0] = 0;
                heater8_o_upper[0] = 0;

                heater9_o_dss[0] = 0;
                heater9_o_dssn[0] = 0;
                heater9_o_hc[0] = 0;
                heater9_o_hcs[0] = 0;
                heater9_o_hd[0] = 0;
                heater9_o_hin[0] = 0;
                heater9_o_hss[0] = 0;
                heater9_o_hssn[0] = 0;
                heater9_o_hwin[0] = 0;
                heater9_o_hwout[0] = 0;
                heater9_o_index[0] = 0;
                heater9_o_lower[0] = 0;
                heater9_o_sc[0] = 0;
                heater9_o_tssn[0] = 0;
                heater9_o_upper[0] = 0;

                hp[0] = 0;
                hps[0] = 0;
                peH[0] = 0;
                peM[0] = 0;
                peL[0] = 0;
                pwc[0] = 0;
                qsr[0] = 0;
                time[0] = 0;

                qh[0] = 0;
                hohH[0] = 0;
                hohM[0] = 0;
                hohL[0] = 0;

                qhsH[0] = 0;
                qhsM[0] = 0;
                qhsL[0] = 0;

                hz[0] = 0;
                hgs[0] = 0;
                hzr[0] = 0;
                dzrl[0] = 0;
                hzrl[0] = 0;
                dzr[0] = 0;
                dzrg[0] = 0;
            }

            if (pw < 100)
            {
                qsr[0] = 0;
            }
            else
            {
                if (qsr > 1000)
                {
                    qsrSampleQueue.Enqueue(qsr.buffer);
                    if (qsrSampleQueue.Count >= qsrCacheCount)
                    {
                        qsrSampleQueue.Dequeue();
                    }
                }
                if (ICCompareService.iCCompareResult?.HasSteadyState == false)
                {
                    qsr[0] = qsrSampleQueue.Average();
                }
            }
        }
    }
}
