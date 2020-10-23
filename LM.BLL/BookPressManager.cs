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
    /// 出版社业务类
    /// </summary>
   public class BookPressManager
    {
        private BookPressServices dal = new BookPressServices();
        /// <summary>
        /// 获取所有出版商信息
        /// </summary>
        /// <returns></returns>
        public List<PressModel> GetAllBookPress()
        {
            return dal.GetAllBookPress();
        }
    }
}
