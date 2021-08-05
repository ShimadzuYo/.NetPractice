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
            var radii = new List<int>() {12, 35, 4};
            var areas = new List<double>() { };
            foreach (var a in radii)
            {
                var S = Math.PI * (a * a);
                areas.Add(S);
            }

            foreach (var b in areas)
            {
                Console.WriteLine(b);
            }
            




            
        }
    }
}