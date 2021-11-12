using System;
using System.Collections.Generic;

namespace Task8
{
    public class Tv
    {
        public int _maxChannels = Channels.Count;
        public int CurrentChannelNum;

        public static Dictionary<int, string> Channels = new Dictionary<int, string>()
        {
            { 1, "Perviy canal" },
            { 2, "Rossiya" },
            { 3, "Kultura" }
        };


        public Tv()
        {
            var randomizer = new Random();
            var channelNum = randomizer.Next(1, _maxChannels);
            string channelName = null;
            foreach (var x in Channels)
            {
                if (channelNum == x.Key)
                {
                    channelName = x.Value;
                }
            }

            CurrentChannelNum = channelNum;


            Console.WriteLine($"You are currently watching channel number {CurrentChannelNum} - {channelName}");
        }


        public void GoNext()
        {
            CurrentChannelNum++;
            string channelName = null;
            foreach (var x in Channels)
            {
                if (CurrentChannelNum == x.Key)
                {
                    channelName = x.Value;
                }
            }

            Console.WriteLine($"Current channel is {CurrentChannelNum} - {channelName} now");
        }

        public void GoBack()
        {
            CurrentChannelNum--;
            if (CurrentChannelNum <= 0)
            {
                Console.WriteLine("There is no such channel");
                return;
            }

            string channelName = null;
            foreach (var x in Channels)
            {
                if (CurrentChannelNum == x.Key)
                {
                    channelName = x.Value;
                }
            }

            Console.WriteLine($"Current channel is {CurrentChannelNum} - {channelName} now");
        }

        public void GoTo()
        {
            Console.WriteLine("Enter channel number please");
            var channel = Int32.Parse(Console.ReadLine());
            CurrentChannelNum = channel;
            if (CurrentChannelNum <= 0)
            {
                Console.WriteLine("There is no such channel");
                return;
            }
            string channelName = null;
            foreach (var x in Channels)
            {
                if (CurrentChannelNum == x.Key)
                {
                    channelName = x.Value;
                }
            }

            Console.WriteLine($"Current channel is {CurrentChannelNum} - {channelName} now");
           
        }
    }
}