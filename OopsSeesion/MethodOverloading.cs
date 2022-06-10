using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Airthmatic
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Additin" + (a + b));
        }
        public void add(float a,float b)
        {
            Console.WriteLine("Addition of Float"+(a+b));
        }
        public void add(int a,float b)
        {
            Console.WriteLine("Addition of two"+(a+b));
        }
    }
    class MethodOverloading
    {
        static void Main(string[] args)
        {
            Airthmatic a = new Airthmatic();
            a.add(5, 5);
            a.add(5.4f, 4.6f);
            a.add(5,8.4f);
        }
    }
}
