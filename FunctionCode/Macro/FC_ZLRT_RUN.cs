using DCSCommon;
using System;

namespace FunctionCode
{
    public partial class ZLRT
    {
        public override DCSCommon.ICommand Command
        {
            get
            {
                return base.Command;
            }
            set
            {
                base.Command = value;
            }
        }

        protected override void Run(ICommand cmd)
        {
            //if (IN > H || IN < L)
            //{
            //    FI[0] = true;
            //    num = 0;
            //}
            //else
            //{
                FI[0] = false;
                if (num < SP)
                {
                    num += 1;
                }
                else
                {
                    if (Math.Abs(IN - IK[DP]) > RL && DV == false)
                    {
                        LC = 0;
                        DV[0] = true;
                    }
                    else
                    {
                        if (Math.Abs(IN - IK[DP]) > RL)
                        {
                            LC = 0;
                        }
                        else
                        {
                            if (DV == true && (LC < AP))
                            {
                                LC += 1;
                            }
                            else
                            {
                                if (DV == true && (LC >= AP))
                                {
                                    DV[0] = false;
                                    LC = 0;
                                }
                            }
                        }
                    }
                }
            //}
            IK[0] = IN;
            for (int i = 8; i >= 0; i--)
            {
                IK[i + 1] = IK[i];
            }
        }
    }
}
