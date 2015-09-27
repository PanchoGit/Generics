namespace Generics.Factory
{
    //public class GenericInheritance<T> : T {}
    
    public class FactoryExtended<T> : FactoryStruct<T> where T : struct
    {
    }
}
