using System;
using Utilities;

namespace Task8
{
    public class SubTask2: BaseTask
    {
        public override void Start()
        {
            base.Start();
            var ele1 = new Elevator(0,200);
            Console.WriteLine("Which floor would you like to go to?");
            var inputFloors = Int32.Parse(Console.ReadLine() ?? string.Empty);
            Console.WriteLine("What is the weight of your cargo?");
            var inputCargoWeight = Int32.Parse(Console.ReadLine() ?? string.Empty);
            ele1.GoTo(inputFloors,inputCargoWeight);


        }
    }
}