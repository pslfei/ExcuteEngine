using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.IO;

namespace DCSCommon
{

    /// <summary>
    /// Pin计算缓存接口
    /// </summary>
    public interface IMonitor 
    {
        /// <summary>
        /// 索引方式读写值
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        //object this[int i] { get; set; }

        IntPtr Ptr { get;}
    }

    /// <summary>
    /// Pin计算缓存接口
    /// </summary>
    public interface IPinCalculationCache : IO, IValuable, IMonitor
    {
        /// <summary>
        /// 索引方式读写值
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        //object this[int i] { get; set; }
    }

    /// <summary>
    /// 更新能力接口
    /// </summary>
    public interface IChangable
    {
        /// <summary>
        /// 读取是否有更新变化
        /// </summary>
        bool Changed { get;}
    }

    /// <summary>
    /// 缓冲接口
    /// </summary>
    public interface IBuffer
    {
        /// <summary>
        /// 设置或读取缓冲值
        /// </summary>
        object Buffer { get; set; }
    }

    /// <summary>
    /// 存储接口
    /// </summary>
    public interface IStore
    {
        /// <summary>
        /// 清除所有数据
        /// </summary>
        bool Clear();

        /// <summary>
        /// 加载数据
        /// </summary>
        /// <param name="fs">数据输入流</param>
        bool Load(Stream fs);

        /// <summary>
        /// 保存数据
        /// </summary>
        /// <param name="fs">数据输出流</param>
        bool Save(Stream fs);
    }

    /// <summary>
    /// 数据集接口
    /// </summary>
    public interface IDataBase
    {

        /// <summary>
        /// 根据变量地址进行数据块拷贝和按位取反函数
        /// </summary>
        /// <param name="Target">目的变量地址</param>
        /// <param name="Source">源变量地址</param>
        /// <param name="IsReversed">是否按位取反</param>
        bool CopyTo(VariableAddress Target, VariableAddress Source, bool IsReversed);

        /// <summary>
        /// 根据FSID进行数据块拷贝和按位取反函数，作用在复合类型内部域中，实行两者之间的子成员互相拷贝，
        /// 特别注意的是由FSID计算所得的偏移量为零，即只拷贝偏移为零的子成员，不拷贝整个复合类型，
        /// 如果计算所得偏移量已是uint的MaxValue，则拷贝整个复合类型，因为偏移量最大也不会超出uint的MaxValue。
        /// </summary>
        /// <param name="TargetFSID">目标FSID</param>
        /// <param name="SourceFSID">源FSID</param>
        /// <param name="IsReversed">是否按位取反</param>
        bool CopyTo(long TargetFSID, long SourceFSID, bool IsReversed);

        /// <summary>
        /// 根据SID进行数据块拷贝函数和按位取反，实行变量之间的整块内存拷贝
        /// </summary>
        /// <param name="TargetSID">目标SID</param>
        /// <param name="SourceSID">源SID</param>
        /// <param name="IsReversed">是否按位取反</param>
        bool CopyTo(int TargetSID, int SourceSID, bool IsReversed);

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="FSID">变量的FSID</param>
        /// <returns></returns>
        bool Delete(long FSID);

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="SID">变量的SID</param>
        /// <returns></returns>
        bool Delete(int SID);

        /// <summary>
        /// 申请变量，返回SID
        /// </summary>
        /// <param name="Name">变量名称</param>
        /// <param name="TypeName">类型名称</param>
        /// <param name="Class">变量类别</param>
        /// <returns></returns>
        int New(string Name, string TypeName, VariableClass Class);
        
        /// <summary>
        /// 获得变量的FSID
        /// </summary>
        /// <param name="SID">变量的SID</param>
        /// <param name="Offset">变量的偏移量</param>
        /// <returns></returns>
        long GetFSID(int SID, uint Offset);
        
        /// <summary>
        /// 根据SID设置读写能力
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="ability"></param>
        /// <returns></returns>
        bool SetWriteReadAbility(int SID, WriteReadAbility ability);

        /// <summary>
        /// 根据FSID设置读写能力
        /// </summary>
        /// <param name="FSID"></param>
        /// <param name="ability"></param>
        /// <returns></returns>
        bool SetWriteReadAbility(long FSID, WriteReadAbility ability);

        /// <summary>
        /// 根据FSID获得读写能力
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        WriteReadAbility GetWriteReadAbility(long FSID);

        /// <summary>
        /// 根据SID获得读写能力
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        WriteReadAbility GetWriteReadAbility(int SID);

        /// <summary>
        /// 获得变量名称
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        string GetVariableName(int SID);

        /// <summary>
        /// 获得变量名称
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        string GetVariableName(long FSID);

        /// <summary>
        /// 获得变量类型名称
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        string GetVariableTypeName(int SID);

        /// <summary>
        /// 获得变量类型名称
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        string GetVariableTypeName(long FSID);

        /// <summary>
        /// 获得变量地址
        /// </summary>
        /// <param name="Names"></param>
        /// <returns></returns>
        VariableAddress GetVariableAddress(params string[] Names);

        /// <summary>
        /// 获得变量的物理地址
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        IntPtr GetVariableAddress(long FSID);

        /// <summary>
        /// 获得变量长度
        /// </summary>
        /// <param name="SID"></param>
        /// <returns></returns>
        uint GetVariableLength(int SID);

