using System;
using System.Collections.Generic;
using System.Linq;

using Generics.Entity;
using Generics.Model;
using Generics.Translator;

using NUnit.Framework;

namespace UnitTest.Generics
{
    public class TranslatorVariantTest
    {
        [Test]
        public void ShouldSuccessfullyTranslate()
        {
            var sut = new Translator();

            var skater = new SkaterModel { Id = 1, Name = "Luan Oliveira", Brand = "Flip", Stance = "Goofy" };

            var actual = sut.Translate(skater);

            Assert.NotNull(actual);
        }

        [Test]
        public void ShouldSuccessfullyCovariant()
        {
            Animal[] persons = new Animal[4];

            persons[0] = new Animal();
            persons[1] = new AnimalCat();
            persons[2] = new AnimalPerson();

            var person = (AnimalPerson)persons[2];

            Assert.IsAssignableFrom<AnimalPerson>(person);
            Assert.IsNotAssignableFrom<Animal>(person);

            List<Animal> personsList = new List<Animal>();

            personsList.Add(new Animal());
            personsList.Add(new AnimalCat());
            personsList.Add(new AnimalPerson());

            var personListItem = personsList.Last();

            Assert.IsAssignableFrom<AnimalPerson>(personListItem);
            Assert.IsNotAssignableFrom<Animal>(personListItem);
        }

        [Test]
        public void ShouldFailCovariant()
        {
            Animal[] cats = new AnimalCat[3];

            cats[0] = new AnimalCat { Name = "Tigrus" };
            cats[1] = new AnimalCat { Name = "Garfield" };

            Assert.Throws<ArrayTypeMismatchException>(() => { cats[2] = new AnimalPerson(); });

            var cat = cats[1];

            Assert.IsAssignableFrom<AnimalCat>(cat);
            Assert.IsNotAssignableFrom<Animal>(cat);

        #if NotCompilable
            AnimalCat[] otherCats = new Animal[2];

            therCats[0] = new Animal();

            List<AnimalCat> otherCatsList = new List<Animal>();
        #endif
        }
    }
}
