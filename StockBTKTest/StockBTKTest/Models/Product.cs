using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StockBTKTest.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }
        public string PhotoName { get; set; }
        public byte[] Image { get; set; }
    }
}