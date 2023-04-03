using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Data.Entity.Migrations.Model.UpdateDatabaseOperation;

namespace Lab6_p2
{
    internal class BookManergerContext:DbContext
    {
        public BookManergerContext() : base("name=BookManerger")
        {
            //var initializer = new MigrateDatabaseToLatestVersion<BookManergerContext, Migrations.Configuration>();
            //Database.SetInitializer(initializer);
        }
        public DbSet<BookManerger> BookManers { get; set; }
        public DbSet<Catagoly> Catagolies { get; set; }
    }
}
