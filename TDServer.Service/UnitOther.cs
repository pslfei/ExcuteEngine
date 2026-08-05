namespace TDServer.Service
{
    public class eletodaysum
    {
        /// <summary>
        /// 1号机当日发电量
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double value { get; set; }
    }

    public class PageInput
    {
        public string code { get; set; }

        public string unit { get; set; }

        public double Value { get; set; }

        public string Description { get; set; }

        public string datetime { get; set; }
    }

    public class Data
    {
        /// <summary>
        /// 
        /// </summary>
        public int id { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ov { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tpy { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int tsf { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int har { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int d { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int mar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int mad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double aad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double vad { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int qnetar { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double clzc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public double cfhc { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int e { get; set; }
    }

    public class Root
    {
        /// <summary>
        /// 
        /// </summary>
        public int code { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string msg { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public Data data { get; set; }
    }
}
