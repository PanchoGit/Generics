using System;
using Generics.Entity;

namespace Generics.Data
{
    //Derivation Constraint
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
            return 1;
        }
    }

    //Derivation Constraint
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
            return 1;
        }
    }
}
