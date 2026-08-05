using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
    public partial class HSSCS : Function
    {
        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool M1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M8;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //private bool M9;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MA;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MB;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MC;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MD;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool ME;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MG;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MH;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MI;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MJ;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MK;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool ML;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MM;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MN;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MO;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MP;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("运算中间变量")]
        //public bool MQ;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器复位端")]
        //public bool R8;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器置位端")]
        //public bool S8;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("RS触发器输出端")]
        //public bool Q8;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输入端")]
        //public bool I7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器输出端")]
        //public bool O7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U2;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U3;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U4;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U5;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U6;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("定时器计数单元")]
        //public int U7;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("状态反馈错误")]
        //public bool SE;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("命令阻塞")]
        //public bool CJ;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("开运行超时")]
        //public bool OT;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("关运行超时")]
        //public bool CT;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("状态偏差开到关")]
        //public bool OC;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("状态偏差关到开 ")]
        //public bool CO;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备关保护触发")]
        //public bool CP;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("开指示灯箭头闪烁")]
        //public bool OA;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("开指示灯常亮")]
        //public bool OL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("开指示灯闪烁")]
        //public bool OK;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("关指示灯箭头闪烁")]
        //public bool CA;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("关指示灯常亮")]
        //public bool CL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("关指示灯闪烁")]
        //public bool CF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("报警指示灯常亮")]
        //public bool AL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("报警指示灯闪烁")]
        //public bool AF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示黄色常亮")]
        //public bool YL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示黄色闪烁")]
        //public bool YF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示绿色常亮")]
        //public bool GL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示绿色闪烁")]
        //public bool GF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示红色常亮")]
        //public bool RL;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("设备指示红色闪烁")]
        //public bool RF;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private bool preOpen;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private bool preClose;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private bool preStop;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private float SampleTime;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private bool DV0To1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("")]
        //private bool RV0To1;

        //[PinType(PinTypes.Internal)]
        //[PinDisplay("为逻辑控制量LC0-LC8的直接赋值")]
        //[MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 9)]
        //public bool[] LC = new bool[9];
    }
}