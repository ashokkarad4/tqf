using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.MethodOverRiding
{
    class Mobile
    {
        public virtual void display()
        {
            Console.WriteLine("This is Mobile");
        }
    }
    class Samsung : Mobile
    {
        public override void display()
        {
            Console.WriteLine("This is Samsung Mobile");
        }
    }
    class Apple:Mobile
    {
        public override void display()
        {
            Console.WriteLine("This is Apple Mobile");
        }
    }
    class MobileOverRide
    {
        static void Main(string[] args)
        {
            Mobile m = new Samsung();
            m.display();
            Mobile m1 = new Apple();
            m1.display();

        }
    }
}
