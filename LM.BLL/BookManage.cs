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
    /// 图书业务类
    /// </summary>
    public class BookManage
    {
        private BookServices dal = new BookServices();
        /// <summary>
        /// 得到所有的图书的详细信息
        /// </summary>
        /// <returns></returns>
        public List<BookExtModel> GetAllBooks()
        {
            return dal.GetAllBooks();
        }
        /// <summary>
        /// 得到所有图书的出版社
        /// </summary>
        /// <returns></returns>
        public List<PressModel> GetBookPress()
        {
            return dal.GetBookPress();
        }
        /// <summary>
        /// 修改图书
        /// </summary>
        /// <param name="bk"></param>
        /// <returns></returns>
        public int UpdateBook(BookModel bk)
        {
            return dal.UpdateBook(bk);
        }

        /// <summary>
        /// 根据图书编号得到图书信息
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns></returns>
        public BookExtModel GetBookModelById(string bookid)
        {
            return dal.GetBookModelById(bookid);
        }
        /// 产生新的图书编号
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public string CreateNewBookId()
        {
            return dal.CreateNewBookId();
        }
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="bk"></param>
        /// <returns></returns>
        public int InsertBook(BookModel bk)
        {
            return dal.InsertBook(bk);
        }
    }
}
