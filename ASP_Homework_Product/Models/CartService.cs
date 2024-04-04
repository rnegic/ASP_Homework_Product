using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class CartService: ICartService
    {
        private readonly Cart _cart;

        public CartService()
        {
            _cart = new Cart();
        }

        public void AddItem(Product product)
        {
            var cartItem = _cart.Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (cartItem != null)
            {
                cartItem.Quantity++;
            }
            else
            {
                _cart.Items.Add(new CartItem { Product = product, Quantity = 1 });
            }
        }

        public Cart GetCart()
        {
            return _cart;
        }
    }
}
