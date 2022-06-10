using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Animal
    {
        public int legs = 4;
    }
    class cat : Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }
    class SingleInheritance1
    {
        static void Main(string[] args)
        {
            cat c = new cat();
            c.show();

        }
    }
}
