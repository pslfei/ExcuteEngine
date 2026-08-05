using DBServer.LogServer;
using DBServer.Model;
using DCSType;
using Newtonsoft.Json;
using System.Dynamic;
using System.Text;
using TDengineDriver;
using TDengineDriver.Impl;

namespace TDServer.Service
{
    public class TDengineHelp
    {
        private static string database = "test";
        private static string host = "192.168.1.43";

        private static LoggerService<TDengineHelp> logger = null;

        static TDengineHelp()
        {
            if (logger == null)
            {
                logger = new LoggerService<TDengineHelp>();
            }
        }
        public static void ExitTDengine()
        {
            TDengine.Cleanup();
        }

        /// <summary>
        /// 设置数据库信息
        /// </summary>
        /// <param name="_database">数据库名称</param>
        /// <param name="_host">数据库地址</param>
        public static void SetDbInfo(string _database, string _host)
        {
            database = _database;
            host = _host;
            logger.InfoLog("数据库设置完成" + database + host);
        }

        /// <summary>
        /// 批量写入数据库
        /// </summary>
        /// <param name="points"></param>
        /// <param name="writeNumber">zh</param>
        /// <returns></returns>
        public static bool InsertTDengine(Dictionary<string, PointModel> points, int writeNumber = 3000)
        {
            if (points == null || points.Count == 0)
                return false;
            if (writeNumber <= 0)
                writeNumber = 4000;

            System.DateTime begintime = DateTime.Now;

            if (points.Count <= writeNumber)
            {
                //无需分组
                IntPtr conn = GetConnection();
                Insert(points, conn);
                FreeConnection(conn);
                conn = IntPtr.Zero;
            }
            else
            {
                //需要分组
                double dCount = points.Count / (writeNumber * 1f);
                int dicsCount = (int)Math.Ceiling(dCount);//需要分组的个数
                int counter = 0;
                //  GetConns(dicsCount);//创建和任务数量相等的连接
                var gg = points.GroupBy(g => counter++ / writeNumber);

                if (true)
                {
                    //分组串行执行
                    IntPtr conn = GetConnection();
                    foreach (var item in gg)
                    {
                        var arry = item.ToArray();
                        bool isSuccess = InsertArry(arry, conn);
                        arry = null;
                    }
                    FreeConnection(conn);
                    conn = IntPtr.Zero;
                }
                else
                {
                    //并行
                    var tasks = new List<Task<bool>>();
                    foreach (var item in gg)
                    {
                        Task<bool> result = Task.Run(() =>
                        {
                            var arry = item.ToArray();
                            IntPtr conn = GetConnection();
                            bool isSuccess = InsertArry(arry, conn);//conns[item.Key]                   

                            FreeConnection(conn);
                            conn = IntPtr.Zero;

                            arry = null;
                            return isSuccess;
                        });
                        tasks.Add(result);
                    }
                    while (tasks.Count > 0)
                    {
                        var completedTask = Task.WhenAny(tasks).Result;//这里的Result是指代Task<int>!
                        tasks.Remove(completedTask);
                        //Console.WriteLine("A task has been completed with result {0}.", completedTask.Result);
                        //if (!completedTask.Result)
                        //{
                        //    return false;
                        //}
                    }
                    tasks?.Clear();
                    tasks = null;
                }
                gg = null;
            }

            Console.WriteLine(string.Format("{0}......cost {1} ms", points == null ? 0 : points.Count, (DateTime.Now - begintime).TotalMilliseconds));
            return true;
        }

