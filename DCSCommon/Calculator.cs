using System;
using System.Collections.Generic;
using System.Text;

namespace DCSCommon
{
    /// <summary>
    /// 运算的抽象模型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Calculator<T> : ICalculator<T> where T : struct, IComparable<T>, IConvertible
    {
        /// <summary>
        /// 默认算子
        /// </summary>
        private static ICalculator<T> defualtOperator = null;

        /// <summary>
        /// 锁对象
        /// </summary>
        private static object objLock = new object();
        
        /// <summary>
        /// 默认计算对象
        /// </summary>
        public static ICalculator<T> Defualt
        {
            get 
            {
                //单一模式，双锁
                if (defualtOperator == null)
                {
                    lock (objLock)
                    {
                        if (defualtOperator == null)
                        {
                            CreateOperator();
                        }
                    }
                }
                return defualtOperator; 
            }
        }

        /// <summary>
        /// 创建算子
        /// </summary>
        /// <returns></returns>
        private static void CreateOperator()
        {
            T a = (T)((IConvertible)(0)).ToType(typeof(T), null);//返回零或false
            TypeCode code = a.GetTypeCode();
            switch (code)
            {
                case TypeCode.Boolean:
                    defualtOperator = (ICalculator<T>)new BoolCalculator();
                    break;
                case TypeCode.Double:
                    defualtOperator = (ICalculator<T>)new DoubleCalculator();
                    break;
                case TypeCode.Int16:
                    defualtOperator = (ICalculator<T>)new ShortCalculator();
                    break;
                case TypeCode.Int32:
                    defualtOperator = (ICalculator<T>)new IntCalculator();
                    break;
                case TypeCode.Int64:
                    defualtOperator = (ICalculator<T>)new LongCalculator();
                    break;
                case TypeCode.Single:
                    defualtOperator = (ICalculator<T>)new FloatCalculator();
                    break;
                //default:
            }
        }

        #region ICalculator<T> Members

        #region 四则运算

        #region 加法器
        public abstract int Add(T a, int b);

        public abstract short Add(T a, short b);

        public abstract long Add(T a, long b);

        public abstract float Add(T a, float b);

        public abstract double Add(T a, double b);

        public abstract T Add(T a, bool b);

        public abstract T Add<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Add2(T a, T b);
        #endregion

        #region 减法器
        public abstract int Subtract(T a, int b);

        public abstract short Subtract(T a, short b);

        public abstract long Subtract(T a, long b);

        public abstract float Subtract(T a, float b);

        public abstract double Subtract(T a, double b);

        public abstract T Subtract(T a, bool b);

        public abstract T Subtract<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Subtract2(T a, T b);
        #endregion

        #region 乘法器
        public abstract int Multiply(T a, int b);

        public abstract short Multiply(T a, short b);

        public abstract long Multiply(T a, long b);

        public abstract float Multiply(T a, float b);

        public abstract double Multiply(T a, double b);

        public abstract T Multiply(T a, bool b);

        public abstract T Multiply<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Multiply2(T a, T b);
        #endregion

        #region 除法器
        public abstract int Division(T a, int b);

        public abstract short Division(T a, short b);

        public abstract long Division(T a, long b);

        public abstract float Division(T a, float b);

        public abstract double Division(T a, double b);

        public abstract T Division(T a, bool b);

        public abstract T Division<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Division2(T a, T b);
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public abstract bool GreaterThan(T a, int b);

        public abstract bool GreaterThan(T a, short b);

        public abstract bool GreaterThan(T a, long b);

        public abstract bool GreaterThan(T a, float b);

        public abstract bool GreaterThan(T a, double b);

        public abstract bool GreaterThan(T a, bool b);

        public abstract bool GreaterThan<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool GreaterThan2(T a, T b);
        #endregion

        #region 小于号
        public abstract bool LessThan(T a, int b);

        public abstract bool LessThan(T a, short b);

        public abstract bool LessThan(T a, long b);

        public abstract bool LessThan(T a, float b);

        public abstract bool LessThan(T a, double b);

        public abstract bool LessThan(T a, bool b);

        public abstract bool LessThan<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool LessThan2(T a, T b);
        #endregion

        #region 大于等于号
        public abstract bool GreaterEqual(T a, int b);

        public abstract bool GreaterEqual(T a, short b);

        public abstract bool GreaterEqual(T a, long b);

        public abstract bool GreaterEqual(T a, float b);

        public abstract bool GreaterEqual(T a, double b);

        public abstract bool GreaterEqual(T a, bool b);

        public abstract bool GreaterEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool GreaterEqual2(T a, T b);
        #endregion

        #region 小于等于号
        public abstract bool LessEqual(T a, int b);

        public abstract bool LessEqual(T a, short b);

        public abstract bool LessEqual(T a, long b);

        public abstract bool LessEqual(T a, float b);

        public abstract bool LessEqual(T a, double b);

        public abstract bool LessEqual(T a, bool b);

        public abstract bool LessEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool LessEqual2(T a, T b);
        #endregion

        #region 等于号
        public abstract bool Equal(T a, int b);

        public abstract bool Equal(T a, short b);

        public abstract bool Equal(T a, long b);

        public abstract bool Equal(T a, float b);

        public abstract bool Equal(T a, double b);

        public abstract bool Equal(T a, bool b);

        public abstract bool Equal<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool Equal2(T a, T b);
        #endregion

        #region 不等于号
        public abstract bool UnEqual(T a, int b);

        public abstract bool UnEqual(T a, short b);

        public abstract bool UnEqual(T a, long b);

        public abstract bool UnEqual(T a, float b);

        public abstract bool UnEqual(T a, double b);

        public abstract bool UnEqual(T a, bool b);

        public abstract bool UnEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract bool UnEqual2(T a, T b);
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public abstract int And(T a, int b);

        public abstract short And(T a, short b);

        public abstract long And(T a, long b);

        public abstract float And(T a, float b);

        public abstract double And(T a, double b);

        public abstract bool And(T a, bool b);

        public abstract T And<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T And2(T a, T b);
        #endregion

        #region 或运算
        public abstract int Or(T a, int b);

        public abstract short Or(T a, short b);

        public abstract long Or(T a, long b);

        public abstract float Or(T a, float b);

        public abstract double Or(T a, double b);

        public abstract bool Or(T a, bool b);

        public abstract T Or<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Or2(T a, T b);
        #endregion

        #region 异或运算
        public abstract int Xor(T a, int b);

        public abstract short Xor(T a, short b);

        public abstract long Xor(T a, long b);

        public abstract float Xor(T a, float b);

        public abstract double Xor(T a, double b);

        public abstract bool Xor(T a, bool b);

        public abstract T Xor<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Xor2(T a, T b);
        #endregion

        #region 反运算

        public abstract T Reverse(T a);

        #endregion

        #region 模运算
        public abstract int Mod(T a, int b);

        public abstract short Mod(T a, short b);

        public abstract long Mod(T a, long b);

        public abstract float Mod(T a, float b);

        public abstract double Mod(T a, double b);

        public abstract T Mod(T a, bool b);

        public abstract T Mod<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        public abstract T Mod2(T a, T b);
        #endregion

        #region 非运算

        public abstract T Not(T a);

        #endregion

        #endregion//布尔运算

        #endregion//ICalculator<T> Members
    }

    /// <summary>
    /// 单精度运算器
    /// </summary>
    internal unsafe class FloatCalculator : Calculator<float>
    {
        #region 四则运算

        #region 加法器
        public override int Add(float a, int b)
        {
            return (int)(a + b);
        }

        public override short Add(float a, short b)
        {
            return (short)(a + b);
        }

        public override long Add(float a, long b)
        {
            return (long)a + b;
        }

        public override float Add(float a, float b)
        {
            return a + b;
        }

        public override double Add(float a, double b)
        {
            return a + b;
        }

        public override float Add(float a, bool b)
        {
            if (b)
                return a + 1;
            else
                return a;
        }

        public override float Add<U>(float a, U b)
        {
            return a + b.ToSingle(null);
        }

        public override float Add2(float a, float b)
        {
            return a + b;
        }
        #endregion

        #region 减法器
        public override int Subtract(float a, int b)
        {
            return (int)(a - b);
        }

        public override short Subtract(float a, short b)
        {
            return (short)(a - b);
        }

        public override long Subtract(float a, long b)
        {
            return (long)a - b;
        }

        public override float Subtract(float a, float b)
        {
            return a - b;
        }

        public override double Subtract(float a, double b)
        {
            return a - b;
        }

        public override float Subtract(float a, bool b)
        {
            if (b)
                return a - 1;
            else
                return a;
        }

        public override float Subtract<U>(float a, U b)
        {
            return a - b.ToSingle(null);
        }

        public override float Subtract2(float a, float b)
        {
            return a - b;
        }
        #endregion

