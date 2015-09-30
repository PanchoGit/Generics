using Generics.Entity;

namespace Generics.Factory
{
    //Constructor Constraint
    public class EntityFactory<T> where T : new()
    {
        public T CreateElement()
        {
            return new T();
        }
    }

    //SkaterEntity posee un constructor público
    public class SkateEntityFactory : EntityFactory<SkaterEntity>
    {
        public SkaterEntity CreateSkater()
        {
            return CreateElement();
        }
    }
}
