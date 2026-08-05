///*----------------------------------------------------------------
//// Copyright (C) 2010 Race
//// 版权所有。 
////
//// 文件名：CalculationCache.cs
//// 文件功能描述：CalculationCache——计算Cache
//// 
////
//// 创建标识：赵明明2010
////
//// 修改标识：
//// 修改描述：
////
//// 修改标识：
//// 修改描述：
////----------------------------------------------------------------*/
//using System;
//using System.Collections.Generic;
//using System.Text;
//using DCSCommon;

//namespace DCSType
//{

//    /// <summary>
//    /// Pin计算Cache
//    /// </summary>
//    public class PinCalculationCache : IPinCalculationCache
//    {
//        #region fields
//        /// <summary>
//        /// 默认算子
//        /// </summary>
//        private IPinCalculationCache calculator = null;

//        /// <summary>
//        /// 锁对象
//        /// </summary>
//        private static object objLock = new object();

//        /// <summary>
//        /// 类型字典
//        /// </summary>
//        private static Dictionary<int, TypeEnum> dictType = new Dictionary<int, TypeEnum>();

//        #endregion

//        #region IPinCalculationCache 成员

//        public object this[int i]
//        {
//            get
//            {
//                return calculator[i];
//            }
//            set
//            {
//                calculator[i] = value;
//            }
//        }

//        #endregion

//        /// <summary>
//        /// 默认构造函数
//        /// </summary>
//        public PinCalculationCache()
//        {
//        }

//        /// <summary>
//        /// 静态构造，只初始一次
//        /// </summary>
//        static PinCalculationCache()
//        {
//            dictType[typeof(int    ).MetadataToken] = TypeEnum.Int;
//            dictType[typeof(bool   ).MetadataToken] = TypeEnum.Boolean;
//            dictType[typeof(short  ).MetadataToken] = TypeEnum.Short;
//            dictType[typeof(long   ).MetadataToken] = TypeEnum.Long;
//            dictType[typeof(byte   ).MetadataToken] = TypeEnum.Byte;
//            dictType[typeof(char   ).MetadataToken] = TypeEnum.Char;
//            dictType[typeof(uint   ).MetadataToken] = TypeEnum.UInt;
//            dictType[typeof(ushort ).MetadataToken] = TypeEnum.UShort;
//            dictType[typeof(ulong  ).MetadataToken] = TypeEnum.ULong;
//            dictType[typeof(sbyte  ).MetadataToken] = TypeEnum.SByte;
//            dictType[typeof(decimal).MetadataToken] = TypeEnum.Decimal;
//            dictType[typeof(double ).MetadataToken] = TypeEnum.Double;
//            dictType[typeof(float  ).MetadataToken] = TypeEnum.Float;
//            dictType[typeof(LA     ).MetadataToken] = TypeEnum.LA;
//            dictType[typeof(LD     ).MetadataToken] = TypeEnum.LD;
//            dictType[typeof(LP     ).MetadataToken] = TypeEnum.LP;
//            dictType[typeof(LP32   ).MetadataToken] = TypeEnum.LP32;
//            dictType[typeof(Seq_FeedBackPackPoint).MetadataToken] = TypeEnum.Seq_FeedBackPackPoint; 
//            dictType[typeof(Seq_FeedBackPackStruct).MetadataToken] = TypeEnum.Seq_FeedBackPackStruct; 
//            dictType[typeof(Seq_LinkPackPoint).MetadataToken] = TypeEnum.Seq_LinkPackPoint; 
//            dictType[typeof(Seq_LinkPackStruct).MetadataToken] = TypeEnum.Seq_LinkPackStruct; 
//            dictType[typeof(Seq_StepInPackPoint).MetadataToken] = TypeEnum.Seq_StepInPackPoint; 
//            dictType[typeof(Seq_StepInPackStruct).MetadataToken] = TypeEnum.Seq_StepInPackStruct; 
         
//        }

