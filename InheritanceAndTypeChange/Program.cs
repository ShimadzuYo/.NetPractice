using System;

namespace InheritanceAndTypeChange
{
    class Program
    {
        static void Main(string[] args)
        {
            var Vasya = new Player("Vasya", "Mage");
            Mage mage = null;

            if (Vasya.Guild == "Mage")
            {
                Console.WriteLine($"What is going to be {Vasya.name}`s school? ");
                var school = Console.ReadLine();
                mage = new Mage(Vasya.name, Vasya.Guild, school);
            }
            mage.Print();


        }
    }
}