using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class Replacing_NegativeValues
    {
        static void Main(string[] args)
        {
            int[] p = { 12, -6, 4, 85, -5, 2 };
            Console.WriteLine(String.Join(",",p));
            int square = 1;
            for(int i=0;i<p.Length;i++)
            {
                if(p[i]<0)
                {
                    p[i] = p[i - 1] * p[i - 1];
                }
            }
            Console.WriteLine(".............................");
            Console.WriteLine(String.Join(" ",p));
        }
    }
}
