using Kamoji.Helpers;
using Kamoji.Internals;
using Xunit;

namespace Kamoji.Test
{
    public class KamojiTest_Helper
    {
        [Fact]
        public void ShouldReturnRandomPositive()
        {
            var embarrassement = Emoji.Positive[ePositive.Embarrassement];
            var joy = Emoji.Positive[ePositive.Joy];
            var love = Emoji.Positive[ePositive.Love];
            var sympathy = Emoji.Positive[ePositive.Sympathy];

            Assert.Contains(KamojiHelper.Positive(ePositive.Embarrassement), embarrassement);
            Assert.Contains(KamojiHelper.Positive(ePositive.Joy), joy);
            Assert.Contains(KamojiHelper.Positive(ePositive.Love), love);
            Assert.Contains(KamojiHelper.Positive(ePositive.Sympathy), sympathy);
        }

        [Fact]
        public void ShouldReturnRandomNegative()
        {
            var anger = Emoji.Negative[eNegative.Anger];
            var dissatisfaction = Emoji.Negative[eNegative.Dissatisfaction];
            var fear = Emoji.Negative[eNegative.Fear];
            var pain = Emoji.Negative[eNegative.Pain];
            var sadness = Emoji.Negative[eNegative.Sadness];

            Assert.Contains(KamojiHelper.Negative(eNegative.Anger), anger);
            Assert.Contains(KamojiHelper.Negative(eNegative.Dissatisfaction), dissatisfaction);
            Assert.Contains(KamojiHelper.Negative(eNegative.Fear), fear);
            Assert.Contains(KamojiHelper.Negative(eNegative.Pain), pain);
            Assert.Contains(KamojiHelper.Negative(eNegative.Sadness), sadness);
        }
    }
}
