using Responsibility_Chain.Checkers;
using System;

namespace Responsibility_Chain
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Tworzymy łańcuch odpowiedzialności
            var passwordChecker = new NumberChecker(new LengthChecker(new UpperLetterChecker(null)));

            var result = passwordChecker.Analyze("dahsjk%^^&*1231");

            Console.WriteLine(result.ActualPoints);
        }
    }
}
