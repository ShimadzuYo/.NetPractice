using System;
using System.Collections.Generic;
using System.Globalization;
using Utilities;

namespace Task3
{
    public class SubTask6 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            var radii = new List<double>() {12, 35, 4};
            var result = CalculateCircleArea(radii);


            foreach (var radius in result)
            {
                Console.WriteLine(radius);
            }
        }

        private static List<double> CalculateCircleArea(ICollection<double> radii)
        {
            var areas = new List<double>();
            foreach (var radius in radii)
            {
                var s = Math.PI * (radius * radius);
                areas.Add(s);
            }

            return areas;
        }
    }
}