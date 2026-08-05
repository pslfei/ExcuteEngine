using System;
using DCSCommon;
namespace FunctionCode
{
    public partial class HSALARMSPARK
	{
		protected override void Run(ICommand cmd)
		{
            if (I1 == false)
            {
                O1[0] = false;
                O2[0] = false;
                O3[0] = false;
            }

            if (OLD_I1 == false && I1 == true)
            {
                unack = true;
            }

            if (unack)
            {
                if (I1 == true && I2 == true)//O1: 表示报警正发生已确认；红色
                {
                    O1[0] = true;
                    O2[0] = false;
                    O3[0] = false;
                    unack = false;
                }
                else if (I1 == true && I2 == false)//O2: 表示报警正发生未确认；红闪
                {
                    O1[0] = false;
                    O2[0] = true;
                    O3[0] = false;
                }
                else if (I1 == false && I2 == false)//O3: 表示报警曾发生未确认；橙红色并闪烁
                {
                    O1[0] = false;
                    O2[0] = false;
                    O3[0] = true;
                }
                else if (I1 == false && I2 == true)//O3: 表示报警曾发生已确认；无色
                {
                    O1[0] = false;
                    O2[0] = false;
                    O3[0] = false;
                    unack = false;
                }
            }

            OLD_I1 = I1;
		}
	}
}
