/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：Point.cs
// 文件功能描述：点的抽象模型
// 
//
// 创建标识：赵明明200906
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
    /// <summary>
    /// 点的抽象模型
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    public abstract class Point<T> : IValuable, IPointOperation where T : struct, IComparable<T>, IConvertible
    {
        #region Fields
        /// <summary>
        /// 信号质量
        /// </summary>
        protected QualityTypes quality;
        /// <summary>
        /// 设置或获得信号质量
        /// </summary>
        public virtual QualityTypes Quality
        {
            get { return quality; }
            set { quality = value; }
        }

        /// <summary>
        /// 是否跟踪
        /// </summary>
        protected bool istrace;
        /// <summary>
        /// 设置或获得是否跟踪
        /// </summary>
        public virtual bool IsTrace
        {
            get { return istrace; }
            set { istrace = value; }
        }

        /// <summary>
        /// 是否正处于Alarm状态
        /// </summary>
        protected bool isalarm;
        /// <summary>
        /// 设置或获得是否正处于Alarm状态
        /// </summary>
        public virtual bool IsAlarm
        {
            get { return isalarm; }
            set { isalarm = value; }
        }

        /// <summary>
        /// 强制值
        /// </summary>
        protected T forcevalue;
        /// <summary>
        /// 设置或获得强制值
        /// </summary>
        public virtual T ForceValue
        {
            get { return forcevalue; }
            set 
            {
                if (this.isforced != 0)
                    this.value = value;
                forcevalue = value; 
            }
        }

        /// <summary>
        /// 是否强制
        /// </summary>
        protected byte isforced;
        /// <summary>
        /// 设置或获得是否强制
        /// </summary>
        public virtual byte IsForced
        {
            get { return isforced; }
            set 
            { 
                isforced = value;
                if (isforced != 0)
                    this.value = this.forcevalue;
            }
        }

        /// <summary>
        /// 数值
        /// </summary>
        protected T value;
        /// <summary>
        /// 设置或获得数值
        /// </summary>
        public virtual object Value
        {
            get { /*return this.value;*/return 0; }
            set 
            {
                //alarm规则没写
                if (this.isforced != 0)
                    this.value = this.forcevalue;
                else
                {
                    //this.value = (T)value; 
                    if (value is T)
                        this.value = (T)value;
                    else
                        this.value = (T)((IConvertible)(value)).ToType(typeof(T), null);
                }
            }
        }

        #endregion

        #region Self Functions

        public virtual object this[int i]
        {
            get
            {
                return this.value;
            }
            set
            {
                if (value is T)
                    this.value = (T)value;
                else
                    this.value = (T)((IConvertible)(value)).ToType(typeof(T), null);
            }
        }

        /// <summary>
        /// 通过名称设置成员变量的值，使得对成员的赋值具有一定的约束，如强制时，写值的情况。子类可以重载此函数完成更为复杂的逻辑
        /// </summary>
        /// <param name="value"></param>
        /// <param name="names"></param>
        public virtual void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "value":
                    this.Value = (T)value;
                    break;
                case "isforced":
                    this.IsForced = (byte)value;
                    break;
                case "forcevalue":
                    this.ForceValue = (T)value;
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

        /// <summary>
        /// 通过名称读取成员变量的值。子类可以重载此函数完成更为复杂的逻辑
        /// </summary>
        /// <param name="names"></param>
        public virtual object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "value":
                    return this.Value;
                case "isforced":
                    return this.IsForced;
                case "forcevalue":
                    return this.ForceValue;
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

        public Point()
        {
            this.quality = QualityTypes.Good;
            this.istrace = false;
            this.isalarm = false;
        }

        public Point(QualityTypes Quality, bool IsTrace, bool IsAlarm, T ForceValue, byte IsForced, T Value)
        {
            this.quality = Quality;
            this.istrace = IsTrace;
            this.isalarm = IsAlarm;
            this.forcevalue = ForceValue;
            this.isforced = IsForced;
            this.value = Value;
        }

        #endregion

        #region Overload Operator
        //------------------------------运算符重载------------------------------------------

        #region 四则运算
        public static T operator +(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) + B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Add2(A.value, B.value);
        }

        public static T operator +(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) + B.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Add2(A.value, B);
        }

        public static T operator +(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToSingle(null) + B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Add2(A, B.value);
        }

        public static T operator -(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) - B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Subtract2(A.value, B.value);
        }

        public static T operator -(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) - B.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Subtract2(A.value, B);
        }

        public static T operator -(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToSingle(null) - B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Subtract2(A, B.value);
        }

        public static T operator *(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) * B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Multiply2(A.value, B.value);
        }

        public static T operator *(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) * B.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Multiply2(A.value, B);
        }

        public static T operator *(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToSingle(null) * B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Multiply2(A, B.value);
        }

        public static T operator /(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) / B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Division2(A.value, B.value);
        }

        public static T operator /(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) / B.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Division2(A.value, B);
        }

        public static T operator /(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToSingle(null) / B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Division2(A, B.value);
        }
        #endregion

        #region 逻辑运算
        public static bool operator >(Point<T> A, Point<T> B)
        {
            return A.value.CompareTo(B.value) > 0;
        }

        public static bool operator >(Point<T> A, T B)
        {
            return A.value.CompareTo(B) > 0;
        }

        public static bool operator >(T A, Point<T> B)
        {
            return A.CompareTo(B.value) > 0;
        }

        public static bool operator <(Point<T> A, Point<T> B)
        {
            return A.value.CompareTo(B.value) < 0;
        }

        public static bool operator <(Point<T> A, T B)
        {
            return A.value.CompareTo(B) < 0;
        }

        public static bool operator <(T A, Point<T> B)
        {
            return A.CompareTo(B.value) < 0;
        }

        public static bool operator >=(Point<T> A, Point<T> B)
        {
            return A.value.CompareTo(B.value) >= 0;
        }

        public static bool operator >=(Point<T> A, T B)
        {
            return A.value.CompareTo(B) >= 0;
        }

        public static bool operator >=(T A, Point<T> B)
        {
            return A.CompareTo(B.value) >= 0;
        }

        public static bool operator <=(Point<T> A, Point<T> B)
        {
            return A.value.CompareTo(B.value) <= 0;
        }

        public static bool operator <=(Point<T> A, T B)
        {
            return A.value.CompareTo(B) <= 0;
        }

        public static bool operator <=(T A, Point<T> B)
        {
            return A.CompareTo(B.value) <= 0;
        }

        public static bool operator ==(Point<T> A, Point<T> B)
        {
            object o1 = (object)A;
            object o2 = (object)B;
            if (o1 == null && o2 == null)
                return true;
            else if (o1 == null | o2 == null)
                return false;
            else
                return A.value.CompareTo(B.value) == 0;
        }

        public static bool operator ==(Point<T> A, T B)
        {
            if ((object)A == null)
                return false;
            return A.value.CompareTo(B) == 0;
        }

        public static bool operator ==(T A, Point<T> B)
        {
            if ((object)B == null)
                return false;
            return A.CompareTo(B.value) == 0;
        }

        public static bool operator !=(Point<T> A, Point<T> B)
        {
            object o1 = (object)A;
            object o2 = (object)B;
            if (o1 == null && o2 == null)
                return false;
            else if (o1 == null | o2 == null)
                return true;
            else
                return A.value.CompareTo(B.value) != 0;
        }

        public static bool operator !=(Point<T> A, T B)
        {
            if ((object)A == null)
                return true;
            return A.value.CompareTo(B) != 0;
        }

        public static bool operator !=(T A, Point<T> B)
        {
            if ((object)B == null)
                return true;
            return A.CompareTo(B.value) != 0;
        }
        #endregion

        #region 布尔运算
        public static T operator &(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) & B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.And2(A.value, B.value);
        }

        public static T operator &(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) & B.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.And2(A.value, B);
        }

        public static T operator &(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToInt32(null) & B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.And2(A, B.value);
        }

        public static T operator |(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) | B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Or2(A.value, B.value);
        }

        public static T operator |(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) | B.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Or2(A.value, B);
        }

        public static T operator |(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToInt32(null) | B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Or2(A, B.value);
        }

        public static T operator ^(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) ^ B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Xor2(A.value, B.value);
        }

        public static T operator ^(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToInt32(null) ^ B.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Xor2(A.value, B);
        }

        public static T operator ^(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToInt32(null) ^ B.value.ToInt32(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Xor2(A, B.value);
        }

        public static T operator %(Point<T> A, Point<T> B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) % B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Mod2(A.value, B.value);
        }

        public static T operator %(Point<T> A, T B)
        {
            //return (T)((IConvertible)(A.value.ToSingle(null) % B.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Mod2(A.value, B);
        }

        public static T operator %(T A, Point<T> B)
        {
            //return (T)((IConvertible)(A.ToSingle(null) % B.value.ToSingle(null))).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Mod2(A, B.value);
        }

        public static T operator !(Point<T> A)
        {
            //IConvertible i;
            //if (A.value.ToSingle(null) != 0)
            //    i = 0;
            //else i = 1;
            //return (T)i.ToType(typeof(T), null);
            return Calculator<T>.Defualt.Not(A.value);
        }

        public static T operator ~(Point<T> A)
        {
            //int i = A.value.ToInt32(null);
            //i = ~i;
            //return (T)((IConvertible)i).ToType(typeof(T), null);
            return Calculator<T>.Defualt.Reverse(A.value);
        }

        // 绝对真运算符。如果操作数不为0，则返回 true，否则返回 false:
        public static bool operator true(Point<T> A)
        {
            return A.value.ToSingle(null) != 0;
        }

        // 绝对假运算符。如果操作数为0，则返回 true，否则返回 false:
        public static bool operator false(Point<T> A)
        {
            return A.value.ToSingle(null) == 0;
        }
        #endregion

        public static implicit operator T(Point<T> A)
        {
            return A.value;
        }

        #endregion

        #region Object方法重写

        // 重写 Object.Equals(object o) 方法:
        public override bool Equals(object o)
        {
            try
            {
                if (o == null)
                    return false;
                if (this.GetHashCode() == o.GetHashCode())
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        // 重写 Object.GetHashCode() 方法:
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        // 重写 ToString 方法以便将 LA 转换为 string:
        public override string ToString()
        {
            return this.Value.ToString();
        }

        //private static bool IsNull(object o)
        //{
        //    try
        //    {
        //        o.GetHashCode();
        //        return false;
        //    }
        //    catch
        //    {
        //        return true;
        //    }
        //}
        #endregion
    }
}
