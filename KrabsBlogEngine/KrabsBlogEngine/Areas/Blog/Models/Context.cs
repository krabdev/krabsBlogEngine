using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace KrabsBlogEngine.Areas.Blog.Models
{
    public class Context : DbContext
    {
        public Context() : base("DefaultConnection")
        {}

        public DbSet<Post> Posts { get; set; }
    }
}