using System;
using System.Collections.Generic;
using Utilities;
using System.Linq;
using System.Security.Cryptography;

namespace Task3
{
    public class SubTask5 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var array1 = GenerateArrayWithRandomElements();


            var array2 = GenerateArrayWithUserInput();

            Console.WriteLine("Array A:");
            PrintOutArray(array1);
            Console.WriteLine("Array B:");
            PrintOutArray(array2);


            var array3 = new List<int>();
            const int max = 10;

            for (var i = 0; i < max; i++)
            {
                if (array1.Count == array2.Count)
                {
                    var sum = array1[i] + array2[i];
                    array3.Add(sum);
                }
            }

            Console.WriteLine("Array C:");
            PrintOutArray(array3);

            var maxTrue = array3.Max();
            Console.WriteLine($"MAX in array C = {maxTrue}");
            var mins = array3.Skip(array3.Count - 3);
            var minElement = mins.Min();
            Console.WriteLine($"{minElement} is the smallest of the last three");
        }


        static void PrintOutArray(List<int> array)
        {
            foreach (var element in array)
            {
                Console.WriteLine(element);
            }
        }

        private static List<int> GenerateArrayWithRandomElements(int size = 10, int minRandom = -100,
            int maxRandom = 100)
        {
            var randomArray = new List<int>();
            var randNum = new Random();
            for (var c = 0; c < size; c++)
            {
                var randomElement = randNum.Next(minRandom, maxRandom);
                randomArray.Add(randomElement);
            }

            return randomArray;
        }

        private static List<int> GenerateArrayWithUserInput(int size = 10)
        {
            var inputArray = new List<int>();
            const string defaultNum = "1";
            for (var n = 0; n < size; n++)
            {
                Console.WriteLine("Enter the value please");
                var element = int.Parse(Console.ReadLine() ?? defaultNum);
                inputArray.Add(element);
            }

            return inputArray;
        }
    }
}