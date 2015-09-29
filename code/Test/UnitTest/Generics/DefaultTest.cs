using System;
using System.Collections.Generic;
using Generics.Model;

using NUnit.Framework;

namespace UnitTest.Generics
{
    public class DefaultTest
    {
        [Test]
        public void ShouldSuccessfullyBeDefault()
        {
            var actualInt = default(int);
            Assert.AreEqual(0, actualInt);

            var actualBool = default(bool);
            Assert.AreEqual(false, actualBool);

            var actualDate = default(DateTime);
            Assert.AreEqual(DateTime.MinValue, actualDate);

            var actualInNullable = default(int?);
            Assert.AreEqual(null, actualInNullable);


            var actualObject = default(object);
            Assert.AreEqual(null, actualObject);

            var actualClass = default(SkaterModel);
            Assert.AreEqual(null, actualClass);

            var actualList = default(List<int>);
            Assert.AreEqual(null, actualList);
        }
    }
}
