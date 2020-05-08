using System.Collections.Generic;
using System.Threading;

namespace Proxy
{
    public class DbContext : IDbContext
    {
        public DbContext()
        {
            // symuluje długie ladowanie metody
            Thread.Sleep(5000);
        }

        public IEnumerable<string> GetActiveUsers()
        {
            var users = new List<string>
            {
                "Jarek",
                "Tomek",
                "Adam",
                "Jurek",
                "Andrzej",
                "Jacek",
            };

            return users;
        }
    }
}