using Kamoji.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Kamoji.Services
{
    public class Randomizer : IRandomizer
    {
        private readonly Random _rand = new Random();
        public Randomizer()
        { }

        public int Next(int maxValue = int.MaxValue)
        {
            return _rand.Next(maxValue);
        }
    }
}
