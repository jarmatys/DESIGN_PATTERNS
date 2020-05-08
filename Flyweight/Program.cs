using Flyweight.Helpers;
using System;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            var p1 = Product.CreateInstance(1, "test", "red");
            var p2 = Product.CreateInstance(2, "test1", "red");
            var p3 = Product.CreateInstance(3, "test2", "red");
            var p4 = Product.CreateInstance(4, "test3", "Green");
            var p5 = Product.CreateInstance(5, "test4", "Yellow");
            var p6 = Product.CreateInstance(6, "test5", "red");
        }
    }
}
