using LM.Common;
using LM.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.DAL
{
/// <summary>
/// 登录日志数据访问类
/// </summary>
   public class LoginLogsSevices
    {
        DBHelper helper = new DBHelper();
        /// <summary>
        /// 写入登陆者日志
        /// </summary>
        /// <param name="objLog"></param>
        /// <returns></returns>
        public int WriteLoginLogs(LoginLogsModel objLog)
        {
            string sql = "insert into LoginLogs(LoginId,UserName,LoginComputer,LoginTime)";
            sql += " values(@loginid,@username,@computer,@logintime)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@loginid",objLog.LoginId),
                new SqlParameter("@username",objLog.UserName),
                new SqlParameter("@computer",objLog.LoginComputer),
                new SqlParameter("@logintime",objLog.LoginTime)
            };
            int result = helper.ExecuteSql(sql, para);
            return result;
        }

        /// <summary>
        /// 获取登录服务器时间
        /// </summary>
        /// <returns></returns>
        public DateTime GetServerTime()
        {
            return helper.GetServerTime();
        }
    }
}
