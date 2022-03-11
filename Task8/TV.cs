using System;
using System.Collections.Generic;
using System.Linq;

namespace Task8
{
    public class Tv
    {
        public static readonly List<string> AvailableChannels = new()
        {
            { null },
            { "Perviy kanal" },
            { "Kultura" },
            { "MTV" },
            { "Zadrot TV" },
            { "Hustler" }
        };

        public readonly int MaxChannels = AvailableChannels.Count;
        public int CurrentChannelNum;


        public Tv()
        {
            var randomizer = new Random();
            CurrentChannelNum = randomizer.Next(0, MaxChannels);
            Console.WriteLine(
                $"You are currently watching channel number {CurrentChannelNum} - {AvailableChannels[CurrentChannelNum]}");
        }


        public void GoNext()
        {
            if (CurrentChannelNum >= MaxChannels - 1)
            {
                Console.WriteLine("You have exceeded the channel limit and are being redirected to the first channel");
                GoTo(1);
                return;
            }

            CurrentChannelNum++;
            Console.WriteLine($"Current channel is {CurrentChannelNum} - {AvailableChannels[CurrentChannelNum]} now");
        }

        public void GoBack()
        {
            if (CurrentChannelNum <= 0)
            {
                Console.WriteLine("There is no such channel");
                return;
            }

            CurrentChannelNum--;
            Console.WriteLine($"Current channel is {CurrentChannelNum} - {AvailableChannels[CurrentChannelNum]} now");
        }

        public void GoTo(int channel)
        {
            CurrentChannelNum = channel;
            if (CurrentChannelNum <= 0 || CurrentChannelNum > MaxChannels)
            {
                Console.WriteLine("There is no such channel");
                return;
            }

            Console.WriteLine($"Current channel is {CurrentChannelNum} - {AvailableChannels[channel]} now");
        }
    }
}