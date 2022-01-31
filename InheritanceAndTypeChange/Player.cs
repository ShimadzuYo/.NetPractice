using System;

namespace InheritanceAndTypeChange
{
    public class Player
    {
        public string name;

        public string Guild
        {
            get => Guild;
            set{
                if (value == "Mage")
                {
                    Console.WriteLine("Your character is a mage");
                }}
        }

        public Player(string name, string guild)
        {
            this.name = name;
            this.Guild = guild;
        }
        
    }
}