using System;

namespace Task8
{
    public class Elevator
    {
        private int currentFloor;
        private int capacity;
        private int maxFloors = 18;

        public Elevator(int current, int cap)
        {
            currentFloor = current;
            capacity = cap;
            Console.WriteLine($"The elevator is currently on floor {currentFloor} ");
        }

        public bool IsUnderCapacity(int weight)
        {
            if (weight < capacity)
            {
                return true;
            }

            return false;
        }

        public bool HasThisManyFloors(int floor)
        {
            if (floor < maxFloors)
            {
                return true;
            }

            return false;
        }

        public void GoTo(int floor, int weight)
        {
            var check1 = HasThisManyFloors(floor);
            var check2 = IsUnderCapacity(weight);
            if (check1 && check2 is true)
            {
                do
                {
                    currentFloor++;
                    Console.WriteLine($"We are currently on the floor {currentFloor}");
                } while (currentFloor < floor);
            }

            if (!check1)
            {
                Console.WriteLine($"This elevator only goes up to {maxFloors} floors");
            }

            if (!check2)
            {
                Console.WriteLine($"This elevator can only carry up to {capacity}kg");
            }
        }
    }
}