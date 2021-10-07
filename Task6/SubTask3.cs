using System;
using Utilities;

// ReSharper disable TailRecursiveCall
namespace Task6
{
    public class SubTask3 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Enter the first number please:");
            var a = int.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("Enter the second number please (must be greater than the first one): ");
            var b = int.Parse(Console.ReadLine() ?? string.Empty);
            Recursion(a, b);
        }


        private static void Recursion(int a, int b)
        {
            Console.Write($"{a} ");
            if (a == b)
            {
                return;
            }

            Recursion(a + 1, b);
        }
    }
}