using LM.Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Common
{
    /// <summary>
    /// 数据库访问通用类
    /// </summary>
    /// 2019年7月4日,严boss更新
    public class DBHelper
    {
        //定义连接字符串变量(从app.config文件读取)
        private static readonly string miwenstr = ConfigurationManager.ConnectionStrings["sqlstr"].ToString();
        //解密连接字符串
        private static readonly string str = EncryptHelper.AESDecrypt(miwenstr);
        private static SqlConnection connection;

        
        /// <summary>
        /// 获取数据库服务器的系统时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerTime()
        {
            string sql = "Select GETDATE()"; 
            return Convert.ToDateTime(ExcuteScalarSql(sql));
        }

        #region 通过事务提交到数据库
        public bool UpdateByTransaction(List<string> sqlList)
        {
            //实例化数据库连接
            SqlConnection conn = new SqlConnection(str);
            //实例化command类
            SqlCommand cmd = new SqlCommand();
            //指定cmd对象使用的连接对象
            cmd.Connection = conn;
            //执行
            try
            {
                //打开连接
                conn.Open();
                //开启事务
                cmd.Transaction = conn.BeginTransaction();
                //逐条执行SQL
                foreach (string item in sqlList)
                {
                    cmd.CommandText = item;
                    cmd.ExecuteNonQuery();
                }
                //提交事务
                cmd.Transaction.Commit();
                //返回
                return true;
            }
            catch (Exception ex)
            {
                if (cmd.Transaction != null)
                {
                    //回滚事务
                    cmd.Transaction.Rollback();
                }
                throw new Exception("调用事务方法是出现错误！具体信息：" + ex.Message);
            }
            finally
            {
                if (cmd.Transaction != null)
                {
                    cmd.Transaction = null;
                }
                //关闭连接
                conn.Close();
            } 
        }
        #endregion


        public static SqlConnection Connection
        {
            get
            {
                string connectionstring = str;
                if (connection == null)
                {
                    connection = new SqlConnection(connectionstring);
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Closed)
                {
                    connection.Open();
                }
                else if (connection.State == System.Data.ConnectionState.Broken)
                {
                    connection.Close();
                    connection.Open();
                }
                return connection;
            }
        }


        /// <summary>
        /// 通过sql语句执行增,删,改操作
        /// </summary>
        /// <param name="sqlstr">增删改语句</param>
        /// <returns>返回受影响的行数(0代表失败,1代表成功)</returns>
        public int ExecuteSql(string sqlstr)
        {
            int result = 0;
            //1,创建数据库连接
            SqlConnection conn = new SqlConnection(str);
            //2,打开连接对象
            try
            {
                conn.Open();
                //3,创建command对象
                SqlCommand cmd = new SqlCommand(sqlstr, conn);
                //4,执行nonquery方法
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                conn.Close();
            }
            //5,返回执行结果 
            return result;
        }

        /// <summary>
        /// 通过sql语句执行增,删,改操作
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="par">参数列表</param>
        /// <returns>返回受影响的行数</returns>
        public int ExecuteSql(string sql, params SqlParameter[] par)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    if (par != null && par.Length > 0)
                    {
                        com.Parameters.AddRange(par);
                    }
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    return com.ExecuteNonQuery();
                }
            }
        } 
 

        /// <summary>
        /// 通过存储过程执行增,删,改操作
        /// </summary>
        /// <param name="proname">存储过程名称</param>
        /// <param name="par">参数列表</param>
        /// <returns></returns>
        public int ExecutePro(string proname, params SqlParameter[] par)
        {
            using (SqlConnection con = new SqlConnection(str))
            {
                using (SqlCommand com = new SqlCommand(proname, con))
                {
                    com.CommandTimeout = 60;
                    com.CommandType = CommandType.StoredProcedure;
                    if (par != null && par.Length > 0)
                    {
                        com.Parameters.AddRange(par);
                    }
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    return com.ExecuteNonQuery();
                }
            }
        }


        /// <summary>
        /// 通过sql语句执行查询操作,返回单一结果(第1行第1列)
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>返回单行单列的值(返回object对象)</returns>
        public object ExcuteScalarSql(string sql)
        {
            //创建连接
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            //创建command对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            //执行单一查询
            object result = cmd.ExecuteScalar();
            conn.Close();
            //返回结果
            return result;
        }

        /// <summary>
        /// 通过sql语句执行查询操作,返回单一结果(第1行第1列)
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="par">参数列表</param>
        /// <returns></returns>
        public  object ExcuteScalarSql(string sql, params SqlParameter[] par)
        {
            //创建连接
            using (SqlConnection con = new SqlConnection(str))
            {
                //创建cmd对象
                using (SqlCommand com = new SqlCommand(sql, con))
                {
                    //添加参数
                    if (par != null && par.Length > 0)
                    {
                        com.Parameters.AddRange(par);
                    }
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }
                    return com.ExecuteScalar();
                }
            }
        } 


        /// <summary>
        /// 通过存储过程执行查询操作,返回单一结果(第一行第一列)
        /// </summary>
        /// <param name="proname">存储过程名称</param>
        /// <returns>返回单行单列的值(返回object对象)</returns>
        public object ExcuteScalarPro(string proname, params SqlParameter[] par)
        {
            SqlConnection conn = new SqlConnection(str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(proname, conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            if (par != null && par.Length > 0)
            {
                cmd.Parameters.AddRange(par);
            }
            object result = cmd.ExecuteScalar();
            return result;
        }


        /// <summary>
        /// 通过sql语句执行查询操作,返回datareader对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <returns>返回datareader对象</returns>
        public SqlDataReader GetDataReaderSql(string sql)
        {
            //1,创建连接
            SqlConnection conn = new SqlConnection(str);
            //2,创建cmd对象
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                //3,执行reader方法,CommandBehavior.CloseConnection此句的意思是让应用程序的调用者来关闭连接
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                conn.Close();
                throw ex; //抛出异常
            }
        }

        /// <summary>
        /// 通过sql语句执行查询操作,返回datareader对象
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="par">参数列表</param>
        /// <returns></returns>
        public  SqlDataReader GetDataReaderSql(string sql, params SqlParameter[] par)
        {
            SqlConnection con = new SqlConnection(str); 
            using (SqlCommand com = new SqlCommand(sql, con))
            { 
                if (par != null && par.Length > 0)
                {
                    com.Parameters.AddRange(par);
                }
                if (con.State != ConnectionState.Open)
                {
                    con.Open();
                }
                return com.ExecuteReader(CommandBehavior.CloseConnection); 
            }
        }
 

        /// <summary>
        /// 通过存储过程执行查询操作，返回datareader对象
        /// </summary>
        /// <param name="procname">存储过程名称</param>
        /// <param name="par">参数列表</param>
        /// <returns></returns>
        public SqlDataReader GetDataReaderPro(string procname, params SqlParameter[] par)
        {
            //1,创建连接
            SqlConnection conn = new SqlConnection(str);
            //2,创建command对象
            using (SqlCommand com = new SqlCommand(procname, conn))
            {
                com.CommandType = CommandType.StoredProcedure;
                if (par != null && par.Length > 0)
                {
                    com.Parameters.AddRange(par);
                }
                if (conn.State != ConnectionState.Open)
                {
                    conn.Open();
                }
                //3，执行查询操作
                return com.ExecuteReader(CommandBehavior.CloseConnection);
            }
        }


        /// <summary>
        /// 通过sql语句返回数据集
        /// </summary>
        /// <param name="sql">sql查询语句</param>
        /// <returns>返回数据集DataSet对象</returns>
        public DataSet GetDataSetSql(string sql)
        {
            DataSet ds = new DataSet();
            //1,创建连接
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                //2,创建适配器
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                //3,填充dataset 
                da.Fill(ds);
            }
            //4,返回结果
            return ds;
        }

        /// <summary>
        /// 通过sql语句返回数据集
        /// </summary>
        /// <param name="sql">sql语句</param>
        /// <param name="par">参数列表</param>
        /// <returns></returns>
        public DataSet GetDataSetSql(string sql, params SqlParameter[] par)
        { 
            DataSet ds = new DataSet();
            //1,创建连接
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                //2,创建适配器
                using (SqlDataAdapter da = new SqlDataAdapter(sql, conn))
                {
                    if (par != null && par.Length > 0)
                    {
                        da.SelectCommand.Parameters.AddRange(par);
                    }
                    //3,填充dataset 
                    da.Fill(ds);
                } 
            }
            //4,返回结果
            return ds; 
        }


        /// <summary>
        /// 通过存储过程返回数据集
        /// </summary>
        /// <param name="proname">存储过程名称</param>
        /// <param name="par">参数列表</param>
        /// <returns>返回数据集DataSet对象</returns>
        public DataSet GetDataSetPro(string proname, params SqlParameter[] par)
        {
            DataSet ds = new DataSet();
            //1,创建连接
            using (SqlConnection conn = new SqlConnection(str))
            {
                conn.Open();
                //2，创建comd对象
                SqlCommand com = new SqlCommand(proname, conn);
                com.CommandType = CommandType.StoredProcedure;
                if (par != null && par.Length > 0)
                {
                    com.Parameters.AddRange(par);
                }
                //3,创建适配器
                SqlDataAdapter da = new SqlDataAdapter(com);
                //4,填充dataset 
                da.Fill(ds);
            }
            //5,返回结果
            return ds;
        }
    }
}
