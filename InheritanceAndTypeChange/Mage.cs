using System;
using System.Globalization;

namespace InheritanceAndTypeChange
{
    public class Mage : Player
    {
        public string school;
        public int skill;
        private Random rand = new Random();
        
        public Mage(string name, string guild, string school) : base(name, guild)
        {
            skill = rand.Next(0, 100);
            this.school = school;
        }

        public void Print()
        {
            Console.WriteLine(name,Guild,school);
        }
    }
}