using System;

namespace AbstractClassesPractice
{
    public class GenericExampleSon : GenericExample<int, int>

    {
        public string future;
        public string Future
        {
            get
            {
                future = Future;
                return future;

            }
            set => throw new NotImplementedException();
        }

        public string Status { get; set; }


        public GenericExampleSon(string status)
        {
            Status = status;
        }

        public override void Print()
        {
            Console.WriteLine($"{Name} {Surname} {ID} {Status}");
        }
    }
}