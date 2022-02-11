using System;

namespace TryCatchPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your name please!");
                var name = Console.ReadLine()?.Trim();
                Console.WriteLine($"Hi {name}");

            }
            catch (NameTooShort e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
            

            
        }
    }
}