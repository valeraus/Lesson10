using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddTask
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас MyClass <T>, що містить статичний фабричний метод - T FacrotyMethod (), 
    який буде породжувати екземпляри типу, зазначеного в якості параметра типу (покажчика місця заповнення типом - Т).
     */
    class MyClass<T> where T : new()
    {
        public static T FacrotyMethod()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main()
        {
            int i = MyClass<int>.FacrotyMethod();

            Console.WriteLine(i.GetType().Name);

            Program p = MyClass<Program>.FacrotyMethod();

            Console.WriteLine(p.GetType().Name);

            Console.ReadKey();
        }
    }
}
