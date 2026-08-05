using System;
using System.Collections.Generic;
using System.Text;

namespace DCSCommon
{
    /// <summary>
    /// RTD操作异常
    /// </summary>
    public class RTDException : System.Exception
    {
        private string message;

        public RTDException(string Message)
        {
            message = Message;
        }

        public override string Message
        {
            get
            {
                return message;
            }
        }

        public override string ToString()
        {
            if (message != null)
                return message;
            else return string.Empty;
        }
    }

    /// <summary>
    /// 装载操作异常
    /// </summary>
    public class LoadException : System.Exception
    {
        private string message;

        public LoadException(string Message)
        {
            message = Message;
        }

        public override string Message
        {
            get
            {
                return message;
            }
        }

        public override string ToString()
        {
            if (message != null)
                return message;
            else return string.Empty;
        }
    }

    /// <summary>
    /// 命令异常
    /// </summary>
    public class CommandException : Exception
    {
        private string message;

        public CommandException(string Message)
        {
            message = Message;
        }

        public override string Message
        {
            get
            {
                return message;
            }
        }

        public override string ToString()
        {
            if (message != null)
                return message;
            else return string.Empty;
        }
    }

    /// <summary>
    /// 插件协议异常
    /// </summary>
    public class PlugAgreementException : Exception
    {
        private string message;

        public PlugAgreementException(string Message)
        {
            message = Message;
        }

        public override string Message
        {
            get
            {
                return message;
            }
        }

        public override string ToString()
        {
            if (message != null)
                return message;
            else return string.Empty;
        }
    }
}
