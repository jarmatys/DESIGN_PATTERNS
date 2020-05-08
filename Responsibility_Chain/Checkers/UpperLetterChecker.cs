using Responsibility_Chain.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Responsibility_Chain.Checkers
{
    class UpperLetterChecker : IPasswordStrength
    {
        public IPasswordStrength Successor { get; set; }

        public UpperLetterChecker(IPasswordStrength successor)
        {
            Successor = successor;
        }

        public PasswordResult Analyze(string password, PasswordResult passwordResult = default)
        {
            // przydzielamy punkty
            int point = 0;
            foreach(var sign in password)
            {
                if(point < 20 && char.IsUpper(sign))
                {
                    point += 1;
                }
            }

            // jeżeli nie ma kolejnego successora to wyrzuć ostateczny wynik
            if(Successor != null)
            {
                return Successor.Analyze(password, passwordResult.AddPoints(point));
            }
            // jeżeli jest successor to przekazujemy go dalej
            return passwordResult;
        }
    }
}
