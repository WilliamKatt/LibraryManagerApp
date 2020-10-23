using LM.DAL;
using LM.Model;
using LM.Model.Extension;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.BLL
{
    /// <summary>
    /// 图书类别业务逻辑类
    /// </summary>
   public class BookTypeManager
    {
        private BookTypeSevices dal = new BookTypeSevices();
        /// <summary>
        /// 得到所有的图书类别
        /// </summary>
        /// <returns></returns>
        public List<BookTypeModel> GetAllBookTypes()
        {
            return dal.GetAllBookTypes();
        }
        /// <summary>
        /// 根据类别Id得到类别信息及父类信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public BookTypeExtModel GetBookTypeId(int typeId)
        {
            return dal.GetBookTypeId(typeId);
        }
        /// <summary>
        /// 根据当前类别产生新的类别编号
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public string CreateNewTypeId(int typeid)
        {
            return dal.CreateNewTypeId(typeid);
        }
        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddBookType(BookTypeModel item)
        {
            return dal.AddBookType(item);
        }
        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public int DeleteBookType(int typeid)
        {
            return dal.DeleteBookType(typeid);
        }
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int UpdateBookType(BookTypeModel item)
        {
            return dal.UpdateBookType(item);
        }
    }
}
