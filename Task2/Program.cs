using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{

    /*
    Використовуючи Visual Studio, створіть проект за шаблоном Console Application. 
    Створіть клас MyList. 
    Реалізуйте у найпростішому наближенні можливість використання його екземпляра аналогічно екземпляру класу List. 
    Мінімально необхідний інтерфейс взаємодії з екземпляром повинен включати метод додавання елемента (Add), 
    індексатор для отримання значення елемента за вказаним індексом (T) і властивість тільки для читання 
    для отримання загальної кількості елементів(Count).
     */
    public interface IMyList<T>
    {
        void Add(T a);
        T this[int index] { get; }
        int Count { get; }
        void Clear();
        bool Contains(T item);
    }
    public class MyList<T> : IMyList<T>
    {
        private T[] array;

        public MyList()
        {
            array = new T[0];
        }

        public void Add(T a)
        {
            T[] tempArray = new T[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                tempArray[i] = array[i];
            }
            tempArray[array.Length] = a;
            array = tempArray;
        }

        public T this[int index]
        {
            get { return array[index]; }
        }

        public int Count
        {
            get { return array.Length; }
        }

        public void Clear()
        {
            array = new T[0];
        }

        public bool Contains(T item)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if ((int)(object)array[i] == (int)(object)item)
                {
                    return true;
                }
            }
            return false;
        }
        public override string ToString()
        {
            string stroka = null;
            for (int i = 0; i < array.Length; i++)
            {
                stroka += array[i] + " ";
            }
            return "Розмір масиву " + array.Length + " Елементи масиву: " + stroka;
        }
    }

    internal class Program
    {
        static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Введіть розмір масиву:");
            string str = Console.ReadLine();
            int u = string.IsNullOrEmpty(str) ? 0 : Convert.ToInt32(str);

            var list = new MyList<int>();

            var t = new Random();
            for (int x = 0; x < u; x++)
            {
                list.Add(t.Next(100));
            }

            Console.WriteLine("Перший елемент: {0}, кількість елементів: {1}",list[0],list.Count);

            Console.WriteLine("Масив елементів:");
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 30));


            Console.WriteLine("Введіть значення для пошуку:");
            if (list.Contains(Convert.ToInt32(Console.ReadLine())))
            {
                Console.WriteLine("Введене значення знаходиться в масиві");
            }
            else
            {
                Console.WriteLine("Значення не знайдено!");
            }

            //Delay
            Console.ReadKey();

        }
    }
}
