using Responsibility_Chain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Responsibility_Chain.Checkers
{
    public class LengthChecker : IPasswordStrength
    {
        public IPasswordStrength Successor { get; set; }

        public LengthChecker(IPasswordStrength successor)
        {
            Successor = successor;
        }

        public PasswordResult Analyze(string password, PasswordResult passwordResult = default)
        {
            // przydzielamy punkty
            int point = 0;

            if (point <= 30)
            {
                point = password.Length;
            }
            else
            {
                point = 30;
            }


            // jeżeli nie ma kolejnego successora to wyrzuć ostateczny wynik
            if (Successor != null)
            {
                return Successor.Analyze(password, passwordResult.AddPoints(point));
            }
            // jeżeli jest successor to przekazujemy go dalej
            return passwordResult;
        }
    }
}
