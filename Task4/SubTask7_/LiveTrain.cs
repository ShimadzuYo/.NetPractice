using System;
using System.Threading.Tasks;

namespace Task4.SubTask7_
{
    public class LiveTrain : Train
    {

        private readonly Station _station;

        public LiveTrain(int carCount, int seatCount) : base(carCount, seatCount)
        {
            _station = new Station();
            StartLiveTrain();
        }

        public override void PrintSeats()
        {
            Console.SetCursorPosition(0, 0);
            base.PrintSeats();
        }

        private async Task StartLiveTrain()
        {
            while (true)
            {
                InitializeSeatsRandomly();
                PrintSeats();
                await _station.PrintStatusAndWaitTillNextStation();
                _station.GetTimeToNextStation();
                _station.MoveToNextStation();
            }
        }
    }
}