        public static bool InsertArry(KeyValuePair<string, PointModel>[] points, IntPtr conn)
        {
            if (points == null || points.Length <= 0 || conn == IntPtr.Zero)
                return false;

            bool susscessflag = true;
            //  IntPtr conn = GetConnection();
            IntPtr res;
            StringBuilder valuesBuilder = new StringBuilder();
            foreach (var item in points)
            {
                valuesBuilder.Append(" " + item.Key.ToTableName());
                valuesBuilder.Append(" VALUES ");
                valuesBuilder.Append("(");
                valuesBuilder.Append($"'{item.Value.DateTime}',{item.Value.Value}");
                valuesBuilder.Append(") ");
            }
            var sql = "INSERT INTO" + valuesBuilder.ToString();
            try
            {
                res = TDengine.Query(conn, sql);
                susscessflag = CheckRes(conn, res, "failed to insert data");
                FreeResult(res);
                res = IntPtr.Zero;
                if (!susscessflag)
                    Console.WriteLine("insert failed.");
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
                susscessflag = false;
                if ("failed to insert data since: Table does not exist" == msg)
                {
                    //CreateTablesByDic(points); 万工说的，来的数据必须和点表 一样，没有在点表里面填写的直接丢弃
                    //   logger.InfoLog("数据库中有不存在的点，系统对比且自创建");

                }
                logger.ErrorLog(msg);
            }
            sql = null;
            valuesBuilder?.Clear();
            valuesBuilder = null;
            res = IntPtr.Zero;

            return susscessflag;

        }
        public static bool Insert(Dictionary<string, PointModel> points, IntPtr conn)
        {
            if (points == null || points.Count <= 0 || conn == IntPtr.Zero)
                return false;

            bool susscessflag = false;
            IntPtr res;
            StringBuilder valuesBuilder = new StringBuilder();
            foreach (var item in points)
            {
                valuesBuilder.Append(" " + item.Key.ToTableName());
                valuesBuilder.Append(" VALUES ");
                valuesBuilder.Append("(");
                valuesBuilder.Append($"'{item.Value.DateTime}',{item.Value.Value}");
                valuesBuilder.Append(") ");
            }
            var sql = "INSERT INTO" + valuesBuilder.ToString();
            try
            {
                res = TDengine.Query(conn, sql);
                susscessflag = CheckRes(conn, res, "failed to insert data");
                if (!susscessflag)
                {
                    logger.ErrorLog(sql);
                }
                FreeResult(res);
                res = IntPtr.Zero;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.ToString());
                susscessflag = false;
            }

            sql = null;
            valuesBuilder?.Clear();
            valuesBuilder = null;
            res = IntPtr.Zero;

