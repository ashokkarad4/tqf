using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Inheritance
{
    class Bird
    {
        public string color="Green" ;
        public void a1()
        { Console.WriteLine("Hiii"); }
    }
    class Parrot : Bird
    {
        public void nikhil(int a)
        {
            Console.WriteLine(color);
        }
    }
    class SingleEx1
    {
        static void Main(string[] args)
        {
            Parrot p = new Parrot();
            p.nikhil(5);
            p.a1();

        }
    }
}
