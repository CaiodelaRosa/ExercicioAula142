using System.Text;

namespace ExercicioAula142.Entities
{
    class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product()
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} $ {Price:F2}");

            return sb.ToString();
        }
    }
}
