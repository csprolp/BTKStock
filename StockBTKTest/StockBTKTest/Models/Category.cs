using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockBTKTest.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public IEnumerable<Product> Products { get; set; }
    }
}