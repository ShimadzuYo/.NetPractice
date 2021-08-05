using Utilities;
using System;


namespace Task3
{
    public class SubTask4 : BaseTask
    {
        public override void Start()
        {
            base.Start();
            const int divisionX = 0;
            const int divisionY = 0;
            const string defaultHouseCoordinatesX = "0";
            const string defaultHouseCoordinatesY = "0";
            Console.WriteLine("Enter the x and y coordinates of your house please");
            var houseCoordinatesX = int.Parse(Console.ReadLine() ?? defaultHouseCoordinatesX);
            var houseCoordinatesY = int.Parse(Console.ReadLine() ?? defaultHouseCoordinatesY);
            switch (houseCoordinatesX)
            {
                case 0 when houseCoordinatesY == divisionY:
                    Console.WriteLine("Border");
                    break;
                case > divisionX when houseCoordinatesY > divisionY:
                    Console.WriteLine("NE");
                    break;
                case > divisionX when houseCoordinatesY < divisionY:
                    Console.WriteLine("SE");
                    break;
                case < divisionX when houseCoordinatesY > divisionY:
                    Console.WriteLine("NW");
                    break;
                case < divisionX when houseCoordinatesY < divisionY:
                    Console.WriteLine("SW");
                    break;
            }
        }
    }
}