namespace Generics.Model
{
    public class PersonModel : IModel, IPersonModel
    {
        public int Id { get; set; }

        public string Name { get; set; }
    }
}
