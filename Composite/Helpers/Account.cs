using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Helpers
{
    public class Account : IBankAccount 
    {
        public string ID { get; }

        public Account(string id)
        {
            ID = id;
        }

        public IBankAccount Close()
        {
            Console.WriteLine($"Zamknieto konto - {ID}");
            return this;
        }

        public IBankAccount Open()
        {
            Console.WriteLine($"Otwarto konto - {ID}");
            return this;
        }
    }
}
