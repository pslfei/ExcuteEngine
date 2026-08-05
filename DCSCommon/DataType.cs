using System;
using System.Collections.Generic;
using System.Collections;
using System.Text;
using System.Runtime.InteropServices;
using System.Reflection;


namespace DCSCommon
{
    /// <summary>
    /// 通信数据
    /// </summary>
    [Serializable]
    public class TrafficData
    {
        /// <summary>
        /// 系统域标识
        /// </summary>
        private long fsid;

        /// <summary>
        /// 设置或读取FSID
        /// </summary>
        public long FSID
        {
            get { return fsid; }
            set { fsid = value; }
        }

        /// <summary>
        /// 数据
        /// </summary>
        private object data;

        /// <summary>
        /// 设置或读取数据
        /// </summary>
        public object Data
        {
            get { return data; }
            set { data = value; }
        }

        public TrafficData()
        {
            fsid = -1;
            data = null;
        }

        public TrafficData(long FSID, object Data)
        {
            this.fsid = FSID;
            this.data = Data;
        }
    }

    /// <summary>
    /// 租用参数
    /// </summary>
    [Serializable]
    public class LeaseParams
    {
        /// <summary>
        /// 系统域标识
        /// </summary>
        public long fsid;

        /// <summary>
        /// 变量类别
        /// </summary>
        public VariableClass varClass;

        /// <summary>
        /// 类型名称
        /// </summary>
        public string typeName;

        /// <summary>
        /// 成员偏移表
        /// </summary>
        public List<uint> offsets;

        /// <summary>
        /// 成员域标识表
        /// </summary>
        public List<long> fsids;

        public LeaseParams(long FSID, VariableClass Class, string TypeName)
        {
            fsid = FSID;
            varClass = Class;
            typeName = TypeName;
            offsets = null;
            fsids = null;
        }
    }

    /// <summary>
    /// 通知数据
    /// </summary>
    [Serializable]
    public struct InformData
    {
        /// <summary>
        /// 系统域标识
        /// </summary>
        public long fsid;

        /// <summary>
        /// 更新数据
        /// </summary>
        public object data;

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="FSID"></param>
        /// <param name="Data"></param>
        public InformData(long FSID, object Data)
        {
            fsid = FSID;
            data = Data;
        }
    }

    /// <summary>
    /// 通知刷新事件参数
    /// </summary>
    public class InformRefreshArgs : EventArgs
    {
        /// <summary>
        /// 需要通知的数据
        /// </summary>
        private InformData[] datas = null;

        /// <summary>
        /// 获取通知数据
        /// </summary>
        public InformData[] Datas
        {
            get { return datas; }
        }

        /// <summary>
        /// 构造函数
        /// </summary>
        /// <param name="Datas">通知的数据</param>
        public InformRefreshArgs(InformData[] Datas)
        {
            datas = Datas;
        }
    }

    /// <summary>
    /// 分配SID资源的结构体
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [Serializable]
    public struct AllocSIDResource
    {
        /// <summary>
        /// 基地址
        /// </summary>
        public int baseSID;

        /// <summary>
        /// 预分配个数
        /// </summary>
        public uint preAllocNum;

        public AllocSIDResource(int BaseSID, uint PreAllocNum)
        {
            baseSID = BaseSID;
            preAllocNum = PreAllocNum;
        }
    }

    /// <summary>
    /// 变量地址
    /// </summary>
    [Serializable]
    public struct VariableAddress
    {
        /// <summary>
        /// RTD系统中的地址标号
        /// </summary>
        private int sid;

        /// <summary>
        /// 设置或读取地址标号
        /// </summary>
        public int Sid
        {
            get { return sid; }
            set { sid = value; }
        }

        /// <summary>
        /// 地址偏移量
        /// </summary>
        private uint offset;

        /// <summary>
        /// 设置或读取偏移量
        /// </summary>
        public uint Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        /// <summary>
        /// 变量的内存长度(单位：字节)
        /// </summary>
        private ushort length;

        /// <summary>
        /// 读取变量长度(单位：字节)
        /// </summary>
        public ushort Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// 如果是引用类型，其父类型位移
        /// </summary>
        private uint parentOffset;

