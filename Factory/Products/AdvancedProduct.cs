using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Products
{
    public class AdvancedProduct : IProduct
    {
        public string Info()
        {
            return "Advanced";
        }
    }
}
