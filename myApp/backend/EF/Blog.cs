using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBackend.EF
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }

        // Referential Integrity: with this line, EF will generate a foreign key
        public List<Post> Posts { get; } = new List<Post>();
    }
}