        public uint ParentOffset
        {
            get { return parentOffset; }
            set { parentOffset = value; }
        }

        /// <summary>
        /// 空地址
        /// </summary>
        public static VariableAddress Empty
        {
            get
            {
                return new VariableAddress(-1, 0, 0, 0);
            }
        }

        public static bool operator ==(VariableAddress address1, VariableAddress address2)
        {
            if (address1.GetHashCode() == address2.GetHashCode())
                return true;
            else return false;
        }

        public static bool operator !=(VariableAddress address1, VariableAddress address2)
        {
            if (address1.GetHashCode() != address2.GetHashCode())
                return true;
            else return false;
        }

        /// <summary>
        /// 变量地址初始化函数。注意：RTD需检查Sid、Offset和Length的有效性
        /// </summary>
        /// <param name="Sid">变量所在Piont的SID</param>
        /// <param name="Offset">变量偏移</param>
        /// <param name="Length">变量长度</param>
        public VariableAddress(int Sid, uint Offset, ushort Length)
        // : this()
        {
            this.sid = Sid;
            this.offset = Offset;
            this.length = Length;
            this.parentOffset = 0;
        }

        /// <summary>
        /// 变量地址初始化函数。注意：RTD需检查Sid、Offset和Length的有效性
        /// </summary>
        /// <param name="Sid">变量所在Piont的SID</param>
        /// <param name="Offset">变量偏移</param>
        /// <param name="ParentOffset">针对引用类型，其父类型的偏移</param>
        /// <param name="Length">变量长度</param>
        public VariableAddress(int Sid, uint Offset, uint ParentOffset, ushort Length)
        // : this()
        {
            this.sid = Sid;
            this.offset = Offset;
            this.parentOffset = ParentOffset;
            this.length = Length;
        }

        //public VariableAddress()
        //{
        //    sid = -1;
        //    offset = 0;
        //    length = 0;
        //}

        #region Object方法重写

        // 重写 Object.Equals(object o) 方法:
        public override bool Equals(object o)//o可能为空
        {
            try
            {
                if (o == null)
                    return false;
                if (this.GetHashCode() == o.GetHashCode())
                    return true;
                else return false;
            }
            catch
            {
                return false;
            }
        }

        // 重写 Object.GetHashCode() 方法:
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        #endregion
    }

    public unsafe class TypeManageItem
    {
        /// <summary>
        /// 类型
        /// </summary>
        private Type type = null;

        /// <summary>
        /// 获得或设置成员个数
        /// </summary>
        private uint memberNum = 0;

        /// <summary>
        /// 成员个数
        /// </summary>
        public uint MemberNum
        {
            get { return memberNum; }
            set { memberNum = value; }
        }

        /// <summary>
        /// 该类型所占的字节数长度
        /// </summary>
        private uint length = 0;

        /// <summary>
        /// 获得或设置该类型所占的字节数长度
        /// </summary>
        public uint Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// 变量类别
        /// </summary>
        private VariableClass Class = VariableClass.Point;

        /// <summary>
        /// 获得或设置变量类别
        /// </summary>
        public VariableClass VarClass
        {
            get { return Class; }
            set { Class = value; }
        }

        /// <summary>
        /// 描述信息
        /// </summary>
        private string display = "";

        /// <summary>
        /// 获得或设置描述信息
        /// </summary>
        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        /// <summary>
        /// 偏移量子表的ID号，通过该ID可以获得到记录以偏移量为表索引的所有成员信息表
        /// </summary>
        private int offsetChildTableID = -1;

        /// <summary>
        /// 获得或设置偏移量子表的ID号，通过该ID可以获得到记录以偏移量为表索引的所有成员信息表
        /// </summary>
        public int OffsetChildTableID
        {
            get { return offsetChildTableID; }
            set { offsetChildTableID = value; }
        }

        /// <summary>
        /// 名称子表的ID号，通过该ID可以获得到记录以名称为表索引的所有成员信息表
        /// </summary>
        private int nameChildTableID = -1;

