using Kamoji.Interfaces;
using Kamoji.Internals;
using Kamoji.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Kamoji.Test
{
    [TestClass]
    public class KamojiTest
    {
        private readonly Mock<IRandomizer> _randomizer;

        public KamojiTest()
        {
            _randomizer = new Mock<IRandomizer>();
            _randomizer.Setup(r => r.Next(0)).Returns(0);
        }

        [TestMethod]
        public void ShouldReturnPositiveCategory()
        {
            IKamojiService kamoji = new KamojiService(_randomizer.Object);

            var embarrassement = kamoji.Positive(ePositive.Embarrassement);
            var joy = kamoji.Positive(ePositive.Joy);
            var love = kamoji.Positive(ePositive.Love);
            var sympathy = kamoji.Positive(ePositive.Sympathy);

            Assert.AreEqual(Emoji.Positive[ePositive.Embarrassement][0], embarrassement);
            Assert.AreEqual(Emoji.Positive[ePositive.Joy][0], joy);
            Assert.AreEqual(Emoji.Positive[ePositive.Love][0], love);
            Assert.AreEqual(Emoji.Positive[ePositive.Sympathy][0], sympathy);
        }

        [TestMethod]
        public void ShouldReturnNegativeCategory()
        {
            IKamojiService kamoji = new KamojiService(_randomizer.Object);

            var anger = kamoji.Negative(eNegative.Anger);
            var dissatisfaction = kamoji.Negative(eNegative.Dissatisfaction);
            var fear = kamoji.Negative(eNegative.Fear);
            var pain = kamoji.Negative(eNegative.Pain);
            var sadness = kamoji.Negative(eNegative.Sadness);

            Assert.AreEqual(Emoji.Negative[eNegative.Anger][0], anger);
            Assert.AreEqual(Emoji.Negative[eNegative.Dissatisfaction][0], dissatisfaction);
            Assert.AreEqual(Emoji.Negative[eNegative.Fear][0], fear);
            Assert.AreEqual(Emoji.Negative[eNegative.Pain][0], pain);
            Assert.AreEqual(Emoji.Negative[eNegative.Sadness][0], sadness);
        }
    }
}
