using DCSCommon;
namespace FunctionCode
{
    public partial class E_H
	{
		protected override void Run(ICommand cmd)
		{
            WH[0] = 0;
            ER[0] = false;

            if (MU <= MD)
            {
                ER[0] = true;
                return;
            }

            //(*add by DJ , for the reason : if AV out of range , should reach the limits , not zero *)
            if (AV > MU)
            {
                AV[0] = MU;
            }

            if (AV < MD)
            {
                AV[0] = MD;
            }

            //输出16进制数据
            WH[0] = int.Parse(System.Convert.ToString((int)((AV - MD) / (MU - MD)), 16));
		}
	}
}
