using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight.Helpers
{
    public interface IProduct
    {
        int ID { get; set; }
        string Name { get; set; }
        string Color { get; set; }
    }
}
