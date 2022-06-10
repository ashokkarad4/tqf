using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Oops
{
    static class StaClass
    {
        static int x = 15;
        public static void display()
        {
            Console.WriteLine(x);
        }
    }
    class StaticDemo
    {
        static int a = 5, b = 5;
        public StaticDemo()
        {
            int sum = a + b;
            Console.WriteLine("Sum="+sum);
            int mul = a * b;
            Console.WriteLine("Mul="+mul);

        }

        
        static void Main(string[] args)
        {
            StaticDemo s = new StaticDemo();
            /* Console.WriteLine(StaticDemo.a);
             Console.WriteLine(StaticDemo.b);*/
            Console.WriteLine(a);
            Console.WriteLine(b);
            StaClass.display();
         



        }
    }
}
