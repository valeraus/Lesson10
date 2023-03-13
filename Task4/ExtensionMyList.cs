using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    static class ExtensionMyList
    {
        public static T[] GetArray<T>(this MyList<T> list)
        {
            var temp = new T[list.Lenght];
            for (int i = 0; i < list.Lenght; i++)
            {
                temp[i] = list[i];
            }
            return temp;
        }
    }
}
