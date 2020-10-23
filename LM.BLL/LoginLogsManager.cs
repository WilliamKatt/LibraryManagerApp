using LM.Common;
using LM.DAL;
using LM.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BLL
{
    /// <summary>
    /// 
    /// </summary>
   public class LoginLogsManager
    {
        LoginLogsSevices dal = new LoginLogsSevices();
        /// <summary>
        /// 写入登陆者日志
        /// </summary>
        /// <param name="objLog"></param>
        /// <returns></returns>
        public int WriteLoginLogs(LoginLogsModel objLog)
        {
            return dal.WriteLoginLogs(objLog);
        }
        public DateTime GetServerTime()
        {
            return dal.GetServerTime();
        }
    }
    
}
