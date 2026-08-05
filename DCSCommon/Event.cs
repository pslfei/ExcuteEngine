using System;
using System.Collections.Generic;
using System.Text;

namespace DCSCommon
{
    /// <summary>
    /// 预分配的资源已经使用完了
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    public delegate AllocSIDResource PreAllocSIDConsume(object sender, EventArgs e);

    /// <summary>
    /// 通知订阅器数据更新
    /// </summary>
    /// <param name="e"></param>
    public delegate void InformRefresh(InformRefreshArgs e);

    /// <summary>
    /// 消息事件
    /// </summary>
    /// <param name="msg"></param>
    public delegate void MessageEvent(string msg);


    public delegate void InformationOperatorRecordHandler(OperatorRecParams[] data);
}
