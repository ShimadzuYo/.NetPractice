using System;
using System.Buffers.Text;
using System.Collections.Generic;

namespace OopPractice
{
    public class MathGroup : Group
    {
        private string level;
        private DateTime time;
        private int number;
        private int classesAmount = 20;
        public TimeSpan CourseLength = new(30, 0, 0, 0);

        private List<string> levelsMath = new()
        {
            "beginner", "intermediate", "advanced"
        };

        public MathGroup()
        {


        }

        public new void GenerateRandomGroup()
        {
            var rand = new Random();
            var die = rand.Next(0, levelsMath.Count);
            for (var j = 0; j < levelsMath.Count; j++)
            {
                if (j == die)
                {
                    Level = levelsMath[j];
                }
            }

        }
        
        
    }
}