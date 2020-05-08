using System;
using Factory.Helpers;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            var f = new ProductFactory();

            Console.WriteLine(f.CreateProduct("simple").Info());
            Console.WriteLine(f.CreateProduct("virtual").Info());
            Console.WriteLine(f.CreateProduct("advanced").Info());

        }
    }
}
