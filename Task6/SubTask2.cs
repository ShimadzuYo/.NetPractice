using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace Task6
{
    public class SubTask2:BaseTask
    
    {
        public override void Start()
        {
            base.Start();
            Console.WriteLine("Hi there retard!");
            var result = TheJob();
            Console.WriteLine(result);
            
        }

        private static int TheJob()
        {
            var myInts = new List<int>(10);
            for (var i = 0; i < myInts.Capacity; i++)
            {
                Console.WriteLine("Enter a value pls!");
                int theElement = Int32.Parse(Console.ReadLine() ?? string.Empty);
                myInts.Add(theElement);
            }

            var theResult = 0;
            string op = "";
            Console.WriteLine("Enter the operation pls - avg, min or max");
            var theOpChoice = Console.ReadLine();
            // TODO: Refactor with delegates 
            if (theOpChoice == "avg")
            {
                theResult = myInts.Sum() / myInts.Count;
            }

            if (theOpChoice == "min")
            {
                theResult = myInts.Min();
            }

            if (theOpChoice == "max")
            {
                theResult = myInts.Max();
            }

            return theResult;


        }
    }
}