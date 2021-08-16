using System;
using Utilities;

namespace Task4
{
    public class SubTask1 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            const string defaultNum = "1";
            Console.WriteLine("Enter the first number please");
            var firstNum = int.Parse(Console.ReadLine() ?? defaultNum);
            Console.WriteLine("Enter the second number please");
            var secondNum = int.Parse(Console.ReadLine() ?? defaultNum);
            Console.WriteLine("Enter the operation please");
            var operation = Console.ReadLine();
            Calculation(firstNum, secondNum, operation);
        }

        private static void Calculation(int firstOperand, int secondOperand, string @operator)
        {
            switch (@operator)
            {
                case "+":
                {
                    var plus = firstOperand + secondOperand;
                    Console.WriteLine($"{firstOperand} + {secondOperand} = {plus}");
                    break;
                }
                case "-":
                {
                    var minus = firstOperand - secondOperand;
                    Console.WriteLine($"{firstOperand} - {secondOperand} = {minus}");
                    break;
                }
                case "*":
                {
                    var asterisk = firstOperand * secondOperand;
                    Console.WriteLine($"{firstOperand} * {secondOperand} = {asterisk}");
                    break;
                }
                case "/":
                {
                    var slash = firstOperand / secondOperand;
                    Console.WriteLine($"{firstOperand} / {secondOperand} = {slash}");
                    break;
                }
            }
        }
    }
}