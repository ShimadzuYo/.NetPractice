using System;
using Utilities;


namespace Task3
{
    public class SubTask1: BaseTask

    {
        public override void Start()
        {
            const string defaultNumberOne = "1";
            const string defaultNumberTwo = "2";
            Console.WriteLine("Enter the first number cunt!");
            var firstNumber = int.Parse(Console.ReadLine() ?? defaultNumberOne);
            Console.WriteLine("Enter the second number bitchcunt!");
            var secondNumber = int.Parse(Console.ReadLine() ?? defaultNumberTwo);
            if (firstNumber < secondNumber)
            {
                Console.WriteLine("<");
            }
            else if (firstNumber > secondNumber)
            {
                Console.WriteLine(">");
            }
            else if (firstNumber == secondNumber)
            {
                Console.WriteLine("=");
            }

        }

    }
}