        /// <summary>
        /// 获得变量长度
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        uint GetVariableLength(long FSID);

        /// <summary>
        /// 获得变量长度
        /// </summary>
        /// <param name="Name"></param>
        /// <returns></returns>
        uint GetVariableLength(string Name);

        /// <summary>
        /// 附加别名系统
        /// </summary>
        /// <param name="AliasArray">别名数组，第一列为原名列，第二列为别名列</param>
        /// <returns>返回附加成功的别名数目，失败返回-1</returns>
        long AppendaAliasSystem(string[][] AliasArray);

        /// <summary>
        /// 根据FSID读写变量
        /// </summary>
        /// <param name="User">使用者</param>
        /// <param name="FSID">变量的FSID</param>
        /// <returns></returns>
        object this[string User, long FSID]
        {
            get;
            set;
        }

        /// <summary>
        /// 根据SID读写变量
        /// </summary>
        /// <param name="SID">变量SID</param>
        /// <returns></returns>
        object this[int SID]
        {
            get;
            set;
        }

        /// <summary>
        /// 根据变量地址读写变量
        /// </summary>
        /// <param name="Address">变量地址</param>
        /// <returns></returns>
        object this[VariableAddress Address]
        {
            get;
            set;
        }

        /// <summary>
        /// 根据SID和Offset读写变量
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="Offset"></param>
        /// <returns></returns>
        object this[int SID, uint Offset]
        {
            get;
            set;
        }

        /// <summary>
        /// 根据名字获得SID
        /// </summary>
        /// <param name="Name">变量名称</param>
        /// <returns></returns>
        int this[string Name]
        {
            get;
        }

        /// <summary>
        /// 根据可变名称返回变量的FSID
        /// </summary>
        /// <param name="names"></param>
        long this[params string[] names] { get; }
    }

    /// <summary>
    /// RTD接口
    /// </summary>
    public interface IRTD : ICloneable, IStore, IDataBase, IChangable
    {
        void EnableReview(bool isReviewing);
        /// <summary>
        /// 重新初始化
        /// </summary>
        /// <returns></returns>
        bool Restart();

        /// <summary>
        /// 启动工作
        /// </summary>
        /// <returns></returns>
        bool Start();

        /// <summary>
        /// 重置RTD中的对象关系
        /// </summary>
        /// <returns></returns>
        bool Reset();

        /// <summary>
        /// 停止工作
        /// </summary>
        /// <returns></returns>
        bool Stop();

        /// <summary>
        /// 添加从属RTD到主RTD
        /// </summary>
        /// <param name="rtd"></param>
        /// <returns></returns>
        bool AddRTD(IRTD rtd);

        /// <summary>
        /// RTD之间交换数据
        /// </summary>
        void ExchangeData();

        /// <summary>
        /// 接受数据
        /// </summary>
        /// <param name="RtdName"></param>
        /// <param name="buffer"></param>
        void AcceptData(string RtdName, byte[] buffer);

        /// <summary>
        /// 通知主RTD，从RTD更换名称
        /// </summary>
        /// <param name="oldName">原有的名称</param>
        /// <param name="newName">新名称</param>
        bool SlaveRTDChangeName(string oldName, string newName);

        /// <summary>
        /// 订阅变量，返回FSID，由SID左移32为加offset组成，即FSID=SID《32+offset，SID=FISD》32，offset=FSID&0xffffffff
        /// </summary>
        /// <param name="name">可变名称</param>
        /// <returns></returns>
        long Subscribe(params string[] names);

        /// <summary>
        /// 取消订阅
        /// </summary>
        /// <param name="FSID">变量的FSID</param>
        /// <param name="IsForced">是否强制取消订约</param>
        /// <returns></returns>
        bool UnSubscribe(long FSID, bool IsForced);

        /// <summary>
        /// 向主RTD租约变量供其内部的Command使用
        /// </summary>
        /// <param name="user">使用者名称</param>
        /// <param name="name">可变名称</param>
        /// <returns></returns>
        LeaseParams Lease(string user, params string[] names);

        /// <summary>
        /// 解除租约
        /// </summary>
        /// <param name="fsid"></param>
        void UnLease(long fsid);

        /// <summary>
        /// 反向订阅变量，返回FSID，向实时数据中心去订约
        /// </summary>
        /// <param name="name">可变名称</param>
        /// <returns></returns>
        long ReversedSubscribe(params string[] names);

        /// <summary>
        /// 取消反向订阅
        /// </summary>
        /// <param name="FSID">变量的FSID</param>
        /// <returns></returns>
        bool UnReversedSubscribe(long FSID);

        /// <summary>
        /// 链接Point到Pin之间的连线
        /// </summary>
        /// <param name="Point">Point变量地址</param>
        /// <param name="Pin">Pin变量地址</param>
        /// <returns></returns>
        bool ConnectPointToPin(VariableAddress Point, VariableAddress Pin);

        /// <summary>
        /// 断开Pin到Point之间的连线
        /// </summary>
        /// <param name="Pin">Pin变量地址</param>
        /// <returns></returns>
        bool DisconnectPointToPin(VariableAddress Pin);
        
        /// <summary>
        /// 切换插件
        /// </summary>
        /// <param name="PlugPath">插件路径</param>
        /// <param name="PointPlug">设置工作的点插件名称</param>
        /// <param name="FCPlug">设置工作的功能码插件名称</param>
        /// <param name="MacroPlug">设置工作的宏插件名称</param>
        /// <returns></returns>
        bool ChangePlug(string PlugPath, string PointPlug, string FCPlug, string MacroPlug);

