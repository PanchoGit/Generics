namespace Generics.Factory
{
#if NotCompile
    public class GenericInheritance<T> : T {}
#endif
    
    public class FactoryStructExtended<T> : FactoryStruct<T> where T : struct
    {
    }

    public class AnotherExtended<T1, T2> where T1 : T2 where T2 : new()
    {
    }

#if NotCompile
    public class Inception<T1, T2> where T1 : T2 where T2 : T1
#endif
}