        #region 乘法器
        public override int Multiply(float a, int b)
        {
            return (int)(a * b);
        }

        public override short Multiply(float a, short b)
        {
            return (short)(a * b);
        }

        public override long Multiply(float a, long b)
        {
            return (long)a * b;
        }

        public override float Multiply(float a, float b)
        {
            return a * b;
        }

        public override double Multiply(float a, double b)
        {
            return a * b;
        }

        public override float Multiply(float a, bool b)
        {
            if (b)
                return a;
            else
                return 0;
        }

        public override float Multiply<U>(float a, U b)
        {
            return a * b.ToSingle(null);
        }

        public override float Multiply2(float a, float b)
        {
            return a * b;
        }
        #endregion

        #region 除法器
        public override int Division(float a, int b)
        {
            return (int)unchecked(a / b);
        }

        public override short Division(float a, short b)
        {
            return (short)unchecked(a / b);
        }

        public override long Division(float a, long b)
        {
            return unchecked((long)a / b);
        }

        public override float Division(float a, float b)
        {
            return unchecked(a / b);
        }

        public override double Division(float a, double b)
        {
            return unchecked(a / b);
        }

        public override float Division(float a, bool b)
        {
            if (b)
                return a;
            else
                return float.MaxValue;
        }

        public override float Division<U>(float a, U b)
        {
            return unchecked(a / b.ToSingle(null));
        }