        /// <summary>
        /// 获得或设置名称子表的ID号，通过该ID可以获得到记录以名称为表索引的所有成员信息表
        /// </summary>
        public int NameChildTableID
        {
            get { return nameChildTableID; }
            set { nameChildTableID = value; }
        }

        /// <summary>
        /// 显示的类型名
        /// </summary>
        private string typeName = "";

        /// <summary>
        /// 设置或读取显示的类型名
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        /// <summary>
        /// 对象句柄地址
        /// </summary>
        private int* handlePtr = (int*)0;

        /// <summary>
        /// 记录上次句柄持有的对象句柄
        /// </summary>
        private unsafe int LastObjAddress
        {
            get
            {
                return *handlePtr;
            }
        }

        /// <summary>
        /// 对象句柄
        /// </summary>
        private GCHandle handle = new GCHandle();

        /// <summary>
        /// 类型句柄
        /// </summary>
        private int typeHandle = 0;

        /// <summary>
        /// 是否为引用类型
        /// </summary>
        private bool isReferenceType = true;

        /// <summary>
        /// 持有的对象（为中间转化所需）
        /// </summary>
        private object target = null;

        /// <summary>
        /// 锁对象
        /// </summary>
        private object objLock = new object();

        /// <summary>
        /// 是否为数组
        /// </summary>
        private bool isArray = false;

        /// <summary>
        /// 是否为字符串
        /// </summary>
        private bool isString = false;

        /// <summary>
        /// 数组长度
        /// </summary>
        private uint arrayLength = 0;

        /// <summary>
        /// 元素类型名称
        /// </summary>
        private string elementTypeName = "";

