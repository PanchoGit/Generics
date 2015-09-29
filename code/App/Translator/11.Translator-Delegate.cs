using Generics.Entity;

namespace Generics.Translator
{
    public class TranslatorDelegate<T>
    {
        public delegate void GenericDelegate(T entity);

        public void DoSomething(T entity)
        {
        }
    }

    public class TranslatorDelegateProcess
    {
        public TranslatorDelegateProcess()
        {
            ISkaterEntity entity = new SkaterEntity();

            var class1 = new TranslatorDelegate<ISkaterEntity>();

            TranslatorDelegate<ISkaterEntity>.GenericDelegate methodPointered = class1.DoSomething;

            methodPointered(entity);
        }
    }
}
