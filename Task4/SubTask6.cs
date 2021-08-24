using System;
using System.Collections.Generic;
using Utilities;

namespace Task4
{
    public class SubTask6 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var theMainList = GenerateInitialArray();
            foreach (var element in theMainList)
            {
                Console.WriteLine(element);
            }

            PositiveAndNegative(theMainList);
            var numberOfEvenIndices = EvenIndexCounter(theMainList);
            Console.WriteLine($"The even indices : {numberOfEvenIndices}");
            var numberOfOddIndices = OddIndexCounter(theMainList);
            Console.WriteLine($"The odd indices : {numberOfOddIndices}");


            List<int> GenerateInitialArray(int size = 10, int minRange = -10, int maxRange = 10)
            {
                var randomArray = new List<int>();
                var randNum = new Random();
                for (var i = 0; i < size; i++)
                {
                    var randomElement = randNum.Next(minRange, maxRange);
                    randomArray.Add(randomElement);
                }

                return randomArray;
            }

            static void PositiveAndNegative(List<int> subject)
            {
                var negativeElements = new List<int>();
                var positiveElements = new List<int>();
                foreach (var element in subject)
                {
                    if (element < 0)
                    {
                        negativeElements.Add(element);
                    }
                    else
                    {
                        positiveElements.Add(element);
                    }
                }

                Console.WriteLine("Positive elements:");
                foreach (var positiveElement in positiveElements)
                {
                    Console.WriteLine(positiveElement);
                }

                Console.WriteLine("Negative elements:");
                foreach (var negativeElement in negativeElements)
                {
                    Console.WriteLine(negativeElement);
                }
            }

            static int EvenIndexCounter(List<int> subject)
            {
                var evenIndex = 0;
                for (var i = 0; i < subject.Count - 1; i++)
                {
                    if (i % 2 == 0)
                    {
                        evenIndex++;
                    }
                }

                return evenIndex;
            }

            static int OddIndexCounter(List<int> subject)
            {
                var oddIndex = 0;
                for (var i = 0; i < subject.Count; i++)
                {
                    if (i % 2 != 0)
                    {
                        oddIndex++;
                    }
                }

                return oddIndex;
            }
        }
    }
}