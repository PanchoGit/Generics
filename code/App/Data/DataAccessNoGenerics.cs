using System;

namespace Generics.Data
{
    public class DataAccessNoGenerics
    {
        public object Save(object entity)
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
            // process entity
            return 1;
        }
    }
}
