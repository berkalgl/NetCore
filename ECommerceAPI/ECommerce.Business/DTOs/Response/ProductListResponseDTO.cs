using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.DTOs.Response
{
    public class ProductListResponseDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? ImageUrl { get; set; }
        public double? Rating { get; set; }
        public decimal? Price { get; set; }
        public string? Description { get; set; }
    }
}
