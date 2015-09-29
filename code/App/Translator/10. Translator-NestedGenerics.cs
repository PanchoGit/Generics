using Generics.Entity;

namespace Generics.Translator
{
    //Nested Generics
    public class GlobalTranslator<T>
    {
        public void Do(T entity)
        {
        }

        public class NestedTranslator<T2>
        {
            public void Do(T data1, T2 data2)
            {
            }

            public NestedTranslator(T2 entity)
            {
            }
        }
    }

    public class ProcessGlobalTranslator
    {
        public ProcessGlobalTranslator()
        {
            var a = new GlobalTranslator<SkaterEntity>.NestedTranslator<SoccerPlayerEntity>(new SoccerPlayerEntity());
            a.Do(new SkaterEntity(), new SoccerPlayerEntity());

            var b = new GlobalTranslator<int>.NestedTranslator<PersonEntity>(new PersonEntity());
            b.Do(1, new PersonEntity());
        }
    }
}
