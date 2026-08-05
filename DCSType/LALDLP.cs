/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：LALDLP.cs
// 文件功能描述：LALDLP
// 
//
// 创建标识：赵明明200907
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
using System.Reflection;
using DCSCommon;

namespace DCSType
{
    public interface ILALDLP : IValuable
    {
    }

    //public class TestLaLdLp : IValuable
    //{
    //    private IValuable transaction = null;

    //    #region IValuable Members

    //    public object Value
    //    {
    //        get
    //        {
    //            if (transaction == null)
    //                return 0;
    //            else return transaction.Value;
    //        }
    //        set
    //        {
    //            if (transaction != null)
    //                transaction.Value = value;
    //        }
    //    }

    //    #endregion

    //    public TestLaLdLp(IValuable A)
    //    {
    //        this.transaction = A;
    //    }

    //    public TestLaLdLp()
    //    {

    //    }

    //    [SpecialName]
    //    public static TestLaLdLp op_Implicit(IValuable A)
    //    {
    //        return new TestLaLdLp(A);
    //    }

    //    [SpecialName]
    //    public static TestLaLdLp op_Explicit(IValuable A)
    //    {
    //        return new TestLaLdLp(A);
    //    }
    //}

    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public abstract class LALDLP<T> : Point<T>, ILALDLP where T : struct, IComparable<T>, IConvertible
    {
        #region 任意类型转换器

        #region 左类型转换

        /// <summary>
        /// 将Point<double>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_LeftShift(LALDLP<T> X, Point<double> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<double>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<double> op_LeftShift(Point<double> X, LALDLP<T> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将Point<float>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_LeftShift(LALDLP<T> X, Point<float> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<float>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<float> op_LeftShift(Point<float> X, LALDLP<T> Y)
        {
            X.Value = (float)Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LA类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LA op_LeftShift(LA X, LALDLP<T> Y)
        {
            X.Value = (float)Y.Value;
            return X;
        }

        /// <summary>
        /// 将Point<int>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_LeftShift(LALDLP<T> X, Point<int> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<int>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<int> op_LeftShift(Point<int> X, LALDLP<T> Y)
        {
            X.Value = (int)Y.Value;
            return X;
        }

        /// <summary>
        /// 将Point<short>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_LeftShift(LALDLP<T> X, Point<short> Y)
        {
            X.Value = Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<short>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<short> op_LeftShift(Point<short> X, LALDLP<T> Y)
        {
            X.Value = (short)Y.Value;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LP类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LP op_LeftShift(LP X, LALDLP<T> Y)
        {
            X.Value = (short)Y.Value;
            return X;
        }

        /// <summary>
        /// 将Point<bool>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_LeftShift(LALDLP<T> X, Point<bool> Y)
        {
            if ((bool)Y.Value)
                X.Value = 1;
            else X.Value = 0;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<bool>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<bool> op_LeftShift(Point<bool> X, LALDLP<T> Y)
        {
            X.Value = ((IComparable)Y.Value).CompareTo(0) != 0;
            return X;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LD类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LD op_LeftShift(LD X, LALDLP<T> Y)
        {
            X.Value = ((IComparable)Y.Value).CompareTo(0) != 0;
            return X;
        }

        #endregion

        #region 右类型转换

        /// <summary>
        /// 将Point<double>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_RightShift(Point<double> X, LALDLP<T> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<double>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<double> op_RightShift(LALDLP<T> X, Point<double> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将Point<float>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_RightShift(Point<float> X, LALDLP<T> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<float>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<float> op_RightShift(LALDLP<T> X, Point<float> Y)
        {
            Y.Value = (float)X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LA类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LA op_RightShift(LALDLP<T> X, LA Y)
        {
            Y.Value = (float)X.Value;
            return Y;
        }

        /// <summary>
        /// 将Point<int>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_RightShift(Point<int> X, LALDLP<T> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<int>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<int> op_RightShift(LALDLP<T> X, Point<int> Y)
        {
            Y.Value = (int)X.Value;
            return Y;
        }

        /// <summary>
        /// 将Point<short>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_RightShift(Point<short> X, LALDLP<T> Y)
        {
            Y.Value = X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<short>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<short> op_RightShift(LALDLP<T> X, Point<short> Y)
        {
            Y.Value = (short)X.Value;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LP类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LP op_RightShift(LALDLP<T> X, LP Y)
        {
            Y.Value = (short)X.Value;
            return Y;
        }

        /// <summary>
        /// 将Point<bool>类型转换为LALDLP<T>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LALDLP<T> op_RightShift(Point<bool> X, LALDLP<T> Y)
        {
            if ((bool)X.Value)
                Y.Value = 1;
            else Y.Value = 0;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为Point<bool>类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static Point<bool> op_RightShift(LALDLP<T> X, Point<bool> Y)
        {
            Y.Value = ((IComparable)X.Value).CompareTo(0) != 0;
            return Y;
        }

        /// <summary>
        /// 将LALDLP<T>类型转换为LD类型
        /// </summary>
        /// <param name="X"></param>
        /// <param name="Y"></param>
        /// <returns></returns>
        [SpecialName]
        public static LD op_RightShift(LALDLP<T> X, LD Y)
        {
            Y.Value = ((IComparable)X.Value).CompareTo(0) != 0;
            return Y;
        }

        #endregion

        #region 显式转换

        [SpecialName]
        public static T op_Implicit(LA A)
        {
            return (T)((IConvertible)A.Value).ToType(typeof(T), null);
        }

        [SpecialName]
        public static T op_Explicit(LA A)
        {
            return (T)((IConvertible)A.Value).ToType(typeof(T), null);
        }

        #endregion

        #endregion


        #region 协变式(IValuable<double> Members)

        //public new double Value
        //{
        //    get
        //    {
        //        return 0;
        //    }
        //    set
        //    {
        //    }
        //}

        #endregion

        public override object Value
        {
            get
            {
                return base.Value;
            }
            set
            {
                base.Value = value;
            }
        }
    }
}
