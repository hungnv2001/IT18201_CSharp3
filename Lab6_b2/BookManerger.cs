using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_b2
{
    public class BookManerger
    {
        [Key]
        public string ID { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        public int CatagolyID { get; set; }
        public int Price { get; set; }
        public int Amount { get; set; }
      //   public Catagoly Catagoly { get; set; }
    }
    public class Catagoly
    {
        [Key]
        public int CatagolyID { get; set; }
        [MaxLength(50)]
        public string CatagolyName { get; set; }

        public List<BookManerger> Books { get; set; }
    }
}
