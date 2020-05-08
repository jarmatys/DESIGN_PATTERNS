using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy
{
    public class DbContextProxy : IDbContext
    {
        private IDbContext dbContext;

        public IEnumerable<string> GetActiveUsers()
        {
            if(dbContext == null)
            {
                dbContext = new DbContext();
            }
            // metoda do wyciągnięcia danych aktywuje się dopiero w momencie jej pierwszego wywołania
            return dbContext.GetActiveUsers();
        }
    }
}
