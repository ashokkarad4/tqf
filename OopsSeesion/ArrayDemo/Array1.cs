using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class Array1
    {
        static void Main(string[] args)
        {
            int[] a = { 4, -3, 6, -2, -5 };
       
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<0)
                {
                    a[i] = a[i] * a[i];
                }
                Console.WriteLine(a[i]);
            }
        }
    }
}
