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
    /// 登陆账号业务逻辑类
    /// </summary>
   public class SysAdminsManager
    {
        private SysAdminsServices dal = new SysAdminsServices();
        /// <summary>
        /// 将账号和密码返回登录实体
        /// </summary>
        /// <param name="usermodel"></param>
        /// <returns></returns>
        public SysAdminsModel QueryLoginAccount(SysAdminsModel usermodel)
        {
            return dal.QueryLoginAccount(usermodel);
        }
        /// <summary>
        /// 更新账号的登陆时间
        /// </summary>
        /// <param name="loginId"></param>
        /// <returns></returns>
        public int UpdateLoginTime(int loginId)
        {
            return dal.UpdateLoginTime(loginId);
        }
    }
}
