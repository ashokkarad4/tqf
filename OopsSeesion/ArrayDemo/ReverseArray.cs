using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class ReverseArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44, 55 };
            Console.WriteLine(String.Join(" ",a));
            Console.WriteLine("...........................");
          /*  for(int i=a.Length-1;i>=0;i--)
            {
                Console.WriteLine(a[i]+" ");
            }
            Console.WriteLine("......................");
            Console.WriteLine(String.Join(" ",a));*/
            int j = a.Length - 1;

            for(int i=0;i<a.Length/2;i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;
            }
            Console.WriteLine("/////////////////////////");

            for(int i=0;i<a.Length;i++)
            {
                Console.WriteLine(" "+a[i]);
            }
        }
    }
}
