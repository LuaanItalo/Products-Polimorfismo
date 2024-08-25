using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimor2.Entities
{
    internal class UsedProduct : Product
    {

        public DateTime ManufactureDate { get; set; }


        public UsedProduct() { }

        public UsedProduct(string name,double price,DateTime manufactureDate) : base(name, price)
        {
            ManufactureDate = manufactureDate;
        }

        public override void PriceTag()
        {
            

            Console.WriteLine($"Product: {Name} (used)");
            Console.WriteLine($"Price: {Price:C}");
            Console.WriteLine($"Manufacture Date: {ManufactureDate:d}");

        }
    }
}
