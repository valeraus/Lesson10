using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть розширює метод: public static T [] GetArray <T> (this MyList <T> list)
    Застосуйте розширює метод до примірника типу MyList <T>, розробленим в домашньому завданні 2 для даного уроку. 
    Виведіть на екран значення елементів масиву, який повернув розширює метод GetArray ().
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть розмір масиву:");
            int u = Convert.ToInt32(Console.ReadLine());

            var list = new MyList<int>(u);

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(x, t.Next(100));
            }

            Console.WriteLine("Масив");
            int[] f = list.GetArray();   // використання розширюючого методу

            for (int i = 0; i < f.Length; i++)
            {
                Console.Write("{0} ", f[i]);
            }

            Console.WriteLine();
            Console.WriteLine("Довжина масива: {0}", list.Lenght);

            // Delay.
            Console.ReadKey();
        }
    }
}
