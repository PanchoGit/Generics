using System;
using Generics.Entity;

namespace Generics.Factory
{
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

    /*
     * SkaterEntity no es un struct es un class que puede ser nullable
    public class SkateFactory : FactoryStruct<SkaterEntity>
    {
        public SkaterEntity CreateSkater()
        {
            return Create();
        }
    }*/
}
