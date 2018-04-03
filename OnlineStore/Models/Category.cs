using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OnlineStore.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        public int CategoryNo { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
    }
}