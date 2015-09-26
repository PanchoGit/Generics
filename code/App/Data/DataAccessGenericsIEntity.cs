using System;
using Generics.Entity;

namespace Generics.Data
{
    public class DataAccessGenericsIEntity<T> where T : IEntity
    {
        public T Save(T entity)
        {
            var entityModify = entity as IEntityModify;
            if (entityModify != null)
            {
                entityModify.Modify = DateTime.Now;
            }
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
