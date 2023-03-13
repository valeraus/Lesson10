using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application.
    Створіть клас MyDictionary <TKey, TValue>. Реалізуйте в найпростішому наближенні можливість використання 
    його примірника аналогічно примірнику класу Dictionary (Урок 6 приклад 5). 
    Мінімально необхідний інтерфейс взаємодії з екземпляром, повинен включати метод додавання пар елементів, 
    індексатор для отримання значення елемента за вказаною індексу 
    і властивість тільки для читання для отримання загальної кількості пар елементів.
     */
    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть розмір словника:");
            int n = Convert.ToInt32(Console.ReadLine());

            var dictionary = new MyDictionary<string, string>(n);

            for (int i = 0; i < n; i++)
            {
                dictionary.Add(i, "стіл", "table");
            }

            Console.WriteLine(new string('-', 20));

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(dictionary[i]);
            }

            Console.WriteLine(new string('-', 20));

            Console.WriteLine(dictionary[0]);
            Console.WriteLine(dictionary.Lenght);

            // Delay.
            Console.ReadKey();
        }
    }
}
