using System;

namespace PracticeTasks
{
    public class SubTask5
    {
        public static void Questionaire()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your surname?");
            string surname = Console.ReadLine();
            Console.WriteLine("Where are you from my man or woman?");
            string country = Console.ReadLine();
            Console.WriteLine("Which year were you born?");
            int yearOfBirth = Int32.Parse(Console.ReadLine());


            int age = AgeCalc(yearOfBirth);
            if (age > 0)
            {
                Console.WriteLine($"Hello {name} {surname}. You are {age} years old and you are from {country}.");
            }
            else
            {
                Console.WriteLine("You lying piece of shit get the fuck outta here!");
            }
        }

        static int AgeCalc(int year)
        {
            int result = 2021 - year;
            return result;
        }
    }
}