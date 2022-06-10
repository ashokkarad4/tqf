using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Vehicle
    {
        public int wheeler = 4;
    }
    class Car:Vehicle
    {
        public void show()
        {
            Console.WriteLine(wheeler);
        }
    }
    class SingleEx2
    {
        static void Main(string[] args)
        {
            Car c = new Car();
            c.show();
        }
    }
}
