using System;
using System.Collections.Generic;
using System.Linq;

namespace Task4.SubTask7_
{
    public class Train
    {
        // field
        // public int CarCount;
        // property
        private const int VacantSeat = 0;
        private const int OccupiedSeat = 1;
        private const int BookedSeat = 2;

        public int CarCount { get; }
        public int SeatCount { get; }
        public string OccupiedSeatCharacter { get; set; } = "*";

        private int[,] Seats { get; }

        public Train(int carCount, int seatCount)
        {
            CarCount = carCount;
            SeatCount = seatCount;

            Seats = new int[CarCount, SeatCount];
            InitializeSeatsRandomly();
        }

        public void PrintSeats()
        {
            PrintSeatsNumbersHeader();
            for (var row = 0; row < Seats.GetLength(0); row++)
            {
                PrintRow(row);
                Console.WriteLine();
            }
        }

        public void PrintCarByNumber(int carNumber)
        {
            carNumber -= 1;
            PrintSeatsNumbersHeader();
            PrintRow(carNumber);
            Console.WriteLine();
            PrintVacantSeatsInfo(carNumber);
        }

        private void PrintVacantSeatsInfo(int carNumber)
        {
            var vacantSeatNumbers = GetVacantSeatsByCarNumber(carNumber);

            Console.WriteLine($"Vacant seats count: {vacantSeatNumbers.Count}");

            var vacantSeats = vacantSeatNumbers.Select(x => x.ToString("00"));
            Console.WriteLine($"Vacant seats: {string.Join(" ", vacantSeats)}");
        }

        private List<int> GetVacantSeatsByCarNumber(int carNumber)
        {
            var vacantSeatNumbers = new List<int>();
            for (var i = 0; i < SeatCount; i++)
            {
                if (Seats[carNumber, i] == VacantSeat)
                    vacantSeatNumbers.Add(i + 1);
            }

            return vacantSeatNumbers;
        }

        private void InitializeSeatsRandomly()
        {
            var random = new Random();
            for (var row = 0; row < Seats.GetLength(0); row++)
            {
                for (var column = 0; column < Seats.GetLength(1); column++)
                {
                    Seats[row, column] = random.Next(0, 2);
                }
            }
        }

        private void PrintRow(int row)
        {
            Console.Write((row + 1).ToString("00") + " ");
            for (var column = 0; column < Seats.GetLength(1); column++)
            {
                Console.Write(GetSeatIdentifier(row, column) + "  ");
            }
        }

        private string GetSeatIdentifier(int row, int column)
        {
            return Seats[row, column] == OccupiedSeat ? OccupiedSeatCharacter : " ";
        }


        private void PrintSeatsNumbersHeader()
        {
            Console.Write("  ");
            for (var i = 0; i < SeatCount; i++)
            {
                Console.Write((i + 1).ToString("00") + " ");
            }

            Console.WriteLine();
        }
        
        

        

        // public string Booking(List<int> vacantSeatsInTheCar)
        // {
        //     Console.WriteLine("Which seat would you like to book?");
        //     var bookedSeat = "+";
        //     foreach (var seat in vacantSeatsInTheCar)
        //     {
        //         if (seat == VacantSeat)
        //         {
        //             bookedSeat = seat.ToString();
        //         }
        //     }
        //
        //     return bookedSeat;
        // }
    }
}