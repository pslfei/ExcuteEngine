/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：Tag.cs
// 文件功能描述：Tag类型的抽象模型
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
using DCSCommon;

namespace DCSType
{
    /// <summary>
    /// Tag类型的抽象模型
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Tag)]
    public abstract class Tag : IValuable, IO
    {
        #region Fields
        /// <summary>
        /// 报警
        /// </summary>
        protected bool alm;
        /// <summary>
        /// 设置或读取报警
        /// </summary>
        public bool ALM
        {
            get { return alm; }
            set { alm = value; }
        }

        /// <summary>
        /// 信号质量
        /// </summary>
        protected bool q;
        /// <summary>
        /// 设置或读取信号质量
        /// </summary>
        public bool Q
        {
            get { return q; }
            set { q = value; }
        }

        #endregion

        #region IO Members

        public virtual void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "alm":
                    this.ALM = (bool)value;
                    break;
                case "q":
                    this.Q = (bool)value;
                    break;
            }
        }

        public virtual object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "alm":
                    return this.ALM;
                case "q":
                    return this.Q;
                default:
                    return null;
            }
        }

        #endregion

        #region IValuable Members

        /// <summary>
        /// 设置或获得数值
        /// </summary>
        public virtual object Value
        {
            get
            {
                return 0.0;
            }
            set
            {
            }
        }


        public object this[int i]
        {
            get
            {
                return 0.0;
            }
            set
            {
            }
        }
        #endregion
    }

    /// <summary>
    /// Tag类型的抽象泛型
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Tag)]
    public abstract class Tag<T> : IValuable, IO where T : struct, IConvertible
    {
        #region Fields
        /// <summary>
        /// 报警
        /// </summary>
        protected bool alm;
        /// <summary>
        /// 设置或读取报警
        /// </summary>
        public bool ALM
        {
            get { return alm; }
            set { alm = value; }
        }

        /// <summary>
        /// 信号质量
        /// </summary>
        protected bool q;
        /// <summary>
        /// 设置或读取信号质量
        /// </summary>
        public bool Q
        {
            get { return q; }
            set { q = value; }
        }

        #endregion

        #region IO Members

        public virtual void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "alm":
                    this.ALM = (bool)value;
                    break;
                case "q":
                    this.Q = (bool)value;
                    break;
            }
        }

        public virtual object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "alm":
                    return this.ALM;
                case "q":
                    return this.Q;
                default:
                    return null;
            }
        }

        #endregion

        #region IValuable Members

        /// <summary>
        /// 设置或获得数值
        /// </summary>
        public virtual object Value
        {
            get
            {
                return ((IConvertible)(0)).ToType(typeof(T), null);//返回零或false
            }
            set
            {
            }
        }


        public object this[int i]
        {
            get
            {
                return ((IConvertible)(0)).ToType(typeof(T), null);//返回零或false
            }
            set
            {
            }
        }
        #endregion
    }
}
