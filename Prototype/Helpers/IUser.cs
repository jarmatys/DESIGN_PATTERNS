using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype.Helpers
{
    public interface IUser
    {
        string Name { get; set; }
        string Login { get; set; }
        string Password { get; set; }
    }
}
