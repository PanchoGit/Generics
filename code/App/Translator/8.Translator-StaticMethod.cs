using System;

using Generics.Entity;

namespace Generics.Translator
{
    //Generic Class + Generic Static Method
    public class TranslatorStaticMethod<T>
    {
        //Generic Static Method
        public static T2 AnotherMethod<T2>(T t, T2 t2)
        {
            return t2;
        }

        //Non-Generic Method
        public static T OneMethod(T t)
        {
            return default(T);
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
