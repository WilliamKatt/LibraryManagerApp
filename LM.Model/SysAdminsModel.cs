using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model
{
    /// <summary>
    /// 登陆账号实体类
    /// </summary>
   public class SysAdminsModel
    {
        public int LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string UserName { get; set; }
        public bool IsDisable { get; set; }
        public bool IsSupperUser { get; set; }
        public DateTime LastLoginTime { get; set; }
    }
}
