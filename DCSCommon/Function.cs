/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：Function.cs
// 文件功能描述：功能码的抽象模型
// 
//
// 创建标识：赵明明200903
//
// 修改标识：
// 修改描述：
//
// 修改标识：
// 修改描述：
//----------------------------------------------------------------*/
using System.Runtime.InteropServices;

namespace DCSCommon
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Block)]
    [FCName("AbstractFunction")]
    [FCDisplay("功能码的抽象模型")]
    public abstract class Function
    {
        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块的名字")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 32)]
        public string FcName = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块的实例化名称")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
        public string InstanceName = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块的编码")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 20)]
        public string FcCode = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块的描述")]
        [MarshalAsAttribute(UnmanagedType.ByValArray, SizeConst = 50)]
        public string Description = "";

        [PinType(PinTypes.Constant)]
        [PinDisplay("算法块类型")]
        public enumType FcType = enumType.Base;

        [PinType(PinTypes.Constant)]
        [PinDisplay("sheetid")]
        public int SheetId = 0;


        [PinType(PinTypes.Internal)]
        [PinDisplay("计算状态")]
        public enumCalcType CalcStatus = enumCalcType.Normal;
        public enum enumCalcType
        {
            /// <summary>
            /// 正常
            /// </summary>
            Normal = 0,
            /// <summary>
            /// 错误
            /// </summary>
            Error = 1,
            /// <summary>
            /// 机组停机
            /// </summary>
            PlantStops = 2,
        }

        public enum enumType
        {
            /// <summary>
            /// 预警诊断
            /// </summary>
            Warn = 0,
            /// <summary>
            /// 基础块
            /// </summary>
            Base = 1,
            /// <summary>
            /// 故障输出
            /// </summary>
            FaultOut = 2,
            /// <summary>
            /// 二次计算
            /// </summary>
            SC = 3,
            /// <summary>
            /// 健康度
            /// </summary>
            Health = 4,
            /// <summary>
            /// 报警确认
            /// </summary>
            Ack,
            /// <summary>
            /// 工况寻优
            /// </summary>
            ICO,
        }

        /// <summary>
        /// 当前是否运行
        /// </summary>
        [PinType(PinTypes.Internal)]
        [PinDisplay("开关状态，是否运行")]
        protected bool runable = true;

        /// <summary>
        /// 命令实例
        /// </summary>
        private ICommand command = null;


        /// <summary>
        /// 获得或设置命令实例
        /// </summary>
        public virtual ICommand Command
        {
            get { return command; }
            set { command = value; }
        }

        /// <summary>
        /// 属性：FC是否可以执行
        /// </summary>
        public bool Runable
        {
            get { return runable; }
            set { runable = value; }
        }

        public string Name
        {
            get
            {
                Type t = this.GetType();
                string name = null;
                foreach (FCNameAttribute attribute in t.GetCustomAttributes(typeof(FCNameAttribute), false))
                {
                    if (attribute != null)
                    {
                        name += attribute.ToString();
                    }
                }
                return name;
            }
        }

        /// <summary>
        /// 用来FC重载，功能码执行函数
        /// </summary>
        protected abstract void Run(ICommand cmd);


        /// <summary>
        /// 第一次运行的初始化函数
        /// </summary>
        public virtual void FirstRun(ICommand cmd)
        {
           
        }

        /// <summary>
        /// 对外接口，运行函数
        /// </summary>
        public void Implement(ICommand cmd)
        {
            if (runable)
                Run(cmd);
        }

        /// <summary>
        /// 通过名称设置成员变量的值，使得对成员的赋值时，给功能码可以感知到，并做相应的业务。子类可以重载此函数完成更为复杂的逻辑
        /// </summary>
        /// <param name="value"></param>
        /// <param name="names"></param>
        public virtual void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            string temp;
            switch (names[0])
            {
                case "runable":
                    this.Runable = (bool)value;
                    break;
                case "FcName":
                    //this.FcName = value.ToString();
                    temp = value.ToString();
                    CopyString(ref this.FcName, ref temp);
                    break;
                case "FcCode":
                    //this.FcCode = value.ToString();
                    temp = value.ToString();
                    CopyString(ref this.FcCode, ref temp);
                    break;
            }
        }

        /// <summary>
        /// 拷贝字符串
        /// </summary>
        /// <param name="Target"></param>
        /// <param name="Source"></param>
        /// <param name="Capability"></param>
        private unsafe void CopyString(ref string Target, ref string Source)
        {
            GCHandle handle1 = GCHandle.Alloc(Target, GCHandleType.Normal);
            GCHandle handle2 = GCHandle.Alloc(Source, GCHandleType.Normal);

            IntPtr ptr1 = GCHandle.ToIntPtr(handle1);
            int* handlePtr1 = (int*)ptr1.ToPointer();
            handlePtr1 = (int*)(*handlePtr1);

            IntPtr ptr2 = GCHandle.ToIntPtr(handle2);
            int* handlePtr2 = (int*)ptr2.ToPointer();
            handlePtr2 = (int*)(*handlePtr2);

            handlePtr1++;
            int capability = *handlePtr1;
            handlePtr2 += 2;
            int count = *handlePtr2;

            //防止容量不够
            if (capability <= 1)//windows操作系统New出的对象，否则RTD系统New出的对象
            {
                Target = Source;
                handle1.Free();
                handle2.Free();
                return;
            }

            count = Math.Min(count, capability - 1);
            handlePtr1++;
            short* sh1 = (short*)handlePtr1;
            short* sh2 = (short*)handlePtr2;
            for (int i = 0; i < count + 3; i++)
                *(sh1 + i) = *(sh2 + i);
            handle1.Free();
            handle2.Free();
        }

        /// <summary>
        /// 通过名称读取成员变量的值。子类可以重载此函数完成更为复杂的逻辑
        /// </summary>
        /// <param name="names"></param>
        public virtual object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "runable":
                    return this.Runable;
                case "FcName":
                    return this.FcName;
                case "FcCode":
                    return this.FcCode;
                default:
                    return null;
            }
        }
    }

    /// <summary>
    /// 管脚细节信息
    /// </summary>
    public class PinDetails<T> : IPinDetails
    {
        private T defaultvalue;
        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue
        {
            get { return defaultvalue; }
            set { defaultvalue = (T)value; }
        }

        private T maxvalue;
        /// <summary>
        /// 最大值
        /// </summary>
        public object MaxValue
        {
            get { return maxvalue; }
            set { maxvalue = (T)value; }
        }

        private T minvalue;
        /// <summary>
        /// 最小值
        /// </summary>
        public object MinValue
        {
            get { return minvalue; }
            set { minvalue = (T)value; }
        }

        private bool tune;
        /// <summary>
        /// 是否可调
        /// </summary>
        public bool Tune
        {
            get { return tune; }
            set { tune = value; }
        }

        private bool required;
        /// <summary>
        /// 是否必要
        /// </summary>
        public bool Required
        {
            get { return required; }
            set { required = value; }
        }

        private bool fix;
        /// <summary>
        /// 地址是否绑定，不用分配
        /// </summary>
        public bool Fixed
        {
            get { return fix; }
            set { fix = value; }
        }

        private bool reverse;
        /// <summary>
        /// 是否反转运算
        /// </summary>
        public bool Reverse
        {
            get { return reverse; }
            set { reverse = value; }
        }

        private bool hasdefualtvalue;

        /// <summary>
        /// 是否拥有默认值
        /// </summary>
        public bool HasDefualtValue
        {
            get { return hasdefualtvalue; }
        }

        private string pointname;
        /// <summary>
        /// 连接的Point名称
        /// </summary>
        public string PointName
        {
            get { return pointname; }
            set
            {
                pointname = value;
                AnalysePointName();
            }
        }

        public PinDetails()
        {
            tune = false;
            required = false;
            fix = false;
            hasdefualtvalue = false;
            reverse = false;
        }

        public PinDetails(string PointName)
            : this()
        {
            pointname = PointName;
            AnalysePointName();
        }

        public PinDetails(T DefaultValue)
            : this()
        {
            defaultvalue = DefaultValue;
            hasdefualtvalue = true;
        }

        public PinDetails(string PointName, T DefaultValue)
            : this(PointName)
        {
            defaultvalue = DefaultValue;
            hasdefualtvalue = true;
        }

        public PinDetails(T DefaultValue, T MaxValue, T MinVaue)
            : this()
        {
            defaultvalue = DefaultValue;
            maxvalue = MaxValue;
            minvalue = MinVaue;
            hasdefualtvalue = true;
        }

        public PinDetails(string PointName, T DefaultValue, T MaxValue, T MinVaue)
            : this(DefaultValue, MaxValue, MinVaue)
        {
            pointname = PointName;
            AnalysePointName();
        }

        public PinDetails(T DefaultValue, T MaxValue, T MinVaue, bool Tune, bool Required, bool Fixed)
        {
            defaultvalue = DefaultValue;
            maxvalue = MaxValue;
            minvalue = MinVaue;
            tune = Tune;
            required = Required;
            fix = Fixed;
            hasdefualtvalue = true;
        }

        public PinDetails(string PointName, T DefaultValue, T MaxValue, T MinVaue, bool Tune, bool Required, bool Fixed)
            : this(DefaultValue, MaxValue, MinVaue, Tune, Required, Fixed)
        {
            pointname = PointName;
            AnalysePointName();
        }

        /// <summary>
        /// 分析点名，判断是否需要反转
        /// </summary> 
        private void AnalysePointName()
        {
            if (string.IsNullOrEmpty(pointname))
                return;

            if (PointName.Contains(","))
            {
                reverse = false;
            }
            else
            {
                if (pointname.Contains("~"))
                {
                    reverse = true;
                    pointname = pointname.Replace("~", "");
                }
                else
                    reverse = false;
            }
        }
        //public PinDetails(string PointName, bool Reverse)
        //    : this(PointName)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(T DefaultValue, bool Reverse)
        //    : this(DefaultValue)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(string PointName, T DefaultValue, bool Reverse)
        //    : this(PointName, DefaultValue)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(T DefaultValue, T MaxValue, T MinVaue, bool Reverse)
        //    : this(DefaultValue, MaxValue, MinVaue)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(string PointName, T DefaultValue, T MaxValue, T MinVaue, bool Reverse)
        //    : this(PointName, DefaultValue, MaxValue, MinVaue)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(T DefaultValue, T MaxValue, T MinVaue, bool Tune, bool Required, bool Fixed, bool Reverse)
        //    : this(DefaultValue, MaxValue, MinVaue, Tune, Required, Fixed)
        //{
        //    reverse = Reverse;
        //}

        //public PinDetails(string PointName, T DefaultValue, T MaxValue, T MinVaue, bool Tune, bool Required, bool Fixed, bool Reverse)
        //    : this(PointName, DefaultValue, MaxValue, MinVaue, Tune, Required, Fixed)
        //{
        //    reverse = Reverse;
        //}
    }

    /// <summary>
    /// 点细节信息
    /// </summary>
    public class PointDetails<T> : IPointDetails
    {
        private T defaultvalue;
        /// <summary>
        /// 默认值
        /// </summary>
        public object DefaultValue
        {
            get { return defaultvalue; }
            set { defaultvalue = (T)value; }
        }

        private T maxvalue;
        /// <summary>
        /// 最大值
        /// </summary>
        public object MaxValue
        {
            get { return maxvalue; }
            set { maxvalue = (T)value; }
        }

        private T minvalue;
        /// <summary>
        /// 最小值
        /// </summary>
        public object MinValue
        {
            get { return minvalue; }
            set { minvalue = (T)value; }
        }

        private T forcevalue;
        /// <summary>
        /// 强制值
        /// </summary>
        public object ForceValue
        {
            get { return forcevalue; }
            set { forcevalue = (T)value; }
        }

        private bool isforced;
        /// <summary>
        /// 是否强制
        /// </summary>
        public bool IsForced
        {
            get { return isforced; }
            set { isforced = value; }
        }

        private string typename;
        /// <summary>
        /// 类型名称
        /// </summary>
        public string TypeName
        {
            get { return typename; }
            set { typename = value; }
        }

        private string pointname;
        /// <summary>
        /// Point名称
        /// </summary>
        public string PointName
        {
            get { return pointname; }
            set { pointname = value; }
        }

        public PointDetails()
        {
            isforced = false;
        }

        public PointDetails(string PointName, string TypeName)
            : this()
        {
            pointname = PointName;
            typename = TypeName;
        }

        public PointDetails(string PointName, string TypeName, T DefaultValue, T MaxValue, T MinVaue, T ForceValue)
            : this(PointName, TypeName)
        {
            defaultvalue = DefaultValue;
            maxvalue = MaxValue;
            minvalue = MinVaue;
            forcevalue = ForceValue;
        }

        public PointDetails(string PointName, string TypeName, T DefaultValue, T MaxValue, T MinVaue, T ForceValue, bool IsFoced)
            : this(PointName, TypeName, DefaultValue, MaxValue, MinVaue, ForceValue)
        {
            isforced = IsFoced;
        }
    }
}
