using System;
using System.Collections.Generic;
using Generics.Model;
using Xunit;

namespace UnitTest
{
    public class DefaultTest
    {
        [Fact]
        public void ShouldSuccessfullyBeDefault()
        {
            var actualInt = default(int);
            Assert.Equal(0, actualInt);

            var actualBool = default(bool);
            Assert.Equal(false, actualBool);

            var actualDate = default(DateTime);
            Assert.Equal(DateTime.MinValue, actualDate);

            var actualInNullable = default(int?);
            Assert.Equal(null, actualInNullable);


            var actualObject = default(object);
            Assert.Equal(null, actualObject);

            var actualClass = default(SkaterModel);
            Assert.Equal(null, actualClass);

            var actualList = default(List<int>);
            Assert.Equal(null, actualList);
        }
    }
}
