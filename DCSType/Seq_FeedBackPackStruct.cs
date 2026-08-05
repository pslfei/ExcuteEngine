using System;
using System.Collections.Generic;
using System.Text;

namespace DCSType
{
    public struct Seq_FeedBackPackStruct : IConvertible, IComparable<Seq_FeedBackPackStruct>
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
        public int PortID;
        public void Set_PortID(int portID)
        {
            PortID = portID;
            
        }

        /// <summary>
        /// BRANCH或STEP的ComponentName
        /// </summary>
        public int SEQ_ComponentID;
        public void Set_SEQ_ComponentID(int seq_ComponentID)
        {
            SEQ_ComponentID = seq_ComponentID;
        }

        /// <summary>
        /// 步骤号
        /// </summary>
        public int StepNum;
        public void Set_StepNum(int stepNum)
        {
            StepNum = stepNum;
        }

        /// <summary>
        /// 剩余等待时间
        /// </summary>
        public float R_WT;
        public void Set_R_WT(float r_WT)
        {
            R_WT = r_WT;
        }

        /// <summary>
        /// 剩余监视时间
        /// </summary>
        public float R_MT;
        public void Set_R_MT(float r_MT)
        {
            R_MT = r_MT;
        }

        /// <summary>
        /// 运行时间错误
        /// </summary>
        public bool Run_ET;
        public void Set_Run_ET(bool run_ET)
        {
            Run_ET = run_ET;
        }

        /// <summary>
        /// 是否为分支步
        /// </summary>
        public bool Step_Branch;
        public void Set_Step_Branch(bool step_Branch)
        {
            Step_Branch = step_Branch;
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

        #region IComparable<Seq_FeedBackPackStruct> 成员

        public int CompareTo(Seq_FeedBackPackStruct other)
        {
            throw new Exception("The method or operation is not implemented.");
        }

        #endregion
    };
}