//        /// <summary>
//        /// 构造函数
//        /// </summary>
//        /// <param name="PinAddress">Pin对象地址</param>
//        /// <param name="PinType">Pin类型</param>
//        /// <exception cref="ArgumentNullException"></exception>
//        /// <exception cref="Exception"></exception>
//        public PinCalculationCache(IntPtr PinAddress, Type PinType)
//        {
//            if (PinAddress == IntPtr.Zero)
//                throw new ArgumentNullException("PinAddress", "不能为空！");
//            if (PinType == null)
//                throw new ArgumentNullException("PinType", "不能为空！");
//            if (calculator == null)
//            {
//                if (PinType.IsEnum)
//                    PinType = typeof(int);
//                if (!CreateCalculator(PinAddress, PinType))
//                {
//                    throw new Exception("初始化算子失败！");
//                }
//            }
//        }

//        /// <summary>
//        /// 创建算子
//        /// </summary>
//        /// <param name="PinAddress">Pin对象地址</param>
//        /// <param name="PinType">Pin类型</param>
//        /// <returns></returns>
//        private bool CreateCalculator(IntPtr PinAddress, Type PinType)
//        {
//            if (!dictType.ContainsKey(PinType.MetadataToken))
//                return false;
//            TypeEnum t = dictType[PinType.MetadataToken];
//            switch (t)
//            {
//                case TypeEnum.Int:
//                    calculator = new IntCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Boolean:
//                    calculator = new BooleanCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Short:
//                    calculator = new ShortCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Long:
//                    calculator = new LongCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Byte:
//                    calculator = new ByteCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Char:
//                    calculator = new CharCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.UInt:
//                    calculator = new UIntCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.UShort:
//                    calculator = new UShortCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.ULong:
//                    calculator = new ULongCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.SByte:
//                    calculator = new SByteCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Decimal:
//                    calculator = new DecimalCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Double:
//                    calculator = new DoubleCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Float:
//                    calculator = new FloatCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.LA:
//                    calculator = new LACalculationCache(PinAddress);
//                    break;
//                case TypeEnum.LD:
//                    calculator = new LDCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.LP:
//                    calculator = new LPCalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_FeedBackPackPoint:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_FeedBackPackStruct:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_LinkPackPoint:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_LinkPackStruct:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_StepInPackPoint:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
//                case TypeEnum.Seq_StepInPackStruct:
//                    calculator = new LP32CalculationCache(PinAddress);
//                    break;
              

//            }
//            return true;
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            calculator.SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return calculator.GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return calculator.Value;
//            }
//            set
//            {
//                calculator.Value = value;
//            }
//        }

//        #endregion
//    }

//    #region 内部算子

//    internal unsafe class IntCalculationCache : IPinCalculationCache
//    {
//        private int* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is int)
//                    *ptr = (int)value;
//                else
//                    *ptr = (int)((IConvertible)(value)).ToInt32(null);
//            }
//        }

//        public IntCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (int*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is int)
//                    *ptr = (int)value;
//                else
//                    *ptr = (int)((IConvertible)(value)).ToInt32(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class BooleanCalculationCache : IPinCalculationCache
//    {
//        private bool* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is bool)
//                    *ptr = (bool)value;
//                else
//                    *ptr = (bool)((IConvertible)(value)).ToBoolean(null);
//            }
//        }

//        public BooleanCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (bool*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is bool)
//                    *ptr = (bool)value;
//                else
//                    *ptr = (bool)((IConvertible)(value)).ToBoolean(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class ShortCalculationCache : IPinCalculationCache
//    {
//        private short* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is short)
//                    *ptr = (short)value;
//                else
//                    *ptr = (short)((IConvertible)(value)).ToInt16(null);
//            }
//        }

//        public ShortCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (short*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is short)
//                    *ptr = (short)value;
//                else
//                    *ptr = (short)((IConvertible)(value)).ToInt16(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class LongCalculationCache : IPinCalculationCache
//    {
//        private long* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is long)
//                    *ptr = (long)value;
//                else
//                    *ptr = (long)((IConvertible)(value)).ToInt64(null);
//            }
//        }

//        public LongCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (long*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is long)
//                    *ptr = (long)value;
//                else
//                    *ptr = (long)((IConvertible)(value)).ToInt64(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class ByteCalculationCache : IPinCalculationCache
//    {
//        private byte* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is byte)
//                    *ptr = (byte)value;
//                else
//                    *ptr = (byte)((IConvertible)(value)).ToByte(null);
//            }
//        }

