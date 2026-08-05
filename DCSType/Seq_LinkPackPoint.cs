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
    public struct Seq_LinkPackPoint : IValuable, IPointOperation
    {
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
            internal set
            {
                isConnected = value;
            }
        }
        #region IValuable 成员

        /// <summary>
        /// 数值
        /// </summary>
        private Seq_LinkPackStruct buffer;
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
                if (value is Seq_LinkPackStruct)
                    this.buffer = (Seq_LinkPackStruct)value;
                else
                    throw new Exception("给Seq_LinkPackStruct类型赋值异常");
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

        #region IPointOperation 成员

        public bool IsAlarm
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public byte IsForced
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public bool IsTrace
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        public QualityTypes Quality
        {
            get
            {
                throw new Exception("The method or operation is not implemented.");
            }
            set
            {
                throw new Exception("The method or operation is not implemented.");
            }
        }

        #endregion

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "isconnected":
                    this.Connected = (bool)value;
                    return;
                    break;
            }
            throw new Exception("The method or operation is not implemented.");
        }

        public object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "isconnected":
                    return this.Connected;
            }
            throw new Exception("The method or operation is not implemented.");
        }
        #endregion
    }
}