        [DllImport("msvcrt.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern IntPtr memcpy(void* dest, void* src, long size);

        /// <summary>
        /// 获得或设置元素类型名称
        /// </summary>
        public string ElementTypeName
        {
            get { return elementTypeName; }
            set
            {
                if (value != null && value != "")
                    elementTypeName = value;
            }
        }

        /// <summary>
        /// 获得或设置是否为数组
        /// </summary>
        public bool IsArray
        {
            get { return isArray; }
            set { isArray = value; }
        }

        /// <summary>
        /// 获得或设置是否为字符串
        /// </summary>
        public bool IsString
        {
            get { return isString; }
            set { isString = value; }
        }

        /// <summary>
        /// 获得或设置数组长度
        /// </summary>
        public uint ArrayLength
        {
            get { return arrayLength; }
            set { arrayLength = value; }
        }

        /// <summary>
        /// 获得初始状态的对象
        /// </summary>
        public object Target
        {
            get { return target; }
        }

        /// <summary>
        /// 获取是否为引用类型（包括了接口），否则为值类型
        /// </summary>
        public bool IsReferenceType
        {
            get
            {
                return isReferenceType;
            }
            private set
            {
                isReferenceType = value;
            }
        }

        /// <summary>
        /// 设置或获取类型
        /// </summary>
        public unsafe Type ItemType
        {
            get
            {
                return type;
            }
            set
            {
                lock (objLock)
                {
                    type = value;
                    if (type != null)
                    {
                        if (type.IsValueType)
                            IsReferenceType = false;
                        else
                            IsReferenceType = true;
                        if (type == typeof(string))
                        {
                            target = (string)"";
                            IsString = true;
                            typeHandle = type.TypeHandle.Value.ToInt32();
                            //计算length
                            int* p = (int*)(type.TypeHandle.Value.ToInt32() + 4);
                            length = (uint)(*p);
                        }
                        else if (type.IsArray)
                        {
                            IsArray = true;
                            int* p = (int*)(type.TypeHandle.Value.ToInt32() + 2);
                            typeHandle = *p;
                            target = Activator.CreateInstance(type, 1);//创建仅仅拥有一个元素的数组
                        }
                        else
                        {
                            IsArray = false;
                            typeHandle = type.TypeHandle.Value.ToInt32();
                            //计算length
                            int* p = (int*)(type.TypeHandle.Value.ToInt32() + 4);
                            length = (uint)(*p);
                            //System.Diagnostics.Debug.WriteLine(value.ToString() + ",length=" + length);
                            target = Activator.CreateInstance(type);
                        }
                        //object obj = type.GetConstructors()[0].Invoke(null);
                        if (!IsReferenceType)
                            this.Handle = GCHandle.Alloc(target, GCHandleType.Normal);

                        this.TypeName = DealWithTypeName(type);
                    }
                }
            }
        }

        private string DealWithTypeName(Type type)
        {
            if (type == null)
                return null;
            if (type.IsGenericType)
            {
                string typename = type.GetGenericTypeDefinition().Name.Replace("`2", "") + "<";
                Type[] types = type.GetGenericArguments();
                if (types != null)
                {
                    Type t = null;
                    for (int i = 0; i < types.Length; i++)
                    {
                        t = types[i];
                        typename += DealWithTypeName(t);
                        if (i < types.Length - 1)
                            typename += ",";
                    }
                }
                typename += ">";
                return typename;
            }
            else return type.Name;
        }

        /// <summary>
        /// 设置对象句柄
        /// </summary>
        private unsafe GCHandle Handle
        {
            set
            {
                if (handle != value)
                {
                    if (handle.IsAllocated)
                    {
                        handle.Free();
                    }
                    handle = value;
                    if (handle.IsAllocated)
                    {
                        IntPtr ptr = GCHandle.ToIntPtr(handle);
                        handlePtr = (int*)ptr.ToPointer();
                    }
                }
                else
                {
                }
            }
        }

        /// <summary>
        /// 获得类型句柄
        /// </summary>
        public int TypeHandle
        {
            get
            {
                return typeHandle;
            }
        }
      //  List<GCHandle> handles = new List<GCHandle>();
       // List<GCHandlerHelper> handleHelper = new List<GCHandlerHelper>();

        bool booltype;
        float floatType;
        /// <summary>
        /// 根据对象地址获得对象
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public object this[int address]
        {
            get
            {
                lock (objLock)
                {
                    if (address == 0)
                        return null;
                    //if (!handle.IsAllocated)
                    //    return null;
                    if (IsReferenceType)
                    {
                        //return target = Activator.CreateInstance(type);
                        //int lastObjAddress = LastObjAddress;

                        try
                        {
                            //IntPtr p = new IntPtr((int*)address + 4);
                            //GCHandle gh = GCHandle.FromIntPtr(p);
                            //object o= gh.Target;
                            //gh.Free();
                            //return o;
                            //if (handle.IsAllocated)
                            //{
                            //    handle.Free();
                            //}


                            //object o = GCHandle.FromIntPtr(ipp).Target;
                            if (this.IsString)
                            {
                                handle = GCHandle.Alloc(target, GCHandleType.Normal);
                                // return (string)obj;
                            }
                            else if (this.IsArray)
                            {
                                handle = GCHandle.Alloc(Activator.CreateInstance(type, 1), GCHandleType.Normal);
                            }
                            else
                                handle = GCHandle.Alloc(Activator.CreateInstance(type), GCHandleType.Normal);
                            GCHandlerHelper hp = new GCHandlerHelper();

                            // handles.Add(handle);
                            IntPtr ptr = GCHandle.ToIntPtr(handle);


                            handlePtr = (int*)ptr.ToPointer();
                            hp.firstObjectAdr = *handlePtr;
                            hp.Handle = handle;
                            *handlePtr = address + 4;//+4表示跳过Syncblk，使得地址移到TypeHandle
                            hp.currentObjectAdr = *handlePtr;
                            hp.Ptr = ptr;
                            //handleHelper.Add(hp);
                            object obj = handle.Target;
                            *handlePtr = hp.firstObjectAdr;
                            handle.Free();
                            return obj;
                        }
                        finally
                        {
                            //*handlePtr = lastObjAddress;
                        }
                    }
                    else
                    {//值拷贝
                        bool success = false;
                        int retryCount = -1;
                        while (!success)
                        {
                            retryCount++;
                            if (retryCount > 0)
                            {
                            }
                            try
                            {
                                //if (this.length == 1)
                                //{
                                //    return ToBool(address);
                                //}
                                //else if(this.length == 4)
                                //{
                                //    return ToFloat(address);z
                                //}
                                //else 
                                {
                                    target = Activator.CreateInstance(type);
                                    this.Handle = GCHandle.Alloc(target, GCHandleType.Normal);
                                    //测试静态类的对象是否被移动
                                    memcpy((int*)(LastObjAddress + 4), (int*)address, this.length);//+4表示跳过TypeHandle
                                }
                                success = true;
                            }
                            catch (Exception e)
                            {
                                System.Diagnostics.Debug.WriteLine(e.Message);
                            }
                        }
                        return handle.Target;
                    }
                }
            }
        }

        float ToFloat(int address)
        {
            float* p;
            p = (float*)address;
            return *p;
        }

        bool ToBool(int address)
        {
            bool* p;
            p = (bool*)address;
            return *p;
        }

        /// <summary>
        /// 根据对象地址克隆对象
        /// </summary>
        /// 
        /// <param name="address"></param>
        /// <returns></returns>
        public unsafe object Clone(int address)
        {
            lock (objLock)
            {
                if (address == 0)
                    return null;
                //if (!handle.IsAllocated)
                //    return null;
                if (IsReferenceType)
                {
                    //if (this.IsString)
                    //    return "";
                    //return target = Activator.CreateInstance(type);
                    //int lastObjAddress = LastObjAddress;

                    try
                    {
                        //IntPtr p = new IntPtr((int*)address + 4);
                        //GCHandle gh = GCHandle.FromIntPtr(p);
                        //object o= gh.Target;
                        //gh.Free();
                        //return o;
                        //if (handle.IsAllocated)
                        //{
                        //    handle.Free();
                        //}


                        //object o = GCHandle.FromIntPtr(ipp).Target;
                        if (this.IsString)
                        {
                            handle = GCHandle.Alloc(target, GCHandleType.Normal);
                            // return (string)obj;
                        }
                        else if (this.IsArray)
                        {
                            handle = GCHandle.Alloc(Activator.CreateInstance(type, 1), GCHandleType.Normal);
                        }
                        else
                            handle = GCHandle.Alloc(Activator.CreateInstance(type), GCHandleType.Normal);
                        GCHandlerHelper hp = new GCHandlerHelper();

                        // handles.Add(handle);
                        IntPtr ptr = GCHandle.ToIntPtr(handle);


                        handlePtr = (int*)ptr.ToPointer();
                        hp.firstObjectAdr = *handlePtr;
                        hp.Handle = handle;
                        *handlePtr = address + 4;//+4表示跳过Syncblk，使得地址移到TypeHandle
                        hp.currentObjectAdr = *handlePtr;
                        hp.Ptr = ptr;
                        //handleHelper.Add(hp);
                        object obj = handle.Target;
                        *handlePtr = hp.firstObjectAdr;
                        handle.Free();

                        if (this.isString)
                            return obj;
                        else
                        {

                            {

                                obj = type.GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(obj, null);
                                return obj;
                            }
                        }
                        return obj;
                    }
                    finally
                    {
                        //*handlePtr = lastObjAddress;
                    }
                }
                //if (IsReferenceType)
                //{
                //   // return target = Activator.CreateInstance(type);

                //    if (address == 0)
                //        return null;
                //    //if (!handle.IsAllocated)
                //    //    return null;
                //    int lastObjAddress = LastObjAddress;

                //    try
                //    {                 
                //        *handlePtr = address + 4;//+4表示跳过Syncblk，使得地址移到TypeHandle
                //        if (this.IsString)
                //            return (string)handle.Target;
                //        else
                //        {
                //            object obj = handle.Target;
                //            obj = type.GetMethod("MemberwiseClone", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(obj, null);
                //            return obj;
                //        }
                //    }
                //    finally
                //    {
                //        *handlePtr = lastObjAddress;
                //    }
                //}
                else
                {//值拷贝
                    //return target = Activator.CreateInstance(type);
                    //target = Activator.CreateInstance(type);
                    //this.Handle = GCHandle.Alloc(target, GCHandleType.Normal);
                    //memcpy((int*)(LastObjAddress + 4), (int*)address, this.length);
                    //return handle.Target;
                    bool success = false;
                    int retryCount = -1;
                    while (!success)
                    {
                        retryCount++;
                        if (retryCount > 0)
                        {
                        }
                        try
                        {
                            //if (this.length == 1)
                            //{
                            //    return ToBool(address);
                            //}
                            //else if(this.length == 4)
                            //{
                            //    return ToFloat(address);z
                            //}
                            //else 
                            {
                                target = Activator.CreateInstance(type);
                                this.Handle = GCHandle.Alloc(target, GCHandleType.Normal);
                                //测试静态类的对象是否被移动
                                memcpy((int*)(LastObjAddress + 4), (int*)address, this.length);//+4表示跳过TypeHandle
                            }
                            success = true;
                        }
                        catch (Exception e)
                        {
                            System.Diagnostics.Debug.WriteLine(e.Message);
                        }
                    }
                    return handle.Target;
                }
            }
        }

        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object Convert(object value)
        {
            if (value == null)
                return null;
            if (this.ItemType.IsValueType)
                return System.Convert.ChangeType(value, this.ItemType);
            else return value;
        }

        /// <summary>
        /// 析构函数
        /// </summary>
        ~TypeManageItem()
        {


            if (handle.IsAllocated)
            {
                handle.Free();
                if (this.isReferenceType)
                {
                }
            }
        }

        public void Clear()
        {

            if (handle.IsAllocated)
            {
                handle.Free();
            }
            this.target = null;
        }
    }

    public class ChildTableItem
    {
        /// <summary>
        /// 类型
        /// </summary>
        private Type type = null;

        /// <summary>
        /// 该成员变量所占的字节数长度
        /// </summary>
        private uint length = 0;

        /// <summary>
        /// 获得或设置该成员变量所占的字节数长度
        /// </summary>
        public uint Length
        {
            get { return length; }
            set { length = value; }
        }

        /// <summary>
        /// 该成员变量在嵌套类型中的偏移量
        /// </summary>
        private uint offset = uint.MaxValue;

        /// <summary>
        /// 获得或设置该成员变量在嵌套类型中的偏移量
        /// </summary>
        public uint Offset
        {
            get { return offset; }
            set { offset = value; }
        }

        /// <summary>
        /// 该成员变量的嵌套类型在对象中的偏移量（注：等于uint.MaxValue表示无嵌套类型）
        /// </summary>
        private uint parentOffset = uint.MaxValue;

        /// <summary>
        /// 获得或设置该成员变量的嵌套类型在对象中的偏移量（注：等于uint.MaxValue表示无嵌套类型）
        /// </summary>
        public uint ParentOffset
        {
            get { return parentOffset; }
            set { parentOffset = value; }
        }

        /// <summary>
        /// 该成员变量的嵌套引用类型在对象中的引用偏移量（注：等于uint.MaxValue表示无嵌套类型）
        /// </summary>
        private uint parentReferenceOffset = uint.MaxValue;

        /// <summary>
        /// 获得或设置该成员变量的嵌套引用类型在对象中的引用偏移量（注：等于uint.MaxValue表示无嵌套类型）
        /// </summary>
        public uint ParentReferenceOffset
        {
            get { return parentReferenceOffset; }
            set { parentReferenceOffset = value; }
        }

        /// <summary>
        /// Pin类型
        /// </summary>
        private PinTypes pinType = PinTypes.None;

        /// <summary>
        /// 获得或设置Pin类型
        /// </summary>
        public PinTypes PinType
        {
            get { return pinType; }
            set { pinType = value; }
        }

        /// <summary>
        /// 是否为Pin结构中的Pinner
        /// </summary>
        private bool isPinner = false;

        /// <summary>
        /// 获得或设置是否为Pin结构中的Pinner
        /// </summary>
        public bool IsPinner
        {
            get { return isPinner; }
            set { isPinner = value; }
        }

        /// <summary>
        /// 该成员的名称
        /// </summary>
        private string childName = "";

        /// <summary>
        /// 获得或设置名称
        /// </summary>
        public string ChildName
        {
            get { return childName; }
            set { childName = value; }
        }

        /// <summary>
        /// 该成员的全称
        /// </summary>
        private string childFullName = "";

        /// <summary>
        /// 获得或设置全称
        /// </summary>
        public string ChildFullName
        {
            get { return childFullName; }
            set { childFullName = value; }
        }

        /// <summary>
        /// 描述信息
        /// </summary>
        private string display = "";

        /// <summary>
        /// 获得或设置描述信息
        /// </summary>
        public string Display
        {
            get { return display; }
            set { display = value; }
        }

        /// <summary>
        /// 类型句柄
        /// </summary>
        private int typeHandle = 0;

        /// <summary>
        /// 数组名称（注：如果该成员类型是数组的话，将需要该名称进行查找TypeManageItem项）
        /// </summary>
        private string arrayTypeName = "";

        /// <summary>
        /// 获得或设置数组名称
        /// </summary>
        public string ArrayTypeName
        {
            get { return arrayTypeName; }
            set
            {
                if (value != null && value != "")
                    arrayTypeName = value;
            }
        }

        /// <summary>
        /// 是否为数组
        /// </summary>
        private bool isArray = false;

        /// <summary>
        /// 获得或设置是否为数组
        /// </summary>
        public bool IsArray
        {
            get { return isArray; }
            set { isArray = value; }
        }

        /// <summary>
        /// 数组长度
        /// </summary>
        private uint arrayLength = 0;

        /// <summary>
        /// 获得或设置数组长度
        /// </summary>
        public uint ArrayLength
        {
            get { return arrayLength; }
            set { arrayLength = value; }
        }

        /// <summary>
        /// 引用的长度
        /// </summary>
        private uint referenceLength = 0;

        /// <summary>
        /// 获得或设置引用的长度
        /// </summary>
        public uint ReferenceLength
        {
            get { return referenceLength; }
            set { referenceLength = value; }
        }

        /// <summary>
        /// 引用的偏移（注：针对引用类型）
        /// </summary>
        private uint referenceOffset = uint.MaxValue;

        /// <summary>
        /// 获得或设置引用的偏移（注：针对引用类型）
        /// </summary>
        public uint ReferenceOffset
        {
            get { return referenceOffset; }
            set { referenceOffset = value; }
        }

        /// <summary>
        /// 是否为引用类型
        /// </summary>
        private bool isReferenceType = true;

        /// <summary>
        /// 获取或设置是否为引用类型，否则为值类型
        /// </summary>
        public bool IsReferenceType
        {
            get
            {
                return isReferenceType;
            }
            private set
            {
                isReferenceType = value;
            }
        }

        /// <summary>
        /// 是否为接口
        /// </summary>
        private bool isInterface = true;

        /// <summary>
        /// 获取或设置是否为接口
        /// </summary>
        public bool IsInterface
        {
            get
            {
                return isInterface;
            }
            private set
            {
                isInterface = value;
            }
        }

        /// <summary>
        /// 类型ID
        /// </summary>
        private int typeId = -1;

        /// <summary>
        /// 获得或设置类型ID
        /// </summary>
        public int TypeId
        {
            get { return typeId; }
            set { typeId = value; }
        }

        /// <summary>
        /// 显示的类型名
        /// </summary>
        private string typeName = "";

        /// <summary>
        /// 设置或读取显示的类型名
        /// </summary>
        public string TypeName
        {
            get { return typeName; }
            set { typeName = value; }
        }

        /// <summary>
        /// 设置或获取类型
        /// </summary>
        public unsafe Type ChildType
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
                if (type != null)
                {
                    if (type.IsValueType)
                        IsReferenceType = false;
                    else IsReferenceType = true;
                    if (type.IsInterface)
                        IsInterface = true;
                    else IsInterface = false;
                    if (type.IsArray)
                    {
                        IsArray = true;
                        int* p = (int*)(type.TypeHandle.Value.ToInt32() + 2);
                        typeHandle = *p;
                    }
                    else
                    {
                        IsArray = false;
                        typeHandle = type.TypeHandle.Value.ToInt32();
                        //计算length
                        int* p = (int*)(type.TypeHandle.Value.ToInt32() + 4);
                        length = (uint)(*p);
                    }
                    this.TypeName = DealWithTypeName(type);
                }
            }
        }

