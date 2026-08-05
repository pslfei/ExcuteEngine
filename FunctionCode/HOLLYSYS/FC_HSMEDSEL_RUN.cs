using System;
using DCSCommon;
namespace FunctionCode
{
	public partial class HSMEDSEL
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            if (X1.Quality == DCSCommon.QualityTypes.Bad)
                Q1[0] = true;
            else
                Q1[0] = false;

            if (X2.Quality == DCSCommon.QualityTypes.Bad)
                Q2[0] = true;
            else
                Q2[0] = false;

            if (X3.Quality == DCSCommon.QualityTypes.Bad)
                Q3[0] = true;
            else
                Q3[0] = false;


            if (Q1 | Q2 | Q3)
                QQ[0] = true;
            else
                QQ[0] = false;


            if (Q1 & Q2 & Q3)//三个点都为坏点
            {
                Q0[0] = true;
            }
            else//至少有一个好点
            {
                Q0[0] = false;
                if (MD >= 4)
                {
                    if (MD == 4)
                    {
                        AV[0] = X1;
                    }
                    else if (MD == 5)
                    {
                        AV[0] = X2;
                    }
                    else if (MD == 6)
                    {
                        AV[0] = X3;
                    }
                }
                else if (MD < 4)
                {
                    if (Q1 | Q2 | Q3)//至少有一个坏点
                    {
                        
                        if (!Q1 & Q2 & Q3)//仅Q1为好点
                        {
                            AV[0] = X1;
                        }
                        else if (!Q2 & Q1 & Q3)//仅Q2为好点
                        {
                            AV[0] = X2;
                        }
                        else if (!Q3 & Q1 & Q2)//仅Q3为好点
                        {
                            AV[0] = X3;
                        }
                        else if (!Q1 & !Q2 & Q3)//Q1、Q2为好点
                        {
                            if (Math.Abs(X1 - X2) < DB)
                            {
                                AV[0] = (X1 + X2) / 2;
                            }
                        }
                        else if (!Q1 & Q2 & !Q3)//Q1、Q3为好点
                        {
                            if (Math.Abs(X1 - X3) < DB)
                            {
                                AV[0] = (X1 + X3) / 2;
                            }
                        }
                        else if (Q1 & !Q2 & !Q3)//Q2、Q3为好点
                        {
                            if (Math.Abs(X2 - X3) < DB)
                            {
                                AV[0] = (X2 + X3) / 2;
                            }
                        }
                    }
                    else if ((!Q1) & (!Q2) & (!Q3))//三个点都是好点
                    {
                        if ((Math.Abs(X1 - X3)) < DB && (Math.Abs(X1 - X2) < DB) && (Math.Abs(X2 - X3) < DB))//彼此之间偏差均不越限
                        {
                            if (MD == 0)//取三者中间值
                            {

                                float MedianValue = 0.0f;
                                if ((X1 - X2) * (X1 - X3) <= 0)
                                    MedianValue = X1;
                                else if ((X2 - X1) * (X2 - X3) <= 0)
                                    MedianValue = X2;
                                else if ((X3 - X1) * (X3 - X2) <= 0)
                                    MedianValue = X3;

                                AV[0] = MedianValue;        
                            }
                            else if (MD == 1)//取三者平均值
                            {
                                AV[0] = (X1 + X2 + X3) / 3;
                            }
                            else if (MD == 2)//取三者中低值
                            {
                                AV[0] = Math.Min(Math.Min(X1, X2), X3);
                            }
                            else if (MD == 3)//取三者中高值
                            {
                                AV[0] = Math.Max(Math.Max(X1, X2), X3);
                            }
                        }
                        else//至少有俩个点之间的偏差
                        {
                            if ((Math.Abs(X1 - X2)) < DB && (Math.Abs(X3 - X1)) > DB && (Math.Abs(X3 - X2)) > DB)
                            {
                                AV[0] = (X1 + X2) / 2;
                            }
                            else if ((Math.Abs(X1 - X3)) < DB && (Math.Abs(X2 - X1)) > DB && (Math.Abs(X2 - X3)) > DB)
                            {
                                AV[0] = (X1 + X3) / 2;
                            }
                            else if ((Math.Abs(X2 - X3)) < DB && (Math.Abs(X1 - X2)) > DB && (Math.Abs(X1 - X3)) > DB)
                            {
                                AV[0] = (X2 + X3) / 2;
                            }
                            else if ((Math.Abs(X1 - X2)) > DB && (Math.Abs(X3 - X1)) < DB && (Math.Abs(X3 - X2)) < DB)
                            {
                                AV[0] = X3;
                            }
                            else if ((Math.Abs(X1 - X3)) > DB && (Math.Abs(X2 - X1)) < DB && (Math.Abs(X2 - X3)) < DB)
                            {
                                AV[0] = X2;
                            }
                            else if ((Math.Abs(X2 - X3)) > DB && (Math.Abs(X1 - X2)) < DB && (Math.Abs(X1 - X3)) < DB)
                            {
                                AV[0] = X1;
                            }
                        }
                    }
                }
            }
        }
	}
}
