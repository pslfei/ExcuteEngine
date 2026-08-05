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
using System.Runtime.InteropServices;

namespace DCSCommon
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Block)]
    [FCName("AbstractFunction")]
    [FCDisplay("功能码的抽象模型")]
    public abstract class WarnFunction : Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("报警状态")]
        public bool WarnActive;

        [PinType(PinTypes.Constant)]
        [PinDisplay("确认")]
        public bool UnAck;

        [PinType(PinTypes.Constant)]
        [PinDisplay("确认")]
        public byte WarnState = 1;

        [PinType(PinTypes.Constant)]
        [PinDisplay("模型ID")]
        public int ModelID = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("系统ID")]
        public int SysID = 0;

        [PinType(PinTypes.Constant)]
        [PinDisplay("异常")]
        public bool Exception;
    }
}