//        public ByteCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (byte*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is byte)
//                    *ptr = (byte)value;
//                else
//                    *ptr = (byte)((IConvertible)(value)).ToByte(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class CharCalculationCache : IPinCalculationCache
//    {
//        private char* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is char)
//                    *ptr = (char)value;
//                else
//                    *ptr = (char)((IConvertible)(value)).ToChar(null);
//            }
//        }

//        public CharCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (char*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is char)
//                    *ptr = (char)value;
//                else
//                    *ptr = (char)((IConvertible)(value)).ToChar(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class UIntCalculationCache : IPinCalculationCache
//    {
//        private uint* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is uint)
//                    *ptr = (uint)value;
//                else
//                    *ptr = (uint)((IConvertible)(value)).ToUInt32(null);
//            }
//        }

//        public UIntCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (uint*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is uint)
//                    *ptr = (uint)value;
//                else
//                    *ptr = (uint)((IConvertible)(value)).ToUInt32(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class UShortCalculationCache : IPinCalculationCache
//    {
//        private ushort* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is ushort)
//                    *ptr = (ushort)value;
//                else
//                    *ptr = (ushort)((IConvertible)(value)).ToUInt16(null);
//            }
//        }

//        public UShortCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (ushort*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is ushort)
//                    *ptr = (ushort)value;
//                else
//                    *ptr = (ushort)((IConvertible)(value)).ToUInt16(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class ULongCalculationCache : IPinCalculationCache
//    {
//        private ulong* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is ulong)
//                    *ptr = (ulong)value;
//                else
//                    *ptr = (ulong)((IConvertible)(value)).ToUInt64(null);
//            }
//        }

//        public ULongCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (ulong*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is ulong)
//                    *ptr = (ulong)value;
//                else
//                    *ptr = (ulong)((IConvertible)(value)).ToUInt64(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class SByteCalculationCache : IPinCalculationCache
//    {
//        private sbyte* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is sbyte)
//                    *ptr = (sbyte)value;
//                else
//                    *ptr = (sbyte)((IConvertible)(value)).ToSByte(null);
//            }
//        }

//        public SByteCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (sbyte*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is sbyte)
//                    *ptr = (sbyte)value;
//                else
//                    *ptr = (sbyte)((IConvertible)(value)).ToSByte(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class DecimalCalculationCache : IPinCalculationCache
//    {
//        private decimal* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is decimal)
//                    *ptr = (decimal)value;
//                else
//                    *ptr = (decimal)((IConvertible)(value)).ToDecimal(null);
//            }
//        }

//        public DecimalCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (decimal*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is decimal)
//                    *ptr = (decimal)value;
//                else
//                    *ptr = (decimal)((IConvertible)(value)).ToDecimal(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class DoubleCalculationCache : IPinCalculationCache
//    {
//        private double* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is double)
//                    *ptr = (double)value;
//                else
//                    *ptr = (double)((IConvertible)(value)).ToDouble(null);
//            }
//        }

//        public DoubleCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (double*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is double)
//                    *ptr = (double)value;
//                else
//                    *ptr = (double)((IConvertible)(value)).ToDouble(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class FloatCalculationCache : IPinCalculationCache
//    {
//        private float* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is float)
//                    *ptr = (float)value;
//                else
//                    *ptr = (float)((IConvertible)(value)).ToSingle(null);
//            }
//        }

//        public FloatCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (float*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            this.Value = value;
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return this.Value;
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return *ptr;
//            }
//            set
//            {
//                if (value is float)
//                    *ptr = (float)value;
//                else
//                    *ptr = (float)((IConvertible)(value)).ToSingle(null);
//            }
//        }

//        #endregion
//    }

//    internal unsafe class LACalculationCache : IPinCalculationCache
//    {
//        private LA* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LACalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LA*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }

//    internal unsafe class LDCalculationCache : IPinCalculationCache
//    {
//        private LD* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LDCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LD*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }

