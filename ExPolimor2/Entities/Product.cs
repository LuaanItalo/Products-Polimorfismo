using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ExPolimor2.Entities
{
    internal class Product
    {
         public string Name { get; protected set; }

        public double  Price { get; protected set; }

        public  Product() 
        {
        }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public virtual void PriceTag()
        {
            Console.WriteLine($"Produto: {Name}");
            Console.WriteLine($"Preco: {Price:C}");
        }

         
    }
}
