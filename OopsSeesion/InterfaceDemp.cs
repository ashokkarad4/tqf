using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
   interface A1
    {
        void Add(int a,int b);
    }
    interface B1
    {
        void Sub(int a,int b);
    }
    class Airthmatic1 : A1, B1
    {
       

        public void Add(int a, int b)
        {
            Console.WriteLine("Add="+(a+b));        
        }

        public void Sub(int a,int b)
        {
            Console.WriteLine("Sub is="+(a-b));
        }
    }
    class InterfaceDemp
    {
        static void Main(string[] args)
        {
            Airthmatic1 a = new Airthmatic1();
            a.Add(15, 15);
            a.Sub(12, 6);
        }
    }
}
