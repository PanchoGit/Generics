using System;

namespace Generics.Factory
{
    //Value Type Constraint
    public class FactoryStruct<T> where T : struct
    {
        public T Create()
        {
            return default(T);
        }
    }

    public class DateTimeFactory : FactoryStruct<DateTime>
    {
        public DateTime CreateDateTime()
        {
            return Create();
        }
    }

    public class NumberFactory : FactoryStruct<int>
    {
        public int CreateInt()
        {
            return Create();
        }
    }

#if NotCompile //SkaterEntity es un reference
    public class SkateFactory : FactoryStruct<SkaterEntity>
    {
        public SkaterEntity CreateSkater()
        {
            return Create();
        }
    }
#endif
}
