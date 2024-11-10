using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Task5
    {
        public interface IStorage<T>
        {
            void Add(T item);
            T Get(int index);
        }

        public class ListStorage<T> : IStorage<T>
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
