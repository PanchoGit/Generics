using System;

namespace Generics.Entity
{
    public class SkaterEntity : IEntity, ISkaterEntity, IEntityModify
    {
        public SkaterEntity()
        {
            Name = "Tipo Nah";
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public string Stance { get; set; }

        public string Brand { get; set; }

        public DateTime Modify { get; set; }

        public DateTime Registry { get; set; }
    }
}
