using System.Text;

namespace ExercicioAula142.Entities
{
    class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()
        {
        }

        public ImportedProduct(string name, double price, double customsFee)
            : base (name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"{Name} $ {TotalPrice():F2} (Customs fee: $ {CustomsFee:F2})");
            
            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}