using Generics.Operator;
using Xunit;

namespace UnitTest.Generics
{
    public class GenericsOperatorTest
    {
        [Fact]
        public void ShouldSuccessfullyOperator()
        {
            var value1 = new GenericsWithOperator<TipoNah>(new TipoNah("He-Man"));

            var value2 = new GenericsWithOperator<TipoNah>(new TipoNah("She-Ra"));

            var actual = value1 + value2;

            Assert.Equal("He-Man.She-Ra", actual);
        }
    }
}