            return susscessflag;

        }
        public static bool Insert(string sql)
        {
            if (sql == null || sql.Trim() == "")
                return false;
            IntPtr conn = GetConnection();
            IntPtr res;
            bool result = true;
            try
            {
                res = TDengine.Query(conn, sql);
                bool bb = CheckRes(conn, res, "failed to insert data");
                if (!bb)
                {
                    logger.ErrorLog(sql);
                }
                FreeResult(res);
                res = IntPtr.Zero;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.ToString());
                result = false;
            }
            finally
            {
                res = IntPtr.Zero;
            }
            FreeConnection(conn);
            conn = IntPtr.Zero;
            return result;

        }

        public static bool Insert(List<string> sqlList)
        {
            if (sqlList == null || sqlList.Count == 0)
                return false;
            IntPtr conn = GetConnection();
            IntPtr res = IntPtr.Zero;
            bool result = true;
            int writeNumber = 1000;
            try
            {
                for (int i = 0; i < sqlList.Count; i += writeNumber)
                {
                    string sql = "insert into ";
                    for (int j = i; j < Math.Min(i + writeNumber, sqlList.Count); j++)
                    {
                        sql += sqlList[j];
                    }
                    sql += ";";

                    res = TDengine.Query(conn, sql);
                    bool bb = CheckRes(conn, res, "failed to insert data");
                    if (!bb)
                    {
                        logger.ErrorLog(sql);
                    }
                }

                FreeResult(res);
                res = IntPtr.Zero;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.ToString());
                result = false;
            }
            finally
            {
                res = IntPtr.Zero;
            }
            FreeConnection(conn);
            conn = IntPtr.Zero;
            return result;

        }


        public static bool Insert(Dictionary<string, double> dict)
        {
            if (dict?.Count == 0)
            {
                return true;
            }
            string sql = "insert into ";
            foreach (var itme in dict)
            {
                sql += $" {itme.Key} values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}','{itme.Value}')";
            }
            sql += ";";
            Insert(sql);
            return false;
        }


        #region 数据写入服务心跳
        /// <summary>
        /// 心跳数据写入到数据库，方便保护软件读取
        /// </summary>
        public static void HeartBeat(bool isSuccess, string msg = "操作成功")
        {
            return;

            IntPtr conn = GetConnection();
            var sql = $"INSERT INTO server_Log VALUES ('{DateTime.Now.ToFormatString()}','{isSuccess.ToString().ToLower()}','{msg}');";
            try
            {
                var s = sql.ToLower();
                IntPtr res = TDengine.Query(conn, s);
                CheckRes(conn, res, "failed to insert data");
                FreeResult(res);
                res = IntPtr.Zero;
            }
            catch (Exception ex)
            {
                //  success = false;
            }
            FreeConnection(conn);
            conn = IntPtr.Zero;
        }
        private static void CreateLogTable()
        {
            try
            {
                IntPtr conn = GetConnection();
                string sql = "CREATE TABLE server_Log (ts TIMESTAMP, run_state BOOL, message NCHAR(100))";
                IntPtr res = TDengine.Query(conn, sql);
                CheckRes(conn, res, "failed to create stable");

                FreeResult(res);
                res = IntPtr.Zero;
                FreeConnection(conn);
                conn = IntPtr.Zero;
            }
            catch (Exception ex)
            {

            }


        }
        #endregion
        public static bool CreateTables(IEnumerable<VPoint> vPoints)
        {
            if (vPoints == null)
                return false;

            long index = 0;
            IntPtr conn = GetConnection();
            if (conn == IntPtr.Zero)
                return false;


            IntPtr res;// =TDengine.Query(conn, "CREATE DATABASE power WAL_RETENTION_PERIOD 3600");
                       // CheckRes(conn, res, "failed to create database");
            res = TDengine.Query(conn, "drop DATABASE  " + database);
            CheckResPtr(res, "failed to create database");
            FreeResult(res);

            res = TDengine.Query(conn, "CREATE DATABASE " + database);
            CheckResPtr(res, "failed to create database");
            FreeResult(res);

            res = TDengine.Query(conn, "USE " + database);
            string sql = null;
            foreach (var item in vPoints)
            {
                try
                {
                    //string tbName = "dcs_" + item.Name.ToLower().Replace("-", "_").Trim().Replace(" ", "").Replace(".", "")
                    //    .Replace("/","_").Replace("@","_");
                    //Console.WriteLine(tbName);
                    string tbName = item.Name.ToTableName();
                    CheckRes(conn, res, "failed to change database");
                    sql = "CREATE TABLE " + tbName + " (ts TIMESTAMP, pvalue FLOAT)";
                    res = TDengine.Query(conn, sql);
                    CheckRes(conn, res, "failed to create stable");
                    //item.Name= tbName;
                    Console.WriteLine("创建{0}", tbName);

                    FreeResult(res);
                    res = IntPtr.Zero;
                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.ToString());
                    //TDengine.Close(conn);

                }
            }
            res = IntPtr.Zero;
            FreeConnection(conn);
            conn = IntPtr.Zero;

            CreateLogTable();
            Console.WriteLine(index);
            return true;
        }
        /// <summary>
        /// 写入创建表
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>

        public static bool CreateTablesByDict(KeyValuePair<string, PointModel>[] points)
        {
            if (points == null || points.Length == 0) return false;

            List<object> tbNames = QueryTables();
            IntPtr conn = GetConnection();
            IntPtr res;
            string sql = null;


            foreach (var item in points)
            {
                bool find = false;//表示找不到（默认值）
                try
                {
                    string tbName = item.Key.ToTableName();
                    foreach (var n in tbNames)
                    {
                        if (tbName == n.ToString())
                        {
                            find = true;
                            break;
                        }
                    }
                    if (!find)
                    {
                        sql = "CREATE TABLE " + tbName + " (ts TIMESTAMP, pvalue FLOAT)";
                        res = TDengine.Query(conn, sql);
                        CheckRes(conn, res, "failed to create stable");

                        FreeResult(res);
                        res = IntPtr.Zero;

                    }
                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.ToString());
                    //TDengine.Close(conn);
                }
            }

            tbNames?.Clear();
            tbNames = null;
            res = IntPtr.Zero;

            FreeConnection(conn);
            conn = IntPtr.Zero;

            // Console.WriteLine(index);
            return true;
        }

        /// <summary>
        /// /初始化创建表
        /// </summary>
        /// <param name="points"></param>
        /// <returns></returns>
        public static bool CreateTablesByArray(string[] pointsName)
        {

            if (pointsName == null)
                return false;

            List<object> tbNames = QueryTables();
            IntPtr conn = GetConnection();
            IntPtr res;
            string sql = null;
            if (tbNames == null)
                return false;

            foreach (var item in pointsName)
            {
                bool find = false;//表示找不到（默认值）
                try
                {
                    string tbName = item.ToTableName();
                    foreach (var n in tbNames)
                    {
                        if (tbName == n.ToString())
                        {
                            find = true;
                            break;
                        }

                    }
                    if (!find)
                    {
                        sql = "CREATE TABLE " + tbName + " (ts TIMESTAMP, pvalue FLOAT)";
                        res = TDengine.Query(conn, sql);
                        CheckRes(conn, res, "failed to create stable");

                        FreeResult(res);
                        res = IntPtr.Zero;
                    }

                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.ToString());
                    TDengine.Close(conn);
                }
            }

            tbNames?.Clear();
            tbNames = null;
            res = IntPtr.Zero;
            FreeConnection(conn);
            conn = IntPtr.Zero;

            // Console.WriteLine(index);
            return true;
        }
        public static List<Object> QueryTables()
        {
            List<Object>? resData = null;
            var conn = GetConnection();
            if (conn == IntPtr.Zero)
            {
                //throw new Exception("Connect to TDengine failed");
                return null;
            }
            else
            {
                IntPtr res = TDengine.Query(conn, " show tables;");
                if (TDengine.ErrorNo(res) != 0)
                {
                    // throw new Exception("Failed to query since: " + TDengine.Error(res));
                }
                // print values
                resData = LibTaos.GetData(res);

                FreeResult(res);
                res = IntPtr.Zero;

            }
            FreeConnection(conn);
            conn = IntPtr.Zero;

            return resData;
        }


        public static List<Object> QuerySTables()
        {
            List<Object>? resData = null;
            var conn = GetConnection();
            if (conn == IntPtr.Zero)
            {
                //throw new Exception("Connect to TDengine failed");
                return null;
            }
            else
            {
                IntPtr res = TDengine.Query(conn, " show stables;");
                if (TDengine.ErrorNo(res) != 0)
                {
                    // throw new Exception("Failed to query since: " + TDengine.Error(res));
                }
                // print values
                resData = LibTaos.GetData(res);

                FreeResult(res);
                res = IntPtr.Zero;

            }
            FreeConnection(conn);
            conn = IntPtr.Zero;

            return resData;
        }


        public static IntPtr GetConnection()
        {
            short port = 6030;
            string username = Environment.GetEnvironmentVariable("TDENGINE_USERNAME")
                ?? throw new InvalidOperationException("缺少必需的环境变量：TDENGINE_USERNAME");
            string password = Environment.GetEnvironmentVariable("TDENGINE_PASSWORD")
                ?? throw new InvalidOperationException("缺少必需的环境变量：TDENGINE_PASSWORD");
            string dbname = database;
            var conn = TDengine.Connect(host, username, password, dbname, port);
            if (conn == IntPtr.Zero)
            {
                // throw new Exception("Connect to TDengine failed");
                Console.WriteLine($"host is 【{host}】 username is 【{username}】 dbname is 【{dbname}】 port is 【{port}】");
                Console.WriteLine("Connect to TDengine failed");
            }
            else
            {
                //Console.WriteLine("Connect to TDengine success");
            }
            return conn;

        }

        public static bool CheckRes(IntPtr conn, IntPtr res, String errorMsg)
        {
            if (TDengine.ErrorNo(res) != 0)
            {
                // errorMsg= $"{errorMsg} since: {TDengine.Error(res)}";
                string str = $"{errorMsg} since: {TDengine.Error(res)}";
                logger.ErrorLog(str);
                //throw new Exception($"{errorMsg} since: {TDengine.Error(res)}");
                Console.WriteLine("insert failed. " + str);
                return false;
            }
            return true;

        }
        static void CheckResPtr(IntPtr res, string errorMsg)
        {
            if (TDengine.ErrorNo(res) != 0)
            {
                //throw new Exception(errorMsg + " since:" + TDengine.Error(res));
                string str = errorMsg + " since:" + TDengine.Error(res);
                logger.ErrorLog(str);
            }
        }

        /// <summary>
        /// close
        /// </summary>
        /// <param name="conn"></param>
        /// <returns></returns>
        public static bool FreeConnection(IntPtr conn)
        {
            if (conn == IntPtr.Zero)
            {
                return false;
            }

            try
            {
                TDengine.Close(conn);
                //TDengine.FreeResult(conn);
                //TDengine.Cleanup();//退出程序的时候调用一次
            }
            catch
            {
                return false;
            }
            return true;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="result"></param>
        /// <returns></returns>
        public static bool FreeResult(IntPtr result)
        {
            if (result == IntPtr.Zero)
            {
                return false;
            }

            try
            {
                TDengine.FreeResult(result);
                //TDengine.Cleanup();//退出程序的时候调用一次
            }
            catch
            {
                return false;
            }
            return true;
        }

        public static void CreateWarnTable(Dictionary<string, string> warnDict)
        {
            return;
            try
            {
                List<object> tbNames = QueryTables();
                List<object> stbNames = QuerySTables();
                if (stbNames != null && stbNames.Count > 0)
                {
                    tbNames.AddRange(stbNames);
                }


                IntPtr conn = GetConnection();

                try
                {

                    foreach (var item in warnDict)
                    {
                        string tbName = item.Key;
                        if (!tbNames.Contains(tbName))
                        {
                            string sql = item.Value;
                            IntPtr res = TDengine.Query(conn, sql);
                            CheckRes(conn, res, "failed to create stable");

                            FreeResult(res);
                            res = IntPtr.Zero;
                        }
                    }
                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.ToString());
                }

                tbNames?.Clear();
                FreeConnection(conn);
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
            }
        }


        public static bool CreateSCalcTablesByDict(Dictionary<string, Dictionary<string, object>> secondaryCalculationPinList)
        {
            return true;
            try
            {
                Dictionary<string, string> createTableList = new Dictionary<string, string>();
                foreach (var item in secondaryCalculationPinList)
                {
                    string tableName = item.Key;
                    string createTableSql = $"CREATE TABLE {tableName}(ts TIMESTAMP,";
                    //string insertSql = $"insert into {tableName}(ts,";


                    foreach (var item2 in item.Value)
                    {
                        string filedName = item2.Key;
                        createTableSql += filedName + " FLOAT,";
                        //insertSql += filedName + ",";
                    }
                    createTableSql = createTableSql.TrimEnd(',') + ")";
                    createTableList.Add(tableName, createTableSql);
                }

                if (createTableList == null || createTableList.Count == 0) return false;

                List<object> tbNames = QueryTables();
                IntPtr conn = GetConnection();
                IntPtr res;

                foreach (var item in createTableList)
                {
                    bool find = false;//表示找不到（默认值）
                    try
                    {
                        string tbName = item.Key.ToTableName();
                        foreach (var n in tbNames)
                        {
                            if (tbName == n.ToString())
                            {
                                find = true;
                                break;
                            }
                        }
                        if (!find)
                        {
                            res = TDengine.Query(conn, item.Value);
                            CheckRes(conn, res, "failed to create stable");

                            FreeResult(res);
                            res = IntPtr.Zero;

                        }
                    }
                    catch (Exception ex)
                    {
                        logger.ErrorLog(ex.ToString());
                        //TDengine.Close(conn);
                    }
                }

                tbNames?.Clear();
                tbNames = null;
                res = IntPtr.Zero;

                FreeConnection(conn);
                conn = IntPtr.Zero;

                // Console.WriteLine(index);
                return true;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.Message);
                return false;
            }
        }

        public static bool CreateSTablesByDict(Dictionary<string, string> dict)
        {
            if (dict == null || dict.Count == 0) return false;



            IntPtr conn = GetConnection();
            IntPtr res;

            foreach (var item in dict)
            {
                try
                {
                    string tbName = item.Key.ToTableName();

                    res = TDengine.Query(conn, item.Value);
                    CheckRes(conn, res, "failed to create stable");

                    FreeResult(res);
                    res = IntPtr.Zero;

                }
                catch (Exception ex)
                {
                    logger.ErrorLog(ex.ToString());
                    //TDengine.Close(conn);
                }
            }


            res = IntPtr.Zero;

            FreeConnection(conn);
            conn = IntPtr.Zero;
            return true;



            //try
            //{
            //    if (dict == null || dict.Count == 0) return false;

            //    List<object> tbNames = QueryTables();
            //    List<object> stbNames = QuerySTables();
            //    if (stbNames != null && stbNames.Count > 0)
            //    {
            //        tbNames.AddRange(stbNames);
            //    }

            //    IntPtr conn = GetConnection();
            //    IntPtr res;

            //    foreach (var item in dict)
            //    {
            //        try
            //        {
            //            string tbName = item.Key.ToTableName();
            //            if (!tbNames.Contains(tbName))
            //            {
            //                res = TDengine.Query(conn, item.Value);
            //                CheckRes(conn, res, "failed to create stable");

            //                FreeResult(res);
            //                res = IntPtr.Zero;
            //            }
            //        }
            //        catch (Exception ex)
            //        {
            //            logger.ErrorLog(ex.ToString());
            //            //TDengine.Close(conn);
            //        }
            //    }

            //    tbNames?.Clear();
            //    tbNames = null;
            //    res = IntPtr.Zero;

            //    FreeConnection(conn);
            //    conn = IntPtr.Zero;
            //    return true;
            //}
            //catch (Exception ex)
            //{
            //    logger.ErrorLog(ex.Message);
            //    return false;
            //}

        }

        public static void InsertSCalcDataByDict(Dictionary<string, Dictionary<string, object>> secondaryCalculationPinList)
        {
            if (secondaryCalculationPinList.Count > 0)
            {
                //List<string> insertTableList = new List<string>();
                string insertSql = $"insert into ";
                foreach (var item in secondaryCalculationPinList)
                {
                    string tableName = item.Key;
                    insertSql += $"{tableName} (ts,";
                    string valueSql = $" values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',";

                    foreach (var item2 in item.Value)
                    {
                        string filedName = item2.Key;
                        insertSql += filedName + ",";

                        double value = 0;
                        if (item2.Value is LA)
                        {
                            value = ((LA)item2.Value).buffer;
                        }
                        else if (item2.Value is LD)
                        {
                            value = ((LD)item2.Value).buffer ? 1 : 0;
                        }
                        valueSql += value.ToString() + ",";
                    }

                    insertSql = insertSql.TrimEnd(',') + ")";
                    valueSql = valueSql.TrimEnd(',') + ")";
                    insertSql += valueSql;

                    //insertTableList.Add(insertSql);
                }
                insertSql += ";";
                Insert(insertSql);
            }
        }

        static Dictionary<string, List<WarnRValue>> oldWarnRValueList = new Dictionary<string, List<WarnRValue>>();
        public static void InsertWarnRDataByDict(Dictionary<string, List<WarnRValue>> warnRValueList)
        {
            try
            {
                if (warnRValueList.Count > 0)
                {
                    string insertSql = "";
                    foreach (var item in warnRValueList)
                    {
                        for (int i = 0; i < item.Value.Count; i++)
                        {
                            //double oldValue = oldWarnRValueList.Count == 0 ? 0 : oldWarnRValueList[item.Key][i].RValue.To2d();
                            if (item.Value[i].RValue is null)
                            {
                                continue;
                            }
                            double newValue = item.Value[i].RValue.To2d();
                            //if (oldValue != newValue)//变化存储
                            {
                                insertSql += $"{item.Value[i].WarnRTableName} values('{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}',{newValue}) ";
                            }
                        }
                    }

                    if (!string.IsNullOrEmpty(insertSql))
                    {
                        insertSql = $"insert into " + insertSql.TrimEnd() + ";";
                        Insert(insertSql);
                    }
                }

                oldWarnRValueList = warnRValueList;
            }
            catch (Exception ex)
            {

            }
        }

        public static IEnumerable<dynamic> QueryDataBySql(string sql)
        {
            List<object> list = new List<object>();
            IntPtr conn = GetConnection();
            IntPtr res;
            try
            {
                res = TDengine.Query(conn, sql);
                if (TDengine.ErrorNo(res) == 0)
                {
                    var metas = LibTaos.GetMeta(res);
                    var resData = LibTaos.GetData(res);
                    var combineList = resData.Chunk(metas.Count);
                    var ret = combineList.Select(x =>
                    {
                        // 创建一个动态对象
                        dynamic obj = new ExpandoObject();
                        for (var i = 0; i < x.Length; i++)
                        {
                            var prop = metas[i].name;
                            var value = x[i];
                            ((IDictionary<string, object>)obj).Add(prop, value);
                        }
                        return obj;
                    });

                    return ret;

                }
                FreeResult(res);
                res = IntPtr.Zero;
            }
            catch (Exception ex)
            {
                logger.ErrorLog(ex.ToString());

            }
            finally
            {
                res = IntPtr.Zero;
            }
            FreeConnection(conn);
            conn = IntPtr.Zero;

            return Enumerable.Empty<dynamic>();
        }
    }


    public class warndata
    {
        public long ts { get; set; }


        public int? sysid { get; set; }

        public int? modelid { get; set; }


        public int active { get; set; }


        public int unack { get; set; }

        public int warnstate { get; set; }
    }
}
