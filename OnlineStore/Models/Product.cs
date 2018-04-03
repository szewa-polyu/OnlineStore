using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductNo { get; set; }
        public string Name { get; set; }        
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public Category Category { get; set; }
        public Brand Brand { get; set; }
    }
}