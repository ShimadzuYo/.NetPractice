using System.Collections;
using System;
using System.Collections.Generic;

namespace Task9
{
    public class Product
    {
        public string name;
        public int storageLife;
        public string storagePlace;
        public DateTime DeliveryTimeStamp;
        public List<string> names = new List<string>()
        {
            "Milk","Salt", "Fish", "Shit", "Cum"
        };

        public Product()
        {
            var random = new Random();
            var nameChoice = random.Next(0, names.Count);
            for (int x = 0; x < names.Count; x++)
            {
                if (nameChoice == x)
                {
                    name = names[x];
                }
            }
            
        }
        
    }
    
}