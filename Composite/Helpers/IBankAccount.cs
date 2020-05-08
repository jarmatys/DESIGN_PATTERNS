using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Helpers
{
    public interface IBankAccount
    {
        string ID { get; }
        IBankAccount Open();
        IBankAccount Close();
    }
}
