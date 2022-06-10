using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.MethodOverRiding
{
    class Bird
    {
        public virtual void eat()
        {
            Console.WriteLine("Bird Is Eating");
        }
    }
    class Sparrow:Bird
    {
        public override void eat()
        {
            Console.WriteLine("Sparrow is Eating");
        }
    }
    class Overriding1
    {
        static void Main(string[] args)
        {
            /* Sparrow s = new Sparrow();
             s.eat();*/
            Bird b = new Bird();
            b.eat();
        }
    }
}
