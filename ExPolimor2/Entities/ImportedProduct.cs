using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimor2.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; protected set; }

        public ImportedProduct (string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override void PriceTag()
        {
            Console.WriteLine($"Produto: {Name}");
            Console.WriteLine($"Preco: {Price:C}");
            Console.WriteLine($"Customs Fee: {CustomsFee:C}");
        }


        public double TotalPrice()
        {
            return Price += CustomsFee;
        }        
    }
}
