using Generics.Model;

namespace Generics.Entity
{
    public interface ISkaterEntity : IPersonModel
    {
        string Stance { get; set; }
    }
}
