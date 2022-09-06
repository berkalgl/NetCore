using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business.DTOs.Request
{
    public class ProductRequestDTO
    {
        public ProductRequestDTO()
        {
            Name = "";
            ImageUrl = "";
            Rating = 0;
            Price = 0;
            Description = "";
        }

        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public double Rating { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
    }
}
