using System.ComponentModel.DataAnnotations;

namespace ECommerce.Entities
{
    public partial class Product : IEntity
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Ürün adı boş olamaz!")]
        public string Name { get; set; } = null!;
        public string? ImageUrl { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
        public int? CategoryId { get; set; }
    }
}
