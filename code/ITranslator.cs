namespace Generics
{
    public interface ITranslator<out T, in TModel>
    {
        T TranslateToPerson(TModel model);
    }
}