        /// <summary>
        /// 由FSID计算SID和Offset
        /// </summary>
        /// <param name="FSID"></param>
        /// <param name="SID"></param>
        /// <param name="Offset"></param>
        void Translate(long FSID, ref int SID, ref uint Offset);

        /// <summary>
        /// 根据SID和Offset计算FSID
        /// </summary>
        /// <param name="SID"></param>
        /// <param name="Offset"></param>
        /// <param name="FSID"></param>
        void Translate(int SID, uint Offset, ref long FSID);

        /// <summary>
        /// 获得连接的变量的FSID（获得BlockName.PinName上连接的 “点” 名）
        /// </summary>
        /// <param name="Name">BlockName</param>
        /// <param name="Member">PinName</param>
        /// <returns></returns>
        long[] GetLinkedVariable(string Name, string Member);

        /// <summary>
        /// 获得连接的变量的FSID
        /// </summary>
        /// <param name="Sid"></param>
        /// <param name="Offset"></param>
        /// <returns></returns>
        long[] GetLinkedVariable(int Sid, uint Offset);

        /// <summary>
        /// 获得连接的变量的FSID
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        long[] GetLinkedVariable(long FSID);

        /// <summary>
        /// 获得所有点集合（每一项都包含pointname和pointtype信息）
        /// </summary>
        /// <param name="RtdName">RTD名称。如果RtdName为null，RTD工作模式为主模式，则在所有RTD中搜索；RTD工作模式为从模式，则在此RTD中搜索</param>
        /// <returns></returns>
        string[][] GetPoints(string RtdName);

        /// <summary>
        /// 获得所有功能块集合（每一项都包含blockname和fcname信息）
        /// </summary>
        /// <param name="RtdName">RTD名称。如果RtdName为null，RTD工作模式为主模式，则在所有RTD中搜索；RTD工作模式为从模式，则在此RTD中搜索</param>
        /// <returns></returns>
        string[][] GetBlocks(string RtdName);

        /// <summary>
        /// 获得功能块详细信息（包含membername,pintype,datatype,value,minvalue,maxvalue,fsid,display信息）
        /// </summary>
        /// <param name="RtdName">RTD名称。如果RtdName为null，RTD工作模式为主模式，则在所有RTD中搜索；RTD工作模式为从模式，则在此RTD中搜索</param>
        /// <param name="BlockName">功能块名称</param>
        /// <returns></returns>
        BlockDetails[] GetBlockDetails(string RtdName, string BlockName);

        /// <summary>
        /// 获得成员的详细信息
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        ChildTableItem GetMemberDetails(params string[] names);

        /// <summary>
        /// 获得点详细信息（包含membername,value,fsid信息）
        /// </summary>
        /// <param name="RtdName">RTD名称。如果RtdName为null，RTD工作模式为主模式，则在所有RTD中搜索；RTD工作模式为从模式，则在此RTD中搜索</param>
        /// <param name="PointName">点名称</param>
        /// <returns></returns>
        PointDetails[] GetPointDetails(string RtdName, string PointName);

        /// <summary>
        /// 引发订约器刷新所有订约项
        /// </summary>
        void TriggerRefresh();

        /// <summary>
        /// 刷新通知器
        /// </summary>
        void RefreshNotifier();

        /// <summary>
        /// 释放资源
        /// </summary>
        void Dispose();

        /// <summary>
        /// 设置或读取RTD的名称
        /// </summary>
        string Name { get;set;}

        /// <summary>
        /// 读取下一个可分配的SID
        /// </summary>
        int AllocSID { get;}

        /// <summary>
        /// 预分配的SID已经使用完的通知事件
        /// </summary>
        PreAllocSIDConsume SIDConsume { get;set;}

        /// <summary>
        /// 读取或设置通知数据变化事件
        /// </summary>
        InformRefresh InformRefreshHandler { get;set;}

        /// <summary>
        /// 设置或读写是否启动写数据触发器
        /// </summary>
        bool EnableWirterTrigger { get;set;}

        /// <summary>
        /// 设置或读取预分配的SID个数
        /// </summary>
        uint PreAllocNum { get;set;}

        /// <summary>
        /// 设置起始SID
        /// </summary>
        int BaseSID { set;}

        /// <summary>
        /// 读取RTD是否处于运行状态
        /// </summary>
        bool Runable { get;}

        /// <summary>
        /// 设置或读取周期数
        /// </summary>
        uint CycleCount { get;set;}

        /// <summary>
        /// 读取元数据是否发生变化
        /// </summary>
        bool MetaModified { get;}

        /// <summary>
        /// 读取或设置是否在序列化时进行垃圾回收
        /// </summary>
        bool RecyclingAtSerializing { get; set; }

        /// <summary>
        /// 获得类型管理器
        /// </summary>
        ITypeManage TypeManage { get;}

        /// <summary>
        /// 设置或读取主RTD
        /// </summary>
        IRTD Master { get;set;}
        
        /// <summary>
        /// 读取RTD集
        /// </summary>
        Dictionary<string, IRTD> Rtds { get;}

        /// <summary>
        /// 读取通信集
        /// </summary>
        Dictionary<string, IRTD> Communications { get;}

