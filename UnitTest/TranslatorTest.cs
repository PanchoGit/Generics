using Generics;
using Generics.Model;

using Xunit;

namespace UnitTest
{
    public class TranslatorTest
    {
        [Fact]
        public void ShouldSuccessfullyTranslate()
        {
            var sut = new Translator();

            var skater = new SkaterModel { Id = 1, Name = "Luan Oliveira", Brand = "Flip", Stance = "Goofy" };

            var actual = sut.Translate(skater);

            Assert.NotNull(actual);
        }
    }
}
