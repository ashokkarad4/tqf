using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Animal1
    {
       public void sound()
        {
            Console.WriteLine("Animal Sound");
        }
    }
    class Dog : Animal1
    {
       public void bark()
        {
            Console.WriteLine("Dog is Barking");
        }
    }
    class BabyDog : Dog
    {
       public void weep()
        {
            Console.WriteLine("BabyDog Sound Weeping");
        }
    }
    class MultilevelInheritance1
    {
        static void Main(string[] args)
        {
            BabyDog b = new BabyDog();
            b.sound();
            b.bark();
            b.weep();
        }
    }
}
