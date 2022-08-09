using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ECommerce.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var products = _productService.GetProducts();
            return View(products);
        }

        [Authorize]
        public IActionResult Create()
        {
            ViewBag.Categories = _categoryService.GetCategories().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString()});
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product product)
        { 
            if(!ModelState.IsValid)
            {
                ViewBag.Categories = _categoryService.GetCategories().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
                return View();
            }

            _productService.Add(product);
            return Redirect("/");
        }

        [Authorize]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = _categoryService.GetCategories().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });

            var product = _productService.GetProductById(id);

            return View(product);
        }

        [HttpPost]
        public IActionResult Edit(int id, Product product)
        {
            if(!ModelState.IsValid)
            {
                ViewBag.Categories = _categoryService.GetCategories().Select(c => new SelectListItem { Text = c.Name, Value = c.Id.ToString() });
                return View(product);
            }
            _productService.Update(product);
            return Redirect("/");
        }
    }
}
