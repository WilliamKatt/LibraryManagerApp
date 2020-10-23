using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model
{
    /// <summary>
    /// 图书类别实体类
    /// </summary>
   public class BookTypeModel
    {
        public int TypeId { get; set; }
        public string TypeName { get; set; }
        public int ParentTypeId { get; set; }
        public string TypeDESC { get; set; }
    }
}
