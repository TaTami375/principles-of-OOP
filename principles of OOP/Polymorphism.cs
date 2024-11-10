using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace principles_of_OOP
{
    internal class Polymorphism
    {
        public class Animal
        {
            public virtual void MakeSound()
            {
                Console.WriteLine("Некое животное издает некий звук.");
            }
        }

        public class Dog : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Гав! Гав!");
            }
        }

        public class Cat : Animal
        {
            public override void MakeSound()
            {
                Console.WriteLine("Мяу! Мяу!");
            }
        }

        //public class Program
        //{
        //    public static void Main()
        //    {
        //        Animal myDog = new Dog();
        //        Animal myCat = new Cat();
        //        myDog.MakeSound();  // Output: Woof! Woof!
        //        myCat.MakeSound();  // Output: Meow! Meow!
        //    }
        //}
    }
}
