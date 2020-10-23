using LM.Common;
using LM.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.DAL
{
    /// <summary>
    /// 出版社数据访问类
    /// </summary>
   public class BookPressServices
    {
        DBHelper db = new DBHelper();
        /// <summary>
        /// 获取所有出版商信息
        /// </summary>
        /// <returns></returns>
        public List<PressModel> GetAllBookPress()
        {
            List<PressModel> data = null;
            string sql = "select * from BookPress";
            DataSet ds = db.GetDataSetSql(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                data =ListDataSet.DataSetToIList<PressModel>(ds,0).ToList();
            }
            return data;
        }
    }
}
