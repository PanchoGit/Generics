namespace Generics.Translator
{
    public interface ITranslator<out T, in TModel>
    {
        T Translate(TModel model);
    }
}
