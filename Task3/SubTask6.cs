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
            var result = CalculateRadii(radii);


            foreach (var b in result)
            {
                Console.WriteLine(b);
            }
        }

        static List<double> CalculateRadii(ICollection<double> radii)
        {
            var areas = new List<double>();
            foreach (var a in radii)
            {
                var s = Math.PI * (a * a);
                areas.Add(s);
            }

            return areas;
        }
    }
}