using ECommerce.Extensions;
using ECommerce.Models;
using ECommerce.Services;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace ECommerce.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;

        public CartController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index()
        {
            var collection = GetCartCollectionFromSession();

            return View(collection);
        }
        [HttpPost]
        public IActionResult AddToCart(int id)
        {
            var product = _productService.GetProductById(id);

            if (product == null)
                return NotFound();

            ShoppingCartCollection shoppingCartCollection = GetCartCollectionFromSession();

            shoppingCartCollection.Add(product, 1);
            SaveCartCollectionToSession(shoppingCartCollection);

            //TODO 1: Redirect to index when it is completed.
            return Redirect("/");
        }

        private void SaveCartCollectionToSession(ShoppingCartCollection shoppingCartCollection)
        {

            HttpContext.Session.SetJson("cart", shoppingCartCollection);

            //HttpContext.Session.SetString("cart", JsonSerializer.Serialize(shoppingCartCollection));
        }

        private ShoppingCartCollection GetCartCollectionFromSession()
        {
            return HttpContext.Session.GetJson<ShoppingCartCollection>("cart") ?? new ShoppingCartCollection();
        }
    }
}
