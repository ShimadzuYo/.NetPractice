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
            var resultOfCalculation = Calculation(firstNum, secondNum, operation);
            if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid input");
            }
            else
            {
                Console.WriteLine($"{firstNum} {operation} {secondNum} = {resultOfCalculation}");
            }
        }

        private static int Calculation(int firstOperand, int secondOperand, string @operator)
        {
            var result = @operator switch
            {
                "+" => firstOperand + secondOperand,
                "-" => firstOperand - secondOperand,
                "*" => firstOperand * secondOperand,
                "/" => firstOperand / secondOperand,
                _ => 0
            };

            return result;
        }
    }
}