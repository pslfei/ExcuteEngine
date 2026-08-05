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
using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace DCSCommon
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Block)]
    [FCName("AbstractFunction")]
    [FCDisplay("功能码的抽象模型")]
    public abstract class HealthFunction : Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("正常限制")]
        public float NormalValue1;

        [PinType(PinTypes.Constant)]
        [PinDisplay("报警限制")]
        public float AlarmValue1;

        [PinType(PinTypes.Constant)]
        [PinDisplay("跳闸限制")]
        public float TripValue1;

        [PinType(PinTypes.Constant)]
        [PinDisplay("正常限制")]
        public float NormalValue2;

        [PinType(PinTypes.Constant)]
        [PinDisplay("报警限制")]
        public float AlarmValue2;

        [PinType(PinTypes.Constant)]
        [PinDisplay("跳闸限制")]
        public float TripValue2;

        [PinType(PinTypes.Constant)]
        [PinDisplay("计算方式")]
        public int Mode;

        [PinType(PinTypes.Constant)]
        [PinDisplay("系统ID")]
        public int SystemID;

        [PinType(PinTypes.Constant)]
        [PinDisplay("设备ID")]
        public int DeviceID;

        [PinType(PinTypes.Constant)]
        [PinDisplay("输入选取数")]
        public int SelNum;

        [PinType(PinTypes.Constant)]
        [PinDisplay("设备运行条件")]
        public string DeviceRunCondition = "";
        public List<object> outList2 = new List<object>();
        public List<float> outList = new List<float>();
    }
}
