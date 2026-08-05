using System;
using DCSCommon;
using DCSType;
namespace FunctionCode
{
	public partial class AVG
    {
		protected override void Run(ICommand cmd)
		{
			int connectedNum = 0;
            float sum = 0;

            if (IN1.Connected)
			{
				connectedNum++;
                sum += IN1;
            }

            if (IN2.Connected)
            {
                connectedNum++;
                sum += IN2;
            }

            if (IN3.Connected)
            {
                connectedNum++;
                sum += IN3;
            }

            if (IN4.Connected)
            {
                connectedNum++;
                sum += IN4;
            }

            if (IN5.Connected)
            {
                connectedNum++;
                sum += IN5;
            }

            if (IN6.Connected)
            {
                connectedNum++;
                sum += IN6;
            }

            if (IN7.Connected)
            {
                connectedNum++;
                sum += IN7;
            }

            if (IN8.Connected)
            {
                connectedNum++;
                sum += IN8;
            }

            if (connectedNum == 0)
            {
                OUT[0] = 0;
            }
            else
            {
                OUT[0] = sum / connectedNum;
            }
        }
	}
}