//    internal unsafe class LPCalculationCache : IPinCalculationCache
//    {
//        private LP* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LPCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LP*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }

//    internal unsafe class LP32CalculationCache : IPinCalculationCache
//    {
//        private LP32* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LP32CalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LP32*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }

//     //dictType[typeof(Seq_FeedBackPackPoint).MetadataToken] = TypeEnum.Seq_FeedBackPackPoint; 

//     //       dictType[typeof(Seq_FeedBackPackStruct).MetadataToken] = TypeEnum.Seq_FeedBackPackStruct; 

//     //       dictType[typeof(Seq_LinkPackPoint).MetadataToken] = TypeEnum.Seq_LinkPackPoint; 
//     //       dictType[typeof(Seq_LinkPackStruct).MetadataToken] = TypeEnum.Seq_LinkPackStruct; 
//     //       dictType[typeof(Seq_StepInPackPoint).MetadataToken] = TypeEnum.Seq_StepInPackPoint; 
//     //       dictType[typeof(Seq_StepInPackStruct).MetadataToken] = TypeEnum.Seq_StepInPackStruct; 
//    internal unsafe class Seq_FeedBackPackPointCalculationCache : IPinCalculationCache
//    {
//        private Seq_FeedBackPackPoint* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public Seq_FeedBackPackPointCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (Seq_FeedBackPackPoint*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }
//    internal unsafe class Seq_FeedBackPackStructCalculationCache : IPinCalculationCache
//    {
//        private Seq_FeedBackPackStruct* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public Seq_FeedBackPackStructCalculationCache(IntPtr PinAddress)
//        {
//            ptr = (Seq_FeedBackPackStruct*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }
//    internal unsafe class Seq_LinkPackPointCalculationCache : IPinCalculationCache
//    {
//        private LA* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LACalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LA*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }
//    internal unsafe class Seq_LinkPackStructCalculationCache : IPinCalculationCache
//    {
//        private LA* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LACalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LA*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }
//    internal unsafe class Seq_StepInPackPointCalculationCache : IPinCalculationCache
//    {
//        private LA* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LACalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LA*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }
//    internal unsafe class Seq_StepInPackStructCalculationCache : IPinCalculationCache
//    {
//        private LA* ptr;

//        public object this[int i]
//        {
//            get
//            {
//                return (*ptr)[i];
//            }
//            set
//            {
//                (*ptr)[i] = value;
//            }
//        }

//        public LACalculationCache(IntPtr PinAddress)
//        {
//            ptr = (LA*)PinAddress.ToPointer();
//        }

//        #region IO 成员

//        public void SetMemberValue(object value, params string[] names)
//        {
//            ptr->SetMemberValue(value, names);
//        }

//        public object GetMemberValue(params string[] names)
//        {
//            return ptr->GetMemberValue(names);
//        }

//        #endregion

//        #region IValuable 成员

//        public object Value
//        {
//            get
//            {
//                return ptr->Value;
//            }
//            set
//            {
//                ptr->Value = value;
//            }
//        }

//        #endregion
//    }

//    #endregion



//}