        /// <summary>
        /// 设置或读取工作模式，RTD的工作模式为主从+克隆模式
        /// </summary>
        RTDWorkMode Mode { get;set;}

        /// <summary>
        /// 根据FSID批量读写变量
        /// </summary>
        /// <param name="User">使用者</param>
        /// <param name="FSIDS">批量变量的FSID</param>
        /// <returns></returns>
        object[] this[string User, long[] FSIDS] { get;set;}

        /// <summary>
        /// 根据FSID变量获取
        /// </summary>
        /// <param name="FSID">变量的FSID</param>
        /// <returns></returns>
        object GetVariable(long FSID);
		/// <summary>
		///  数据DataChange通知周期，单位秒
		/// </summary>
		double InformDataChangeCycle{	get;set;}
		/// <summary>
		/// 启动关闭数据数据DataChange通知线程，True启动线程，false关闭线程
		/// </summary>
		bool EnableTimerDataChange{get;	set;}
    }

    /// <summary>
    /// 序列化业务
    /// </summary>
    public interface ISerializeOperation
    {
        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj">序列化的对象</param>
        bool Serialize(object obj);

        /// <summary>
        /// 序列化
        /// </summary>
        /// <param name="obj">序列化的对象</param>
        /// <param name="prjStream">工程的数据流</param>
        bool Serialize(object obj, Stream prjStream);

        /// <summary>
        /// 反序列化
        /// </summary>
        Object Deserialize();

        /// <summary>
        /// 反序列化
        /// </summary>
        /// <param name="dpu">DPU的实例</param>
        /// <param name="prjStream">工程的数据流</param>
        object Deserialize(IDpu dpu, Stream prjStream);

        /// <summary>
        /// 序列化操作的文件流
        /// </summary>
        FileStream FileStream { get;set;}

        /// <summary>
        /// 序列化操作的文件路径
        /// </summary>
        string Path { get;set;}
    }

    /// <summary>
    /// 初始化业务接口
    /// </summary>
    public interface IInitOperation
    {
        /// <summary>
        /// 根据数据库初始化所有Point
        /// </summary>
        bool InitPointByDatabase();

        /// <summary>
        /// 根据数据库初始化FC与Point关系，Pin初始值等
        /// </summary>
        bool InitFCByDatabase();

        /// <summary>
        /// 打开控制器
        /// </summary>
        bool Open();

        /// <summary>
        /// 根据控制器ID号打开控制器
        /// </summary>
        /// <param name="ControllerID">控制器ID号</param>
        /// <returns></returns>
        bool Open(int ControllerID);

        /// <summary>
        /// 清除数据
        /// </summary>
        bool Clear();

        /// <summary>
        /// 根据名称获得FC细节信息
        /// </summary>
        /// <param name="Name">FC名称</param>
        /// <returns></returns>
        Dictionary<string, IPinDetails> this[string Name]
        {
            get;
        }

        /// <summary>
        /// 读取或设置控制器ID号
        /// </summary>
        int ControllerID
        {
            get;
            set;
        }

        /// <summary>
        /// 读取算法块对应的功能码名称集合
        /// </summary>
        Dictionary<string, string> BlockNamesToFCNames
        {
            get;
        }

        /// <summary>
        /// 设置或读取业务是否已打开
        /// </summary>
        bool Opened
        {
            get;
            set;
        }

        /// <summary>
        /// 获取点集合
        /// </summary>
        IList<IPointDetails> Points
        {
            get;
        }

        /// <summary>
        /// 获得功能块集合枚举
        /// </summary>
        /// <returns></returns>
        IEnumerator GetEnumerator();
    }

    /// <summary>
    /// 管脚信息接口
    /// </summary>
    public interface IPinDetails
    {
        /// <summary>
        /// 默认值
        /// </summary>
        object DefaultValue { get; set; }

        /// <summary>
        /// 是否拥有默认值
        /// </summary>
        bool HasDefualtValue { get;}

