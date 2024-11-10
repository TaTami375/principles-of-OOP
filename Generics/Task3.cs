using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Task3
    {
        public class Repository<T> where T : class
        {
            private List<T> items = new List<T>();

            public void Add(T item)
            {
                items.Add(item);
            }

            public T Get(int index)
            {
                if (index < 0 || index >= items.Count)
                {
                    throw new IndexOutOfRangeException("Index out of range.");
                }
                return items[index];
            }
        }
    }
}
