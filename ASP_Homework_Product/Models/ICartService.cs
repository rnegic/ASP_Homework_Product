namespace ASP_Homework_Product.Models
{
    public interface ICartService
    {
        void AddItem(Product product);
        Cart GetCart();
    }
}
