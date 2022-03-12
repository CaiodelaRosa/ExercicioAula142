using System;
using System.Text;

namespace ExercicioAula142.Entities
{
    class UsedProduct : Product
    {
        public DateTime ManufactureDate { get; set; }
        
        public UsedProduct()
        {
        }

        public UsedProduct(string name, double price, DateTime manufactureDate)
            : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public UsedProduct(string name, double price) : base(name, price)
        {
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} (used) $ {Price:F2} (Manufacture date: {ManufactureDate.ToString("MM/dd/yyyy")})");

            return sb.ToString();
        }
    }
}
