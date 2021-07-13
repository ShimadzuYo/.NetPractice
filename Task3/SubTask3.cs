

using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;


namespace Task3
{
    public class SubTask3 : BaseTask
    {
        public override void Start()
        {
            const string defaultGuestNumber = "1";
            const string defaultCakeRadius = "14.0";
            const double pi = 3.1452;  
            Console.WriteLine("How many guests will be present (including you)?");
            var guests = int.Parse(Console.ReadLine() ?? defaultGuestNumber);
            Console.WriteLine("Enter the cake`s radius (in cm) please.");
            var cakeRadius = double.Parse(Console.ReadLine() ?? defaultCakeRadius);
            var slices = (2 * pi * cakeRadius) / guests;
            Console.WriteLine($"Here is the optimal size of the slice so that each guest gets an equally sized slice: {slices} cm");
        }
    }
}
