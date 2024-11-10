using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_SOLID
{
    internal class LiskovSubstitutionPrinciple
    {
        public abstract class Bird
        {
            public abstract void Eat();

            // Метод для полета
            public virtual void Fly()
            {
                Console.WriteLine("В полёте...");
            }
        }

        public class Sparrow : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("Воробей хавает.");
            }

            public override void Fly()
            {
                Console.WriteLine("Воробей летает.");
            }
        }

        public class Penguin : Bird
        {
            public override void Eat()
            {
                Console.WriteLine("Пингвин хавает.");
            }

            // Переопределяем, чтобы указать, что пингвин не летает
            public override void Fly()
            {
                throw new NotImplementedException("Бро, пингвин не летает...");
            }
        }
    }
}
