using System;
using System.Collections.Generic;
using System.Text;

namespace DCSType
{
    public struct Seq_StepInPackStruct : IConvertible, IComparable<Seq_StepInPackStruct>
    {
        /// <summary>
        /// SGC的ComponentID
        /// </summary>
        public int SGC_ComponentID;
        public void Set_SGC_ComponentID(int sgc_ComponentID)
        {
            SGC_ComponentID = sgc_ComponentID;
        }

        /// <summary>
        /// 控制位
        /// </summary>
        public int ControlBits;
        public void Set_ControlBits(int controlBits)
        {
            ControlBits = controlBits;
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

        #region IComparable<Seq_StepInPackStruct> 成员

        public int CompareTo(Seq_StepInPackStruct other)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    };
}
