using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    static class StaticMethod
    {
        public static void calculate(int a,int b)
        {
            Console.WriteLine("Sum="+(a+b));
        }
        public static void calculate(double x,double y)
        {
            Console.WriteLine("Sub" + (x - y));
        }
    }
    class StaticMethodOverload
    {
        static void Main(string[] args)
        {
            StaticMethod.calculate(4, 6);
            StaticMethod.calculate(9.4, 4.4);
        }
    }
}
