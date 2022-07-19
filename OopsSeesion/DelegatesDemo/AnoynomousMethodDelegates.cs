using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.DelegatesDemo
{
    public delegate void mydelegate3(int x, int y);

    class AnoynomousMethodDelegates
    {
        
        
            //Anoynomous method
            static void Main(string[] args)
            {
                mydelegate3 d1 = delegate (int a, int b)                                                                                                //instead of creating a method inside class above directly create a method inside main method
                {
                    Console.WriteLine("Addition=" + (a + b));
                };
                d1(10, 20);
            }
        
    }
}
