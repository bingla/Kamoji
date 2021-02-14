using Kamoji.Interfaces;
using System;

namespace Kamoji.Services
{
    public class Randomizer : IRandomizer
    {
        private readonly Random _rand = new Random();
        public Randomizer()
        { }

        public int Next(int maxValue)
        {
            return _rand.Next(maxValue < 0 ? 0 : maxValue - 1);
        }
    }
}
