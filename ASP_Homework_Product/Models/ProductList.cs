using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class ProductList
    {
        private static List<Product> _products = new List<Product>()
        {
            new Product("пицца", 100, "вкусная"),
            new Product("птица", 200, "The white-tailed eagle, sometimes known as the 'sea eagle', is a large bird of prey, widely distributed across temperate Eurasia. Like all eagles, it is a member of the family Accipitridae which includes other diurnal raptors such as hawks, kites, and harriers."),
            new Product("паук", 300, "таук"),
        };

        public static List<Product> GetProducts() => _products;

        public static Product GetProductById(int id) => _products.FirstOrDefault(p => p.Id == id);
    }
}
