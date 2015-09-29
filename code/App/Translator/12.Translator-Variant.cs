using Generics.Entity;
using Generics.Model;

namespace Generics.Translator
{
    public interface ITranslator<out T, in TModel>
    {
        T Translate(TModel model);
    }

    public class Translator : ITranslator<IPersonModel, ISkaterModel>
    {
        public IPersonModel Translate(ISkaterModel model)
        {
            var person = new PersonModel { Name = model.Name };

            return model;
        }
    }

    public class ProcessTranslator
    {
        public ProcessTranslator()
        {
            Animal[] persons = new Animal[4];

            persons[0] = new Animal();
            persons[1] = new AnimalCat();
            persons[2] = new AnimalPerson();
            //persons[3] = new Stone();

            var person = (AnimalPerson)persons[0];
        }
    }
}
