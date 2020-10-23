using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model
{
    /// <summary>
    /// 登录日志实体类
    /// </summary>
   public class LoginLogsModel
    {
        public int LogId { get; set; }
        public int LoginId { get; set; }
        public  string UserName { get; set; }
        public string LoginComputer { get; set; }
        public DateTime LoginTime { get; set; }
        public DateTime ExitTime { get; set; }
    }
}
