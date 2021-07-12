using System;
using Utilities;

namespace Task2
{
    public class SubTask2 : BaseTask
    {
        public override void Start()
        {
            base.Start();

            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            var surname = Console.ReadLine();
            Console.WriteLine("Where are you from my man or woman?");
            var country = Console.ReadLine();
            Console.WriteLine("Which year were you born?");
            var yearOfBirth = int.Parse(Console.ReadLine());


            int age = CalculateAge(yearOfBirth);
            if (age > 0)
            {
                Console.WriteLine($"Hello {name} {surname}. You are {age} years old and you are from {country}.");
            }
            else
            {
                Console.WriteLine("You lying piece of shit get the fuck outta here!");
            }
        }

        private static int CalculateAge(int year)
        {
            var result = DateTime.Today.Year - year;
            return result;
        }
    }
}