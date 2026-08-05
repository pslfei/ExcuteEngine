using DCSCommon;
namespace FunctionCode
{
	public partial class HSSLMTSUM
	{
		protected override void Run(ICommand cmd) 
        {
            _ENO[0] = _EN;
            if (!_EN)
                return;

            float factor = 0.0f;//时间转换系数

            //(*输出格式,输出格式 0:秒 1：分钟 2：小时 3:ms*)
            if (SOF == 0)
            {
                factor = 1;
            }
            else if (SOF == 1)
            {
                factor = 60;
            }
            else if (SOF == 2)
            {
                factor = 3600;
            }


            if (RS)
            {
                AV[0] = 0;
                AV1[0] = 0;
            }
            else
            {
                if (I1DQ == true || I1 > AH || I1 < AL)
                {
                    float TS = cmd.Dpu.Cycle;
                    AV[0] = (AV + TS) / factor;
                    AV1[0] = AV + TS;
                }
            }
		}
	}
}
