using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_b1
{
    internal class Company
    {
        [Key]
        public string CompanyId { get; set; }
        [MaxLength(50)]
        public string Name { get; set; }
    }
}
