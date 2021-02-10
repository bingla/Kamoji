using Kamoji.Interfaces;
using Kamoji.Internals;
using Kamoji.Services;
using Moq;
using Xunit;

namespace Kamoji.Test
{
    public class KamojiTest
    {
        private Mock<IRandomizer> _randomizer;

        public KamojiTest()
        {
            _randomizer = new Mock<IRandomizer>();
            _randomizer.Setup(r => r.Next(0)).Returns(0);
        }

        [Fact]
        public void ShouldReturnPositiveCategory()
        {
            IKamojiService kamoji = new KamojiService(_randomizer.Object);

            var embarrassement = kamoji.Positive(ePositive.Embarrassement);
            var joy = kamoji.Positive(ePositive.Joy);
            var love = kamoji.Positive(ePositive.Love);
            var sympathy = kamoji.Positive(ePositive.Sympathy);


            Assert.Equal(Emoji.Positive[ePositive.Embarrassement][0], embarrassement);
            Assert.Equal(Emoji.Positive[ePositive.Joy][0], joy);
            Assert.Equal(Emoji.Positive[ePositive.Love][0], love);
            Assert.Equal(Emoji.Positive[ePositive.Sympathy][0], sympathy);
        }

        [Fact]
        public void ShouldReturnNegativeCategory()
        {
            IKamojiService kamoji = new KamojiService(_randomizer.Object);

            var anger = kamoji.Negative(eNegative.Anger);
            var dissatisfaction = kamoji.Negative(eNegative.Dissatisfaction);
            var fear = kamoji.Negative(eNegative.Fear);
            var pain = kamoji.Negative(eNegative.Pain);
            var sadness = kamoji.Negative(eNegative.Sadness);

            Assert.Equal(Emoji.Negative[eNegative.Anger][0], anger);
            Assert.Equal(Emoji.Negative[eNegative.Dissatisfaction][0], dissatisfaction);
            Assert.Equal(Emoji.Negative[eNegative.Fear][0], fear);
            Assert.Equal(Emoji.Negative[eNegative.Pain][0], pain);
            Assert.Equal(Emoji.Negative[eNegative.Sadness][0], sadness);
        }
    }
}
