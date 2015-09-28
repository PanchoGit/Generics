using Generics.Entity;

namespace Generics.Factory
{
    public class EntityFactoryByElement<T> where T : new()
    {
        public T CreateElement(ElementType elementType)
        {
            T element;
            switch (elementType)
            {
                case ElementType.Skater:
                    element = new T();
                    break;
                default:
                    element = default(T);
                    break;
            }
            return element;
        }
    }

    public class PersonEntityFactoryByElemen : EntityFactoryByElement<PersonEntity>
    {
        public PersonEntity CreatePerson()
        {
            return CreateElement(ElementType.Person);
        }
    }

    public class SkaterEntityFactoryByElemen : EntityFactoryByElement<SkaterEntity>
    {
        public SkaterEntity CreateSkater()
        {
            return CreateElement(ElementType.Skater);
        }
    }

    public class SoccerPlayerEntityFactoryByElemen : EntityFactoryByElement<SoccerPlayerEntity>
    {
        public SoccerPlayerEntity CreateSoccerPlayer()
        {
            return CreateElement(ElementType.SoccerPlayer);
        }
    }
}
