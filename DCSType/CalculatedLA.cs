/*----------------------------------------------------------------
// Copyright (C) 2009 Race
// 版权所有。
//
// 文件名：CalculatedLA.cs
// 文件功能：计算LA类，支持sum和avg函数计算
//
//
// 创建标识：202X
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
using System.Reflection;
using DCSCommon;

namespace DCSType
{
    /// <summary>
    /// 自定义计算LA类，支持动态计算
    /// </summary>
    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
    [VariableClass(VariableClass.Point)]
    [Serializable]
    public class CalculatedLA : LA
    {
        private readonly List<object> _sourcePoints;
        private readonly string _calculationType;

        public CalculatedLA(List<object> sourcePoints, string calculationType)
            : base(QualityTypes.Good, false, false, false, false, false,
                  float.MaxValue, float.MinValue, 0.0f, 0, 0.0f)
        {
            _sourcePoints = sourcePoints;
            _calculationType = calculationType;
        }

        /// <summary>
        /// 更新计算值
        /// </summary>
        public void UpdateCalculatedValue()
        {
            float result = 0.0f;
            int validCount = 0;

            foreach (object point in _sourcePoints)
            {
                if (point is LA la && la.Quality == QualityTypes.Good)
                {
                    if (_calculationType == "sum")
                    {
                        result += la.buffer;
                    }
                    else if (_calculationType == "avg")
                    {
                        result += la.buffer;
                    }
                    validCount++;
                }
            }

            if (validCount == 0)
            {
                this.Quality = QualityTypes.Bad;
                this.buffer = 0.0f;
            }
            else
            {
                this.Quality = QualityTypes.Good;

                if (_calculationType == "avg")
                {
                    result = result / validCount;
                }

                this.buffer = result;
            }
        }
    }
}