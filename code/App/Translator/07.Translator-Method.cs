using Generics.Entity;

namespace Generics.Translator
{
    // Non-generic class
    public class TranslatorMethod
    {
        //Generic Method
        public TModel Translate<T, TModel>(T entity) 
            where TModel : IEntity, new()
        {
            return new TModel { Id = 0 };
        }

        //Generic Static Method
        public static TModel TranslateThis<T, TModel>(T entity)
            where TModel : IEntity, new()
        {
            return new TModel { Id = 0 };
        }
    }
}
