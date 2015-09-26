using System;

namespace Generics.Entity
{
    public interface IEntityModify
    {
        DateTime Modify { get; set; }

        DateTime Registry { get; set; }
    }
}
