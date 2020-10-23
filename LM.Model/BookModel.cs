using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LM.Model
{
    /// <summary>
    /// 图书实体类
    /// </summary>
   public class BookModel
    {
        public string BookId { get; set; }
        public string BookName { get; set; }
        public int BookType { get; set; }
        public string ISBN { get; set; }
        public string BookAuthor { get; set; }
        public int BookPress { get; set; }
        public decimal BookPrice { get; set; }
        public string BookImage { get; set; }
        public DateTime BookPublishDate { get; set; }  
        public int StorageInNum { get; set; }
        public DateTime StorageInDate { get; set; }
        public int InventoryNum { get; set; }
        public int BorrowedNum { get; set; }

    }
}
