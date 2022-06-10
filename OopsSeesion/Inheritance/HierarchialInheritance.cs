using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Fruit
    {
        public void fruit()
        {
            Console.WriteLine("There are different types of fruits");
        }
    }
    class Mango : Fruit
    {
        public void mango()
        {
            Console.WriteLine("Mango is Green");
        }
    }
    class Banana:Fruit
    {
       public void banana()
        {
            Console.WriteLine("Banaan is yellow");
        }
    }
    class Apple:Fruit
    {
        public void apple()
        {
            Console.WriteLine("Apple is Red");
        }
    }
    class HierarchialInheritance
    {
        static void Main(string[] args)
        {
            Mango m = new Mango();
            m.mango();
            Banana b = new Banana();
            b.banana();
            Apple a = new Apple();
            a.apple();
        }
    }
}
