using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab6_b2
{
    internal class BookManergerContext : DbContext
    {
        public BookManergerContext() : base("name=BookManerger")
        {
            var initializer= new MigrateDatabaseToLatestVersion<BookManergerContext,Migrations.Configuration>();
            Database.SetInitializer(initializer);
        }
        public DbSet<BookManerger> BookManers { get; set; } 
        public DbSet<Catagoly> Catagolies { get; set; }
    }
}
