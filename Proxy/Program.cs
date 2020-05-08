using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. tworze obiekt proxy
            var p = new DbContextProxy();

            // operacje tutaj mojgą się wykonywać bez blokowania

            // 2. dopiero w tym momencie następuje oczyt z "bazy"
            p.GetActiveUsers();
        }
    }
}
