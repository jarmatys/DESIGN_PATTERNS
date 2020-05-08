using Prototype.Helpers;
using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            var u1 = new User(1, "Andrzej", "login", "password");

            // Łatwo możemy skopiować dany obiekt
            var u2 = u1.Clone();

            u1.Name = "testowa zmiana";

            Console.WriteLine(u1);
            Console.WriteLine(u2);
        }
    }
}
