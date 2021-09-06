using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Utilities;

namespace Task4.SubTask7_
{
    public class SubTask7 : BaseTask
    {
        private const int DefaultCarCount = 18;
        private const int DefaultSeatCount = 20;

        public override void Start()
        {
            UserInteraction();
        }

        private static void UserInteraction()
        {
            var train = new Train(DefaultCarCount, DefaultSeatCount);
            train.PrintSeats();

            const string ExitString = "VSE!";
            while (true)
            {
                Console.Write("Enter car number: ");
                var userInput = Console.ReadLine() ?? string.Empty;
                if (userInput == ExitString)
                {
                    Console.WriteLine("NU I POWEL NAHOOY!");
                    break;
                }

                var carNumber = int.Parse(userInput);
                if (carNumber > train.CarCount)
                {
                    Console.WriteLine("TAKOGO VAGONA NET, DAUN, DEBIL, EBAN!");
                    continue;
                }
                train.PrintCarByNumber(carNumber);
                Console.WriteLine();
            }
        }
    }
}