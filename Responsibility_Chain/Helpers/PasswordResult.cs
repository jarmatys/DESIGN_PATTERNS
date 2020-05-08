using System;
using System.Collections.Generic;
using System.Text;

namespace Responsibility_Chain.Helpers
{
    public struct PasswordResult
    {
        public int ActualPoints { get; private set; }
        public int MaxPoints { get; private set; }
        public PasswordResult AddPoints(int points)
        {
            ActualPoints = ActualPoints + points;
            return this;
        }
        public PasswordResult AddMaxPoints(int points)
        {
            MaxPoints = MaxPoints + points;
            return this;
        }

    }
}
