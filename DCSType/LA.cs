/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LA.cs
// 文件功能描述：LA——点类型之一
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
using System.Reflection;
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class LA : IValuable, IPointOperation,IValueSetter
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
        /// 强制值
        /// </summary>
        private float forcevalue;
        /// <summary>
        /// 设置或获得强制值
        /// </summary>
        public float ForceValue
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
        /// 是否达到最大值
        /// </summary>
        private bool maxreached;
        /// <summary>
        /// 设置或获得是否达到最大值
        /// </summary>
        public bool MaxReached
        {
            get { return maxreached; }
            set { maxreached = value; }
        }

        /// <summary>
        /// 是否达到最小值
        /// </summary>
        private bool minreached;
        /// <summary>
        /// 设置或获得是否达到最小值
        /// </summary>
        public bool MinReached
        {
            get { return minreached; }
            set { minreached = value; }
        }

        /// <summary>
        /// 是否正处于HighAlarm状态
        /// </summary>
        private bool ishighalarm;
        /// <summary>
        /// 设置或获得是否正处于HighAlarm状态
        /// </summary>
        public bool IsHighalarm
        {
            get { return ishighalarm; }
            set 
            {
                if (value)
                    this.IsAlarm = true;
                ishighalarm = value; 
            }
        }

        /// <summary>
        /// 是否正处于LowAlarm状态
        /// </summary>
        private bool islowalarm;
        /// <summary>
        /// 设置或获得是否正处于LowAlarm状态
        /// </summary>
        public bool IsLowalarm
        {
            get { return islowalarm; }
            set 
            {
                if (value)
                    this.IsAlarm = true;
                islowalarm = value; 
            }
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
        /// 最大值
        /// </summary>
        private float maxvalue;
        /// <summary>
        /// 设置或获得最大值
        /// </summary>
        public float MaxValue
        {
            get { return maxvalue; }
            set { maxvalue = value; }
        }

        /// <summary>
        /// 最小值
        /// </summary>
        private float minvalue;
        /// <summary>
        /// 设置或获得最小值
        /// </summary>
        public float MinValue
        {
            get { return minvalue; }
            set { minvalue = value; }
        }

        /// <summary>
        /// 数值
        /// </summary>
        public float buffer;
        /// <summary>
        /// 设置或获得数值
        /// </summary>
        public object Value
        {
            get
            {
                return buffer;
            }
            set
            {
                //强制作用
                if (this.isforced != 0)
                    this.buffer = this.forcevalue;
                else
                {
                    if (value is float)
                        this.buffer = (float)value;
                    else
                        this.buffer = ((IConvertible)value).ToSingle(null);
                }

                //报警作用
                if (this.buffer > this.maxvalue)
                {
                    this.maxreached = true;
                    this.ishighalarm = true;
                }
                else if (this.buffer == this.maxvalue)
                {
                    this.maxreached = true;
                    this.ishighalarm = false;
                }
                else
                {
                    this.maxreached = false;
                    this.ishighalarm = false;
                }

                if (this.buffer < this.minvalue)
                {
                    this.minreached = true;
                    this.islowalarm = true;
                }
                else if (this.buffer == this.minvalue)
                {
                    this.minreached = true;
                    this.islowalarm = false;
                }
                else
                {
                    this.minreached = false;
                    this.islowalarm = false;
                }

                this.isalarm = this.ishighalarm | this.islowalarm;
            }
        }


        #endregion

        #region Self Functions

        public LA(QualityTypes Quality, bool IsTrace, bool MaxReached,
            bool MinReached, bool IsHighalarm, bool IsLowalarm,
            float MaxValue, float MinValue, float ForceValue,
            byte IsForced, float Value)
        {
            this.quality = Quality;
            this.istrace = IsTrace;
            this.isalarm = IsHighalarm | IsLowalarm;
            this.forcevalue = ForceValue;
            this.isforced = IsForced;
            this.buffer = Value;

            this.maxreached = MaxReached;
            this.minreached = MinReached;
            this.ishighalarm = IsHighalarm;
            this.islowalarm = IsLowalarm;
            this.maxvalue = MaxValue;
            this.minvalue = MinValue;
            this.isConnected = false;
            
        }

        public void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0].ToLower())
            {
				case "value":
					this.Value = value;
					break;
                case "buffer":
                    this.Value = value;
                    break;
                case "isforced":
                    this.IsForced = (byte)value;
                    break;
                case "forcevalue":
                    if (value is float)
                        this.ForceValue = (float)value;
                    else
                        this.ForceValue = ((IConvertible)value).ToSingle(null);
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
                case "maxvalue":
                    this.MaxValue = (float)value;
                    break;
                case "minvalue":
                    this.MinValue = (float)value;
                    break;
                case "ishighalarm":
                    this.IsHighalarm = (bool)value;
                    break;
                case "islowalarm":
                    this.IsLowalarm = (bool)value;
                    break;
                case "maxreached":
                    this.MaxReached = (bool)value;
                    break;
                case "minreached":
                    this.MinReached = (bool)value;
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
                case "maxvalue":
                    return this.MaxValue;
                case "minvalue":
                    return this.MinValue;
                case "ishighalarm":
                    return this.IsHighalarm;
                case "islowalarm":
                    return this.IsLowalarm;
                case "maxreached":
                    return this.MaxReached;
                case "minreached":
                    return this.MinReached;
                default:
                    return null;
            }
        }

        public object this[int i]
        {
            get
            {
                return this.buffer;
            }
            set
            {
                if (value is IValuable)
                    this.Value = ((IValuable)value).Value;
                else
                    this.Value = value;
            }
        }
       
        #endregion

        #region  运算符重载

        #region 四则运算
        public static float operator +(LA A, LA B)
        {
            return A.buffer + B.buffer;
        }

        public static float operator +(LA A, float B)
        {
            return A.buffer + B;
        }

        public static float operator +(float A, LA B)
        {
            return A + B.buffer;
        }

        public static float operator -(LA A, LA B)
        {
            return A.buffer - B.buffer;
        }

        public static float operator -(LA A, float B)
        {
            return A.buffer - B;
        }

        public static float operator -(float A, LA B)
        {
            return A - B.buffer;
        }

        public static float operator *(LA A, LA B)
        {
            return A.buffer * B.buffer;
        }

        public static float operator *(LA A, float B)
        {
            return A.buffer * B;
        }

        public static float operator *(float A, LA B)
        {
            return A * B.buffer;
        }

        public static float operator /(LA A, LA B)
        {
            return A.buffer / B.buffer;
        }

        public static float operator /(LA A, float B)
        {
            return A.buffer / B;
        }

        public static float operator /(float A, LA B)
        {
            return A / B.buffer;
        }


        #endregion

        #region 逻辑运算
        public static bool operator >(LA A, LA B)
        {
            return A.buffer > B.buffer;
        }

        public static bool operator >(LA A, float B)
        {
            return A.buffer > B;
        }

        public static bool operator >(float A, LA B)
        {
            return A > B.buffer;
        }

        public static bool operator >=(LA A, LA B)
        {
            return A.buffer >= B.buffer;
        }

        public static bool operator >=(LA A, float B)
        {
            return A.buffer >= B;
        }

        public static bool operator >=(float A, LA B)
        {
            return A >= B.buffer;
        }

        public static bool operator <(LA A, LA B)
        {
            return A.buffer < B.buffer;
        }

        public static bool operator <(LA A, float B)
        {
            return A.buffer < B;
        }

        public static bool operator <(float A, LA B)
        {
            return A < B.buffer;
        }

        public static bool operator <=(LA A, LA B)
        {
            return A.buffer <= B.buffer;
        }

        public static bool operator <=(LA A, float B)
        {
            return A.buffer <= B;
        }

        public static bool operator <=(float A, LA B)
        {
            return A <= B.buffer;
        }

        public static bool operator ==(LA A, LA B)
        {
            return A.buffer == B.buffer;
        }

        public static bool operator ==(LA A, float B)
        {
            return A.buffer == B;
        }

        public static bool operator ==(float A, LA B)
        {
            return A == B.buffer;
        }

        public static bool operator !=(LA A, LA B)
        {
            return A.buffer != B.buffer;
        }

        public static bool operator !=(LA A, float B)
        {
            return A.buffer != B;
        }

        public static bool operator !=(float A, LA B)
        {
            return A != B.buffer;
        }
        #endregion

        #region 布尔运算
        public static float operator &(LA A, LA B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B.buffer);
            return i & j;
        }

        public static float operator &(float A, LA B)
        {
            int i = Convert.ToInt32(A);
            int j = Convert.ToInt32(B.buffer);
            return i & j;
        }

        public static float operator &(LA A, float B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B);
            return i & j;
        }

        public static float operator ^(LA A, LA B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B.buffer);
            return i ^ j;
        }

        public static float operator ^(LA A, float B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B);
            return i ^ j;
        }

        public static float operator ^(float A, LA B)
        {
            int i = Convert.ToInt32(A);
            int j = Convert.ToInt32(B.buffer);
            return i ^ j;
        }

        public static float operator |(LA A, LA B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B.buffer);
            return i | j;
        }

        public static float operator |(LA A, float B)
        {
            int i = Convert.ToInt32(A.buffer);
            int j = Convert.ToInt32(B);
            return i | j;
        }

        public static float operator |(float A, LA B)
        {
            int i = Convert.ToInt32(A);
            int j = Convert.ToInt32(B.buffer);
            return i | j;
        }

        public static float operator %(LA A, float B)
        {
            return A.buffer % B;
        }

        public static float operator %(float A, LA B)
        {
            return A % B.buffer;
        }

        public static float operator %(LA A, LA B)
        {
            return A.buffer % B.buffer;
        }

        public static float operator !(LA A)
        {
            if (A.buffer != 0)
                return 0;
            else return 1;
        }

        public static float operator ~(LA A)
        {
            int i = Convert.ToInt32(A.buffer);
            return ~i;
        }

        // 绝对真运算符。如果操作数不为0，则返回 true，否则返回 false:
        public static bool operator true(LA A)
        {
            return A.buffer != 0;
        }

        // 绝对假运算符。如果操作数为0，则返回 true，否则返回 false:
        public static bool operator false(LA A)
        {
            return A.buffer == 0;
        }
        #endregion


        public static implicit operator float(LA A)
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
            Value = Convert.ToSingle(value);
        }
    }
}
