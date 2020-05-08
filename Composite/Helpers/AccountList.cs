using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Helpers
{
    class AccountList : IBankAccount
    {
        public string ID { get; }

        public List<IBankAccount> Accounts { get; }
        public AccountList(List<IBankAccount> accounts)
        {
            Accounts = accounts;
        }

        public IBankAccount Close()
        {
            foreach(var account in Accounts)
            {
                account.Close();
            }
            return this;
        }

        public IBankAccount Open()
        {
            foreach (var account in Accounts)
            {
                account.Open();
            }
            return this;
        }
    }
}
