using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public interface IDbContext
    {
        IEnumerable<string> GetActiveUsers();
    }
}