        private string DealWithTypeName(Type type)
        {
            if (type == null)
                return null;
            if (type.IsGenericType)
            {
                string typename = type.GetGenericTypeDefinition().Name.Replace("`2", "") + "<";
                Type[] types = type.GetGenericArguments();
                if (types != null)
                {
                    Type t = null;
                    for (int i = 0; i < types.Length; i++)
                    {
                        t = types[i];
                        typename += DealWithTypeName(t);
                        if (i < types.Length - 1)
                            typename += ",";
                    }
                }
                typename += ">";
                return typename;
            }
            else return type.Name;
        }


        /// <summary>
        /// 获得类型句柄
        /// </summary>
        public int TypeHandle
        {
            get
            {
                return typeHandle;
            }
        }

        /// <summary>
        /// 浅表克隆
        /// </summary>
        /// <returns></returns>
        public ChildTableItem Clone()
        {
            ChildTableItem item = new ChildTableItem();
            item.arrayLength = this.arrayLength;
            item.arrayTypeName = this.arrayTypeName;
            item.childFullName = this.childFullName;
            item.childName = this.childName;
            item.ChildType = this.ChildType;
            item.display = this.display;
            item.isPinner = this.isPinner;
            item.length = this.length;
            item.offset = this.offset;
            item.pinType = this.pinType;
            item.referenceLength = this.referenceLength;
            item.referenceOffset = this.referenceOffset;
            item.typeId = this.typeId;
            return item;
        }

