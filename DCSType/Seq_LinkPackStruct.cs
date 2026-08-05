using System;
using System.Collections.Generic;
using System.Text;

namespace DCSType
{
    public struct Seq_LinkPackStruct : IConvertible, IComparable<Seq_LinkPackStruct>
    {
        /// <summary>
        /// 算法块的唯一名称
        /// </summary>
        public int ComponentID;
        public void Set_ComponentID(int componentID)
        {
            ComponentID = componentID;
        }

        /// <summary>
        /// 管脚名称
        /// </summary>
        public int NextOuputIndex;
        public void Set_NextOutputIndex(int nextOuputIndex)
        {
            NextOuputIndex = nextOuputIndex;
        }

        /// <summary>
        /// 运行时间错误引起的停止序列
        /// </summary>
        public bool RTE_STP;
        public void Set_RTE_STP(bool rte_STP)
        {
            RTE_STP = rte_STP;
        }

        /// <summary>
        /// 运行时间错误引起的闭锁指令
        /// </summary>
        public bool RTE_BLC;
        public void Set_RTE_BLC(bool rte_BLC)
        {
            RTE_BLC = rte_BLC;
        }

        /// <summary>
        /// 复位
        /// </summary>
        public bool RESET;
        public void Set_RESET(bool reset)
        {
            RESET = reset;
        }

        /// <summary>
        /// 闭锁步骤指令输出
        /// </summary>
        public bool CMD_BL;
        public void Set_CMD_BL(bool cmd_BL)
        {
            CMD_BL = cmd_BL;
        }

        /// <summary>
        /// 试运转模式
        /// </summary>
        public bool COM;
        public void Set_COM(bool com)
        {
            COM = com;
        }

        #region IConvertible 成员

        public TypeCode GetTypeCode()
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public bool ToBoolean(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public byte ToByte(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public char ToChar(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public DateTime ToDateTime(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public decimal ToDecimal(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public double ToDouble(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public short ToInt16(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public int ToInt32(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public long ToInt64(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public sbyte ToSByte(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public float ToSingle(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public string ToString(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public object ToType(Type conversionType, IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ushort ToUInt16(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public uint ToUInt32(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        public ulong ToUInt64(IFormatProvider provider)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion

        #region IComparable<Seq_LinkPackStruct> 成员

        public int CompareTo(Seq_LinkPackStruct other)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    };
}
