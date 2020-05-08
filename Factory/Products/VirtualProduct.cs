using System;
using System.Collections.Generic;
using System.Text;

namespace Factory.Products
{
    public class VirtualProduct : IProduct
    {
        public string Info()
        {
            return "Virtual";
        }
    }
}
