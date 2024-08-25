using ExPolimor2.Entities;
using System.Globalization;
using System.Runtime;

internal class Program
{
    private static void Main(string[] args)
    {
        
        List<Product> products = new List<Product>();

        Console.Write("Enter the number of products: ");
        int numProduct = int.Parse(Console.ReadLine()!);

        for (int prdt = 1; prdt <= numProduct; prdt++)
        {
            Console.WriteLine();
            Console.WriteLine($"Product #{prdt} data: ");
            Console.Write("Common, used or imported (c/u/i):  ");
            char condicao = char.Parse(Console.ReadLine()!.ToLower());

            switch (condicao)
            {
                case 'c':
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string name = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double price = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    products.Add(new Product(name, price));
                    break;

                case 'u':
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string nameU = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double priceU = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Manufacture Date (DD/MM/YYYY) : ");
                    DateTime manuFactDate = DateTime.Parse(Console.ReadLine()!);
                    
                    products.Add(new UsedProduct(nameU, priceU, manuFactDate));
                    break;

                case 'i':
                    Console.WriteLine();
                    Console.Write("Name: ");
                    string nameI = Console.ReadLine()!;
                    Console.Write("Price: ");
                    double priceI = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    Console.Write("Custom fee: ");
                    double customFee = double.Parse(Console.ReadLine()!, CultureInfo.InvariantCulture);
                    products.Add(new ImportedProduct(nameI, priceI, customFee));
                    break;

                default:
                    Console.Clear();
                    Console.WriteLine("Opção Invalida!");
                    Thread.Sleep(1000);
                    System.Environment.Exit(0);
                    break;
            }
        }

        Console.WriteLine();
        Console.Clear() ;
        Console.WriteLine("Price Tags: ");
        Console.WriteLine();
        int num = 1;
        foreach (Product item in products)
        {

            Console.WriteLine($"#{num}° Produto: ");
            item.PriceTag();
            num++;
            Console.WriteLine("");
        }
    
    }
}