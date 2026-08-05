/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LD.cs
// 文件功能描述：LD——点类型之一
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
using System.Runtime.CompilerServices;
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LD : IValuable, IPointOperation,IValueSetter
    {
        /// <summary>
        /// 当前是否运行
        /// </summary>
        private bool runable = true;
        public bool Runable { get => runable; set => runable = value; }

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
        private bool forcevalue;
        /// <summary>
        /// 设置或获得强制值
        /// </summary>
        public bool ForceValue
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

        /// <summary>
        /// 数值
        /// </summary>
        public bool buffer;

        #endregion

        public LD(QualityTypes Quality, bool IsTrace,bool alarm,bool ForceValue,byte IsForced, bool Value)
        {
            this.quality = Quality;
            this.istrace = IsTrace;
            this.isalarm = alarm;
            this.forcevalue = ForceValue;
            this.isforced = IsForced;
            this.buffer = Value;
            
            this.isConnected = false;
        }


        public object Value
        {
            get
            {
                return this.buffer;
            }
            set
            {
                if (value is bool)
                    this.buffer = (bool)value;
                else if (value is DCSType.LD)
                {
                    this.buffer = ((DCSType.LD)value).buffer;
                }
                else
                    this.buffer = ((IConvertible)(value)).ToBoolean(null);
            }
        }

        public object this[int i]
        {
            get
            {
                return this.Value;
            }
            set
            {
                //强制作用
                if (this.isforced != 0)
                    this.buffer = this.forcevalue;
                else
                {
                    //if (value is bool)
                    //    this.buffer = (bool)value;
                    //else
                    //    this.buffer = ((IConvertible)(value)).ToBoolean(null);

                    if (value is IValuable)
                        this.Value = ((IValuable)value).Value;
                    else
                        this.Value = value;
                }
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
                    if (value is bool)
                        this.ForceValue = (bool)value;
                    else
                        this.ForceValue = ((IConvertible)value).ToBoolean(null);
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

        #endregion


        #region 运算符重载

        public static bool operator &(LD A, LD B)
        {
            return A.buffer & B.buffer;
        }

        public static bool operator &(bool A, LD B)
        {
            return A & B.buffer;
        }

        public static bool operator &(LD A, bool B)
        {
            return A.buffer & B;
        }


        public static bool operator |(LD A, LD B)
        {
            return A.buffer | B.buffer;
        }

        public static bool operator |(bool A, LD B)
        {
            return A | B.buffer;
        }

        public static bool operator |(LD A, bool B)
        {
            return A.buffer | B;
        }


        public static bool operator ^(LD A, LD B)
        {
            return A.buffer ^ B.buffer;
        }

        public static bool operator ^(bool A, LD B)
        {
            return A ^ B.buffer;
        }

        public static bool operator ^(LD A, bool B)
        {
            return A.buffer ^ B;
        }


        public static bool operator ==(LD A, bool B)
        {
            return A.buffer == B;
        }

        public static bool operator !=(LD A, bool B)
        {
            return A.buffer != B;
        }


        public static implicit operator bool(LD A)
        {
            return A.buffer;
        }

        #endregion

        public override string ToString()
        {
            return this.Value.ToString();
        }

        public void SetValue(object value)
        {
            buffer = Convert.ToBoolean(value);
        }
    }
}
