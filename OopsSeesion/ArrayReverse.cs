using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion
{
    class ArrayReverse
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter array size");
            int num = int.Parse(Console.ReadLine());
            int[] a = new int[num];
            Console.WriteLine("Enter Array Element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=a.Length-1;i>=0;i--)

            {
                Console.WriteLine(a[i]+" ");
            }
        }
    }
}
