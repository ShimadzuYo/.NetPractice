using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Task4.SubTask7_
{
    public class Station
    {
        private readonly List<Tuple<string, TimeSpan>> _stations = new()
        {
            new Tuple<string, TimeSpan>("Говняево", TimeSpan.FromSeconds(4)),
            new Tuple<string, TimeSpan>("Курманалиево", TimeSpan.FromSeconds(2)),
            new Tuple<string, TimeSpan>("Хуйево", TimeSpan.FromSeconds(7)),
            new Tuple<string, TimeSpan>("Грязные дебилы", TimeSpan.FromSeconds(1)),
            new Tuple<string, TimeSpan>("Мытые дебилы", TimeSpan.FromSeconds(2)),
        };

        private int _currentStationIndex = 0;

        public string GetNextStationName()
        {
            var index = _currentStationIndex == _stations.Count - 1 ? 0 : _currentStationIndex + 1;
            return _stations[index].Item1;
        }

        public TimeSpan GetTimeToNextStation()
        {
            return _stations[_currentStationIndex].Item2;
        }

        public void MoveToNextStation()
        {
            if (_currentStationIndex == _stations.Count - 1)
                _currentStationIndex = 0;

            _currentStationIndex++;
        }


        public async Task PrintStatusAndWaitTillNextStation()
        {
            // Console.SetCursorPosition(row, 0);

            Console.WriteLine($"Next station - {GetNextStationName()}                                                         ");
            var timeToNextStation = GetTimeToNextStation().TotalSeconds;
            var (left,top) = Console.GetCursorPosition();
            await Task.Run(async () =>
            {
                do
                {
                     
                    Console.SetCursorPosition(left, top);
                    Console.WriteLine($"Next station in {timeToNextStation:00.00} seconds");
                    await Task.Delay(100);
                    timeToNextStation -= 0.1;
                } while (timeToNextStation >= 0);
            });
        }
    }
}