using System.ComponentModel.DataAnnotations;

namespace ECommerce.Models
{
    public class Product
    {
        public int Id{ get; set; }
        [Required(ErrorMessage = "Product name cannot be null")]
        [MinLength(3, ErrorMessage = "Product name length has to be 3 or more")]
        [MaxLength(30)]
        public string Name { get; set; }
        public string? ImageUrl { get; set; }
        public decimal Price{ get; set; }
        public string? Description { get; set; }
        public Category? Category{ get; set; }
        public int CategoryId { get; set; }
    }
}
