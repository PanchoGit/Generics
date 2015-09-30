namespace Generics.Operator
{
    //Generic Static Method + operator
    public class GenericsWithOperator<T>
    {
        public T Element { get; set; }

        public GenericsWithOperator(T element)
        {
            Element = element;
        }

        public static string operator +(GenericsWithOperator<T> value1, GenericsWithOperator<T> value2)
        {
            return string.Format("{0}.{1}", value1.Element, value2.Element);
        }
    }

    public class TipoNah
    {
        public string Name { get; set; }

        public TipoNah(string name)
        {
            Name = name;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
