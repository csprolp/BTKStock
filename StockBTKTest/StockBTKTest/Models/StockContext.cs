using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace StockBTKTest.Models
{
    public class StockContext : DbContext
    {
        public StockContext()
            : base("DefaultConnection")
        { }
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}