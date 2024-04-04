using System;

namespace ASP_Homework_Product.Models
{
    public class Product
    {
        private static int _nextId;
        public int Id { get; private set; }
        public string Name { get; set; }
        public decimal Cost { get; set; }
        public string Description { get; set; }

        public Product(string name, decimal cost, string description)
        {
            Id = System.Threading.Interlocked.Increment(ref _nextId);
            Name = name;
            Cost = cost;
            Description = description;
        }

        public override string ToString()
        {
            return $"{Id} {Name} {Cost}";
        }
    }
}
