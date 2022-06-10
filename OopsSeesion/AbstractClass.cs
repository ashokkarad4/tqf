using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    abstract class AAA
    {
        public abstract void Add(int a,int b);
    }
    class BBB : AAA
    {
        public override void Add(int a,int b)
        {
            Console.WriteLine("addition is="+(a+b));
        }
    }
    class AbstractClass
    {
        static void Main(string[] args)
        {
            AAA a = new BBB();
            a.Add(5, 5);
        }
    }
}
