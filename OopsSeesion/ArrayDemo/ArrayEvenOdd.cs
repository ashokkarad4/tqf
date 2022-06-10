using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class ArrayEvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Array Size");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[size];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    Console.WriteLine("Even Number"+a[i]);
                }
            }
            Console.WriteLine("/////////////////////////");
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2!=0)
                {
                    Console.WriteLine($"Odd Number{a[i]}");
                }
            }
        }
    }
}
