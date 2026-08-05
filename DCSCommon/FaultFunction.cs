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
    public abstract class FaultFunction :Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块的名字")]
        public int FaultCode = 0;

       
    }

  
}
