namespace Generics.Model
{
    public class SoccerPlayerModel : IModel, ISoccerPlayerModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Team { get; set; }
    }
}