/*----------------------------------------------------------------
// Copyright (C) 2010 Race
// 版权所有。 
//
// 文件名：CalculationCache.cs
// 文件功能描述：CalculationCache——计算Cache
// 
//
// 创建标识：赵明明2010
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
using DCSCommon;

namespace DCSType
{

    /// <summary>
    /// Pin计算Cache
    /// </summary>
    public class PinCalculationCache : IPinCalculationCache
    {
        #region fields
        /// <summary>
        /// 默认算子
        /// </summary>
        private IPinCalculationCache calculator = null;

        /// <summary>
        /// 锁对象
        /// </summary>
        private static object objLock = new object();

        /// <summary>
        /// 类型字典
        /// </summary>
        private static Dictionary<int, TypeEnum> dictType = new Dictionary<int, TypeEnum>();

        #endregion

        #region IPinCalculationCache 成员

        public object this[int i]
        {
            get
            {
                return calculator[i];
            }
            set
            {
                calculator[i] = value;
            }
        }

        #endregion

        public IntPtr Ptr
        {
            get 
            {
                return calculator.Ptr;
            }
        }

        /// <summary>
        /// 默认构造函数
        /// </summary>
        public PinCalculationCache()
        {
        }

        /// <summary>
        /// 静态构造，只初始一次
        /// </summary>
        static PinCalculationCache()
        {
            dictType[typeof(int).MetadataToken] = TypeEnum.Int;
            dictType[typeof(bool).MetadataToken] = TypeEnum.Boolean;
            dictType[typeof(short).MetadataToken] = TypeEnum.Short;
            dictType[typeof(long).MetadataToken] = TypeEnum.Long;
            dictType[typeof(byte).MetadataToken] = TypeEnum.Byte;
            dictType[typeof(char).MetadataToken] = TypeEnum.Char;
            dictType[typeof(uint).MetadataToken] = TypeEnum.UInt;
            dictType[typeof(ushort).MetadataToken] = TypeEnum.UShort;
            dictType[typeof(ulong).MetadataToken] = TypeEnum.ULong;
            dictType[typeof(sbyte).MetadataToken] = TypeEnum.SByte;
            dictType[typeof(decimal).MetadataToken] = TypeEnum.Decimal;
            dictType[typeof(double).MetadataToken] = TypeEnum.Double;
            dictType[typeof(float).MetadataToken] = TypeEnum.Float;
            dictType[typeof(LA).MetadataToken] = TypeEnum.LA;
            dictType[typeof(LD).MetadataToken] = TypeEnum.LD;
            dictType[typeof(LP).MetadataToken] = TypeEnum.LP;
            dictType[typeof(LP32).MetadataToken] = TypeEnum.LP32;
            dictType[typeof(Seq_FeedBackPackPoint).MetadataToken] = TypeEnum.Seq_FeedBackPackPoint;
            dictType[typeof(Seq_LinkPackPoint).MetadataToken] = TypeEnum.Seq_LinkPackPoint;
            dictType[typeof(Seq_StepInPackPoint).MetadataToken] = TypeEnum.Seq_StepInPackPoint;
            dictType[typeof(Seq_FeedBackPackStruct).MetadataToken] = TypeEnum.Seq_FeedBackPackStruct;
            dictType[typeof(Seq_LinkPackStruct).MetadataToken] = TypeEnum.Seq_LinkPackStruct;
            dictType[typeof(Seq_StepInPackStruct).MetadataToken] = TypeEnum.Seq_StepInPackStruct; 
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="PinAddress">Pin对象地址</param>
        /// <param name="PinType">Pin类型</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="Exception"></exception>
        public PinCalculationCache(IntPtr PinAddress, Type PinType)
        {
            if (PinAddress == IntPtr.Zero)
                throw new ArgumentNullException("PinAddress", "不能为空！");
            if (PinType == null)
                throw new ArgumentNullException("PinType", "不能为空！");
            if (calculator == null)
            {
                if (PinType.IsEnum)
                    PinType = typeof(int);
                if (!CreateCalculator(PinAddress, PinType))
                {
                    throw new Exception("初始化算子失败！");
                }
            }
        }

        /// <summary>
        /// 创建算子
        /// </summary>
        /// <param name="PinAddress">Pin对象地址</param>
        /// <param name="PinType">Pin类型</param>
        /// <returns></returns>
        private bool CreateCalculator(IntPtr PinAddress, Type PinType)
        {
            if (!dictType.ContainsKey(PinType.MetadataToken))
                return false;
            TypeEnum t = dictType[PinType.MetadataToken];
            switch (t)
            {
                case TypeEnum.Int:
                    calculator = new IntCalculationCache(PinAddress);
                    break;
                case TypeEnum.Boolean:
                    calculator = new BooleanCalculationCache(PinAddress);
                    break;
                case TypeEnum.Short:
                    calculator = new ShortCalculationCache(PinAddress);
                    break;
                case TypeEnum.Long:
                    calculator = new LongCalculationCache(PinAddress);
                    break;
                case TypeEnum.Byte:
                    calculator = new ByteCalculationCache(PinAddress);
                    break;
                case TypeEnum.Char:
                    calculator = new CharCalculationCache(PinAddress);
                    break;
                case TypeEnum.UInt:
                    calculator = new UIntCalculationCache(PinAddress);
                    break;
                case TypeEnum.UShort:
                    calculator = new UShortCalculationCache(PinAddress);
                    break;
                case TypeEnum.ULong:
                    calculator = new ULongCalculationCache(PinAddress);
                    break;
                case TypeEnum.SByte:
                    calculator = new SByteCalculationCache(PinAddress);
                    break;
                case TypeEnum.Decimal:
                    calculator = new DecimalCalculationCache(PinAddress);
                    break;
                case TypeEnum.Double:
                    calculator = new DoubleCalculationCache(PinAddress);
                    break;
                case TypeEnum.Float:
                    calculator = new FloatCalculationCache(PinAddress);
                    break;
                case TypeEnum.LA:
                    calculator = new LACalculationCache(PinAddress);
                    break;
                case TypeEnum.LD:
                    calculator = new LDCalculationCache(PinAddress);
                    break;
                case TypeEnum.LP:
                    calculator = new LPCalculationCache(PinAddress);
                    break;
                case TypeEnum.LP32:
                    calculator = new LP32CalculationCache(PinAddress);
                    break;
                //case TypeEnum.Seq_FeedBackPackPoint:
                //    calculator = new Seq_FeedBackPackPointCalculationCache(PinAddress);
                //    break;
                //case TypeEnum.Seq_LinkPackPoint:
                //    calculator = new Seq_LinkPackPointCalculationCache(PinAddress);
                //    break;
                //case TypeEnum.Seq_StepInPackPoint:
                //    calculator = new Seq_StepInPackPointCalculationCache(PinAddress);
                //    break;

                case TypeEnum.Seq_FeedBackPackPoint:
                    calculator = new Seq_FeedBackPackPointCalculationCache(PinAddress);
                    break;
                case TypeEnum.Seq_FeedBackPackStruct:
                    calculator = new Seq_FeedBackPackStructCalculationCache(PinAddress);
                    break;
                case TypeEnum.Seq_LinkPackPoint:
                    calculator = new Seq_LinkPackPointCalculationCache(PinAddress);
                    break;
                case TypeEnum.Seq_LinkPackStruct:
                    calculator = new Seq_LinkPackStructCalculationCache(PinAddress);
                    break;
                case TypeEnum.Seq_StepInPackPoint:
                    calculator = new Seq_StepInPackPointCalculationCache(PinAddress);
                    break;
                case TypeEnum.Seq_StepInPackStruct:
                    calculator = new Seq_StepInPackStructCalculationCache(PinAddress);
                    break;
            }
            return true;
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            calculator.SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return calculator.GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return calculator.Value;
            }
            set
            {
                calculator.Value = value;
            }
        }

        #endregion
    }

    #region 内部算子

    internal unsafe class IntCalculationCache : IPinCalculationCache
    {
        private int* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is int)
                    *ptr = (int)value;
                else
                    *ptr = (int)((IConvertible)(value)).ToInt32(null);
            }
        }

        public IntCalculationCache(IntPtr PinAddress)
        {
            ptr = (int*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is int)
                    *ptr = (int)value;
                else
                    *ptr = (int)((IConvertible)(value)).ToInt32(null);
            }
        }

        #endregion

        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }

    }

    internal unsafe class BooleanCalculationCache : IPinCalculationCache
    {
        private bool* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is bool)
                    *ptr = (bool)value;
                else
                    *ptr = (bool)((IConvertible)(value)).ToBoolean(null);
            }
        }

        public BooleanCalculationCache(IntPtr PinAddress)
        {
            ptr = (bool*)PinAddress.ToPointer();
            
        }



        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is bool)
                    *ptr = (bool)value;
                else
                    *ptr = (bool)((IConvertible)(value)).ToBoolean(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class ShortCalculationCache : IPinCalculationCache
    {
        private short* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is short)
                    *ptr = (short)value;
                else
                    *ptr = (short)((IConvertible)(value)).ToInt16(null);
            }
        }

        public ShortCalculationCache(IntPtr PinAddress)
        {
            ptr = (short*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is short)
                    *ptr = (short)value;
                else
                    *ptr = (short)((IConvertible)(value)).ToInt16(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class LongCalculationCache : IPinCalculationCache
    {
        private long* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is long)
                    *ptr = (long)value;
                else
                    *ptr = (long)((IConvertible)(value)).ToInt64(null);
            }
        }

        public LongCalculationCache(IntPtr PinAddress)
        {
            ptr = (long*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is long)
                    *ptr = (long)value;
                else
                    *ptr = (long)((IConvertible)(value)).ToInt64(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class ByteCalculationCache : IPinCalculationCache
    {
        private byte* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is byte)
                    *ptr = (byte)value;
                else
                    *ptr = (byte)((IConvertible)(value)).ToByte(null);
            }
        }

        public ByteCalculationCache(IntPtr PinAddress)
        {
            ptr = (byte*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is byte)
                    *ptr = (byte)value;
                else
                    *ptr = (byte)((IConvertible)(value)).ToByte(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class CharCalculationCache : IPinCalculationCache
    {
        private char* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is char)
                    *ptr = (char)value;
                else
                    *ptr = (char)((IConvertible)(value)).ToChar(null);
            }
        }

        public CharCalculationCache(IntPtr PinAddress)
        {
            ptr = (char*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is char)
                    *ptr = (char)value;
                else
                    *ptr = (char)((IConvertible)(value)).ToChar(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class UIntCalculationCache : IPinCalculationCache
    {
        private uint* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is uint)
                    *ptr = (uint)value;
                else
                    *ptr = (uint)((IConvertible)(value)).ToUInt32(null);
            }
        }

        public UIntCalculationCache(IntPtr PinAddress)
        {
            ptr = (uint*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is uint)
                    *ptr = (uint)value;
                else
                    *ptr = (uint)((IConvertible)(value)).ToUInt32(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class UShortCalculationCache : IPinCalculationCache
    {
        private ushort* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is ushort)
                    *ptr = (ushort)value;
                else
                    *ptr = (ushort)((IConvertible)(value)).ToUInt16(null);
            }
        }

        public UShortCalculationCache(IntPtr PinAddress)
        {
            ptr = (ushort*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is ushort)
                    *ptr = (ushort)value;
                else
                    *ptr = (ushort)((IConvertible)(value)).ToUInt16(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class ULongCalculationCache : IPinCalculationCache
    {
        private ulong* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is ulong)
                    *ptr = (ulong)value;
                else
                    *ptr = (ulong)((IConvertible)(value)).ToUInt64(null);
            }
        }

        public ULongCalculationCache(IntPtr PinAddress)
        {
            ptr = (ulong*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is ulong)
                    *ptr = (ulong)value;
                else
                    *ptr = (ulong)((IConvertible)(value)).ToUInt64(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class SByteCalculationCache : IPinCalculationCache
    {
        private sbyte* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is sbyte)
                    *ptr = (sbyte)value;
                else
                    *ptr = (sbyte)((IConvertible)(value)).ToSByte(null);
            }
        }

        public SByteCalculationCache(IntPtr PinAddress)
        {
            ptr = (sbyte*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is sbyte)
                    *ptr = (sbyte)value;
                else
                    *ptr = (sbyte)((IConvertible)(value)).ToSByte(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class DecimalCalculationCache : IPinCalculationCache
    {
        private decimal* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is decimal)
                    *ptr = (decimal)value;
                else
                    *ptr = (decimal)((IConvertible)(value)).ToDecimal(null);
            }
        }

        public DecimalCalculationCache(IntPtr PinAddress)
        {
            ptr = (decimal*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is decimal)
                    *ptr = (decimal)value;
                else
                    *ptr = (decimal)((IConvertible)(value)).ToDecimal(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class DoubleCalculationCache : IPinCalculationCache
    {
        private double* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is double)
                    *ptr = (double)value;
                else
                    *ptr = (double)((IConvertible)(value)).ToDouble(null);
            }
        }

        public DoubleCalculationCache(IntPtr PinAddress)
        {
            ptr = (double*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is double)
                    *ptr = (double)value;
                else
                    *ptr = (double)((IConvertible)(value)).ToDouble(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class FloatCalculationCache : IPinCalculationCache
    {
        private float* ptr;

        public object this[int i]
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is float)
                    *ptr = (float)value;
                else
                    *ptr = (float)((IConvertible)(value)).ToSingle(null);
            }
        }

        public FloatCalculationCache(IntPtr PinAddress)
        {
            ptr = (float*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is float)
                    *ptr = (float)value;
                else
                    *ptr = (float)((IConvertible)(value)).ToSingle(null);
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class LACalculationCache : IPinCalculationCache
    {
        private LA* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public LACalculationCache(IntPtr PinAddress)
        {
            ptr = (LA*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class LDCalculationCache : IPinCalculationCache
    {
        private LD* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public LDCalculationCache(IntPtr PinAddress)
        {
            ptr = (LD*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class LPCalculationCache : IPinCalculationCache
    {
        private LP* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public LPCalculationCache(IntPtr PinAddress)
        {
            ptr = (LP*)PinAddress.ToPointer();
            
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class LP32CalculationCache : IPinCalculationCache
    {
        private LP32* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public LP32CalculationCache(IntPtr PinAddress)
        {
            ptr = (LP32*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_FeedBackPackPointCalculationCache : IPinCalculationCache
    {
        private Seq_FeedBackPackPoint* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public Seq_FeedBackPackPointCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_FeedBackPackPoint*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_LinkPackPointCalculationCache : IPinCalculationCache
    {
        private Seq_LinkPackPoint* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public Seq_LinkPackPointCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_LinkPackPoint*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_StepInPackPointCalculationCache : IPinCalculationCache
    {
        private Seq_StepInPackPoint* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr)[i];
            }
            set
            {
                (*ptr)[i] = value;
            }
        }

        public Seq_StepInPackPointCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_StepInPackPoint*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            ptr->SetMemberValue(value, names);
        }

        public object GetMemberValue(params string[] names)
        {
            return ptr->GetMemberValue(names);
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return ptr->Value;
            }
            set
            {
                ptr->Value = value;
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_FeedBackPackStructCalculationCache : IPinCalculationCache
    {
        private Seq_FeedBackPackStruct* ptr;

        public object this[int i]
        {
            get
            {
                return (*ptr);
            }
            set
            {
                if (value is Seq_FeedBackPackStruct)
                    *ptr = (Seq_FeedBackPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        public Seq_FeedBackPackStructCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_FeedBackPackStruct*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is Seq_FeedBackPackStruct)
                    *ptr = (Seq_FeedBackPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_LinkPackStructCalculationCache : IPinCalculationCache
    {
        private Seq_LinkPackStruct* ptr;

         public object this[int i]
        {
            get
            {
                return (*ptr);
            }
            set
            {
                if (value is Seq_LinkPackStruct)
                    *ptr = (Seq_LinkPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        public Seq_LinkPackStructCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_LinkPackStruct*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is Seq_LinkPackStruct)
                    *ptr = (Seq_LinkPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }

    internal unsafe class Seq_StepInPackStructCalculationCache : IPinCalculationCache
    {
        private Seq_StepInPackStruct* ptr;

         public object this[int i]
        {
            get
            {
                return (*ptr);
            }
            set
            {
                if (value is Seq_StepInPackStruct)
                    *ptr = (Seq_StepInPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        public Seq_StepInPackStructCalculationCache(IntPtr PinAddress)
        {
            ptr = (Seq_StepInPackStruct*)PinAddress.ToPointer();
        }

        #region IO 成员

        public void SetMemberValue(object value, params string[] names)
        {
            this.Value = value;
        }

        public object GetMemberValue(params string[] names)
        {
            return this.Value;
        }

        #endregion

        #region IValuable 成员

        public object Value
        {
            get
            {
                return *ptr;
            }
            set
            {
                if (value is Seq_StepInPackStruct)
                    *ptr = (Seq_StepInPackStruct)value;
                else
                    throw new Exception("此类型不支持类型转换");
            }
        }

        #endregion
        public IntPtr Ptr
        {
            get
            {
                return new IntPtr(ptr); ;
            }
        }
    }
    #endregion
}

