using System.Collections.Generic;
using System.Linq;

namespace ASP_Homework_Product.Models
{
    public class Cart
    {
        public List<CartItem> Items { get; } = new List<CartItem>();

        public void AddItem(Product product)
        {
            var item = Items.FirstOrDefault(i => i.Product.Id == product.Id);
            if (item == null)
            {
                Items.Add(new CartItem { Product = product, Quantity = 1 });
            }
            else
            {
                item.Quantity++;
            }
        }

        public decimal TotalPrice
        {
            get
            {
                decimal totalPrice = 0;
                foreach (var item in Items)
                {
                    totalPrice += item.Product.Cost * item.Quantity;
                }
                return totalPrice;
            }
        }
    }
}
