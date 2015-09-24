namespace Generics
{
    public interface ITranslator<out T, in TModel>
    {
        T Translate(TModel model);
    }
}
