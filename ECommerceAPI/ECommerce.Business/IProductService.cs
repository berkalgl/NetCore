using ECommerce.Business.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Business
{
    public interface IProductService
    {
        Task<IEnumerable<ProductListResponseDTO>> GetProductList();
    }
}
