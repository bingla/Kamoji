using Kamoji.Interfaces;
using Kamoji.Internals;
using Kamoji.Services;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Kamoji.Test
{
    public class KamojiTest_Neutral
    {
        private Mock<IRandomizer> _randomizer;

        public KamojiTest_Neutral()
        {
            _randomizer = new Mock<IRandomizer>();
            _randomizer.Setup(r => r.Next(0)).Returns(0);
        }

        [Fact]
        public void ShouldReturnNeutralCategory()
        {
            IKamojiService kamoji = new KamojiService(_randomizer.Object);

            var confusion = kamoji.Neutral(eNeutral.Confusion);
            var doubt = kamoji.Neutral(eNeutral.Doubt);
            var indifference = kamoji.Neutral(eNeutral.Indifference);
            var surprice = kamoji.Neutral(eNeutral.Surprice);

            Assert.Equal(Emoji.Neutral[eNeutral.Confusion][0], confusion);
            Assert.Equal(Emoji.Neutral[eNeutral.Doubt][0], doubt);
            Assert.Equal(Emoji.Neutral[eNeutral.Indifference][0], indifference);
            Assert.Equal(Emoji.Neutral[eNeutral.Surprice][0], surprice);
        }
    }
}
