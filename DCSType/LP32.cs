/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LP.cs
// 文件功能描述：LP——点类型之一
// 
//
// 创建标识：赵明明200904
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
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    public struct LP32 : IValuable, IPointOperation
    {
        #region Fields

        /// <summary>
        /// 信号质量
        /// </summary>
        private QualityTypes quality;
        /// <summary>
        /// 设置或获得信号质量
        /// </summary>
        public QualityTypes Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        /// <summary>
        /// 是否跟踪
        /// </summary>
        private bool istrace;
        /// <summary>
        /// 设置或获得是否跟踪
        /// </summary>
        public bool IsTrace
        {
            get { return istrace; }
            set { istrace = value; }
        }

        /// <summary>
        /// 是否正处于Alarm状态
        /// </summary>
        private bool isalarm;
        /// <summary>
        /// 设置或获得是否正处于Alarm状态
        /// </summary>
        public bool IsAlarm
        {
            get { return isalarm; }
            set { isalarm = value; }
        }

        /// <summary>
        /// 是否处于信号线连接状态
        /// </summary>
        private bool isConnected;
        /// <summary>
        /// 读取是否连线
        /// </summary>
        public bool Connected
        {
            get
            {
                return isConnected;
            }
            set
            {
                isConnected = value;
            }
        }

        /// <summary>
        /// 强制值
        /// </summary>
        private uint forcevalue;
        /// <summary>
        /// 设置或获得强制值
        /// </summary>
        public uint ForceValue
        {
            get { return forcevalue; }
            set
            {
                if (this.isforced != 0)
                    this.buffer = value;
                forcevalue = value;
            }
        }


        /// <summary>
        /// 是否强制
        /// </summary>
        private byte isforced;
        /// <summary>
        /// 设置或获得是否强制
        /// </summary>
        public byte IsForced
        {
            get { return isforced; }
            set
            {
                isforced = value;
                if (isforced != 0)
                    this.buffer = this.forcevalue;
            }
        }

        private string dataReceiveTime;
        public string DataReceiveTime { get => dataReceiveTime; set => dataReceiveTime = value; }

        /// <summary>
        /// 数值
        /// </summary>
        public uint buffer;

        public LP32()
        {
            quality = QualityTypes.Good;
            istrace = false;
            isalarm = false;
            isConnected = false;
            isforced = 0;
            forcevalue= 0;
            buffer = 0;
            dataReceiveTime = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        #endregion

        public object this[int i]
        {
            get
            {
                if (i < 0 || i > 32)
                    return this.buffer;
                uint temp = (uint)(1 << i);
                temp = (uint)(this.buffer & temp);
                temp >>= i;
                return temp;
            }
            set
            {
                uint val;
                if (value is uint)
                    val = (uint)value;
                else
                    val = ((IConvertible)(value)).ToUInt32(null);
                if (i < 0 || i > 32 || val > 1)
                    return;
                uint temp = (uint)(1 << i);
                if (val == 0)
                {
                    temp = (uint)(~temp);
                    this.buffer = (uint)(this.buffer & temp);
                }
                else
                    this.buffer = (uint)(this.buffer | temp);
            }
        }

        public object Value
        {
            get
            {
                return this.buffer;
            }
            set
            {
                if (value is uint)
                    this.buffer = (uint)value;
                else
                    this.buffer = ((IConvertible)(value)).ToUInt32(null);
            }
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "buffer":
                    this.Value = value;
                    break;
                case "isforced":
                    this.IsForced = (byte)value;
                    break;
                case "forcevalue":
                    if (value is uint)
                        this.ForceValue = (uint)value;
                    else
                        this.ForceValue = ((IConvertible)value).ToUInt32(null);
                    break;
                case "isconnected":
                    this.Connected = (bool)value;
                    break;
                case "quality":
                    this.Quality = (QualityTypes)value;
                    break;
                case "isalarm":
                    this.IsAlarm = (bool)value;
                    break;
                case "istrace":
                    this.IsTrace = (bool)value;
                    break;
            }
        }

        public object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "buffer":
                    return this.Value;
                case "isforced":
                    return this.IsForced;
                case "forcevalue":
                    return this.ForceValue;
                case "isconnected":
                    return this.Connected;
                case "quality":
                    return this.Quality;
                case "isalarm":
                    return this.IsAlarm;
                case "istrace":
                    return this.IsTrace;
                default:
                    return null;
            }
        }

        public static implicit operator LP32(int v)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
