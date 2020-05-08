using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public static class Role
    {
        public static void CheckIsAdmin()
        {
            Console.WriteLine("Sprawdzamy czy jest adminem");
        }
        public static void CheckIsUser()
        {
            Console.WriteLine("Sprawdzamy czy jest użytkownikiem");
        }
    }
}
