namespace Generics.Model
{
    public class SkaterModel : IModel, IPersonModel, ISkaterModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Stance { get; set; }

        public string Brand { get; set; }
    }
}
