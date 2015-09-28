using System;
using System.Collections.Generic;

namespace Generics.Factory
{
    //public class GenericInheritance<T> : T {}
    
    public class FactoryExtended<T> : FactoryStruct<T> where T : struct
    {
    }

    public class FactoryExtended2<T1, T2> where T1 : T2
    {
        public void Add(T1 t1, T2 t2)
        {
            //var result = t1 + t2;
        }
    }
}
