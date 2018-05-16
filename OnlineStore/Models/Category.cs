using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineStore.Models
{
    [Bind(Exclude = "CategoryId")]
    public class Category
    {
        [Key]
        [ScaffoldColumn(false)]
        public int CategoryId { get; set; }

        [Display(Name = "Category No.")]
        public int CategoryNo { get; set; }

        [Required(ErrorMessage = "A Category Name is required")]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Desc { get; set; }

        [Display(Name = "Products")]
        public virtual List<Product> Products { get; set; }
    }
}