using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace bai6
{
    public class Post
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }

    public class Blog
    {
        [Key]
        public int BlogId { get; set; }
        public string Name { get; set; }
        public List<Post> Posts { get; set; }
    }
}
