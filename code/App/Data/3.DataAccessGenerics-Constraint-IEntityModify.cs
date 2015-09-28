using System;
using Generics.Entity;

namespace Generics.Data
{
    public class DataAccessGenericsIEntityModify<T> where T : IEntity, IEntityModify
    {
        public T Save(T entity)
        {
            entity.Modify = DateTime.Now;
            entity.Id = ProcessSave(entity);
            return entity;
        }

        private int ProcessSave(T entity)
        {
            // process entity
            return 1;
        }
    }
}
