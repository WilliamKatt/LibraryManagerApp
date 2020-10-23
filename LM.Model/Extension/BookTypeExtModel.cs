using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model.Extension
{
    /// <summary>
    /// 图书分类扩展实体
    /// </summary>
   public class BookTypeExtModel:BookTypeModel
    {
        /// <summary>
        /// 父类ID
        /// </summary>
        public int ParentTypeId2 { get; set; }
        /// <summary>
        /// 父类名称
        /// </summary>
        public string ParentTypeName { get; set; }
        /// <summary>
        /// 父类描述
        /// </summary>
        public string ParentTypeDESC { get; set; }
    }
}
