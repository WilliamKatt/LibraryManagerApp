using LM.Common;
using LM.Model;
using LM.Model.Extension;
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
    /// 图书数据访问类
    /// </summary>
   public class BookServices
    {
        DBHelper helper = new DBHelper();
        /// <summary>
        /// 得到所有的图书的详细信息
        /// </summary>
        /// <returns></returns>
        public List<BookExtModel> GetAllBooks()
        {
            List<BookExtModel> list = null;
            string sql = "select a.* ,b.TypeName,c.PressName from Book a,BookType b, BookPress c where a.BookType = b.TypeId and a.BookPress = c.PressId";
            DataSet ds = helper.GetDataSetSql(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                list = ListDataSet.DataSetToIList<BookExtModel>(ds, 0).ToList();
            }
            return list;
        }
        /// <summary>
        /// 得到所有图书的出版社
        /// </summary>
        /// <returns></returns>
        public List<PressModel> GetBookPress()
        {
            List<PressModel> list = null;
            string sql = "select PressId,PressName from (select a.* from BookPress a, Book b where a.PressId = b.BookPress) c Group by PressName, PressId";
            DataSet ds = helper.GetDataSetSql(sql);
            if (ds.Tables[0].Rows.Count>0)
            {
                list = ListDataSet.DataSetToIList<PressModel>(ds, 0).ToList();
            }
            return list;
        }
        public int UpdateBook(BookModel bk)
        {
            string sql = "update Book set BookId=@bookid";
            sql += ",BookName=@bookname";
            sql += ",BookType=@booktype";
            sql += ",ISBN=@isbn";
            sql += ",BookAuthor=@bookauthor";
            sql += ",BookPress=@bookpress";
            sql += ",BookImage=@bookimage";
            sql += ",BookPublishDate=@bookpublishdate";
            sql += ",StorageInNum=@storageinnum";
            sql += ",StorageInDate=@storageindate";
            sql += ",InvemtoryNum=@invemtorynum";
            sql += ",BorrowedNum=@borrowednum";
            sql += ",where BookId=@bookid";
                SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@bookid",bk.BookId),
                new SqlParameter("@bookname",bk.BookName),
                new SqlParameter("@booktype",bk.BookType),
                new SqlParameter("@isbn",bk.ISBN),
                new SqlParameter("@bookauthor",bk.BookAuthor),
                new SqlParameter("@bookpress",bk.BookPress),
                new SqlParameter("@bookprice",bk.BookPrice),
                new SqlParameter("@bookimage",bk.BookImage),
                new SqlParameter("@bookpublishdate",bk.BookPublishDate),
                new SqlParameter("@storageinnum",bk.StorageInNum),
                new SqlParameter("@storageindate",bk.StorageInDate),
                new SqlParameter("@inventorynum",bk.InventoryNum),
                new SqlParameter("@borrowednum",bk.BorrowedNum)
            };
            return helper.ExecuteSql(sql, para);
        }
        /// <summary>
        /// 根据图书编号得到图书信息
        /// </summary>
        /// <param name="bookid"></param>
        /// <returns></returns>
        public BookExtModel GetBookModelById(string bookid)
        {
            BookExtModel model = GetAllBooks().Find(x => x.BookId == bookid);
            return model;
        }
        /// <summary>
        /// 产生新的图书编号
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public string CreateNewBookId()
        {
            string sql = "select TOP 1 BookId from book order by BookId DESC";
            object txtid = (helper.ExcuteScalarSql(sql));
            if (txtid == null)
            {
                return "0000000001";
            }
            else
            {
                return (Convert.ToInt32(txtid) + 1).ToString();
            }
        }
        /// <summary>
        /// 添加图书
        /// </summary>
        /// <param name="bk"></param>
        /// <returns></returns>
        public int InsertBook(BookModel bk)
        {
            string sql = "insert into Book values(@bookid";
            sql += ",@bookname";
            sql += ",@booktype";
            sql += ",@isbn";
            sql += ",@bookauthor";
            sql += ",@bookpress";
            sql += ",@bookprice";
            sql += ",@bookimage";
            sql += ",@bookpublishdate";
            sql += ",@storageinnum";
            sql += ",@storageindate";
            sql += ",@inventorynum";
            sql += ",@borrowednum";
            sql += ")";
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@bookid",bk.BookId),
                new SqlParameter("@bookname",bk.BookName),
                new SqlParameter("@booktype",bk.BookType),
                new SqlParameter("@isbn",bk.ISBN),
                new SqlParameter("@bookauthor",bk.BookAuthor),
                new SqlParameter("@bookpress",bk.BookPress),
                new SqlParameter("@bookprice",bk.BookPrice),
                new SqlParameter("@bookimage",bk.BookImage),
                new SqlParameter("@bookpublishdate",bk.BookPublishDate),
                new SqlParameter("@storageinnum",bk.StorageInNum),
                new SqlParameter("@inventorynum",bk.InventoryNum),
                new SqlParameter("@borrowednum",bk.BorrowedNum),
                new SqlParameter("@storageindate",bk.StorageInDate)
            };
            return helper.ExecuteSql(sql, para);
        }
    }
}
