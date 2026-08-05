using System;
using System.Collections.Generic;
using System.Text;
using DCSCommon;
using DCSType;
using System.Runtime.InteropServices;

namespace FunctionCode
{
	[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi, Pack = 1)]
	[FCName("HSsoeRead")]
	[FCDisplay("")]
	public partial class HSsoeRead : Function 
	{
		[PinType(PinTypes.Constant)]
		[PinDisplay("1-bf满，0-bf空")]
        private byte BS = 0;

		[PinType(PinTypes.Constant)]
		[PinDisplay("")]
        private byte bSOEexist = 0;

		[PinType(PinTypes.Output)]
		[PinDisplay("错误代码。0-正确，1-错误。error code , 0--correct , 1--wrong若ER为0，表示没有错误。若ER为1，表示有错误。")]
		private LA ER = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("SOE包号,从1开始,到255,循环计数")]
        private byte PN = 0;

		[PinType(PinTypes.Output)]
		[PinDisplay("控制器中新的SOE事件记录的总个数。the sum of the SOE events in  the controller若newNum为0，表示没有新的SOE事件的数据记录。若newNum大于0，表示读取的SOE事件记录的个数。")]
		private LA newNum = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("清空SOE缓冲区，1-清空，0：保持")]
        private byte CB = 0;

		[PinType(PinTypes.Output)]
		[PinDisplay("读取的SOE事件记录的个数。the events number can be read in the controller若rN为0，表示没有新的SOE事件的数据记录。bf中为空。若rN大于0，表示读取的SOE事件记录的个数。记录放在bf中。即存放在bf中的有效数据的个数。")]
		private LA rN = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Constant)]
		[PinDisplay("清空SOE缓冲区的相应序号，与PN相对应")]
        private byte CN = 0;

		[PinType(PinTypes.Output)]
		[PinDisplay("SOE事件记录区的CRC校验")]
		private LA bFC = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);

		[PinType(PinTypes.Output)]
		[PinDisplay("")]
		private LA bf = new LA(QualityTypes.Good, false, false, false, false, false, float.MaxValue, float.MinValue, 0.0f, 0, 0.0f);
	}
}
