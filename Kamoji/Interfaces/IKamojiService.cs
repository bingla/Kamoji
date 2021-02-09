using Kamoji.Internals;

namespace Kamoji.Interfaces
{
    public interface IKamojiService
    {
        string Animals(eAnimals type);
        string Negative(eNegative type);
        string Neutral(eNeutral type);
        string Other(eOther type);
        string Positive(ePositive type);
        string Various(eVarious type);
    }
}
