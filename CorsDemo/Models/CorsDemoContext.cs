using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CorsDemo.Models
{
    public class CorsDemoContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public CorsDemoContext() : base("name=CorsDemoContext")
        {
        }

        public System.Data.Entity.DbSet<CorsDemo.Models.DAL.Book> Books { get; set; }

        public System.Data.Entity.DbSet<CorsDemo.Models.DAL.Author> Authors { get; set; }
    }
}
