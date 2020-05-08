using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Testowanie singletona
            var s1 = Singleton.Instance();
            var s2 = Singleton.Instance();

            if (ReferenceEquals(s1, s2))
            {
                Console.WriteLine("Obiekty są takie same");
            }
            else
            {
                Console.WriteLine("Obiekty są rózne");
            }
        }
    }
}
