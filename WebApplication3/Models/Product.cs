using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The Product name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a product name between 3 and 50 characters in length")]
        [RegularExpression(@"^[ -'A-Za-z,-.?:]+$", ErrorMessage = "Please enter a product name made up of only ! " + " # $ % & ' , : - . letters and spaces")]
        [Display(Name = "Product Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "The Product description cannot be blank")]
        [StringLength(200, MinimumLength = 3, ErrorMessage = "Please enter a product description between 3 and 200 characters in length")]
        [RegularExpression(@"^[ -)A-Za-z,-.?0-9:]+$", ErrorMessage = "Please enter a product description made up of only ! " + " # $ % & ' , : - . numbers letters and spaces")]
        public string Description { get; set; }

        [Required(ErrorMessage = "The Product price cannot be blank")]
        [Range(0.01, 100000, ErrorMessage = "Please enter a product price between 0.10 and 10000")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Price { get; set; }


        public int? CategoryID { get; set; }
        public virtual Category Category { get; set; }
        public virtual ICollection<ProductImageMapping> ProductImageMappings { get; set; }
    }
}