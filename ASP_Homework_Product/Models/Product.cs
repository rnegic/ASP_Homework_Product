namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int uniqId;
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal cost, string description)
        {
            Name = name;
            Cost = cost;
            Description = description;
            Id = uniqId++;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cost}";
        }
    }
}
