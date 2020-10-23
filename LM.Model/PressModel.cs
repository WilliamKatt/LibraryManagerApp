using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model
{
    /// <summary>
    /// 出版商实体类
    /// </summary>
   public class PressModel
    {
        public int PressId { get; set; }
        public string PressName { get; set; }
        public string PressTel { get; set; }
        public string PressAddress { get; set; }
        public string PressContact { get; set; }

    }
}
