using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required(ErrorMessage = "The category name cannot be blank")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Please enter a category name between 3 and 50 characters in length")]
        [RegularExpression(@"^[a-zA-Z ]+$", ErrorMessage = "Please enter a category name beginning with a capital letter and enter only letters and spaces.")]
        [Display(Name = "Category Name")]
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}