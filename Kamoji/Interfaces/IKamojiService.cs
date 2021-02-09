using Kamoji.Internals;

namespace Kamoji.Interfaces
{
    public interface IKamojiService
    {
        string Negative(eNegative type);
        string Positive(ePositive type);
    }
}
