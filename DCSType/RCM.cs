/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。 
//
// 文件名：RCM.cs
// 文件功能描述：RCM——Tag类型之一
// 
//
// 创建标识：赵明明200907
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
using System.Runtime.InteropServices;
using DCSCommon;

namespace DCSType
{
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    public class RCM : Tag
    {
        #region Fields
        private bool fb;

        public bool FB
        {
            get { return fb; }
            set { fb = value; }
        }
        private bool or;

        public bool OR
        {
            get { return or; }
            set { or = value; }
        }
        private double ov;

        public double OV
        {
            get { return ov; }
            set { ov = value; }
        }
        private bool p_reset;

        public bool P_RESET
        {
            get { return p_reset; }
            set { p_reset = value; }
        }
        private bool p_set;

        public bool P_SET
        {
            get { return p_set; }
            set { p_set = value; }
        }
        private bool rc;

        public bool RC
        {
            get { return rc; }
            set { rc = value; }
        }
        private bool ri;

        public bool RI
        {
            get { return ri; }
            set { ri = value; }
        }
        private bool s_reset;

        public bool S_RESET
        {
            get { return s_reset; }
            set { s_reset = value; }
        }
        private bool s_set;

        public bool S_SET
        {
            get { return s_set; }
            set { s_set = value; }
        }
        private bool sc;

        public bool SC
        {
            get { return sc; }
            set { sc = value; }
        }
        private bool si;

        public bool SI
        {
            get { return si; }
            set { si = value; }
        }
        private bool sp;

        public bool SP
        {
            get { return sp; }
            set { sp = value; }
        }
        private bool tag;

        public bool TAG
        {
            get { return tag; }
            set { tag = value; }
        }
        #endregion

        #region OverLoad
        public override object GetMemberValue(params string[] names)
        {
            if (names == null || names.Length < 1 || names[0] == null)
                return null;
            switch (names[0])
            {
                case "fb":
                    return this.FB;
                case "or":
                    return this.OR;
                case "ov":
                    return this.OV;
                case "p_reset":
                    return this.P_RESET;
                case "p_set":
                    return this.P_SET;
                case "rc":
                    return this.RC;
                case "ri":
                    return this.RI;
                case "s_reset":
                    return this.S_RESET;
                case "s_set":
                    return this.S_SET;
                case "sc":
                    return this.SC;
                case "si":
                    return this.SI;
                case "sp":
                    return this.SP;
                case "tag":
                    return this.TAG;
            }
            return base.GetMemberValue(names);
        }

        public override void SetMemberValue(object value, params string[] names)
        {
            if (value == null || names == null || names.Length < 1 || names[0] == null)
                return;
            switch (names[0])
            {
                case "fb":
                    this.FB = (bool)value;
                    break;
                case "or":
                    this.OR = (bool)value;
                    break;
                case "ov":
                    this.OV = (double)value;
                    break;
                case "p_reset":
                    this.P_RESET = (bool)value;
                    break;
                case "p_set":
                    this.P_SET = (bool)value;
                    break;
                case "rc":
                    this.RC = (bool)value;
                    break;
                case "ri":
                    this.RI = (bool)value;
                    break;
                case "s_reset":
                    this.S_RESET = (bool)value;
                    break;
                case "s_set":
                    this.S_SET = (bool)value;
                    break;
                case "sc":
                    this.SC = (bool)value;
                    break;
                case "si":
                    this.SI = (bool)value;
                    break;
                case "sp":
                    this.SP = (bool)value;
                    break;
                case "tag":
                    this.TAG = (bool)value;
                    break;
            }
            base.SetMemberValue(value, names);
        }
        #endregion
    }
}
