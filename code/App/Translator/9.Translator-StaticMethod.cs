using System;

using Generics.Entity;

namespace Generics.Translator
{
    public class TranslatorStaticMethod<T>
    {
        public static T OneMethod(T t)
        {
            return default(T);
        }

        public static T2 AnotherMethod<T2>(T t, T2 t2)
        {
            return t2;
        }
    }

    public class TranslatorStaticWithOperator<T, TK>
    {
        public static bool operator +(TranslatorStaticWithOperator<T, TK> value1, TK value2)
        {
            return true;
        }
    }

    public class ProcessTranslatorStaticMethod
    {
        public ProcessTranslatorStaticMethod()
        {
            var intResult = TranslatorStaticMethod<int>.OneMethod(1);

            var dateTimeResult = TranslatorStaticMethod<DateTime>.OneMethod(DateTime.Now);

            var playerResult = TranslatorStaticMethod<SoccerPlayerEntity>.OneMethod(new SoccerPlayerEntity{ Id = 1, Name = "Route94" });

            var anotherResult = TranslatorStaticMethod<SoccerPlayerEntity>.AnotherMethod(new SoccerPlayerEntity(),"Luan");
        }
    }
}
