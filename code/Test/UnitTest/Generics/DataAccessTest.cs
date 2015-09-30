using System;
using Generics.Data;
using Generics.Entity;
using NUnit.Framework;

namespace UnitTest.Generics
{
    public class DataAccessTest
    {
        [Test]
        public void ShouldSuccessfullySaveEntity()
        {
            var item = new SkaterEntity();

            var sut = new DataAccessNoGenerics();
            sut.Save(item);

            Assert.AreEqual(1, item.Id);
            Assert.AreEqual(DateTime.Now.ToString("d"), item.Modify.ToString("d"));
        }

        [Test]
        public void ShouldSuccessfullySaveObject()
        {
            var item = new Stone();

            var sut = new DataAccessNoGenerics();
            sut.Save(item);

            Assert.AreEqual(0, item.Id);
        }

        [Test]
        public void ShouldSuccessfullySaveWithGeneric()
        {
            var item = new SkaterEntity();

            var sut = new DataAccessGenericsIEntity<SkaterEntity>();
            sut.Save(item);

            Assert.AreEqual(1, item.Id);
            Assert.AreEqual(DateTime.Now.ToString("d"), item.Modify.ToString("d"));
        }
    }
}
