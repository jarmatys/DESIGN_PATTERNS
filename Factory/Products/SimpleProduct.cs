using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Products
{
    public class SimpleProduct : IProduct
    {
        public string Info()
        {
            return "Simple";
        }
    }
}
