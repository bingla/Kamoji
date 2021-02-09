using System.Collections.Generic;

namespace Kamoji.Internals
{
    public enum ePositive
    {
        Joy,
        Love
    }

    public enum eNegative
    {
        Anger,
        Pain
    }

    public static class Emoji
    {
        public static readonly Dictionary<ePositive, List<string>> Positive = new Dictionary<ePositive, List<string>>
        {
            { ePositive.Joy, new List<string> {
                "(* ^ ω ^)", "(´ ∀ ` *)",
            }},
            { ePositive.Love, new List<string> {
                "(ﾉ´ з `)ノ", "(♡μ_μ)",
            }}
        };

        public static readonly Dictionary<eNegative, List<string>> Negative = new Dictionary<eNegative, List<string>>
        {
            { eNegative.Anger, new List<string> {
                "(＃`Д´)", "( ` ω ´ )"
            }},
            { eNegative.Pain, new List<string> {
                "~(>_<~)", "☆⌒(> _ <)"
            }},
        };
    }
}
