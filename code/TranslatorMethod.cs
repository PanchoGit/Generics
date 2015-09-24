using Generics.Entity;

namespace Generics
{
    public class TranslatorMethod
    {
        public TModel Translate<T, TModel>(T entity) 
            where TModel : IEntity, new()
        {
            var model = new TModel { Id = 0 };

            return model;
        }
    }
}
