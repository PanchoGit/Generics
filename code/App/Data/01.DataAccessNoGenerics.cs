using System;
using Generics.Entity;

namespace Generics.Data
{
    // Non-generic class
    public class DataAccessNoGenerics
    {
        public object Save(object entity)
        {
            var entityModify = entity as IEntityModify;
            if (entityModify != null)
            {
                entityModify.Modify = DateTime.Now;
            }
            
            var id = ProcessSave(entity);

            var entityId = entity as IEntity;
            if (entityId != null)
            {
                entityId.Id = id;
            }

            return entity;
        }

        public object SaveWithReflection(object entity)
        {
            var entityType = entity.GetType();

            if (entityType.GetProperty("Modify") != null)
            {
                var property = entityType.GetProperty("Modify");
                property.SetValue(entity, DateTime.Now);
            }
            
            var id = ProcessSave(entity);

            if (entityType.GetProperty("id") != null)
            {
                var property = entityType.GetProperty("id");
                property.SetValue(entity, id);
            }

            return entity;
        }

        private int ProcessSave(object entity)
        {
            return 1;
        }
    }
}
