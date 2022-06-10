using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class MergeArray
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 15, 14, 11, 12 };
            int[] b = { 8, 9, 10, 11, 15 };
            int[] c = new int[a.Length + b.Length];
            int k = 0;
            for(int i=0;i<a.Length;i++)
            {
                c[k] = a[i];
                k++;
            }
            for(int i=0;i<b.Length;i++)
            {
                c[k] = b[i];
                k++;
            }
            for(int i=0;i<c.Length;i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
