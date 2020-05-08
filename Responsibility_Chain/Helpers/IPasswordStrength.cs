using System;
using System.Collections.Generic;
using System.Text;

namespace Responsibility_Chain.Helpers
{
    public interface IPasswordStrength
    {
        IPasswordStrength Successor { get; set; }
        PasswordResult Analyze(string password, PasswordResult passwordResult = default(PasswordResult));
    }


}
