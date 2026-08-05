using System;
using DCSCommon;
using DCSType;
namespace FunctionCode
{
	public partial class MIN
	{
		protected override void Run(ICommand cmd) 
        {
            //OUT[0] = Math.Min(IN1, IN2);
            List<LA> list = new List<LA>();
            if (IN1.Connected)
            {
                list.Add(IN1);
            }

            if (IN2.Connected)
            {
                list.Add(IN2);
            }

            if (IN3.Connected)
            {
                list.Add(IN3);
            }

            if (IN4.Connected)
            {
                list.Add(IN4);
            }

            if (IN5.Connected)
            {
                list.Add(IN5);
            }

            if (IN6.Connected)
            {
                list.Add(IN6);
            }

            if (IN7.Connected)
            {
                list.Add(IN7);
            }

            if (IN8.Connected)
            {
                list.Add(IN8);
            }

            OUT[0] = list.Select(x => x.buffer).Min();
        }
	}
}
