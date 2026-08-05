using DCSType;

namespace TDServer.Service
{
    public static class ExpandDateTime
    {

        public static long ToTimeStamp(this DateTime date)
        {
            System.DateTime startTime = new System.DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            long timeStamp = (long)(date - startTime).TotalMilliseconds;
            return timeStamp;

        }
        public static string ToFormatString(this DateTime date) => date.ToString("yyyy-MM-dd HH:mm:ss");

        /// <summary>
        /// UTC时间戳Timestamp转换为北京时间
        /// </summary>
        /// <param name="timestamp">要转换的时间戳</param>
        /// <returns></returns>
        public static DateTime ToDateTime(this string timestamp)
        {
            //DateTime dtStart = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); 
            //使用上面的方式会显示TimeZone已过时
            DateTime dtStart = TimeZoneInfo.ConvertTime(new DateTime(1970, 1, 1), TimeZoneInfo.Local);
            long longTimeStamp = long.Parse(timestamp + "0000");
            TimeSpan timeSpan = new TimeSpan(longTimeStamp);
            DateTime targetDt = dtStart.Add(timeSpan).AddHours(8);
            return targetDt;
        }


        public static string ToUTCString(this DateTime date) => date.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssZ");

        public static string ToTableName(this string name)
        {
            string tbName = name.Trim().Replace(" ", "").Replace(".", "").Replace("/", "_");
            return tbName;
        }

        public static Random ran_int = new Random();
        public static Random ran_float = new Random();

        public static double To2d(this double dv)
        {
            return Convert.ToDouble(Math.Round(dv, 2, MidpointRounding.ToEven));
        }

        public static double ToXd(this double dv, int num)
        {
            return Convert.ToDouble(Math.Round(dv, num, MidpointRounding.ToEven));
        }

        public static double ToDouble(this string sv)
        {
            return Convert.ToDouble(sv);
        }

        public static double To2d(this LA dv)
        {
            return Math.Round(dv.buffer, 2, MidpointRounding.ToEven);
        }

        public static float? ToFloatOrNull(this string input)
        {
            // 也可以在这里处理 string.IsNullOrWhiteSpace(input) 等情况
            return float.TryParse(input, out float result) ? result : (float?)null;
        }


        public static double Random(this double dv, int lv, int hv)
        {
            int ints = ran_int.Next(lv, hv);
            dv = ints + ran_float.NextDouble();
            return Math.Round(dv, 2, MidpointRounding.ToEven);
        }

        public static double Random(this LA dv, int lv, int hv)
        {
            int ints = ran_int.Next(lv, hv);
            dv.buffer = (float)(ints + ran_float.NextDouble());
            return Math.Round(dv, 2, MidpointRounding.ToEven).To2d();
        }
    }
}
