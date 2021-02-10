using Kamoji.Interfaces;
using Kamoji.Internals;

namespace Kamoji.Services
{
    public class KamojiService : IKamojiService
    {
        private readonly IRandomizer _randomizer;
        public KamojiService(IRandomizer randomizer)
        {
            _randomizer = randomizer;
        }

        public string Positive(ePositive type)
        {
            return Emoji.Positive.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }

        public string Negative(eNegative type)
        {
            return Emoji.Negative.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }

        public string Neutral(eNeutral type)
        {
            return Emoji.Neutral.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }

        public string Various(eVarious type)
        {
            return Emoji.Various.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }

        public string Animals(eAnimals type)
        {
            return Emoji.Animals.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }

        public string Other(eOther type)
        {
            return Emoji.Other.TryGetValue(type, out var list)
                ? list[_randomizer.Next(list.Count)]
                : string.Empty;
        }
    }
}
