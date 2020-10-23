using LM.Common;
using LM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.DAL
{
    /// <summary>
    /// 登录账号数据访问层
    /// </summary>
   public class SysAdminsServices
    {
        DBHelper db = new DBHelper();
        public SysAdminsModel QueryLoginAccount(SysAdminsModel usermodel)
        {
            SysAdminsModel model = null;
            string sqlstr = "select LoginId,LoginPwd,UserName,IsDisable,IsSuperUser,LastLoginTime from SysAdmins";
            sqlstr += " where LoginId=@logId and LoginPwd=@logPwd";
            SqlParameter[] para = new SqlParameter[] {
            new SqlParameter("@logId",usermodel.LoginId),
           new SqlParameter("@logPwd", usermodel.LoginPwd)
            };
            DataSet ds = db.GetDataSetSql(sqlstr, para);
            if (ds.Tables[0].Rows.Count > 0)
            {
                //将ds对象转换成list集合并且获取第一个对象
                model = ListDataSet.DataSetToIList<SysAdminsModel>(ds, 0).ToList().First();
            }
            return model;
        }
        public int UpdateLoginTime(int loginId)
        {
            string sql = "update SysAdmins set LastLoginTime=@lastloginTime where LoginId=@logId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@lastloginTime",db.GetServerTime()),
                new SqlParameter("@logId",loginId)

            };
            int result = db.ExecuteSql(sql, para);
            return result;
        }
    }
}
