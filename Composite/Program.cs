using Composite.Helpers;
using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            // w tym wzorcu nie ma znaczenia dla programu czy operuje na pojedyńzczym obiekcie czy na liście obiektów

            // pojedyńczy obiekt
            var a1 = new Account("5");

            // lista obiektów
            var aList = new List<IBankAccount>
            {
                new Account("1"),
                new Account("2"),
                new Account("3"),
                new Account("4")
            };

            var a = new AccountList(aList);

            // otwieranie kont
            var bank = new Bank();
            bank.OpenAccount(a1);
            bank.OpenAccount(a);
        }
    }
}
