using Kamoji.Interfaces;
using Kamoji.Internals;
using Kamoji.Services;
using Moq;
using Xunit;

namespace Kamoji.Test
{
    public class KamojiTest_Positive
    {
        private Mock<IRandomizer> _randomizer;

        public KamojiTest_Positive()
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
    }
}
