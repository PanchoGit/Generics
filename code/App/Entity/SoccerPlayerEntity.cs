namespace Generics.Entity
{
    public class SoccerPlayerEntity : IEntity, ISoccerPlayerEntity
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }
    }
}
