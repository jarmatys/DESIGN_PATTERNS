using Strategy.Helpers;
using Strategy.Strategy;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var taxManager = new TaxManager(new PolandTaxStrategy());
            Console.WriteLine(taxManager.Income(300));
            Console.WriteLine(taxManager.Brutto(300));

            taxManager.TaxStrategy = new USATaxStrategy();
            Console.WriteLine(taxManager.Income(300));
            Console.WriteLine(taxManager.Brutto(300));

        }
    }
}
