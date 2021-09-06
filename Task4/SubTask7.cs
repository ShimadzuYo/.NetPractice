using System;
using Utilities;

namespace Task4
{
    public class SubTask7 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var array = new int[18, 20];
            var rowLength = array.GetLength(0);
            var colLength = array.GetLength(1);
            for (var i = 0; i < rowLength; i++)
            {
                for (var j = 0; j < colLength; j++)
                {
                    Console.WriteLine($"{array[i, j]}");
                }
                Console.Write("\n\n");
            }
            

        }
    }
}