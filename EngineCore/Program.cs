using EngineCore;
using EngineCore.Models;

namespace DBFirstMysql
{
    //ExcuteEngine：Initial，RunOneStep,Run,Pause,Stop
    //RTD:支持订阅，支持变化判断（lastValue）,读入（订阅dcs值），写入历史库变化的值

    public class Program
    {

        static void Main(string[] args)
        {

            //using (WarnContext warnContext = new WarnContext())
            //{
            //    List<CfgVarsystem> CfgVarsystemList = warnContext.CfgVarsystems.ToList();
            //    List<CldFcblock> cldFcblockList = warnContext.CldFcblocks.ToList();
            //    List<CldFcinput> CldFcinputList = warnContext.CldFcinputs.ToList();
            //    List<CldFcoutput> CldFcoutputList = warnContext.CldFcoutputs.ToList();
            //    List<CldFcparameter> CldFcparameterList = warnContext.CldFcparameters.ToList();
            //}
            Console.ReadKey();
        }
    }
}

