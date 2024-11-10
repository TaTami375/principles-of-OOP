using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    internal class Task1
    {
        public class Pair<T, U>
        {
            private T first;
            private U second;

            public Pair(T first, U second)
            {
                this.first = first;
                this.second = second;
            }

            public T GetFirst() => first;
            public U GetSecond() => second;

            public void SetFirst(T value) => first = value;
            public void SetSecond(U value) => second = value;

            public override string ToString()
            {
                return $"Pair: ({first}, {second})";
            }
        }
    }
}
