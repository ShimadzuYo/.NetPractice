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

            Console.WriteLine("Enter dividend");
            var dividend = int.Parse(Console.ReadLine() ?? DefaultDividend);
            Console.WriteLine("Enter divisor");
            var divisor = int.Parse(Console.ReadLine() ?? DefaultDivisor);
            Console.WriteLine("And is there a remainder?");
            HasRemainderAfterDivision(dividend, divisor);
        }

        private static void HasRemainderAfterDivision(int firstOperand, int secondOperand)
        {
            var result = firstOperand % secondOperand;
            Console.WriteLine(result == 0 ? "False" : $"True, and it is {result}");
        }
    }
}