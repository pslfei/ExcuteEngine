/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：Pin.cs
// 文件功能描述：管脚模型
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
using System.Runtime.CompilerServices;

namespace DCSCommon
{
    /// <summary>
    /// 管脚模型
    /// </summary>
    /// <typeparam name="T1">Pinner类型</typeparam>
    /// <typeparam name="T2">Point中T类型</typeparam>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public class Pin<T1, T2> : IBuffer, IPin
        where T1 : IValuable
        where T2 : struct, IComparable<T2>, IConvertible
    {
        #region Fields



        /// <summary>
        /// 管脚
        /// </summary>
        [Pin]
        private IValuable pinner;
        /// <summary>
        /// 读取管脚
        /// </summary>
        public T1 Pinner
        {
            get { return (T1)pinner; }
            //set { pinner = value; }
        }

        /// <summary>
        /// 读取管脚接口
        /// </summary>
        public IValuable IPinner
        {
            get { return pinner; }
        }

        /// <summary>
        /// 缓冲值
        /// </summary>
        private T2 buffer;

        /// <summary>
        /// 设置或读取缓冲值
        /// </summary>
        public object Buffer
        {
            get { return buffer; }
            set 
            { 
                //this.Value = (T2)value; 
                if (value is T2)
                    this.buffer = (T2)value;
                else
                    this.buffer = (T2)((IConvertible)(value)).ToType(typeof(T2), null);
            }
        }

        /// <summary>
        /// 是否反转运算
        /// </summary>
        private bool reverse;
        /// <summary>
        /// 设置或获得是否反转运算
        /// </summary>
        public bool Reverse
        {
            get { return reverse; }
            set { reverse = value; }
        }


        /// <summary>
        /// 设置或读取引脚值
        /// </summary>
        public T2 Value
        {
            get
            {
                //if (pinner != null)
                //{
                //    if (pinner.Value is T2)
                //        buffer = (T2)pinner.Value;
                //    else
                //        buffer = (T2)((IConvertible)(pinner.Value)).ToType(typeof(T2), null);
                //}
                return buffer;
            }
            set
            {
                //if (pinner != null)
                //{
                //    pinner.Value = value;
                //    //this.buffer = value;
                //    if (pinner.Value is T2)
                //        buffer = (T2)pinner.Value;
                //    else
                //        buffer = (T2)((IConvertible)(pinner.Value)).ToType(typeof(T2), null);
                //}
                //else
                //{
                //    buffer = value;
                //}
                buffer = value;
            }
        }


        /// <summary>
        /// 读取是否连线
        /// </summary>
        public bool Connected
        {
            get
            {
                if (pinner == null)
                    return false;
                else return true;
            }
        }

        #endregion

        /// <summary>
        /// 根据索引方式读值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object Get(int index)
        {
            return this[index];
        }

        /// <summary>
        /// 根据索引方式写值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="obj"></param>
        public void Set(int index, object obj)
        {
            if (obj is T2)
            {
                this[index] = (T2)obj;
            }
            else
            {
                this[index] = (T2)((IConvertible)(obj)).ToType(typeof(T2), null);
            }
        }

        #region Self Functions

        public virtual T2 this[int i]
        {
            get
            {
                //if (pinner == null)
                //{
                if ((typeof(T1).BaseType.GetHashCode() == typeof(Point<short>).GetHashCode()))
                {
                    if (i < 0 || i > 15)
                        return default(T2);
                    short temp = (short)(1 << i);
                    short val = buffer.ToInt16(null);
                    temp = (short)(val & temp);
                    temp >>= i;
                    if (temp is T2)
                        return (T2)(object)temp;
                    else
                        return (T2)((IConvertible)(temp)).ToType(typeof(T2), null);
                }
                else return buffer;
                //}
                //else
                //{
                //    if (pinner.Value is T2)
                //        buffer = (T2)pinner.Value;
                //    else
                //        buffer = (T2)((IConvertible)(pinner.Value)).ToType(typeof(T2), null);
                //    object val = pinner[i];
                //    if (val is T2)
                //        return (T2)val;
                //    else
                //        return (T2)((IConvertible)(val)).ToType(typeof(T2), null);
                //}
            }
            set
            {
                //if (pinner != null)
                //{
                //    pinner[i] = value;
                //    //this.buffer = value;
                //    if (pinner.Value is T2)
                //        buffer = (T2)pinner.Value;
                //    else
                //        buffer = (T2)((IConvertible)(pinner.Value)).ToType(typeof(T2), null);
                //}
                //else
                //{
                if (typeof(T1).BaseType.GetHashCode() == typeof(Point<short>).GetHashCode())
                {
                    short val = value.ToInt16(null);
                    if (i < 0 || i > 15 || val < 0 || val > 1)
                        return;
                    short temp = (short)(1 << i);
                    short s = buffer.ToInt16(null);
                    if (val == 0)
                    {
                        temp = (short)(~temp);
                        s = (short)(s & temp);
                        if (s is T2)
                            buffer = (T2)(object)s;
                        else
                            buffer = (T2)((IConvertible)(s)).ToType(typeof(T2), null);
                    }
                    else
                    {
                        s = (short)(s | temp);
                        if (s is T2)
                            buffer = (T2)(object)s;
                        else
                            buffer = (T2)((IConvertible)(s)).ToType(typeof(T2), null);
                    }
                }
                else
                    buffer = value;
                //}
            }
        }

        public Pin()
        {
            //this.pinner = default(T1);
            this.pinner = null;
            if (typeof(T2).Name == "Seq_FeedBackPackStruct" || typeof(T2).Name == "Seq_LinkPackStruct" || typeof(T2).Name == "Seq_StepInPackStruct")
            {
                //this.buffer = (T2)((IConvertible)(0)).ToType(typeof(T2), null);//将缓冲值初始为零或false
            }
            else
            {

                this.buffer = (T2)((IConvertible)(0)).ToType(typeof(T2), null);//将缓冲值初始为零或false
            }
        }

        public Pin(IValuable Pinner, T2 Buffer)
        {
            this.pinner = Pinner;
            this.buffer = Buffer;
        }

        public Pin(T1 Pinner, T2 Buffer)
        {
            this.pinner = Pinner;
            this.buffer = Buffer;
        }

        #endregion

        #region Overload Operator
        //------------------------------运算符重载------------------------------------------

        #region 四则运算
        public static T2 operator +(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) + B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Add2(A.Value, B.Value);
        }

