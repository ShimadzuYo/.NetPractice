using System;
using System.Collections.Generic;

namespace AbstractClassesPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var MathGroup = new List<MathStudent>();
            var EngGroup = new List<EngStudent>();
            var Math1 = new MathStudent("Vasya", "Pupkin", 140);
            var Eng1 = new EngStudent("Petya", "Churkin");
            Math1.PrintInfo();
            Eng1.PrintInfo();

            var gena = new GenericExample<string, int>
            {
                Name = "Gena",
                Surname = "Bukin",
                ID = 2548
            };
            gena.Print();

            var gena2 = new GenericExampleSon("Failed")
            {
                Name = 123,
                ID = 456,
                Surname = 678,
            };
            gena2.Print();

        }
    }
}