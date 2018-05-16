using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineStore.Models
{
    [Bind(Exclude = "BrandId")]
    public class Brand
    {
        [ScaffoldColumn(false)]
        public int BrandId { get; set; }
        
        [Display(Name = "Brand No.")]
        public string BrandNo { get; set; }

        [Required(ErrorMessage = "A Brand Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Desc { get; set; }

        //public List<Product> Products { get; set; }
    }
}