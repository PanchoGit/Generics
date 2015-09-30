using Generics.Entity;
using Generics.Translator;
using NUnit.Framework;

namespace UnitTest.Generics
{
    public class TranslatorGenericVariant
    {
        [Test]
        public void ShouldSuccessFullyCovariance()
        {
            var outCat = new OutCat();

            var outAnimal = new OutAnimal();

            Assert.IsInstanceOf<IOut<Animal>>(outCat);
        }

        [Test]
        public void ShouldSuccessFullyContravariance()
        {
            var inCat = new InCat();

            var inAnimal = new InAnimal();

            Assert.IsInstanceOf<IIn<AnimalCat>>(inAnimal);
        }
    }
}
