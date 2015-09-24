using Generics.entity;
using Generics.model;

namespace Generics
{
    public class Translator : ITranslator<IPersonModel, ISkaterModel>
    {
        public TModel Translate<T, TModel>(T entity) where TModel : IEntity, new()
        {
            var model = default(TModel);

            model.Id = 0;

            return model;
        }

        public IPersonModel TranslateToPerson(ISkaterModel model)
        {
            var person = default(IPersonModel); //?????

            person = new PersonModel();

            person.Name = model.Name;

            return model;
        }
    }
}
