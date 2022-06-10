using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class ReverseArray1
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join(" ",a));
            Console.WriteLine("..................");
            for(int i=a.Length-1;i>=0; i--)
            {
                Console.WriteLine(a[i]+" ");
            }

        }
    }
}
