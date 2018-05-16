using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace OnlineStore.Models
{
    [Bind(Exclude = "ProductId")]
    public class Product
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ProductId { get; set; }
        
        [Display(Name = "Product No.")]
        public string ProductNo { get; set; }

        [Required(ErrorMessage = "A Product Name is required")]
        [StringLength(160)]
        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Desc { get; set; }

        [Range(0.01, 100.00,
            ErrorMessage = "Price must be between 0.01 and 100.00")]
        [Display(Name = "Price")]
        public decimal Price { get; set; }

        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
        
        [Display(Name = "Category")]
        public virtual Category Category { get; set; }

        [Display(Name = "Brand")]
        public virtual Brand Brand { get; set; }
    }
}