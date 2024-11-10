using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Task2
    {
        public static T FindMin<T>(T[] array) where T : IComparable<T>
        {
            if (array == null || array.Length == 0)
            {
                throw new ArgumentException("Array cannot be null or empty.");
            }

            T min = array[0];
            foreach (T item in array)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }
            return min;
        }
    }
}
