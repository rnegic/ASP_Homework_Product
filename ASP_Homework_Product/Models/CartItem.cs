namespace ASP_Homework_Product.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
