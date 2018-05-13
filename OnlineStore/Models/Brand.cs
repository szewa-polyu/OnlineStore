using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string BrandNo { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }

        //public List<Product> Products { get; set; }
    }
}