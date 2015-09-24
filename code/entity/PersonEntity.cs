namespace Generics.entity
{
    public class PersonEntity : IEntity, IPersonEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
