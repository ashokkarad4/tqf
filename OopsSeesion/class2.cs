using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class Airtmatic
    {
        public void add(int a,int b)
        {
            Console.WriteLine("Addi="+(a+b));
        }
        public void add(int a,float b)
        {
            Console.WriteLine("Add="+(a+b));
        }
        int add(long a,long b)
        {
            Console.WriteLine("Addition="+(a+b));
            return 0;
        }
        
        

    }
    class class2
    {
        static void Main(string[] args)
        {
            Airthmatic a = new Airthmatic();
            a.add(10,20);
            a.add(10, 20.5f);
            a.add(154, 154);
        }
    }
}
