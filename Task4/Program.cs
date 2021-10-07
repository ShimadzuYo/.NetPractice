using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Task4.SubTask7_;

namespace Task4
{
    public static class Program
    {
        private static async Task Main(string[] args)
        {
            var subTask7 = new SubTask7();
            subTask7.Start();
        }

        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Default animal sound");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Meow!");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Bark!");
            }
        }

        public class Cow : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Moo!");
            }
        }
    }
}