using System;

namespace Task1
{
    public class Subtask6
    {
        public static void Start()
        {
            int[] allTheValues = new int [3];
            for (int i = 0; i <= 3; i++)
            {
                if (i == 0)
                {
                    Console.WriteLine("Enter the first value");
                    allTheValues[i] = Int32.Parse(Console.ReadLine());
                }
                else if (i == 1)
                {
                    Console.WriteLine("Enter the second value");
                    allTheValues[i] = Int32.Parse(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Enter the third value");
                    allTheValues[i] = Int32.Parse(Console.ReadLine());
                    break;
                }

                
            }

            ;
            Console.WriteLine("Enter key of the element for comparison");
            int key = Int32.Parse(Console.ReadLine());
            if (key == 0)
            {
                if (allTheValues[0] < allTheValues[1] && allTheValues[0] < allTheValues[2])
                {
                    Console.WriteLine($"{allTheValues[1]} > {allTheValues[0]}");
                    Console.WriteLine($"{allTheValues[2]} > {allTheValues[0]}");
                    Console.WriteLine($"{allTheValues[0]} = {allTheValues[0]}");
                }
            }
        }
    }
}
            
        
    
