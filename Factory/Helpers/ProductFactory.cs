using Factory.Products;
using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Helpers
{
    public class ProductFactory
    {
        // fabryka pozwala na tworzenie instacji klasy w jednym miejscu co w przyszłosci może ułatwić zmianę implementacji
        public IProduct CreateProduct(string name)
        {
            var map = new Dictionary<string, IProduct>()
            {
                {"simple", new SimpleProduct() },
                {"virtual", new VirtualProduct() },
                {"advanced", new AdvancedProduct() },
            };

            return map[name];
        }
    }
}
