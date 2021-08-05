using System;
using System.Collections.Generic;
using Utilities;
using System.Linq;

namespace Task3
{
    public class SubTask5 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            string[] array1 = {"1", "2", "8", "23", "11", "98", "35", "58", "70", "41"};
            Console.WriteLine("Array A:");
            foreach (var v in array1)
            {
                Console.WriteLine(v);
            }

            string[] array2 = {"1", "2", "8", "23", "11", "98", "35", "58", "70", "41"};
            Console.WriteLine("Array B:");
            foreach (var f in array2)
            {
                Console.WriteLine(f);
            }

            var array3 = new int[10];
            const int max = 10;

            for (var i = 0; i < max; i++)
            {
                if (array1.Length == array2.Length)
                {
                    array3[i] = int.Parse(array1[i]) + int.Parse(array2[i]);
                }
            }

            Console.WriteLine("Array C:");
            foreach (var c in array3)
            {
                Console.WriteLine(c);
            }

            var maxTrue = array3.Max();
            Console.WriteLine($"MAX in array C = {maxTrue}");
            var last3 = array3[^3];
            var last2 = array3[^2];
            var last1 = array3[^1];
            var minOfThree = 0;
            if (last3 < last2 && last3 < last1)
            {
                minOfThree = last3;
            }
            else if (last2 < last3 && last2 < last1)
            {
                minOfThree = last2;
            }
            else if (last1 < last2 && last1 < last3)
            {
                minOfThree = last1;
            }

            Console.WriteLine($"MIN of last 3 in array C = {minOfThree}");
        }
    }
}