using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Helpers
{
    public class Bank
    {
        public Bank OpenAccount(IBankAccount bankAccount)
        {
            bankAccount.Open();
            return this;
        }

        public Bank CloseAccount(IBankAccount bankAccount)
        {
            bankAccount.Close();
            return this;
        }
    }
}
