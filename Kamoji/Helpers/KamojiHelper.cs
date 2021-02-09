using Kamoji.Internals;
using System;

namespace Kamoji.Helpers
{
    public static class KamojiHelper
    {
        public static string Positive(ePositive type)
        {
            var rand = new Random();
            return Emoji.Positive.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }

        public static string Negative(eNegative type)
        {
            var rand = new Random();
            return Emoji.Negative.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }

        public static string Neutral(eNeutral type)
        {
            var rand = new Random();
            return Emoji.Neutral.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }

        public static string Various(eVarious type)
        {
            var rand = new Random();
            return Emoji.Various.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }

        public static string Animals(eAnimals type)
        {
            var rand = new Random();
            return Emoji.Animals.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }

        public static string Other(eOther type)
        {
            var rand = new Random();
            return Emoji.Other.TryGetValue(type, out var list)
                ? list[rand.Next(list.Count)]
                : string.Empty;
        }
    }
}
