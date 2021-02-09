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
    }
}
