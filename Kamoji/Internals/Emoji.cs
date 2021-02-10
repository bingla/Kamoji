using System.Collections.Generic;

namespace Kamoji.Internals
{
    public enum ePositive
    {
        Joy,
        Love,
        Embarrassement,
        Sympathy
    }

    public enum eNegative
    {
        Anger,
        Dissatisfaction,
        Fear,
        Pain,
        Sadness
    }

    public enum eNeutral
    {
        Indifference,
        Confusion,
        Doubt,
        Surprice
    }

    public enum eVarious
    {
        Greeting,
        Hugging,
        Winking,
        Apologizing,
        Nosebleeding,
        Hiding,
        Writing,
        Running,
        Sleeping
    }

    public enum eAnimals
    {
        Cat,
        Bear,
        Dog,
        Rabbit,
        Pig,
        Bird,
        Fish,
        Spider
    }

    public enum eOther
    {
        Friends,
        Enemies,
        Weapons,
        Magic,
        Food,
        Music,
        Games,
        Faces,
        Special
    }

    public static class Emoji
    {
        public static readonly Dictionary<ePositive, List<string>> Positive = new Dictionary<ePositive, List<string>>
        {
            { ePositive.Embarrassement, new List<string> {
                "", "",
            }},
            { ePositive.Joy, new List<string> {
                "(* ^ ω ^)", "(´ ∀ ` *)",
            }},
            { ePositive.Love, new List<string> {
                "(ﾉ´ з `)ノ", "(♡μ_μ)", "(❤ω❤)"
            }},
            { ePositive.Sympathy, new List<string> {
                "", "",
            }},
        };

        public static readonly Dictionary<eNegative, List<string>> Negative = new Dictionary<eNegative, List<string>>
        {
            { eNegative.Anger, new List<string> {
                "(＃`Д´)", "( ` ω ´ )"
            }},
            { eNegative.Dissatisfaction, new List<string> {
                "~(>_<~)", "☆⌒(> _ <)"
            }},
            { eNegative.Fear, new List<string> {
                "(＃`Д´)", "( ` ω ´ )"
            }},
            { eNegative.Pain, new List<string> {
                "~(>_<~)", "☆⌒(> _ <)"
            }},
            { eNegative.Sadness, new List<string> {
                "(＃`Д´)", "( ` ω ´ )"
            }},
        };

        public static readonly Dictionary<eNeutral, List<string>> Neutral = new Dictionary<eNeutral, List<string>>
        {
            { eNeutral.Confusion, new List<string> {
                "(￣ω￣;)", "σ(￣、￣〃)"
            }},
            { eNeutral.Doubt, new List<string> {
                "ヽ(ー_ー )ノ", "ヽ(´ー` )┌"
            }},
            { eNeutral.Indifference, new List<string> {
                "(￣ω￣;)", "σ(￣、￣〃)"
            }},
            { eNeutral.Surprice, new List<string> {
                "ヽ(ー_ー )ノ", "ヽ(´ー` )┌"
            }},
        };

        public static readonly Dictionary<eVarious, List<string>> Various = new Dictionary<eVarious, List<string>>
        {
            { eVarious.Apologizing, new List<string> {
                "" 
            }},
            { eVarious.Greeting, new List<string> {
                ""
            }},
            { eVarious.Hiding, new List<string> {
                ""
            }},
            { eVarious.Hugging, new List<string> {
                ""
            }},
            { eVarious.Nosebleeding, new List<string> {
                ""
            }},
            { eVarious.Running, new List<string> {
                ""
            }},
            { eVarious.Sleeping, new List<string> {
                ""
            }},
            { eVarious.Winking, new List<string> {
                ""
            }},
            { eVarious.Writing, new List<string> {
                ""
            }},
        };

        public static readonly Dictionary<eAnimals, List<string>> Animals = new Dictionary<eAnimals, List<string>>
        {
            { eAnimals.Bear, new List<string> {
                ""
            }},
            { eAnimals.Bird, new List<string> {
                ""
            }},
            { eAnimals.Cat, new List<string> {
                ""
            }},
            { eAnimals.Dog, new List<string> {
                ""
            }},
            { eAnimals.Fish, new List<string> {
                ""
            }},
            { eAnimals.Pig, new List<string> {
                ""
            }},
            { eAnimals.Rabbit, new List<string> {
                ""
            }},
            { eAnimals.Spider, new List<string> {
                ""
            }},
        };

        public static readonly Dictionary<eOther, List<string>> Other = new Dictionary<eOther, List<string>>
        {
            { eOther.Enemies, new List<string> {
                ""
            }},
            { eOther.Faces, new List<string> {
                ""
            }},
            { eOther.Food, new List<string> {
                ""
            }},
            { eOther.Friends, new List<string> {
                ""
            }},
            { eOther.Games, new List<string> {
                ""
            }},
            { eOther.Magic, new List<string> {
                ""
            }},
            { eOther.Music, new List<string> {
                ""
            }},
            { eOther.Special, new List<string> {
                ""
            }},
            { eOther.Weapons, new List<string> {
                ""
            }},
        };
    }
}
