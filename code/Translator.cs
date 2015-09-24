using Generics.Model;

namespace Generics
{
    public class Translator : ITranslator<IPersonModel, ISkaterModel>
    {
        public IPersonModel Translate(ISkaterModel model)
        {
            var person = new PersonModel { Name = model.Name };

            return model;
        }
    }
}
