
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POWERSISAI
{
    public static class test
    {
        public static int add(int a,int b)
        {
            return a + b;
        }

        public class Output_Info
        {
            public float[][] reconData;
            public float[][] errorData;
            public float[][] paraState;
            public float R;
            public float[] SPE;
            public float[] FAI;
            public float[] Index;
        }

        public static float[][] GetReconData(string jstr)
		{
           Output_Info output_Info = JsonConvert.DeserializeObject<Output_Info>(jstr);
            return output_Info.reconData;
  
        }

        public static float[][] GetErrorData(string jstr)
        {
            Output_Info output_Info = JsonConvert.DeserializeObject<Output_Info>(jstr);
            return output_Info.errorData;
        }
    }
}
