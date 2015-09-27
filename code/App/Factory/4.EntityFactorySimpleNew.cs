using Generics.Entity;

namespace Generics.Factory
{
    public class EntityFactory<T> where T : new()
    {
        public T CreateElement()
        {
            return new T();
        }
    }

    public class SkateEntityFactory : EntityFactory<SkaterEntity> //SkaterEntity posee un constructor público
    {
        public SkaterEntity CreateSkater()
        {
            return CreateElement();
        }
    }
}
