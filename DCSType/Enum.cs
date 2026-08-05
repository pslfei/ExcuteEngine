using System;
using System.Collections.Generic;
using System.Text;

namespace DCSType
{
    /// <summary>
    /// 类型枚举
    /// </summary>
    internal enum TypeEnum
    {
        /// <summary>
        /// 整型
        /// </summary>
        Int = 0,
        /// <summary>
        /// 布尔型
        /// </summary>
        Boolean,
        /// <summary>
        /// 短整型
        /// </summary>
        Short,
        /// <summary>
        /// 长整型
        /// </summary>
        Long,
        /// <summary>
        /// 无符号8位整型
        /// </summary>
        Byte,
        /// <summary>
        /// Unicode字符类型
        /// </summary>
        Char,
        /// <summary>
        /// 无符号整型
        /// </summary>
        UInt,
        /// <summary>
        /// 无符号短整型
        /// </summary>
        UShort,
        /// <summary>
        /// 无符号长整型
        /// </summary>
        ULong,
        /// <summary>
        /// 有符号8位整型
        /// </summary>
        SByte,
        /// <summary>
        /// 十进制类型
        /// </summary>
        Decimal,
        /// <summary>
        /// 双精度浮点类型
        /// </summary>
        Double,
        /// <summary>
        /// 单精度浮点类型
        /// </summary>
        Float,
        /// <summary>
        /// 实点类型
        /// </summary>
        LA,
        /// <summary>
        /// 布尔量类型
        /// </summary>
        LD,
        /// <summary>
        /// 16位打包点类型
        /// </summary>
        LP,
        /// <summary>
        /// 32位打包点类型
        /// </summary>
        LP32,
        /// <summary>
        /// LALDLP类型
        /// </summary>
        LALDLP,

        /// <summary>
        /// 顺控类型
        /// </summary>
        Seq_FeedBackPackPoint,
        /// <summary>
        /// 
        /// </summary>
        Seq_LinkPackPoint,
        /// <summary>
        /// 
        /// </summary>
        Seq_StepInPackPoint,
        /// <summary>
        /// 
        /// </summary>
        Seq_FeedBackPackStruct,
        /// <summary>
        /// 
        /// </summary>
        Seq_LinkPackStruct,
        /// <summary>
        /// 
        /// </summary>
        Seq_StepInPackStruct,
    }
}
