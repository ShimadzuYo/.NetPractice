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
            var array1 = new int [10];
            Method1(array1);

            Console.WriteLine("Array A:");
            PrintOutArray(array1);


            var array2 = new int [10];
            Method2(array2);
            Console.WriteLine("Array B:");
            PrintOutArray(array2);


            var array3 = new int[10];
            const int max = 10;

            for (var i = 0; i < max; i++)
            {
                if (array1.Length == array2.Length)
                {
                    array3[i] = array1[i] + array2[i];
                }
            }

            Console.WriteLine("Array C:");
            PrintOutArray(array3);

            var maxTrue = array3.Max();
            Console.WriteLine($"MAX in array C = {maxTrue}");
            var mins = array3.Skip(array3.Length - 3);
            var minElement = mins.Min();
            Console.WriteLine($"{minElement} is the smallest of the last three");
        }


        static void PrintOutArray(Array arr)
        {
            foreach (var x in arr)
            {
                Console.WriteLine(x);
            }
        }

        static void Method1(int[] array)
        {
            Random randNum = new Random();
            for (var c = 0; c < array.Length; c++)
            {
                array[c] = randNum.Next(-100, 100);
            }
        }

        static void Method2(int[] array)
        {
            var defaultNum = "1";
            for (var n = 0; n < array.Length; n++)
            {
                Console.WriteLine("Enter the value please");
                array[n] = int.Parse(Console.ReadLine() ?? defaultNum);
            }
        }
    }
}