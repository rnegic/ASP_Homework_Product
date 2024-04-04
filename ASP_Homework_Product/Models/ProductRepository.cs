using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public interface IProductRepository
    {
        Product GetProductById(int id);
        IEnumerable<Product> GetAllProducts();
    }
    public class ProductRepository : IProductRepository
    {
        private List<Product> _products = new List<Product>()
        {
            new Product("пицца", 100, "вкусная"),
            new Product("птица", 200, "орел двуглавый"),
            new Product("паук", 300, "таук"),
        };

        public Product GetProductById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _products;
        }
    }
}
