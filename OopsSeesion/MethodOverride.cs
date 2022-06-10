using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
   
    class A
    {
        public virtual void add(int a,int b)
        {
            Console.WriteLine(a + b);
        }

    }
    class B : A
    {
        public override void add(int a,int b)
        {
            Console.WriteLine("Addition is="+(a+b));
        }
    }
    class MethodOverride
    {
        static void Main(string[] args)
        {
            A a = new B();
            a.add(5, 5);
        }
     
        
    }
}
