using Generics.Operator;

using NUnit.Framework;

namespace UnitTest.Generics
{
    public class GenericsOperatorTest
    {
        [Test]
        public void ShouldSuccessfullyOperator()
        {
            var value1 = new GenericsWithOperator<TipoNah>(new TipoNah("He-Man"));

            var value2 = new GenericsWithOperator<TipoNah>(new TipoNah("She-Ra"));

            var actual = value1 + value2;

            Assert.AreEqual("He-Man.She-Ra", actual);
        }
    }
}
