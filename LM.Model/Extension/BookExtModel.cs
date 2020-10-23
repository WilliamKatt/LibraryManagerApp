using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model.Extension
{
    /// <summary>
    /// 图书扩展实体类
    /// </summary>
   public class BookExtModel:BookModel
    {
        /// <summary>
        /// 类别名称
        /// </summary>
        public string TypeName { get; set; }
        /// <summary>
        /// 出版社名称
        /// </summary>
        public string PressName { get; set; }

    }
}
