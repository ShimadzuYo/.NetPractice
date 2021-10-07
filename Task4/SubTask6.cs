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
            IndexCounter(theMainList);
        }

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

        static void IndexCounter(List<int> subject)
        {
            var elementsOnEvenIndex = new List<int>();
            var elementsOnOddIndex = new List<int>();
            for (var i = 0; i < subject.Count - 1; i++)
            {
                if (i == 0)
                {
                    elementsOnEvenIndex.Add(subject[i]);
                }
                else if (i % 2 == 0)
                {
                    elementsOnEvenIndex.Add(subject[i]);
                }
                else if (i % 2 != 0)
                {
                    elementsOnOddIndex.Add(subject[i]);
                }
            }

            Console.WriteLine("Elements with even index:");
            for (var b = 0;  b <= elementsOnEvenIndex.Count-1; b++)
            {
                Console.WriteLine(elementsOnEvenIndex[b]);
            }

            Console.WriteLine("Elements with odd index:");
            for (var a = 0;  a <= elementsOnOddIndex.Count-1; a++)
            {
                Console.WriteLine(elementsOnOddIndex[a]);
            }
        }
    }
}