        /// <summary>
        /// 地址是否绑定，不用分配
        /// </summary>
        bool Fixed { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        object MaxValue { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        object MinValue { get; set; }

        /// <summary>
        /// 是否必要
        /// </summary>
        bool Required { get; set; }

        /// <summary>
        /// 是否可调
        /// </summary>
        bool Tune { get; set; }

        /// <summary>
        /// 连接的Point名称
        /// </summary>
        string PointName { get; set; }

        /// <summary>
        /// 是否反转运算
        /// </summary>
        bool Reverse { get; set; }
    }

    /// <summary>
    /// 点信息接口
    /// </summary>
    public interface IPointDetails
    {
        /// <summary>
        /// 默认值
        /// </summary>
        object DefaultValue { get; set; }

        /// <summary>
        /// 最大值
        /// </summary>
        object MaxValue { get; set; }

        /// <summary>
        /// 最小值
        /// </summary>
        object MinValue { get; set; }

        /// <summary>
        /// 强制值
        /// </summary>
        object ForceValue { get; set; }

        /// <summary>
        /// 是否强制
        /// </summary>
        bool IsForced { get; set; }

        /// <summary>
        /// Point名称
        /// </summary>
        string PointName { get; set; }

        /// <summary>
        /// 类型名称
        /// </summary>
        string TypeName { get; set; }
    }

    /// <summary>
    /// 插件接口
    /// </summary>
    public interface IPlug
    {
        /// <summary>
        /// 加载插件
        /// </summary>
        /// <param name="FileName">插件文件路径</param>
        /// <returns></returns>
        bool Load(string Path);

        /// <summary>
        /// 获得插件中的对象
        /// </summary>
        /// <param name="index">索引</param>
        /// <returns></returns>
        object this[int index]{ get; }

        /// <summary>
        /// 获得对象总数
        /// </summary>
        int Count { get;}

        /// <summary>
        /// 插件名称
        /// </summary>
        string Name { get;}

        /// <summary>
        /// 插件版本
        /// </summary>
        string Version { get;}

        /// <summary>
        /// 插件类别
        /// </summary>
        VariableClass PlugClass { get;}

        /// <summary>
        /// 获得枚举器
        /// </summary>
        /// <returns></returns>
        IEnumerator GetEnumerator();
    }

    /// <summary>
    /// 输入输出接口
    /// </summary>
    public interface IO
    {
        /// <summary>
        /// 通过名称设置成员变量的值，使得对成员的赋值具有一定的约束，如强制时，写值的情况。
        /// </summary>
        /// <param name="value"></param>
        /// <param name="names"></param>
        void SetMemberValue(object value, params string[] names);

        /// <summary>
        /// 通过名称读取成员变量的值。子类可以重载此函数完成更为复杂的逻辑
        /// </summary>
        /// <param name="names"></param>
        object GetMemberValue(params string[] names);
    }

    public interface IValueSetter
    {
        void SetValue(object value);
    }

    /// <summary>
    /// 数值接口
    /// </summary>
    public interface IValuable
    {
        /// <summary>
        /// 设置或获得数值
        /// </summary>
        object Value { get;set;}

        /// <summary>
        /// 索引方式读写值
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        object this[int i] { get;set;}
    }

    /// <summary>
    /// Point业务接口
    /// </summary>
    public interface IPointOperation : IO
    {
        /// <summary>
        /// 设置或获得是否正处于Alarm状态
        /// </summary>
        bool IsAlarm { get; set; }

        /// <summary>
        /// 设置或获得是否强制
        /// </summary>
        byte IsForced { get; set; }

        /// <summary>
        /// 设置或获得是否跟踪
        /// </summary>
        bool IsTrace { get; set; }


        //string Description { get; set; }

        /// <summary>
        /// 设置或获得信号质量
        /// </summary>
        QualityTypes Quality { get; set; }
    }

    /// <summary>
    /// 运算接口
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface ICalculator<T> where T : struct, IComparable<T>, IConvertible
    {
        #region 四则运算

        #region 加法器
        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Add(T a, int b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Add(T a, short b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Add(T a, long b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Add(T a, float b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Add(T a, double b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Add(T a, bool b);

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Add<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 加法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Add2(T a, T b);
        #endregion

        #region 减法器
        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Subtract(T a, int b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Subtract(T a, short b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Subtract(T a, long b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Subtract(T a, float b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Subtract(T a, double b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Subtract(T a, bool b);

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Subtract<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 减法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Subtract2(T a, T b);
        #endregion

        #region 乘法器
        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Multiply(T a, int b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Multiply(T a, short b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Multiply(T a, long b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Multiply(T a, float b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Multiply(T a, double b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Multiply(T a, bool b);

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Multiply<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 乘法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Multiply2(T a, T b);
        #endregion

        #region 除法器
        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Division(T a, int b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Division(T a, short b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Division(T a, long b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Division(T a, float b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Division(T a, double b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Division(T a, bool b);

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Division<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 除法器
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Division2(T a, T b);
        #endregion

        #endregion//四则运算

        #region 逻辑运算

        #region 大于号
        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, int b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, short b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, long b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, float b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, double b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan(T a, bool b);

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 大于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterThan2(T a, T b);
        #endregion

        #region 小于号
        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, int b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, short b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, long b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, float b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, double b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan(T a, bool b);

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 小于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessThan2(T a, T b);
        #endregion

        #region 大于等于号
        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, int b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, short b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, long b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, float b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, double b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual(T a, bool b);

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 大于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool GreaterEqual2(T a, T b);
        #endregion

        #region 小于等于号
        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, int b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, short b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, long b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, float b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, double b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual(T a, bool b);

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 小于等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool LessEqual2(T a, T b);
        #endregion

        #region 等于号
        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, int b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, short b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, long b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, float b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, double b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal(T a, bool b);

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Equal2(T a, T b);
        #endregion

        #region 不等于号
        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, int b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, short b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, long b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, float b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, double b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual(T a, bool b);

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 不等于号
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool UnEqual2(T a, T b);
        #endregion

        #endregion//逻辑运算

        #region 布尔运算

        #region 与运算
        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int And(T a, int b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short And(T a, short b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long And(T a, long b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float And(T a, float b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double And(T a, double b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool And(T a, bool b);

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T And<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 与运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T And2(T a, T b);
        #endregion

        #region 或运算
        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Or(T a, int b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Or(T a, short b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Or(T a, long b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Or(T a, float b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Or(T a, double b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Or(T a, bool b);

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Or<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Or2(T a, T b);
        #endregion

        #region 异或运算
        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Xor(T a, int b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Xor(T a, short b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Xor(T a, long b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Xor(T a, float b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Xor(T a, double b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        bool Xor(T a, bool b);

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Xor<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 异或运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Xor2(T a, T b);
        #endregion

        #region 反运算
        /// <summary>
        /// 反运算
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        T Reverse(T a);
        #endregion

        #region 模运算
        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        int Mod(T a, int b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        short Mod(T a, short b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        long Mod(T a, long b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        float Mod(T a, float b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        double Mod(T a, double b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Mod(T a, bool b);

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Mod<U>(T a, U b) where U : struct, IComparable<T>, IConvertible;

        /// <summary>
        /// 模运算
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns></returns>
        T Mod2(T a, T b);
        #endregion

        #region 非运算
        /// <summary>
        /// 非运算
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        T Not(T a);
        #endregion

        #endregion//布尔运算
    }

    /// <summary>
    /// Pin接口
    /// </summary>
    public interface IPin : IBuffer
    {
        /// <summary>
        /// 读取是否连线
        /// </summary>
        bool Connected { get;}

        /// <summary>
        /// 读取管脚接口
        /// </summary>
        IValuable IPinner { get; }

        /// <summary>
        /// 根据索引方式读值
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        object Get(int index);

        /// <summary>
        /// 根据索引方式写值
        /// </summary>
        /// <param name="index"></param>
        /// <param name="obj"></param>
        void Set(int index, object obj);
    }

    /// <summary>
    /// 信号线集合接口
    /// </summary>
    public interface IWireCollection : ICollection<IWire>
    {
        /// <summary>
        /// 根据Pin名称获得信号线
        /// </summary>
        /// <param name="pinName"></param>
        /// <returns></returns>
        IWire this[string pinName] { get;}

        /// <summary>
        /// 根据Pin名称和Point名称获得信号线
        /// </summary>
        /// <param name="pinName"></param>
        /// <param name="pointName"></param>
        /// <returns></returns>
        IWire this[string pinName, string pointName] { get;}

        /// <summary>
        /// 根据索引获得或设置信号线
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        IWire this[int index] { get;set;}
    }

    /// <summary>
    /// 信号线接口
    /// </summary>
    public interface IWire
    {
        /// <summary>
        /// 执行信号传输
        /// </summary>
        /// <param name="RTD">RTD实例</param>
        /// <exception cref="ArgumentNullException"></exception>
        /// <exception cref="RTDException"></exception>
        /// <param name="Direction">传输方向</param>
        bool Transmit(IRTD RTD, CommunicatingDirections Direction);

        /// <summary>
        /// 获得信号线型号（对接型或引用型）
        /// </summary>
        WireAttributes Attribute { get; }

        /// <summary>
        /// 获得连接的功能块名称
        /// </summary>
        string BlockName { get; }

        /// <summary>
        /// 获得连接的功能码名称
        /// </summary>
        string FCName { get; }

        /// <summary>
        /// 获得或设置信号线是否处于连接状态
        /// </summary>
        bool IsConnected { get; set; }

        /// <summary>
        /// 设置或读取是否取反
        /// </summary>
        bool Reversed { get; set; }

        /// <summary>
        /// 获得Point(信号源)地址
        /// </summary>
        VariableAddress PinAddress { get; }

        /// <summary>
        /// 获得点对象
        /// </summary>
        IValuable Point { get; }

        /// <summary>
        /// 获得Pin对象
        /// </summary>
        IPin Pin { get; }

        /// <summary>
        /// 获得连接的管脚名称
        /// </summary>
        string PinName { get; }

        /// <summary>
        /// 获得管脚地址
        /// </summary>
        VariableAddress PointAddress { get; }

        /// <summary>
        /// 获得连接的Point名称
        /// </summary>
        string PointName { get; }

        /// <summary>
        /// 获得或设置线类型
        /// </summary>
        WireTypes Type { get; set; }
    }

    /// <summary>
    /// 命令接口
    /// </summary>
    public interface ICommand
    {
        /// <summary>
        /// 对比，如一致，返回true
        /// </summary>
        /// <param name="o"></param>
        /// <returns></returns>
        bool Compare(object o, out string result);
        /// <summary>
        /// 清空数据
        /// </summary>
        void Clear();

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="pointName">点名称</param>
        /// <param name="pinName">管脚名称</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(string pointName, string pinName, bool reversed);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="pointSID">点的系统ID</param>
        /// <param name="pinName">管脚名称</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(int pointSID, string pinName, bool reversed);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="Target">目标的名称（注：可以为任何域成员）</param>
        /// <param name="Source">源的名称（注：为该功能块域成员）</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(string[] Target, string[] Source, bool reversed);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="w"></param>
        bool AddWire(IWire w);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="pointSID">点的系统ID</param>
        /// <param name="pinName">管脚名称</param>
        /// <param name="type">信号线IO类型</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(int pointSID, string pinName, WireTypes type, bool reversed);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="pointName">点名称</param>
        /// <param name="pinName">管脚名称</param>
        /// <param name="type">信号线IO类型</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(string pointName, string pinName, WireTypes type, bool reversed);

        /// <summary>
        /// 添加信号线
        /// </summary>
        /// <param name="Target">目标的名称（注：可以为任何域成员）</param>
        /// <param name="Source">源的名称（注：为该功能块域成员）</param>
        /// <param name="Type">信号线IO类型</param>
        /// <param name="reversed">是否反转</param>
        bool AddWire(string[] Target, string[] Source, WireTypes Type, bool reversed);

        /// <summary>
        /// 命令执行函数
        /// </summary>
        /// <param name="Rtd">RTD实例</param>
        void Execute();

        /// <summary>
        /// 第一次运行的初始化函数
        /// </summary>
        void FirstRun();

        /// <summary>
        /// 删除指定管脚和点的一条信号线
        /// </summary>
        /// <param name="pointName">点名称</param>
        /// <param name="pinName">管脚名称</param>
        /// <returns></returns>
        bool RemoveWire(string pointName, string pinName);

        /// <summary>
        /// 删除所有与指定管脚连线的所有信号线
        /// </summary>
        /// <param name="pinName">管脚名称</param>
        /// <returns></returns>
        bool RemoveWire(string pinName);

        /// <summary>
        /// 删除信号线
        /// </summary>
        /// <param name="w">信号线</param>
        /// <returns></returns>
        bool RemoveWire(IWire w);

        /// <summary>
        /// 删除信号线
        /// </summary>
        /// <param name="index">信号线索引</param>
        /// <param name="attributes">信号线IO类型</param>
        /// <returns></returns>
        bool RemoveWire(int index, WireAttributes attributes);


        /// <summary>
        /// 从连线集合中获得自身的pin连接的对方pin的唯一名字，格式为  对方块名.对方pin名
        /// </summary>
        /// <param name="PinName">自身PinName</param>
        string GetLinkedPinName(string PinName);


        /// <summary>
        /// 重置命令
        /// </summary>
        void Reset();

        /// <summary>
        /// 获得RTD实例
        /// </summary>
        IRTD Rtd { get; set;}

        /// <summary>
        /// 获得Dpu实例
        /// </summary>
        IDpu Dpu { get; set;}

        /// <summary>
        /// 获得功能块的SID号
        /// </summary>
        int SID { get; }

        /// <summary>
        /// 获得功能码名称
        /// </summary>
        string FCName { get; }

        /// <summary>
        /// 获得命令名（功能块名称）
        /// </summary>
        string Name { get; }


        /// <summary>
        /// 获得引用型信号线集合（注：保存时要是所有信号线连接状态设为不连接）
        /// </summary>
        IWireCollection ReferenceWires { get; }

        /// <summary>
        /// 获得对接型信号线集合
        /// </summary>
        IWireCollection JointWires { get;}
    }

    /// <summary>
    /// 类型管理器接口
    /// </summary>
    public interface ITypeManage : IStore, IChangable
    {
        /// <summary>
        /// 智能克隆
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        object WiseClone(object obj);

        /// <summary>
        /// 智能拷贝
        /// </summary>
        /// <param name="Target"></param>
        /// <param name="Source"></param>
        /// <returns></returns>
        bool WiseCopy(object Target, object Source);

        /// <summary>
        /// 智能申请对象（注：根据已有的内存空间分配对象内部的引用关系）
        /// </summary>
        /// <param name="typeId">类型索引</param>
        /// <param name="objAddress">对象地址，包括Syncblk</param>
        /// <returns></returns>
        bool WiseNew(int typeId, IntPtr objAddress);

        /// <summary>
        /// 根据索引返回类型信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        TypeManageItem this[int typeId] { get; }

        /// <summary>
        /// 根据类型返回索引
        /// </summary>
        /// <param name="t"></param>
        /// <returns></returns>
        int this[Type t] { get; }

        /// <summary>
        /// 根据名称返回索引
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        int this[string name] { get; }

        /// <summary>
        /// 根据索引和偏移返回子变量的相关信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="offset"></param>
        /// <returns></returns>
        ChildTableItem this[int typeId, uint offset] { get; }

        /// <summary>
        /// 根据索引和复合类型中的子变量名返回子变量的相关信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <param name="name"></param>
        /// <returns></returns>
        ChildTableItem this[int typeId, string name] { get; }

        /// <summary>
        /// 根据复合类型的名称和子变量名返回子变量的相关信息
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        ChildTableItem this[params string[] names] { get; }

        /// <summary>
        /// 获得所有类型集合
        /// </summary>
        List<TypeManageItem> Types { get;}

        /// <summary>
        /// 获得偏移子表集合
        /// </summary>
        List<Dictionary<uint, ChildTableItem>> OffsetTables { get;}

        /// <summary>
        /// 获得名称子表集合
        /// </summary>
        List<Dictionary<string, ChildTableItem>> NameTables { get;}

        /// <summary>
        /// 获得系统是否为功能码测试状态
        /// </summary>
        bool IsTest { get;}
    }

    /// <summary>
    /// 分布式控制单元接口
    /// </summary>
    public interface IDpu
    {
        /// <summary>
        /// 读取周期时间（毫秒级，默认值和最小值为200毫秒）
        /// </summary>
        float Cycle { get; set;}

        /// <summary>
        /// 设置或读取周期数
        /// </summary>
        uint CycleCount { get; }

        /// <summary>
        /// 读取Dpu名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 设置或获得RTD实例
        /// </summary>
        IRTD RTD { get; }

        /// <summary>
        /// 设置或获得运行状态
        /// </summary>
        RunState State { get; set; }

        /// <summary>
        /// 设置或读取工作状态
        /// </summary>
        DpuState WorkState { get;set;}

        /// <summary>
        /// 读取版本
        /// </summary>
        string Version { get; }

        /// <summary>
        /// 设置或读取控制器ID号
        /// </summary>
        int ControllerID { get; set; }

        /// <summary>
        /// 设置或获得数据库路径
        /// </summary>
        string DBPath { get; set; }

        /// <summary>
        /// 设置或获得工况与指令文件路径
        /// </summary>
        string ProjectPath { get; set; }

        Dictionary<string, string> FCMap { get;}

        /// <summary>
        /// 获得连接的点名称
        /// </summary>
        /// <param name="blockname"></param>
        /// <param name="pinname"></param>
        /// <returns></returns>
        string[] GetLinkedPointName(string blockname, string pinname);

        /// <summary>
        /// 获得连接的Pin名称
        /// </summary>
        /// <param name="blockname"></param>
        /// <param name="pinname"></param>
        /// <returns></returns>
        string[] GetLinkedPinName(string blockname, string pinname);

        /// <summary>
        /// 添加连线
        /// </summary>
        /// <param name="BlockName">功能块名称</param>
        /// <param name="PinName">管脚名称</param>
        /// <param name="PointName">点名称</param>
        /// <returns></returns>
        bool AddLink(string BlockName, string PinName, string PointName);

        ///// <summary>
        ///// 添加变量
        ///// </summary>
        ///// <param name="Name">变量名称</param>
        ///// <param name="TypeName">变量类型名称</param>
        ///// <param name="Class">变量类别</param>
        ///// <returns></returns>
        //long AddVariable(string Name, string TypeName, DCSCommon.VariableClass Class);  

        /// <summary>
        /// 删除引脚上的指定连线
        /// </summary>
        /// <param name="BlockName">功能块名称</param>
        /// <param name="PinName">管脚名称</param>
        /// <returns></returns>
        bool DeleteLink(string BlockName, string PinName);

        /// <summary>
        /// 删除引脚上的所有连线
        /// </summary>
        /// <param name="BlockName">功能块名称</param>
        /// <param name="PinName">管脚名称</param>
        /// <param name="PointName">点名称</param>
        /// <returns></returns>
        bool DeleteLink(string BlockName, string PinName, string PointName);

         /// <summary>
        /// 释放资源
        /// </summary>
        void Dispose();

        /// <summary>
        /// 下装
        /// </summary>
        /// <returns></returns>
        bool DownLoad(string version, out string info);

        /// <summary>
        /// 获得功能块详细信息
        /// </summary>
        /// <param name="BlockName"></param>
        /// <returns></returns>
        BlockDetails[] GetBlockDetails(string BlockName);

        /// <summary>
        /// 获得所有功能块集合
        /// </summary>
        /// <returns></returns>
        string[][] GetBlocks();

        /// <summary>
        /// 获得点详细信息
        /// </summary>
        /// <param name="PointName"></param>
        /// <returns></returns>
        PointDetails[] GetPointDetails(string PointName);

        /// <summary>
        /// 获得所有点集合
        /// </summary>
        /// <returns></returns>
        string[][] GetPoints();

        /// <summary>
        /// 获取变量对象
        /// </summary>
        /// <param name="FSID">域SID</param>
        /// <returns></returns>
        object GetVariable(long FSID);

        /// <summary>
        /// 初始化业务开始
        /// </summary>
        /// <param name="type">初始化操作类型</param>
        bool InitOperationStart(InitOpType type);

        /// <summary>
        /// 暂停
        /// </summary>
        void Pause();

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="FSID"></param>
        bool RemoveVariable(long FSID);

        /// <summary>
        /// 删除变量
        /// </summary>
        /// <param name="names"></param>
        bool RemoveVariable(params string[] names);

        /// <summary>
        /// 第一次执行命令的初始化函数
        /// </summary>
        void FirstRun();

        /// <summary>
        /// 运行
        /// </summary>
        void Run();

        /// <summary>
        /// 查找变量地址
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        VariableAddress SearchVariableAddress(params string[] names);

        /// <summary>
        /// 查找变量名称
        /// </summary>
        /// <param name="FSID"></param>
        /// <returns></returns>
        string SearchVariableName(long FSID);

        /// <summary>
        /// 序列化业务
        /// </summary>
        /// <param name="WrkStream">工况的数据流</param>
        /// <param name="PrjStream">工程的数据流</param>
        /// <param name="OpType">操作类型</param>
        bool SerializeOperationStart(Stream WrkStream, Stream PrjStream, SerializeOperationType OpType);

        /// <summary>
        /// 设置变量对象
        /// </summary>
        /// <param name="FSID">域SID</param>
        /// <param name="Value">对象值</param>
        /// <returns></returns>
        bool SetVariable(long FSID, object Value);

        /// <summary>
        /// 单步
        /// </summary>
        void Step();

        /// <summary>
        /// 单步功能块
        /// </summary>
        /// <param name="Name">功能块名称</param>
        /// <returns></returns>
        bool StepBlock(string Name);

        /// <summary>
        /// 停止，保留空白DPU
        /// </summary>
        void Stop();

        /// <summary>
        /// 订约
        /// </summary>
        /// <param name="Names"></param>
        /// <returns></returns>
        long Subscribe(params string[] Names);

        /// <summary>
        /// 取消订约
        /// </summary>
        /// <param name="FSID">域SID</param>
        void UnSubscribe(long FSID);

        /// <summary>
        /// 通知开始停止
        /// </summary>
        void InformPause();

        /// <summary>
        /// 等待停止结束
        /// </summary>
        void PauseJoin();
    }
}