        /// <summary>
        /// 转换
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public object Convert(object value)
        {
            if (value == null)
                return null;
            if (this.ChildType.IsEnum)
                return System.Convert.ToInt32(value);
            else if (this.ChildType.IsValueType)
            {
                try
                {
                    return System.Convert.ChangeType(value, this.ChildType);
                }
                catch
                {
                    return Activator.CreateInstance(this.ChildType);
                }
            }
            else
            {
                if (this.PinType == PinTypes.Input || this.PinType == PinTypes.IO || this.PinType == PinTypes.Output)
                {
                    return System.Convert.ChangeType(value, (this.ChildType.GetGenericArguments())[1]);
                }
                else return null;
            }
        }
    }

    /// <summary>
    /// 功能块详细信息
    /// </summary>
    [Serializable]
    public class BlockDetails
    {
        public string membername;
        public string pintype;
        public string datatype;
        public object value;
        public object defaultvalue;
        public object minvalue;
        public object maxvalue;
        public long fsid_buffer;
        public string display;
        public bool isForce;
        public object forceValue;
        public bool isTrace;
        public string dpu;
        public string block;

        public BlockDetails(string MemberName, string PinType, string DataType, object Value, object DefaultValue, object MinValue, object MaxValue, long FSID, string Display)
        {
            membername = MemberName;
            pintype = PinType;
            datatype = DataType;
            value = Value;
            minvalue = MinValue;
            maxvalue = MaxValue;
            fsid_buffer = FSID;
            defaultvalue = DefaultValue;
            display = Display;
        }
    }

    /// <summary>
    /// 点详细信息
    /// </summary>
    [Serializable]
    public class PointDetails
    {
        public string membername;
        public object value;
        public long fsid;

        public PointDetails(string MemberName, object Value, long FSID)
        {
            membername = MemberName;
            value = Value;
            fsid = FSID;
        }
    }

    /// <summary>
    /// 操作员记录
    /// </summary>
    [Serializable]
    public class OperatorRecParams
    {
        public string name;
        public long timeTick;
        public string oldValue;
        public string newValue;
        public string oper;
    }


    public class GCHandlerHelper
    {
        public int firstObjectAdr;

        public int currentObjectAdr;

        public IntPtr Ptr;

        public GCHandle Handle;
    }
}