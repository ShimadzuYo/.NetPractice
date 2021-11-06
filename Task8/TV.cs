using System;

namespace Task8
{
    public class Tv
    {
        public int _maxChannels = 20;
        public int _currentChannel;

        public Tv(int current, int maximum)
        {
            _currentChannel = current;
            _maxChannels = maximum;
            Console.WriteLine($"You are currently watching channel number {current}");
        }
        

        public void GoNext()
        {
            _currentChannel++;
            Console.WriteLine($"Current channel is {_currentChannel} now");
        }

        public void GoBack()
        {
            _currentChannel--;
            Console.WriteLine($"Current channel is {_currentChannel} now");
        }

        public void GoTo(int channel)
        {
            _currentChannel = channel;
            Console.WriteLine($"Current channel is {_currentChannel} now");
        }
    }
    
}