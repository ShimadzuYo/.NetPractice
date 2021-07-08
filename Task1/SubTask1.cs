using System;
using Utilities;

namespace Task1
{
    public class SubTask1 : BaseTask
    {
        private const string DefaultDividend = "10";
        private const string DefaultDivisor = "10";

        public override void Start()
        {
            base.Start();
            
            Console.WriteLine("Enter first dividend");
            var dividend = int.Parse(Console.ReadLine() ?? DefaultDividend);
            Console.WriteLine("Enter second dividend");
            var divisor = int.Parse(Console.ReadLine() ?? DefaultDivisor);
            Console.WriteLine("And is there a remainder?");
            HasRemainderAfterDivision(dividend, divisor);
        }


        // ctrl + p (show argument hint inside method)
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