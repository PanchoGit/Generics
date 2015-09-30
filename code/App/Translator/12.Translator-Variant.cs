using System;
using Generics.Entity;
using Generics.Model;

namespace Generics.Translator
{
    public interface IOut<out T> { }

    public interface IIn<in T> { }

    public class OutCat : IOut<AnimalCat> { }

    public class OutAnimal : IOut<Animal> { }

    public class InCat : IIn<AnimalCat> { }

    public class InAnimal : IIn<Animal> { }

    public interface ITranslator<out T, in TModel, out T2>
    {
        T Translate(TModel model);
        
        T2 TranslateToo(TModel model);
    }

    public class Translator : ITranslator<IPersonEntity, ISkaterModel, ISoccerPlayerModel>
    {
        public IPersonEntity Translate(ISkaterModel model)
        {
            return new PersonEntity();
        }

        public ISoccerPlayerModel TranslateToo(ISkaterModel model)
        {
            return new SoccerPlayerModel();
        }
    }

    public static class Methods
    {
        public static Animal CatIn_AnimalOut(AnimalCat item)
        {
            return new Animal();
        }

        public static AnimalCat CatIn_CatOut(AnimalCat item)
        {
            return new AnimalCat();
        }

        public static Animal AnimalIn_AnimalOut(Animal item)
        {
            return new Animal();
        }

        public static AnimalCat AnimalIn_CatOut(Animal item)
        {
            return new AnimalCat();
        }
    }

    public class GenericDelegateWithVariances
    {
        public static void BindMethods()
        {
            // Bind.
            Func<AnimalCat, Animal> AnimalCatIn_AnimalOut1 = Methods.CatIn_AnimalOut;

            // Covariance.
            Func<AnimalCat, Animal> AnimalCatIn_AnimalOut2 = Methods.CatIn_CatOut;

            // Contravariance.
            Func<AnimalCat, Animal> AnimalCatIn_AnimalOut3 = Methods.AnimalIn_AnimalOut;

            // Covariance and contravariance.
            Func<AnimalCat, Animal> AnimalCatIn_AnimalOut4 = Methods.AnimalIn_CatOut;
        }
    }
}
