using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_b1
{
    internal class CompanyContext:DbContext
    {
        public CompanyContext() : base("name=newCompany")
        {

        }

        public DbSet<Company> Companys { get; set; }
    }
}
