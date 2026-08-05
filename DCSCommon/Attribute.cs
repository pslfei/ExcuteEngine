using System;
using System.Collections.Generic;
using System.Text;

namespace DCSCommon
{
    /// <summary>
    /// FC名称特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class,AllowMultiple=false,Inherited=false)]
    public class FCNameAttribute:Attribute
    {
        private string fcname;

        public string FCName
        {
            get { return fcname; }
        }

        public FCNameAttribute(string FcName)
            : base()
        {
            fcname = FcName;
        }

        public override string ToString()
        {
            return fcname;
        }
    }

    /// <summary>
    /// FC描述特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public class FCDisplayAttribute : Attribute
    {
        private string displaystring;

        public FCDisplayAttribute(string DisplayString)
            : base()
        {
            displaystring = DisplayString;
        }

        public override string ToString()
        {
            return displaystring;
        }
    }

    /// <summary>
    /// 管脚类型特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class PinTypeAttribute : Attribute
    {
        private PinTypes pintype;

        public PinTypes PinType
        {
            get { return pintype; }
        }

        public PinTypeAttribute(PinTypes PinType)
            : base()
        {
            pintype = PinType;
        }

        public override string ToString()
        {
            return pintype.ToString();
        }
    }

    /// <summary>
    /// 管脚标识特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class PinAttribute : Attribute
    {
        public PinAttribute()
            : base()
        {
        }
    }

    /// <summary>
    /// 变量类型特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = false, Inherited = true)]
    public class VariableClassAttribute : Attribute
    {
        private VariableClass variableClass;

        public VariableClass VariableClass
        {
            get { return variableClass; }
        }

        public VariableClassAttribute(VariableClass VariableClass)
            : base()
        {
            variableClass = VariableClass;
        }

        public override string ToString()
        {
            return variableClass.ToString();
        }
    }

    /// <summary>
    /// 管脚描述特性
    /// </summary>
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false, Inherited = false)]
    public class PinDisplayAttribute : Attribute
    {
        private string displaystring;

        public PinDisplayAttribute(string DisplayString)
            : base()
        {
            displaystring = DisplayString;
        }

        public override string ToString()
        {
            return displaystring;
        }
    }

    /// <summary>
    /// 插件协议
    /// </summary>
    [AttributeUsage(AttributeTargets.Assembly, AllowMultiple = false, Inherited = false)]
    public class PlugAgreementAttribute : Attribute
    {
        private string agreementstring;
        private VariableClass varClass = VariableClass.Point;

        public VariableClass VarClass
        {
            get { return varClass; }
            set { varClass = value; }
        }

        public PlugAgreementAttribute(string AgreementString)
            : base()
        {
            agreementstring = AgreementString;
        }

        public override string ToString()
        {
            return agreementstring;
        }
    }
}
