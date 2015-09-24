namespace Generics.Entity
{
    public class SkaterEntity : IEntity, IPersonEntity
    {
        public SkaterEntity()
        {
            Name = "Tipo Nah";
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Stance { get; set; }

        public string Brand { get; set; }
    }
}
