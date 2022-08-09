namespace ECommerce.Models
{
    public class ShoppingCartCollection
    {
        public List<ProductInCart> ProductsInChart { get; set; } = new List<ProductInCart>();

        public void Add(Product product, int quantity)
        {
            var existingProduct = ProductsInChart.Find(p => p.Product.Id == product.Id);

            if (existingProduct != null)
            { 
                existingProduct.Quantity = quantity;
            }else
            {
                ProductsInChart.Add(new ProductInCart { Product = product, Quantity = quantity });
            }
        }
        public decimal GetTotalPrice() => ProductsInChart.Sum(p => p.Product.Price * p.Quantity);

        public void Clear() => ProductsInChart.Clear();
        public void Remove(int id) => ProductsInChart.RemoveAll(x => x.Product.Id == id);
    }

    public class ProductInCart
    { 
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