        public override float Division2(float a, float b)
        {
            return unchecked(a / b);
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(float a, int b)
        {
            return a > b;
        }

        public override bool GreaterThan(float a, short b)
        {
            return a > b;
        }

        public override bool GreaterThan(float a, long b)
        {
            return a > b;
        }

        public override bool GreaterThan(float a, float b)
        {
            return a > b;
        }

        public override bool GreaterThan(float a, double b)
        {
            return a > b;
        }

        public override bool GreaterThan(float a, bool b)
        {
            if (b)
                return a > 1;
            else
                return a > 0;
        }

        public override bool GreaterThan<U>(float a, U b)
        {
            return a > b.ToDouble(null);
        }

        public override bool GreaterThan2(float a, float b)
        {
            return a > b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(float a, int b)
        {
            return a < b;
        }

        public override bool LessThan(float a, short b)
        {
            return a < b;
        }

        public override bool LessThan(float a, long b)
        {
            return a < b;
        }

        public override bool LessThan(float a, float b)
        {
            return a < b;
        }

        public override bool LessThan(float a, double b)
        {
            return a < b;
        }

        public override bool LessThan(float a, bool b)
        {
            if (b)
                return a < 1;
            else
                return a < 0;
        }

        public override bool LessThan<U>(float a, U b)
        {
            return a < b.ToDouble(null);
        }

        public override bool LessThan2(float a, float b)
        {
            return a < b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(float a, int b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(float a, short b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(float a, long b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(float a, float b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(float a, double b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(float a, bool b)
        {
            if (b)
                return a >= 1;
            else
                return a >= 0;
        }

        public override bool GreaterEqual<U>(float a, U b)
        {
            return a >= b.ToDouble(null);
        }

        public override bool GreaterEqual2(float a, float b)
        {
            return a >= b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(float a, int b)
        {
            return a <= b;
        }

        public override bool LessEqual(float a, short b)
        {
            return a <= b;
        }

        public override bool LessEqual(float a, long b)
        {
            return a <= b;
        }

        public override bool LessEqual(float a, float b)
        {
            return a <= b;
        }

        public override bool LessEqual(float a, double b)
        {
            return a <= b;
        }

        public override bool LessEqual(float a, bool b)
        {
            if (b)
                return a <= 1;
            else
                return a <= 0;
        }

        public override bool LessEqual<U>(float a, U b)
        {
            return a <= b.ToDouble(null);
        }

        public override bool LessEqual2(float a, float b)
        {
            return a <= b;
        }
        #endregion

        #region 等于号
        public override bool Equal(float a, int b)
        {
            return a == b;
        }

        public override bool Equal(float a, short b)
        {
            return a == b;
        }

        public override bool Equal(float a, long b)
        {
            return a == b;
        }

        public override bool Equal(float a, float b)
        {
            return a == b;
        }

        public override bool Equal(float a, double b)
        {
            return a == b;
        }

        public override bool Equal(float a, bool b)
        {
            if (b)
                return a == 1;
            else
                return a == 0;
        }

        public override bool Equal<U>(float a, U b)
        {
            return a == b.ToDouble(null);
        }

        public override bool Equal2(float a, float b)
        {
            return a == b;
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(float a, int b)
        {
            return a != b;
        }

        public override bool UnEqual(float a, short b)
        {
            return a != b;
        }

        public override bool UnEqual(float a, long b)
        {
            return a != b;
        }

        public override bool UnEqual(float a, float b)
        {
            return a != b;
        }

        public override bool UnEqual(float a, double b)
        {
            return a != b;
        }

        public override bool UnEqual(float a, bool b)
        {
            if (b)
                return a != 1;
            else
                return a != 0;
        }

        public override bool UnEqual<U>(float a, U b)
        {
            return a != b.ToDouble(null);
        }

        public override bool UnEqual2(float a, float b)
        {
            return a != b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(float a, int b)
        {
            int* ptr = (int*)(&a);
            return *ptr & b;
        }

        public override short And(float a, short b)
        {
            int* ptr = (int*)(&a);
            return (short)(*ptr & b);
        }

        public override long And(float a, long b)
        {
            int* ptr = (int*)(&a);
            return *ptr & b;
        }

        public override float And(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 & *ptr2;
            return b;
        }

        public override double And(float a, double b)
        {
            int* ptr1 = (int*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 & *ptr2;
            return b;
        }

        public override bool And(float a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) & b;
        }

        public override float And<U>(float a, U b)
        {
            float ft = b.ToSingle(null);
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&ft);
            *ptr2 = *ptr1 & *ptr2;
            return ft;
        }

        public override float And2(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 & *ptr2;
            return b;
        }
        #endregion

        #region 或运算
        public override int Or(float a, int b)
        {
            int* ptr = (int*)(&a);
            return *ptr | b;
        }

        public override short Or(float a, short b)
        {
            int* ptr = (int*)(&a);
            return (short)(*ptr | b);
        }

        public override long Or(float a, long b)
        {
            int* ptr = (int*)(&a);
            return *ptr | b;
        }

        public override float Or(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 | *ptr2;
            return b;
        }

        public override double Or(float a, double b)
        {
            int* ptr1 = (int*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 | *ptr2;
            return b;
        }

        public override bool Or(float a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) | b;
        }

        public override float Or<U>(float a, U b)
        {
            float ft = b.ToSingle(null);
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&ft);
            *ptr2 = *ptr1 | *ptr2;
            return ft;
        }

        public override float Or2(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 | *ptr2;
            return b;
        }
        #endregion

        #region 异或运算
        public override int Xor(float a, int b)
        {
            int* ptr = (int*)(&a);
            return *ptr ^ b;
        }

        public override short Xor(float a, short b)
        {
            int* ptr = (int*)(&a);
            return (short)(*ptr ^ b);
        }

        public override long Xor(float a, long b)
        {
            int* ptr = (int*)(&a);
            return *ptr ^ b;
        }

        public override float Xor(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 ^ *ptr2;
            return b;
        }

        public override double Xor(float a, double b)
        {
            int* ptr1 = (int*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 ^ *ptr2;
            return b;
        }

        public override bool Xor(float a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) ^ b;
        }

        public override float Xor<U>(float a, U b)
        {
            float ft = b.ToSingle(null);
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&ft);
            *ptr2 = *ptr1 ^ *ptr2;
            return ft;
        }

        public override float Xor2(float a, float b)
        {
            int* ptr1 = (int*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = *ptr1 ^ *ptr2;
            return b;
        }
        #endregion

        #region 反运算

        public override float Reverse(float a)
        {
            int* ptr = (int*)(&a);
            *ptr = ~*ptr;
            return a;
        }

        #endregion

        #region 模运算
        public override int Mod(float a, int b)
        {
            return (int)a % b;
        }

        public override short Mod(float a, short b)
        {
            return (short)((short)a % b);
        }

        public override long Mod(float a, long b)
        {
            return (long)a % b;
        }

        public override float Mod(float a, float b)
        {
            return a % b;
        }

        public override double Mod(float a, double b)
        {
            return a % b;
        }

        public override float Mod(float a, bool b)
        {
            if (b)
                return 0;
            else
                return a;
        }

        public override float Mod<U>(float a, U b)
        {
            return a % b.ToSingle(null);
        }

        public override float Mod2(float a, float b)
        {
            return a % b;
        }
        #endregion

        #region 非运算

        public override float Not(float a)
        {
            if (a != 0)
                return 0;
            else return 1;
        }

        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// 双精度运算器
    /// </summary>
    internal unsafe class DoubleCalculator : Calculator<double>
    {
        #region 四则运算

        #region 加法器
        public override int Add(double a, int b)
        {
            return (int)(a + b);
        }

        public override short Add(double a, short b)
        {
            return (short)(a + b);
        }

        public override long Add(double a, long b)
        {
            return (long)a + b;
        }

        public override float Add(double a, float b)
        {
            return (float)(a + b);
        }

        public override double Add(double a, double b)
        {
            return a + b;
        }

        public override double Add(double a, bool b)
        {
            if (b)
                return a + 1;
            else
                return a;
        }

        public override double Add<U>(double a, U b)
        {
            return a + b.ToDouble(null);
        }

        public override double Add2(double a, double b)
        {
            return a + b;
        }
        #endregion

        #region 减法器
        public override int Subtract(double a, int b)
        {
            return (int)(a - b);
        }

        public override short Subtract(double a, short b)
        {
            return (short)(a - b);
        }

        public override long Subtract(double a, long b)
        {
            return (long)a - b;
        }

        public override float Subtract(double a, float b)
        {
            return (float)(a - b);
        }

        public override double Subtract(double a, double b)
        {
            return a - b;
        }

        public override double Subtract(double a, bool b)
        {
            if (b)
                return a - 1;
            else
                return a;
        }

        public override double Subtract<U>(double a, U b)
        {
            return a - b.ToDouble(null);
        }

        public override double Subtract2(double a, double b)
        {
            return a - b;
        }
        #endregion

        #region 乘法器
        public override int Multiply(double a, int b)
        {
            return (int)(a * b);
        }

        public override short Multiply(double a, short b)
        {
            return (short)(a * b);
        }

        public override long Multiply(double a, long b)
        {
            return (long)a * b;
        }

        public override float Multiply(double a, float b)
        {
            return (float)(a * b);
        }

        public override double Multiply(double a, double b)
        {
            return a * b;
        }

        public override double Multiply(double a, bool b)
        {
            if (b)
                return a;
            else
                return 0;
        }

        public override double Multiply<U>(double a, U b)
        {
            return a * b.ToDouble(null);
        }

        public override double Multiply2(double a, double b)
        {
            return a * b;
        }
        #endregion

        #region 除法器
        public override int Division(double a, int b)
        {
            return (int)unchecked(a / b);
        }

        public override short Division(double a, short b)
        {
            return (short)unchecked(a / b);
        }

        public override long Division(double a, long b)
        {
            return unchecked((long)a / b);
        }

        public override float Division(double a, float b)
        {
            return (float)unchecked(a / b);
        }

        public override double Division(double a, double b)
        {
            return unchecked(a / b);
        }

        public override double Division(double a, bool b)
        {
            if (b)
                return a;
            else
                return double.MaxValue;
        }

        public override double Division<U>(double a, U b)
        {
            return unchecked(a / b.ToDouble(null));
        }

        public override double Division2(double a, double b)
        {
            return unchecked(a / b);
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(double a, int b)
        {
            return a > b;
        }

        public override bool GreaterThan(double a, short b)
        {
            return a > b;
        }

        public override bool GreaterThan(double a, long b)
        {
            return a > b;
        }

        public override bool GreaterThan(double a, float b)
        {
            return a > b;
        }

        public override bool GreaterThan(double a, double b)
        {
            return a > b;
        }

        public override bool GreaterThan(double a, bool b)
        {
            if (b)
                return a > 1;
            else
                return a > 0;
        }

        public override bool GreaterThan<U>(double a, U b)
        {
            return a > b.ToDouble(null);
        }

        public override bool GreaterThan2(double a, double b)
        {
            return a > b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(double a, int b)
        {
            return a < b;
        }

        public override bool LessThan(double a, short b)
        {
            return a < b;
        }

        public override bool LessThan(double a, long b)
        {
            return a < b;
        }

        public override bool LessThan(double a, float b)
        {
            return a < b;
        }

        public override bool LessThan(double a, double b)
        {
            return a < b;
        }

        public override bool LessThan(double a, bool b)
        {
            if (b)
                return a < 1;
            else
                return a < 0;
        }

        public override bool LessThan<U>(double a, U b)
        {
            return a < b.ToDouble(null);
        }

        public override bool LessThan2(double a, double b)
        {
            return a < b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(double a, int b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(double a, short b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(double a, long b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(double a, float b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(double a, double b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(double a, bool b)
        {
            if (b)
                return a >= 1;
            else
                return a >= 0;
        }

        public override bool GreaterEqual<U>(double a, U b)
        {
            return a >= b.ToDouble(null);
        }

        public override bool GreaterEqual2(double a, double b)
        {
            return a >= b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(double a, int b)
        {
            return a <= b;
        }

        public override bool LessEqual(double a, short b)
        {
            return a <= b;
        }

        public override bool LessEqual(double a, long b)
        {
            return a <= b;
        }

        public override bool LessEqual(double a, float b)
        {
            return a <= b;
        }

        public override bool LessEqual(double a, double b)
        {
            return a <= b;
        }

        public override bool LessEqual(double a, bool b)
        {
            if (b)
                return a <= 1;
            else
                return a <= 0;
        }

        public override bool LessEqual<U>(double a, U b)
        {
            return a <= b.ToDouble(null);
        }

        public override bool LessEqual2(double a, double b)
        {
            return a <= b;
        }
        #endregion

        #region 等于号
        public override bool Equal(double a, int b)
        {
            return a == b;
        }

        public override bool Equal(double a, short b)
        {
            return a == b;
        }

        public override bool Equal(double a, long b)
        {
            return a == b;
        }

        public override bool Equal(double a, float b)
        {
            return a == b;
        }

        public override bool Equal(double a, double b)
        {
            return a == b;
        }

        public override bool Equal(double a, bool b)
        {
            if (b)
                return a == 1;
            else
                return a == 0;
        }

        public override bool Equal<U>(double a, U b)
        {
            return a == b.ToDouble(null);
        }

        public override bool Equal2(double a, double b)
        {
            return a == b;
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(double a, int b)
        {
            return a != b;
        }

        public override bool UnEqual(double a, short b)
        {
            return a != b;
        }

        public override bool UnEqual(double a, long b)
        {
            return a != b;
        }

        public override bool UnEqual(double a, float b)
        {
            return a != b;
        }

        public override bool UnEqual(double a, double b)
        {
            return a != b;
        }

        public override bool UnEqual(double a, bool b)
        {
            if (b)
                return a != 1;
            else
                return a != 0;
        }

        public override bool UnEqual<U>(double a, U b)
        {
            return a != b.ToDouble(null);
        }

        public override bool UnEqual2(double a, double b)
        {
            return a != b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(double a, int b)
        {
            long* ptr = (long*)(&a);
            return (int)(*ptr & b);
        }

        public override short And(double a, short b)
        {
            long* ptr = (long*)(&a);
            return (short)(*ptr & b);
        }

        public override long And(double a, long b)
        {
            long* ptr = (long*)(&a);
            return *ptr & b;
        }

        public override float And(double a, float b)
        {
            long* ptr1 = (long*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = (int)(*ptr1 & *ptr2);
            return b;
        }

        public override double And(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 & *ptr2;
            return b;
        }

        public override bool And(double a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) & b;
        }

        public override double And<U>(double a, U b)
        {
            double ft = b.ToDouble(null);
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&ft);
            *ptr2 = *ptr1 & *ptr2;
            return ft;
        }

        public override double And2(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 & *ptr2;
            return b;
        }
        #endregion

        #region 或运算
        public override int Or(double a, int b)
        {
            long* ptr = (long*)(&a);
            return (int)(*ptr | b);
        }

        public override short Or(double a, short b)
        {
            long* ptr = (long*)(&a);
            return (short)(*ptr | b);
        }

        public override long Or(double a, long b)
        {
            long* ptr = (long*)(&a);
            return *ptr | b;
        }

        public override float Or(double a, float b)
        {
            long* ptr1 = (long*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = (int)(*ptr1 | *ptr2);
            return b;
        }

        public override double Or(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 | *ptr2;
            return b;
        }

        public override bool Or(double a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) | b;
        }

        public override double Or<U>(double a, U b)
        {
            double ft = b.ToDouble(null);
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&ft);
            *ptr2 = *ptr1 | *ptr2;
            return ft;
        }

        public override double Or2(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 | *ptr2;
            return b;
        }
        #endregion

        #region 异或运算
        public override int Xor(double a, int b)
        {
            long* ptr = (long*)(&a);
            return (int)(*ptr ^ b);
        }

        public override short Xor(double a, short b)
        {
            long* ptr = (long*)(&a);
            return (short)(*ptr ^ b);
        }

        public override long Xor(double a, long b)
        {
            long* ptr = (long*)(&a);
            return *ptr ^ b;
        }

        public override float Xor(double a, float b)
        {
            long* ptr1 = (long*)(&a);
            int* ptr2 = (int*)(&b);
            *ptr2 = (int)(*ptr1 ^ *ptr2);
            return b;
        }

        public override double Xor(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 ^ *ptr2;
            return b;
        }

        public override bool Xor(double a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) ^ b;
        }

        public override double Xor<U>(double a, U b)
        {
            double ft = b.ToDouble(null);
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&ft);
            *ptr2 = *ptr1 ^ *ptr2;
            return ft;
        }

        public override double Xor2(double a, double b)
        {
            long* ptr1 = (long*)(&a);
            long* ptr2 = (long*)(&b);
            *ptr2 = *ptr1 ^ *ptr2;
            return b;
        }
        #endregion

        #region 反运算

        public override double Reverse(double a)
        {
            long* ptr = (long*)(&a);
            *ptr = ~*ptr;
            return a;
        }

        #endregion

        #region 模运算
        public override int Mod(double a, int b)
        {
            return (int)a % b;
        }

        public override short Mod(double a, short b)
        {
            return (short)((short)a % b);
        }

        public override long Mod(double a, long b)
        {
            return (long)a % b;
        }

        public override float Mod(double a, float b)
        {
            return (float)(a % b);
        }

        public override double Mod(double a, double b)
        {
            return a % b;
        }

        public override double Mod(double a, bool b)
        {
            if (b)
                return 0;
            else
                return a;
        }

        public override double Mod<U>(double a, U b)
        {
            return a % b.ToDouble(null);
        }

        public override double Mod2(double a, double b)
        {
            return a % b;
        }
        #endregion

        #region 非运算

        public override double Not(double a)
        {
            if (a != 0)
                return 0;
            else return 1;
        }

        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// 整形运算器
    /// </summary>
    internal unsafe class IntCalculator : Calculator<int>
    {
        #region 四则运算

        #region 加法器
        public override int Add(int a, int b)
        {
            return a + b;
        }

        public override short Add(int a, short b)
        {
            return (short)(a + b);
        }

        public override long Add(int a, long b)
        {
            return a + b;
        }

        public override float Add(int a, float b)
        {
            return a + b;
        }

        public override double Add(int a, double b)
        {
            return a + b;
        }

        public override int Add(int a, bool b)
        {
            if (b)
                return a + 1;
            else
                return a;
        }

        public override int Add<U>(int a, U b)
        {
            return a + b.ToInt32(null);
        }

        public override int Add2(int a, int b)
        {
            return a + b;
        }
        #endregion

        #region 减法器
        public override int Subtract(int a, int b)
        {
            return a - b;
        }

        public override short Subtract(int a, short b)
        {
            return (short)(a - b);
        }

        public override long Subtract(int a, long b)
        {
            return a - b;
        }

        public override float Subtract(int a, float b)
        {
            return a - b;
        }

        public override double Subtract(int a, double b)
        {
            return a - b;
        }

        public override int Subtract(int a, bool b)
        {
            if (b)
                return a - 1;
            else
                return a;
        }

        public override int Subtract<U>(int a, U b)
        {
            return a - b.ToInt32(null);
        }

        public override int Subtract2(int a, int b)
        {
            return a - b;
        }
        #endregion

        #region 乘法器
        public override int Multiply(int a, int b)
        {
            return a * b;
        }

        public override short Multiply(int a, short b)
        {
            return (short)(a * b);
        }

        public override long Multiply(int a, long b)
        {
            return a * b;
        }

        public override float Multiply(int a, float b)
        {
            return a * b;
        }

        public override double Multiply(int a, double b)
        {
            return a * b;
        }

        public override int Multiply(int a, bool b)
        {
            if (b)
                return a;
            else
                return 0;
        }

        public override int Multiply<U>(int a, U b)
        {
            return a * b.ToInt32(null);
        }

        public override int Multiply2(int a, int b)
        {
            return a * b;
        }
        #endregion

        #region 除法器
        public override int Division(int a, int b)
        {
            return unchecked(a / b);
        }

        public override short Division(int a, short b)
        {
            return (short)unchecked(a / b);
        }

        public override long Division(int a, long b)
        {
            return unchecked(a / b);
        }

        public override float Division(int a, float b)
        {
            return unchecked(a / b);
        }

        public override double Division(int a, double b)
        {
            return unchecked(a / b);
        }

        public override int Division(int a, bool b)
        {
            if (b)
                return a;
            else
                return int.MaxValue;
        }

        public override int Division<U>(int a, U b)
        {
            return unchecked(a / b.ToInt32(null));
        }

        public override int Division2(int a, int b)
        {
            return unchecked(a / b);
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(int a, int b)
        {
            return a > b;
        }

        public override bool GreaterThan(int a, short b)
        {
            return a > b;
        }

        public override bool GreaterThan(int a, long b)
        {
            return a > b;
        }

        public override bool GreaterThan(int a, float b)
        {
            return a > b;
        }

        public override bool GreaterThan(int a, double b)
        {
            return a > b;
        }

        public override bool GreaterThan(int a, bool b)
        {
            if (b)
                return a > 1;
            else
                return a > 0;
        }

        public override bool GreaterThan<U>(int a, U b)
        {
            return a > b.ToDouble(null);
        }

        public override bool GreaterThan2(int a, int b)
        {
            return a > b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(int a, int b)
        {
            return a < b;
        }

        public override bool LessThan(int a, short b)
        {
            return a < b;
        }

        public override bool LessThan(int a, long b)
        {
            return a < b;
        }

        public override bool LessThan(int a, float b)
        {
            return a < b;
        }

        public override bool LessThan(int a, double b)
        {
            return a < b;
        }

        public override bool LessThan(int a, bool b)
        {
            if (b)
                return a < 1;
            else
                return a < 0;
        }

        public override bool LessThan<U>(int a, U b)
        {
            return a < b.ToDouble(null);
        }

        public override bool LessThan2(int a, int b)
        {
            return a < b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(int a, int b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(int a, short b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(int a, long b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(int a, float b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(int a, double b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(int a, bool b)
        {
            if (b)
                return a >= 1;
            else
                return a >= 0;
        }

        public override bool GreaterEqual<U>(int a, U b)
        {
            return a >= b.ToDouble(null);
        }

        public override bool GreaterEqual2(int a, int b)
        {
            return a >= b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(int a, int b)
        {
            return a <= b;
        }

        public override bool LessEqual(int a, short b)
        {
            return a <= b;
        }

        public override bool LessEqual(int a, long b)
        {
            return a <= b;
        }

        public override bool LessEqual(int a, float b)
        {
            return a <= b;
        }

        public override bool LessEqual(int a, double b)
        {
            return a <= b;
        }

        public override bool LessEqual(int a, bool b)
        {
            if (b)
                return a <= 1;
            else
                return a <= 0;
        }

        public override bool LessEqual<U>(int a, U b)
        {
            return a <= b.ToDouble(null);
        }

        public override bool LessEqual2(int a, int b)
        {
            return a <= b;
        }
        #endregion

        #region 等于号
        public override bool Equal(int a, int b)
        {
            return a == b;
        }

        public override bool Equal(int a, short b)
        {
            return a == b;
        }

        public override bool Equal(int a, long b)
        {
            return a == b;
        }

        public override bool Equal(int a, float b)
        {
            return a == b;
        }

        public override bool Equal(int a, double b)
        {
            return a == b;
        }

        public override bool Equal(int a, bool b)
        {
            if (b)
                return a == 1;
            else
                return a == 0;
        }

        public override bool Equal<U>(int a, U b)
        {
            return a == b.ToDouble(null);
        }

        public override bool Equal2(int a, int b)
        {
            return a == b;
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(int a, int b)
        {
            return a != b;
        }

        public override bool UnEqual(int a, short b)
        {
            return a != b;
        }

        public override bool UnEqual(int a, long b)
        {
            return a != b;
        }

        public override bool UnEqual(int a, float b)
        {
            return a != b;
        }

        public override bool UnEqual(int a, double b)
        {
            return a != b;
        }

        public override bool UnEqual(int a, bool b)
        {
            if (b)
                return a != 1;
            else
                return a != 0;
        }

        public override bool UnEqual<U>(int a, U b)
        {
            return a != b.ToDouble(null);
        }

        public override bool UnEqual2(int a, int b)
        {
            return a != b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(int a, int b)
        {
            return a & b;
        }

        public override short And(int a, short b)
        {
            return (short)(a & b);
        }

        public override long And(int a, long b)
        {
            return a & b;
        }

        public override float And(int a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a & *ptr;
            return b;
        }

        public override double And(int a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a & *ptr;
            return b;
        }

        public override bool And(int a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) & b;
        }

        public override int And<U>(int a, U b)
        {
            return a & b.ToInt32(null);
        }

        public override int And2(int a, int b)
        {
            return a & b;
        }
        #endregion

        #region 或运算
        public override int Or(int a, int b)
        {
            return a | b;
        }

        public override short Or(int a, short b)
        {
            return (short)(a | b);
        }

        public override long Or(int a, long b)
        {
            return a | b;
        }

        public override float Or(int a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a | *ptr;
            return b;
        }

        public override double Or(int a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a | *ptr;
            return b;
        }

        public override bool Or(int a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) | b;
        }

        public override int Or<U>(int a, U b)
        {
            return a | b.ToInt32(null);
        }

        public override int Or2(int a, int b)
        {
            return a | b;
        }
        #endregion

        #region 异或运算
        public override int Xor(int a, int b)
        {
            return a ^ b;
        }

        public override short Xor(int a, short b)
        {
            return (short)(a ^ b);
        }

        public override long Xor(int a, long b)
        {
            return a ^ b;
        }

        public override float Xor(int a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a ^ *ptr;
            return b;
        }

        public override double Xor(int a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a ^ *ptr;
            return b;
        }

        public override bool Xor(int a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) ^ b;
        }

        public override int Xor<U>(int a, U b)
        {
            return a ^ b.ToInt32(null);
        }

        public override int Xor2(int a, int b)
        {
            return a ^ b;
        }
        #endregion

        #region 反运算

        public override int Reverse(int a)
        {
            return ~a;
        }

        #endregion

        #region 模运算
        public override int Mod(int a, int b)
        {
            return a % b;
        }

        public override short Mod(int a, short b)
        {
            return (short)(a % b);
        }

        public override long Mod(int a, long b)
        {
            return a % b;
        }

        public override float Mod(int a, float b)
        {
            return a % b;
        }

        public override double Mod(int a, double b)
        {
            return a % b;
        }

        public override int Mod(int a, bool b)
        {
            if (b)
                return 0;
            else
                return a;
        }

        public override int Mod<U>(int a, U b)
        {
            return a % b.ToInt32(null);
        }

        public override int Mod2(int a, int b)
        {
            return a % b;
        }
        #endregion

        #region 非运算

        public override int Not(int a)
        {
            if (a != 0)
                return 0;
            else return 1;
        }

        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// 长整形运算器
    /// </summary>
    internal unsafe class LongCalculator : Calculator<long>
    {
        #region 四则运算

        #region 加法器
        public override int Add(long a, int b)
        {
            return (int)(a + b);
        }

        public override short Add(long a, short b)
        {
            return (short)(a + b);
        }

        public override long Add(long a, long b)
        {
            return a + b;
        }

        public override float Add(long a, float b)
        {
            return a + b;
        }

        public override double Add(long a, double b)
        {
            return a + b;
        }

        public override long Add(long a, bool b)
        {
            if (b)
                return a + 1;
            else
                return a;
        }

        public override long Add<U>(long a, U b)
        {
            return a + b.ToInt64(null);
        }

        public override long Add2(long a, long b)
        {
            return a + b;
        }
        #endregion

        #region 减法器
        public override int Subtract(long a, int b)
        {
            return (int)(a - b);
        }

        public override short Subtract(long a, short b)
        {
            return (short)(a - b);
        }

        public override long Subtract(long a, long b)
        {
            return a - b;
        }

        public override float Subtract(long a, float b)
        {
            return a - b;
        }

        public override double Subtract(long a, double b)
        {
            return a - b;
        }

        public override long Subtract(long a, bool b)
        {
            if (b)
                return a - 1;
            else
                return a;
        }

        public override long Subtract<U>(long a, U b)
        {
            return a - b.ToInt64(null);
        }

        public override long Subtract2(long a, long b)
        {
            return a - b;
        }
        #endregion

        #region 乘法器
        public override int Multiply(long a, int b)
        {
            return (int)(a * b);
        }

        public override short Multiply(long a, short b)
        {
            return (short)(a * b);
        }

        public override long Multiply(long a, long b)
        {
            return a * b;
        }

        public override float Multiply(long a, float b)
        {
            return a * b;
        }

        public override double Multiply(long a, double b)
        {
            return a * b;
        }

        public override long Multiply(long a, bool b)
        {
            if (b)
                return a;
            else
                return 0;
        }

        public override long Multiply<U>(long a, U b)
        {
            return a * b.ToInt64(null);
        }

        public override long Multiply2(long a, long b)
        {
            return a * b;
        }
        #endregion

        #region 除法器
        public override int Division(long a, int b)
        {
            return (int)unchecked(a / b);
        }

        public override short Division(long a, short b)
        {
            return (short)unchecked(a / b);
        }

        public override long Division(long a, long b)
        {
            return unchecked(a / b);
        }

        public override float Division(long a, float b)
        {
            return unchecked(a / b);
        }

        public override double Division(long a, double b)
        {
            return unchecked(a / b);
        }

        public override long Division(long a, bool b)
        {
            if (b)
                return a;
            else
                return long.MaxValue;
        }

        public override long Division<U>(long a, U b)
        {
            return unchecked(a / b.ToInt64(null));
        }

        public override long Division2(long a, long b)
        {
            return unchecked(a / b);
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(long a, int b)
        {
            return a > b;
        }

        public override bool GreaterThan(long a, short b)
        {
            return a > b;
        }

        public override bool GreaterThan(long a, long b)
        {
            return a > b;
        }

        public override bool GreaterThan(long a, float b)
        {
            return a > b;
        }

        public override bool GreaterThan(long a, double b)
        {
            return a > b;
        }

        public override bool GreaterThan(long a, bool b)
        {
            if (b)
                return a > 1;
            else
                return a > 0;
        }

        public override bool GreaterThan<U>(long a, U b)
        {
            return a > b.ToDouble(null);
        }

        public override bool GreaterThan2(long a, long b)
        {
            return a > b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(long a, int b)
        {
            return a < b;
        }

        public override bool LessThan(long a, short b)
        {
            return a < b;
        }

        public override bool LessThan(long a, long b)
        {
            return a < b;
        }

        public override bool LessThan(long a, float b)
        {
            return a < b;
        }

        public override bool LessThan(long a, double b)
        {
            return a < b;
        }

        public override bool LessThan(long a, bool b)
        {
            if (b)
                return a < 1;
            else
                return a < 0;
        }

        public override bool LessThan<U>(long a, U b)
        {
            return a < b.ToDouble(null);
        }

        public override bool LessThan2(long a, long b)
        {
            return a < b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(long a, int b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(long a, short b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(long a, long b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(long a, float b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(long a, double b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(long a, bool b)
        {
            if (b)
                return a >= 1;
            else
                return a >= 0;
        }

        public override bool GreaterEqual<U>(long a, U b)
        {
            return a >= b.ToDouble(null);
        }

        public override bool GreaterEqual2(long a, long b)
        {
            return a >= b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(long a, int b)
        {
            return a <= b;
        }

        public override bool LessEqual(long a, short b)
        {
            return a <= b;
        }

        public override bool LessEqual(long a, long b)
        {
            return a <= b;
        }

        public override bool LessEqual(long a, float b)
        {
            return a <= b;
        }

        public override bool LessEqual(long a, double b)
        {
            return a <= b;
        }

        public override bool LessEqual(long a, bool b)
        {
            if (b)
                return a <= 1;
            else
                return a <= 0;
        }

        public override bool LessEqual<U>(long a, U b)
        {
            return a <= b.ToDouble(null);
        }

        public override bool LessEqual2(long a, long b)
        {
            return a <= b;
        }
        #endregion

        #region 等于号
        public override bool Equal(long a, int b)
        {
            return a == b;
        }

        public override bool Equal(long a, short b)
        {
            return a == b;
        }

        public override bool Equal(long a, long b)
        {
            return a == b;
        }

        public override bool Equal(long a, float b)
        {
            return a == b;
        }

        public override bool Equal(long a, double b)
        {
            return a == b;
        }

        public override bool Equal(long a, bool b)
        {
            if (b)
                return a == 1;
            else
                return a == 0;
        }

        public override bool Equal<U>(long a, U b)
        {
            return a == b.ToDouble(null);
        }

        public override bool Equal2(long a, long b)
        {
            return a == b;
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(long a, int b)
        {
            return a != b;
        }

        public override bool UnEqual(long a, short b)
        {
            return a != b;
        }

        public override bool UnEqual(long a, long b)
        {
            return a != b;
        }

        public override bool UnEqual(long a, float b)
        {
            return a != b;
        }

        public override bool UnEqual(long a, double b)
        {
            return a != b;
        }

        public override bool UnEqual(long a, bool b)
        {
            if (b)
                return a != 1;
            else
                return a != 0;
        }

        public override bool UnEqual<U>(long a, U b)
        {
            return a != b.ToDouble(null);
        }

        public override bool UnEqual2(long a, long b)
        {
            return a != b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(long a, int b)
        {
            return (int)(a & b);
        }

        public override short And(long a, short b)
        {
            return (short)(a & b);
        }

        public override long And(long a, long b)
        {
            return a & b;
        }

        public override float And(long a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = (int)(a & *ptr);
            return b;
        }

        public override double And(long a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a & *ptr;
            return b;
        }

        public override bool And(long a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) & b;
        }

        public override long And<U>(long a, U b)
        {
            return a & b.ToInt64(null);
        }

        public override long And2(long a, long b)
        {
            return a & b;
        }
        #endregion

        #region 或运算
        public override int Or(long a, int b)
        {
            return (int)(a | b);
        }

        public override short Or(long a, short b)
        {
            return (short)(a | b);
        }

        public override long Or(long a, long b)
        {
            return a | b;
        }

        public override float Or(long a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = (int)(a | *ptr);
            return b;
        }

        public override double Or(long a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a | *ptr;
            return b;
        }

        public override bool Or(long a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) | b;
        }

        public override long Or<U>(long a, U b)
        {
            return a | b.ToInt64(null);
        }

        public override long Or2(long a, long b)
        {
            return a | b;
        }
        #endregion

        #region 异或运算
        public override int Xor(long a, int b)
        {
            return (int)(a ^ b);
        }

        public override short Xor(long a, short b)
        {
            return (short)(a ^ b);
        }

        public override long Xor(long a, long b)
        {
            return a ^ b;
        }

        public override float Xor(long a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = (int)(a ^ *ptr);
            return b;
        }

        public override double Xor(long a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a ^ *ptr;
            return b;
        }

        public override bool Xor(long a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) ^ b;
        }

        public override long Xor<U>(long a, U b)
        {
            return a ^ b.ToInt64(null);
        }

        public override long Xor2(long a, long b)
        {
            return a ^ b;
        }
        #endregion

        #region 反运算

        public override long Reverse(long a)
        {
            return ~a;
        }

        #endregion

        #region 模运算
        public override int Mod(long a, int b)
        {
            return (int)(a % b);
        }

        public override short Mod(long a, short b)
        {
            return (short)(a % b);
        }

        public override long Mod(long a, long b)
        {
            return a % b;
        }

        public override float Mod(long a, float b)
        {
            return a % b;
        }

        public override double Mod(long a, double b)
        {
            return a % b;
        }

        public override long Mod(long a, bool b)
        {
            if (b)
                return 0;
            else
                return a;
        }

        public override long Mod<U>(long a, U b)
        {
            return a % b.ToInt64(null);
        }

        public override long Mod2(long a, long b)
        {
            return a % b;
        }
        #endregion

        #region 非运算

        public override long Not(long a)
        {
            if (a != 0)
                return 0;
            else return 1;
        }

        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// 短整形运算器
    /// </summary>
    internal unsafe class ShortCalculator : Calculator<short>
    {
        #region 四则运算

        #region 加法器
        public override int Add(short a, int b)
        {
            return a + b;
        }

        public override short Add(short a, short b)
        {
            return (short)(a + b);
        }

        public override long Add(short a, long b)
        {
            return a + b;
        }

        public override float Add(short a, float b)
        {
            return a + b;
        }

        public override double Add(short a, double b)
        {
            return a + b;
        }

        public override short Add(short a, bool b)
        {
            if (b)
                return (short)(a + 1);
            else
                return a;
        }

        public override short Add<U>(short a, U b)
        {
            return (short)(a + b.ToInt16(null));
        }

        public override short Add2(short a, short b)
        {
            return (short)(a + b);
        }
        #endregion

        #region 减法器
        public override int Subtract(short a, int b)
        {
            return a - b;
        }

        public override short Subtract(short a, short b)
        {
            return (short)(a - b);
        }

        public override long Subtract(short a, long b)
        {
            return a - b;
        }

        public override float Subtract(short a, float b)
        {
            return a - b;
        }

        public override double Subtract(short a, double b)
        {
            return a - b;
        }

        public override short Subtract(short a, bool b)
        {
            if (b)
                return (short)(a - 1);
            else
                return a;
        }

        public override short Subtract<U>(short a, U b)
        {
            return (short)(a - b.ToInt16(null));
        }

        public override short Subtract2(short a, short b)
        {
            return (short)(a - b);
        }
        #endregion

        #region 乘法器
        public override int Multiply(short a, int b)
        {
            return a * b;
        }

        public override short Multiply(short a, short b)
        {
            return (short)(a * b);
        }

        public override long Multiply(short a, long b)
        {
            return a * b;
        }

        public override float Multiply(short a, float b)
        {
            return a * b;
        }

        public override double Multiply(short a, double b)
        {
            return a * b;
        }

        public override short Multiply(short a, bool b)
        {
            if (b)
                return a;
            else
                return 0;
        }

        public override short Multiply<U>(short a, U b)
        {
            return (short)(a * b.ToInt16(null));
        }

        public override short Multiply2(short a, short b)
        {
            return (short)(a * b);
        }
        #endregion

        #region 除法器
        public override int Division(short a, int b)
        {
            return unchecked(a / b);
        }

        public override short Division(short a, short b)
        {
            return (short)unchecked(a / b);
        }

        public override long Division(short a, long b)
        {
            return unchecked(a / b);
        }

        public override float Division(short a, float b)
        {
            return unchecked(a / b);
        }

        public override double Division(short a, double b)
        {
            return unchecked(a / b);
        }

        public override short Division(short a, bool b)
        {
            if (b)
                return a;
            else
                return short.MaxValue;
        }

        public override short Division<U>(short a, U b)
        {
            return (short)unchecked(a / b.ToInt16(null));
        }

        public override short Division2(short a, short b)
        {
            return (short)unchecked(a / b);
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(short a, int b)
        {
            return a > b;
        }

        public override bool GreaterThan(short a, short b)
        {
            return a > b;
        }

        public override bool GreaterThan(short a, long b)
        {
            return a > b;
        }

        public override bool GreaterThan(short a, float b)
        {
            return a > b;
        }

        public override bool GreaterThan(short a, double b)
        {
            return a > b;
        }

        public override bool GreaterThan(short a, bool b)
        {
            if (b)
                return a > 1;
            else
                return a > 0;
        }

        public override bool GreaterThan<U>(short a, U b)
        {
            return a > b.ToDouble(null);
        }

        public override bool GreaterThan2(short a, short b)
        {
            return a > b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(short a, int b)
        {
            return a < b;
        }

        public override bool LessThan(short a, short b)
        {
            return a < b;
        }

        public override bool LessThan(short a, long b)
        {
            return a < b;
        }

        public override bool LessThan(short a, float b)
        {
            return a < b;
        }

        public override bool LessThan(short a, double b)
        {
            return a < b;
        }

        public override bool LessThan(short a, bool b)
        {
            if (b)
                return a < 1;
            else
                return a < 0;
        }

        public override bool LessThan<U>(short a, U b)
        {
            return a < b.ToDouble(null);
        }

        public override bool LessThan2(short a, short b)
        {
            return a < b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(short a, int b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(short a, short b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(short a, long b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(short a, float b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(short a, double b)
        {
            return a >= b;
        }

        public override bool GreaterEqual(short a, bool b)
        {
            if (b)
                return a >= 1;
            else
                return a >= 0;
        }

        public override bool GreaterEqual<U>(short a, U b)
        {
            return a >= b.ToDouble(null);
        }

        public override bool GreaterEqual2(short a, short b)
        {
            return a >= b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(short a, int b)
        {
            return a <= b;
        }

        public override bool LessEqual(short a, short b)
        {
            return a <= b;
        }

        public override bool LessEqual(short a, long b)
        {
            return a <= b;
        }

        public override bool LessEqual(short a, float b)
        {
            return a <= b;
        }

        public override bool LessEqual(short a, double b)
        {
            return a <= b;
        }

        public override bool LessEqual(short a, bool b)
        {
            if (b)
                return a <= 1;
            else
                return a <= 0;
        }

        public override bool LessEqual<U>(short a, U b)
        {
            return a <= b.ToDouble(null);
        }

        public override bool LessEqual2(short a, short b)
        {
            return a <= b;
        }
        #endregion

        #region 等于号
        public override bool Equal(short a, int b)
        {
            return a == b;
        }

        public override bool Equal(short a, short b)
        {
            return a == b;
        }

        public override bool Equal(short a, long b)
        {
            return a == b;
        }

        public override bool Equal(short a, float b)
        {
            return a == b;
        }

        public override bool Equal(short a, double b)
        {
            return a == b;
        }

        public override bool Equal(short a, bool b)
        {
            if (b)
                return a == 1;
            else
                return a == 0;
        }

        public override bool Equal<U>(short a, U b)
        {
            return a == b.ToDouble(null);
        }

        public override bool Equal2(short a, short b)
        {
            return a == b;
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(short a, int b)
        {
            return a != b;
        }

        public override bool UnEqual(short a, short b)
        {
            return a != b;
        }

        public override bool UnEqual(short a, long b)
        {
            return a != b;
        }

        public override bool UnEqual(short a, float b)
        {
            return a != b;
        }

        public override bool UnEqual(short a, double b)
        {
            return a != b;
        }

        public override bool UnEqual(short a, bool b)
        {
            if (b)
                return a != 1;
            else
                return a != 0;
        }

        public override bool UnEqual<U>(short a, U b)
        {
            return a != b.ToDouble(null);
        }

        public override bool UnEqual2(short a, short b)
        {
            return a != b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(short a, int b)
        {
            return a & b;
        }

        public override short And(short a, short b)
        {
            return (short)(a & b);
        }

        public override long And(short a, long b)
        {
            return a & b;
        }

        public override float And(short a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a & *ptr;
            return b;
        }

        public override double And(short a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a & *ptr;
            return b;
        }

        public override bool And(short a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) & b;
        }

        public override short And<U>(short a, U b)
        {
            return (short)(a & b.ToInt16(null));
        }

        public override short And2(short a, short b)
        {
            return (short)(a & b);
        }
        #endregion

        #region 或运算
        public override int Or(short a, int b)
        {
            return a | b;
        }

        public override short Or(short a, short b)
        {
            return (short)(a | b);
        }

        public override long Or(short a, long b)
        {
            return a | b;
        }

        public override float Or(short a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a | *ptr;
            return b;
        }

        public override double Or(short a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a | *ptr;
            return b;
        }

        public override bool Or(short a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) | b;
        }

        public override short Or<U>(short a, U b)
        {
            return (short)(a | b.ToInt16(null));
        }

        public override short Or2(short a, short b)
        {
            return (short)(a | b);
        }
        #endregion

        #region 异或运算
        public override int Xor(short a, int b)
        {
            return a ^ b;
        }

        public override short Xor(short a, short b)
        {
            return (short)(a ^ b);
        }

        public override long Xor(short a, long b)
        {
            return a ^ b;
        }

        public override float Xor(short a, float b)
        {
            int* ptr = (int*)(&b);
            *ptr = a ^ *ptr;
            return b;
        }

        public override double Xor(short a, double b)
        {
            long* ptr = (long*)(&b);
            *ptr = a ^ *ptr;
            return b;
        }

        public override bool Xor(short a, bool b)
        {
            return ((IConvertible)(a)).ToBoolean(null) ^ b;
        }

        public override short Xor<U>(short a, U b)
        {
            return (short)(a ^ b.ToInt16(null));
        }

        public override short Xor2(short a, short b)
        {
            return (short)(a ^ b);
        }
        #endregion

        #region 反运算

        public override short Reverse(short a)
        {
            return (short)~a;
        }

        #endregion

        #region 模运算
        public override int Mod(short a, int b)
        {
            return a % b;
        }

        public override short Mod(short a, short b)
        {
            return (short)(a % b);
        }

        public override long Mod(short a, long b)
        {
            return a % b;
        }

        public override float Mod(short a, float b)
        {
            return a % b;
        }

        public override double Mod(short a, double b)
        {
            return a % b;
        }

        public override short Mod(short a, bool b)
        {
            if (b)
                return 0;
            else
                return a;
        }

        public override short Mod<U>(short a, U b)
        {
            return (short)(a % b.ToInt16(null));
        }

        public override short Mod2(short a, short b)
        {
            return (short)(a % b);
        }
        #endregion

        #region 非运算

        public override short Not(short a)
        {
            if (a != 0)
                return 0;
            else return 1;
        }

        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// 布尔运算器
    /// </summary>
    internal unsafe class BoolCalculator : Calculator<bool>
    {
        #region 四则运算

        #region 加法器
        public override int Add(bool a, int b)
        {
            if (a)
                return b + 1;
            else 
                return b;
        }

        public override short Add(bool a, short b)
        {
            if (a)
                return (short)(b + 1);
            else
                return b;
        }

        public override long Add(bool a, long b)
        {
            if (a)
                return b + 1;
            else
                return b;
        }

        public override float Add(bool a, float b)
        {
            if (a)
                return b + 1;
            else
                return b;
        }

        public override double Add(bool a, double b)
        {
            if (a)
                return b + 1;
            else
                return b;
        }

        public override bool Add(bool a, bool b)
        {
            return a ^ b;
        }

        public override bool Add<U>(bool a, U b)
        {
            return a ^ b.ToBoolean(null);
        }

        public override bool Add2(bool a, bool b)
        {
            return a ^ b;
        }
        #endregion

        #region 减法器
        public override int Subtract(bool a, int b)
        {
            if (a)
                return b - 1;
            else
                return b;
        }

        public override short Subtract(bool a, short b)
        {
            if (a)
                return (short)(b - 1);
            else
                return b;
        }

        public override long Subtract(bool a, long b)
        {
            if (a)
                return b - 1;
            else
                return b;
        }

        public override float Subtract(bool a, float b)
        {
            if (a)
                return b - 1;
            else
                return b;
        }

        public override double Subtract(bool a, double b)
        {
            if (a)
                return b - 1;
            else
                return b;
        }

        public override bool Subtract(bool a, bool b)
        {
            return a ^ b;
        }

        public override bool Subtract<U>(bool a, U b)
        {
            return a ^ b.ToBoolean(null);
        }

        public override bool Subtract2(bool a, bool b)
        {
            return a ^ b;
        }
        #endregion

        #region 乘法器
        public override int Multiply(bool a, int b)
        {
            if (a)
                return b;
            else
                return 0;
        }

        public override short Multiply(bool a, short b)
        {
            if (a)
                return b;
            else
                return 0;
        }

        public override long Multiply(bool a, long b)
        {
            if (a)
                return b;
            else
                return 0;
        }

        public override float Multiply(bool a, float b)
        {
            if (a)
                return b;
            else
                return 0;
        }

        public override double Multiply(bool a, double b)
        {
            if (a)
                return b;
            else
                return 0;
        }

        public override bool Multiply(bool a, bool b)
        {
            return a & b;
        }

        public override bool Multiply<U>(bool a, U b)
        {
            return a & b.ToBoolean(null);
        }

        public override bool Multiply2(bool a, bool b)
        {
            return a & b;
        }
        #endregion

        #region 除法器
        public override int Division(bool a, int b)
        {
            if (a)
                return 1 / b;
            else
                return 0;
        }

        public override short Division(bool a, short b)
        {
            if (a)
                return (short)(1 / b);
            else
                return 0;
        }

        public override long Division(bool a, long b)
        {
            if (a)
                return 1 / b;
            else
                return 0;
        }

        public override float Division(bool a, float b)
        {
            if (a)
                return 1 / b;
            else
                return 0;
        }

        public override double Division(bool a, double b)
        {
            if (a)
                return 1 / b;
            else
                return 0;
        }

        public override bool Division(bool a, bool b)
        {
            if (a & b)
                return true;
            else
                return false;
        }

        public override bool Division<U>(bool a, U b)
        {
            if (a & b.ToBoolean(null))
                return true;
            else
                return false;
        }

        public override bool Division2(bool a, bool b)
        {
            if (a & b)
                return true;
            else
                return false;
        }
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        public override bool GreaterThan(bool a, int b)
        {
            if (a)
                return b > 1;
            else
                return b > 0;
        }

        public override bool GreaterThan(bool a, short b)
        {
            if (a)
                return b > 1;
            else
                return b > 0;
        }

        public override bool GreaterThan(bool a, long b)
        {
            if (a)
                return b > 1;
            else
                return b > 0;
        }

        public override bool GreaterThan(bool a, float b)
        {
            if (a)
                return b > 1;
            else
                return b > 0;
        }

        public override bool GreaterThan(bool a, double b)
        {
            if (a)
                return b > 1;
            else
                return b > 0;
        }

        public override bool GreaterThan(bool a, bool b)
        {
            return a & !b;
        }

        public override bool GreaterThan<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) > 1;
            else
                return b.ToDouble(null) > 0;
        }

        public override bool GreaterThan2(bool a, bool b)
        {
            return a & !b;
        }
        #endregion

        #region 小于号
        public override bool LessThan(bool a, int b)
        {
            if (a)
                return b < 1;
            else
                return b < 0;
        }

        public override bool LessThan(bool a, short b)
        {
            if (a)
                return b < 1;
            else
                return b < 0;
        }

        public override bool LessThan(bool a, long b)
        {
            if (a)
                return b < 1;
            else
                return b < 0;
        }

        public override bool LessThan(bool a, float b)
        {
            if (a)
                return b < 1;
            else
                return b < 0;
        }

        public override bool LessThan(bool a, double b)
        {
            if (a)
                return b < 1;
            else
                return b < 0;
        }

        public override bool LessThan(bool a, bool b)
        {
            return !a & b;
        }

        public override bool LessThan<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) < 1;
            else
                return b.ToDouble(null) < 0;
        }

        public override bool LessThan2(bool a, bool b)
        {
            return !a & b;
        }
        #endregion

        #region 大于等于号
        public override bool GreaterEqual(bool a, int b)
        {
            if (a)
                return b >= 1;
            else
                return b >= 0;
        }

        public override bool GreaterEqual(bool a, short b)
        {
            if (a)
                return b >= 1;
            else
                return b >= 0;
        }

        public override bool GreaterEqual(bool a, long b)
        {
            if (a)
                return b >= 1;
            else
                return b >= 0;
        }

        public override bool GreaterEqual(bool a, float b)
        {
            if (a)
                return b >= 1;
            else
                return b >= 0;
        }

        public override bool GreaterEqual(bool a, double b)
        {
            if (a)
                return b >= 1;
            else
                return b >= 0;
        }

        public override bool GreaterEqual(bool a, bool b)
        {
            return a | !b;
        }

        public override bool GreaterEqual<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) >= 1;
            else
                return b.ToDouble(null) >= 0;
        }

        public override bool GreaterEqual2(bool a, bool b)
        {
            return a | !b;
        }
        #endregion

        #region 小于等于号
        public override bool LessEqual(bool a, int b)
        {
            if (a)
                return b <= 1;
            else
                return b <= 0;
        }

        public override bool LessEqual(bool a, short b)
        {
            if (a)
                return b <= 1;
            else
                return b <= 0;
        }

        public override bool LessEqual(bool a, long b)
        {
            if (a)
                return b <= 1;
            else
                return b <= 0;
        }

        public override bool LessEqual(bool a, float b)
        {
            if (a)
                return b <= 1;
            else
                return b <= 0;
        }

        public override bool LessEqual(bool a, double b)
        {
            if (a)
                return b <= 1;
            else
                return b <= 0;
        }

        public override bool LessEqual(bool a, bool b)
        {
            return !a | b;
        }

        public override bool LessEqual<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) <= 1;
            else
                return b.ToDouble(null) <= 0;
        }

        public override bool LessEqual2(bool a, bool b)
        {
            return !a | b;
        }
        #endregion

        #region 等于号
        public override bool Equal(bool a, int b)
        {
            if (a)
                return b == 1;
            else
                return b == 0;
        }

        public override bool Equal(bool a, short b)
        {
            if (a)
                return b == 1;
            else
                return b == 0;
        }

        public override bool Equal(bool a, long b)
        {
            if (a)
                return b == 1;
            else
                return b == 0;
        }

        public override bool Equal(bool a, float b)
        {
            if (a)
                return b == 1;
            else
                return b == 0;
        }

        public override bool Equal(bool a, double b)
        {
            if (a)
                return b == 1;
            else
                return b == 0;
        }

        public override bool Equal(bool a, bool b)
        {
            return !(a ^ b);
        }

        public override bool Equal<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) == 1;
            else
                return b.ToDouble(null) == 0;
        }

        public override bool Equal2(bool a, bool b)
        {
            return !(a ^ b);
        }
        #endregion

        #region 不等于号
        public override bool UnEqual(bool a, int b)
        {
            if (a)
                return b != 1;
            else
                return b != 0;
        }

        public override bool UnEqual(bool a, short b)
        {
            if (a)
                return b != 1;
            else
                return b != 0;
        }

        public override bool UnEqual(bool a, long b)
        {
            if (a)
                return b != 1;
            else
                return b != 0;
        }

        public override bool UnEqual(bool a, float b)
        {
            if (a)
                return b != 1;
            else
                return b != 0;
        }

        public override bool UnEqual(bool a, double b)
        {
            if (a)
                return b != 1;
            else
                return b != 0;
        }

        public override bool UnEqual(bool a, bool b)
        {
            return a ^ b;
        }

        public override bool UnEqual<U>(bool a, U b)
        {
            if (a)
                return b.ToDouble(null) != 1;
            else
                return b.ToDouble(null) != 0;
        }

        public override bool UnEqual2(bool a, bool b)
        {
            return a ^ b;
        }
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        public override int And(bool a, int b)
        {
            if (a)
                return b & 1;
            else
                return 0;
        }

        public override short And(bool a, short b)
        {
            if (a)
                return (short)(b & 1);
            else
                return 0;
        }

        public override long And(bool a, long b)
        {
            if (a)
                return b & 1;
            else
                return 0;
        }

        public override float And(bool a, float b)
        {  
            if (a)
            {
                int* ptr = (int*)(&b);
                *ptr = 1 & *ptr;
                return b;
            }
            else
                return 0;
        }

        public override double And(bool a, double b)
        {
            if (a)
            {
                long* ptr = (long*)(&b);
                *ptr = 1 & *ptr;
                return b;
            }
            else
                return 0;
        }

        public override bool And(bool a, bool b)
        {
            return a & b;
        }

        public override bool And<U>(bool a, U b)
        {
            return a & b.ToBoolean(null);
        }

        public override bool And2(bool a, bool b)
        {
            return a & b;
        }
        #endregion

        #region 或运算
        public override int Or(bool a, int b)
        {
            if (a)
                return b | 1;
            else
                return 0;
        }

        public override short Or(bool a, short b)
        {
            if (a)
                return (short)(b | 1);
            else
                return 0;
        }

        public override long Or(bool a, long b)
        {
            if (a)
                return b & 1;
            else
                return 0;
        }

        public override float Or(bool a, float b)
        {
            if (a)
            {
                int* ptr = (int*)(&b);
                *ptr = 1 | *ptr;
                return b;
            }
            else
                return b;
        }

        public override double Or(bool a, double b)
        {
            if (a)
            {
                long* ptr = (long*)(&b);
                *ptr = 1 | *ptr;
                return b;
            }
            else
                return b;
        }

        public override bool Or(bool a, bool b)
        {
            return a | b;
        }

        public override bool Or<U>(bool a, U b)
        {
            return a | b.ToBoolean(null);
        }

        public override bool Or2(bool a, bool b)
        {
            return a | b;
        }
        #endregion

        #region 异或运算
        public override int Xor(bool a, int b)
        {
            if (a)
                return b ^ 1;
            else
                return b ^ 0;
        }

        public override short Xor(bool a, short b)
        {
            if (a)
                return (short)(b ^ 1);
            else
                return (short)(b ^ 0);
        }

        public override long Xor(bool a, long b)
        {
            if (a)
                return b ^ 1;
            else
                return b ^ 0;
        }

        public override float Xor(bool a, float b)
        {
            int* ptr = (int*)(&b);
            if (a)
            {
                *ptr = 1 ^ *ptr;
            }
            else
                *ptr = 0 ^ *ptr;
            return b;
        }

        public override double Xor(bool a, double b)
        {
            long* ptr = (long*)(&b);
            if (a)
            {
                *ptr = 1 ^ *ptr;
            }
            else
                *ptr = 0 ^ *ptr;
            return b;
        }

        public override bool Xor(bool a, bool b)
        {
            return a ^ b;
        }

        public override bool Xor<U>(bool a, U b)
        {
            return a ^ b.ToBoolean(null);
        }

        public override bool Xor2(bool a, bool b)
        {
            return a ^ b;
        }
        #endregion

        #region 反运算

        public override bool Reverse(bool a)
        {
            return !a;
        }

        #endregion

        #region 模运算
        public override int Mod(bool a, int b)
        {
            if (a)
                return 0;
            else
                return b;
        }

        public override short Mod(bool a, short b)
        {
            if (a)
                return 0;
            else
                return b;
        }

        public override long Mod(bool a, long b)
        {
            if (a)
                return 0;
            else
                return b;
        }

        public override float Mod(bool a, float b)
        {
            if (a)
                return 0;
            else
                return b;
        }

        public override double Mod(bool a, double b)
        {
            if (a)
                return 0;
            else
                return b;
        }

        public override bool Mod(bool a, bool b)
        {
            if (b)
                return false;
            else
                return a;
        }

        public override bool Mod<U>(bool a, U b)
        {
            if (b.ToBoolean(null))
                return false;
            else
                return a;
        }

        public override bool Mod2(bool a, bool b)
        {
            if (b)
                return false;
            else
                return a;
        }
        #endregion

        #region 非运算

        public override bool Not(bool a)
        {
            return !a;
        }

        #endregion

        #endregion//布尔运算
    }
}