        public static T2 operator +(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) + B.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Add2(A.Value, B);
        }

        public static T2 operator +(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToSingle(null) + B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Add2(A, B.Value);
        }

        public static T2 operator -(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) - B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Subtract2(A.Value, B.Value);
        }

        public static T2 operator -(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) - B.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Subtract2(A.Value, B);
        }

        public static T2 operator -(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToSingle(null) - B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Subtract2(A, B.Value);
        }

        public static T2 operator *(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) * B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Multiply2(A.Value, B.Value);
        }

        public static T2 operator *(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) * B.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Multiply2(A.Value, B);
        }

        public static T2 operator *(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToSingle(null) * B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Multiply2(A, B.Value);
        }

        public static T2 operator /(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) / B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Division2(A.Value, B.Value);
        }

        public static T2 operator /(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) / B.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Division2(A.Value, B);
        }

        public static T2 operator /(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToSingle(null) / B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Division2(A, B.Value);
        }
        #endregion

        #region 逻辑运算
        public static bool operator >(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            return A.Value.CompareTo(B.Value) > 0;
        }

        public static bool operator >(Pin<T1, T2> A, T2 B)
        {
            return A.Value.CompareTo(B) > 0;
        }

        public static bool operator >(T2 A, Pin<T1, T2> B)
        {
            return A.CompareTo(B.Value) > 0;
        }

        public static bool operator <(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            return A.Value.CompareTo(B.Value) < 0;
        }

        public static bool operator <(Pin<T1, T2> A, T2 B)
        {
            return A.Value.CompareTo(B) < 0;
        }

        public static bool operator <(T2 A, Pin<T1, T2> B)
        {
            return A.CompareTo(B.Value) < 0;
        }

        public static bool operator >=(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            return A.Value.CompareTo(B.Value) >= 0;
        }

        public static bool operator >=(Pin<T1, T2> A, T2 B)
        {
            return A.Value.CompareTo(B) >= 0;
        }

        public static bool operator >=(T2 A, Pin<T1, T2> B)
        {
            return A.CompareTo(B.Value) >= 0;
        }

        public static bool operator <=(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            return A.Value.CompareTo(B.Value) <= 0;
        }

        public static bool operator <=(Pin<T1, T2> A, T2 B)
        {
            return A.Value.CompareTo(B) <= 0;
        }

        public static bool operator <=(T2 A, Pin<T1, T2> B)
        {
            return A.CompareTo(B.Value) <= 0;
        }

        public static bool operator ==(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            object o1 = (object)A;
            object o2 = (object)B;
            if (o1 == null && o2 == null)
                return true;
            else if (o1 == null | o2 == null)
                return false;
            else
                return A.Value.CompareTo(B.Value) == 0;
        }

        public static bool operator ==(Pin<T1, T2> A, T2 B)
        {
            if ((object)A == null)
                return false;
            return A.Value.CompareTo(B) == 0;
        }

        public static bool operator ==(T2 A, Pin<T1, T2> B)
        {
            if ((object)B == null)
                return false;
            return A.CompareTo(B.Value) == 0;
        }

        public static bool operator !=(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            object o1 = (object)A;
            object o2 = (object)B;
            if (o1 == null && o2 == null)
                return false;
            else if (o1 == null | o2 == null)
                return true;
            else
                return A.Value.CompareTo(B.Value) != 0;
        }

        public static bool operator !=(Pin<T1, T2> A, T2 B)
        {
            if ((object)A == null)
                return true;
            return A.Value.CompareTo(B) != 0;
        }

        public static bool operator !=(T2 A, Pin<T1, T2> B)
        {
            if ((object)B == null)
                return true;
            return A.CompareTo(B.Value) != 0;
        }
        #endregion

        #region 布尔运算
        public static T2 operator &(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) & B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.And2(A.Value, B.Value);
        }

        public static T2 operator &(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) & B.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.And2(A.Value, B);
        }

        public static T2 operator &(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToInt32(null) & B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.And2(A, B.Value);
        }

        public static T2 operator |(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) | B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Or2(A.Value, B.Value);
        }

        public static T2 operator |(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) | B.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Or2(A.Value, B);
        }

        public static T2 operator |(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToInt32(null) | B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Or2(A, B.Value);
        }

        public static T2 operator ^(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) ^ B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Xor2(A.Value, B.Value);
        }

        public static T2 operator ^(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToInt32(null) ^ B.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Xor2(A.Value, B);
        }

        public static T2 operator ^(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToInt32(null) ^ B.Value.ToInt32(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Xor2(A, B.Value);
        }

        public static T2 operator %(Pin<T1, T2> A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) % B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Mod2(A.Value, B.Value);
        }

        public static T2 operator %(Pin<T1, T2> A, T2 B)
        {
            //return (T2)((IConvertible)(A.Value.ToSingle(null) % B.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Mod2(A.Value, B);
        }

        public static T2 operator %(T2 A, Pin<T1, T2> B)
        {
            //return (T2)((IConvertible)(A.ToSingle(null) % B.Value.ToSingle(null))).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Mod2(A, B.Value);
        }

        public static T2 operator !(Pin<T1, T2> A)
        {
            //IConvertible i;
            //if (A.Value.ToSingle(null) != 0)
            //    i = 0;
            //else i = 1;
            //return (T2)i.ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Not(A.Value);
        }

        public static T2 operator ~(Pin<T1, T2> A)
        {
            //int i = A.Value.ToInt32(null);
            //i = ~i;
            //return (T2)((IConvertible)i).ToType(typeof(T2), null);
            return Calculator<T2>.Defualt.Reverse(A.Value);
        }

        // 绝对真运算符。如果操作数不为0，则返回 true，否则返回 false:
        public static bool operator true(Pin<T1, T2> A)
        {
            return A.Value.ToSingle(null) != 0;
        }

        // 绝对假运算符。如果操作数为0，则返回 true，否则返回 false:
        public static bool operator false(Pin<T1, T2> A)
        {
            return A.Value.ToSingle(null) == 0;
        }
        #endregion

        public static implicit operator T2(Pin<T1, T2> A)
        {
            return A.Value;
        }

        #endregion

        #region Object方法重写

        // 重写 Object.Equals(object o) 方法:
        public override bool Equals(object o)//o可能为空
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
        #endregion

        #region 任意类型转换器

        #region 左类型转换

        /// <summary>
        /// 将Y的值转换到X的值，返回X
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Pin<T1, T2> op_LeftShift(Pin<T1, T2> X, Pin<T1, T2> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将Y的值转换到X的值，返回X
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Pin<T1, T2> op_LeftShift(Pin<T1, T2> X, IBuffer Y)
        {
            if (Y.Buffer is T2)
                X.Value = (T2)Y.Buffer;
            else X.Value = (T2)((IConvertible)(Y.Buffer)).ToType(typeof(T2), null);
            return X;
        }
        #endregion

        #region 右类型转换

        /// <summary>
        /// 将X的值转换到Y的值，返回Y
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Pin<T1, T2> op_RightShift(Pin<T1, T2> X, Pin<T1, T2> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将X的值转换到Y的值，返回Y
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Pin<T1, T2> op_RightShift(IBuffer X, Pin<T1, T2> Y)
        {
            if (X.Buffer is T2)
                Y.Value = (T2)X.Buffer;
            else Y.Value = (T2)((IConvertible)(X.Buffer)).ToType(typeof(T2), null);
            return Y;
        }
        #endregion

        #endregion

    }
}
