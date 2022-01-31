using System;

namespace AbstractClassesPractice
{
    public class GenericExample <T1, T2>
    {
        public T1 Name { get; set; }
        public T1 Surname { get; set; }
        public T2 ID { get; set; }

        public void Print()
        {
            Console.WriteLine($"{Name} {Surname} {ID}");
        }
    }
    
   
}