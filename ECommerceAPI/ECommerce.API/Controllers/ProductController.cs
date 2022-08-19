using ECommerce.Business;
using ECommerce.Business.DTOs.Request;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }


        [HttpGet]
        public async Task<IActionResult> GetProducts()
        {
            var products = await _productService.GetProductLists();
            if (products == null)
            {
                return NotFound();
            }
            return Ok(products);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetProduct(int id)
        {
            var product = await _productService.GetProduct(id);
            return Ok(product);

        }


        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductRequestDTO product)
        {
            if (ModelState.IsValid)
            {
                await _productService.Create(product);
                return CreatedAtAction(nameof(GetProduct), routeValues: new { id = product.Id }, null);

            }
            return BadRequest(ModelState);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Product product)
        {
            //id'si verilen eleman var mı?
            if (ModelState.IsValid)
            {
                var resultId = await _productService.Update(product);
                //idempotent 
                return Ok(product);

            }
            return BadRequest(ModelState);
        }
    }
}
