using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal a1 = new Animal();
            a1.Talk();
            a1.Sing();
            a1.Greet();

            Animal a2 = new Dog();
            a2.Talk();
            a2.Sing();
            a2.Greet();


            Console.ReadLine();

        }
    }

    class Animal
    {
        public Animal()
        {
            Console.WriteLine("Animal constructor");
        }
        public void Greet()
        {
            Console.WriteLine("Animal says Hello");
        }
        public void Talk()
        {
            Console.WriteLine("Animal talk");
        }
        public virtual void Sing()
        {
            Console.WriteLine("Animal song");
        }
    }

    class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog constructor");
        }
        public new void Talk()
        {
            Console.WriteLine("Dog talk");
        }
        public override void Sing()
        {
            Console.WriteLine("Dog song");
        }
    }
}
