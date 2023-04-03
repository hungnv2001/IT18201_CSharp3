using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var db= new BloggingContext())
            {
                db.Database.CreateIfNotExists();
                var name = Console.ReadLine();
                var blog= new Blog { Name = name };
                db.Blogs.Add(blog);
                db.SaveChanges();
            }
              
        }

      
    }
}
