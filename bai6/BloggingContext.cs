using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class BloggingContext: DbContext
    {
        public BloggingContext() : base("name=Test23")
        {
          //  var initilizer = new MigrateDatabaseToLatestVersion<BloggingContext, Migrations.Configuration>();
          //  Database.SetInitializer(initilizer);
        }

        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

    }
}
