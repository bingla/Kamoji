using Kamoji.Helpers;
using Kamoji.Interfaces;
using Kamoji.Internals;

namespace Kamoji.Services
{
    public class KamojiService : IKamojiService
    {
        public string Positive(ePositive type)
        {
            return KamojiHelper.Positive(type);
        }

        public string Negative(eNegative type)
        {
            return KamojiHelper.Negative(type);
        }

        public string Neutral(eNeutral type)
        {
            return KamojiHelper.Neutral(type);
        }

        public string Various(eVarious type)
        {
            return KamojiHelper.Various(type);
        }

        public string Animals(eAnimals type)
        {
            return KamojiHelper.Animals(type);
        }

        public string Other(eOther type)
        {
            return KamojiHelper.Other(type);
        }
    }
}
