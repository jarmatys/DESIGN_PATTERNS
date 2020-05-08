using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public static class User
    {
        public static void GetInApp()
        {
            LogIn.CheckCredentials();
            Role.CheckIsAdmin();
            Cookie.Set();
        }
    }
}
