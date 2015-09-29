namespace Generics.Factory
{
    // NO
    //public class GenericInheritance<T> : T {}
    
    // SI
    public class FactoryStructExtended<T> : FactoryStruct<T> where T : struct
    {
    }

    public class AnotherExtended<T1, T2> where T1 : T2 where T2 : new()
    {
    }

    // NO
    //public class Inception<T1, T2> where T1 : T2 where T2 : T1
}
