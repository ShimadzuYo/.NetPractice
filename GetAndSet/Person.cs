using System;

namespace GetAndSet
{
    public class Person
    {
        public string name;
        public int age;
        public static int retirementAge = 65;


        // public Person(string name, int age)
        // {
        //     this.name = name;
        //     this.age = age;
        // }

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get => age;
            set
            {
                age = value;
                if (age >= retirementAge)
                {
                    Console.WriteLine("Retired");
                }
            }
        }
    }
}