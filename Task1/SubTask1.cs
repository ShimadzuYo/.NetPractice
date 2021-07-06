using System;

namespace Task1
{
    static class SubTask1
    {
        private const string DefaultDividend = "10";
        private const string DefaultDivisor = "10";

        public static void Start()
        {
            Console.WriteLine("Enter first dividend");
            var dividend = int.Parse(Console.ReadLine() ?? DefaultDividend);
            Console.WriteLine("Enter second dividend");
            var divisor = int.Parse(Console.ReadLine() ?? DefaultDivisor);
            Console.WriteLine("And is there a remainder?");
            HasRemainderAfterDivision(dividend, divisor);
        }


        // ctrl + p (inside method)
        // ctrl + q (show documentation)
        // alt + enter - show recommendations
        // alt + enter + enter - show & apply recommendations
        // shift + f6 - rename
        // ctrl + alt + l - format code
        // ctrl + alt + o - optimize using's
        private static void HasRemainderAfterDivision(int firstOperand, int secondOperand)
        {
            var result = firstOperand % secondOperand;
            Console.WriteLine(result == 0 ? "False" : $"True, and it is {result}");
        }
    }
}