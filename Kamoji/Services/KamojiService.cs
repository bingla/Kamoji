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
    }
}
