using ECommerce.Business;
using Microsoft.AspNetCore.Http;
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
        public async Task<IActionResult> Get()
        {
            var products = await _productService.GetProductList();

            return products != null ? Ok(products) : NotFound();
        }
        public async Task<IActionResult> Add(ProductRequest productRequest)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            await _productService.Create(product);
            //return Created("http://deneme.com", null)
            return CreatedAtAction(nameof(GetById), routeValues: new { id = product.Id }, null);
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {

        }
        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, ProductRequest product)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            //control
            var resultId = await _productService.Update(product);
            return Ok(resultId);
        }
    }
}
