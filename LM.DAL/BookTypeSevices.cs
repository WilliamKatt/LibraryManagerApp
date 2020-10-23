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
    /// 图书类别数据访问类
    /// </summary>
    public class BookTypeSevices
    {
        DBHelper helper = new DBHelper();
        public List<BookTypeModel> GetAllBookTypes()
        {
            string sql = "select TypeId,TypeName,ParentTypeId,TypeDESC from BookType";
            DataSet ds = helper.GetDataSetSql(sql);
            List<BookTypeModel> btlist = null;
            if (ds.Tables[0].Rows.Count > 0)
            {
                btlist = ListDataSet.DataSetToIList<BookTypeModel>(ds, 0).ToList();
            }
            return btlist;
        }
        /// <summary>
        /// 根据类别Id得到类别信息及父类信息
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public BookTypeExtModel GetBookTypeId(int typeId)
        {
            string sql = "select * from (select TypeId, TypeName, TypeDESC, ParentTypeId from booktype) a left join (select TypeId as ParentTypeId2, TypeName as ParentTypeName,TypeDESC as ParentTypeDESC from booktype) b on a.ParentTypeId = b.ParentTypeid2 where a.typeid = @typeId";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("TypeId",typeId)
            };
            BookTypeExtModel model = null;
            DataSet ds = helper.GetDataSetSql(sql, para);
            if (ds.Tables[0].Rows.Count > 0)
            {
                model = ListDataSet.DataSetToIList<BookTypeExtModel>(ds, 0).ToList().First();
            }
            return model;
        }
        /// <summary>
        /// 根据当前类别产生新的类别编号
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public string CreateNewTypeId(int typeid)
        {
            string sql = "select top 1 TypeId from BookType where ParentTypeId=@typeid order by TypeId DESC";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@typeid",typeid)
            };
            object txtid = (helper.ExcuteScalarSql(sql, para));
            if (txtid == null)
            {
                return typeid.ToString() + "01";//说明你选择的是一级分类，所以编号是01
            }
            else
            {
                return (Convert.ToInt32(txtid) + 1).ToString();
            }
        }
        /// <summary>
        /// 添加类别
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int AddBookType(BookTypeModel item)
        {
            string sql = "insert into BookType(TypeId,TypeName,ParentTypeId,TypeDESC)";
            sql += " values (@typeid,@typename,@parenttypeid,@typedesc)";
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@typeid",item.TypeId),
                new SqlParameter("@typename",item.TypeName),
                new SqlParameter("@parenttypeid",item.ParentTypeId),
                new SqlParameter("@typedesc",item.TypeDESC)
            };
            int result = helper.ExecuteSql(sql, para);
            return result;
        }
        /// <summary>
        /// 删除类别
        /// </summary>
        /// <param name="typeid"></param>
        /// <returns></returns>
        public int DeleteBookType(int typeid)
        {
            string txtid = typeid.ToString();
            if (txtid.Length == 5)//二级类别
            {
                //查询该类别下是否还有图书
                string qus = "select count(*) from book where BookType =@typeid";
                SqlParameter[] para2 = new SqlParameter[]
                {
                    new SqlParameter("@typeid",typeid)
                };


                int obj = Convert.ToInt32(helper.ExcuteScalarSql(qus, para2));
                if (obj == 0)
                {
                    string sql = "delete from BookType where Typeid=@typeid";
                    SqlParameter[] para = new SqlParameter[]
                    {
                        new SqlParameter("@typeid",typeid)
                    };
                    return helper.ExecuteSql(sql, para);
                }
                else
                {
                    return -999;
                }
            }
            else//一级类别
            {
                string sql2 = "select * from BookType where ParentTypeId=" + typeid;
                DataSet ds2 = helper.GetDataSetSql(sql2);
                if (ds2.Tables[0].Rows.Count > 0)
                {
                    return 0000;
                }
            }
            return 0000;
        }
        /// <summary>
        /// 修改类别
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        public int UpdateBookType(BookTypeModel item)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(" update BookType set TypeId=@typeid,");
            sb.Append(" TypeName=@typename,");
            sb.Append(" ParentTypeId=@parenttypeid,");
            sb.Append(" TypeDESC=@typedesc");
            sb.Append(" where TypeId=@typeid");
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@typeid",item.TypeId),
                new SqlParameter("@typename",item.TypeName),
                new SqlParameter("@parenttypeid",item.ParentTypeId),
                new SqlParameter("@typedesc",item.TypeDESC)
            };
            return helper.ExecuteSql(sb.ToString(), para);
        }
    }
}
