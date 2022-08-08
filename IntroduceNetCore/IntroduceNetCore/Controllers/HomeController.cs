using IntroduceNetCore.Models;
using Microsoft.AspNetCore.Mvc;

namespace IntroduceNetCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            // IActionResult is concept of loosed coupling, managing dependency

            ViewBag.Date = DateTime.Now;

            var products = new List<Product>
            {
                new Product { Id = 1, Name = "Product 1", Description = "Product 1 Description", Price = 1 },
                new Product { Id = 2, Name = "Product 2", Description = "Product 2 Description", Price = 2 },
            };
            
            // View and many others implements IActionResult
            return View(products);
        }
    }
}
