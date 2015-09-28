using Generics.Entity;

namespace Generics.Translator
{
    public class TranslatorMethod
    {
        public TModel Translate<T, TModel>(T entity) 
            where TModel : IEntity, new()
        {
            return new TModel { Id = 0 };
        }

        public static TModel TranslateThis<T, TModel>(T entity)
            where TModel : IEntity, new()
        {
            return new TModel { Id = 0 };
        }
    }
}
