using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.ArrayDemo
{
    class MaxElementsArray
    {
        static void Main(string[] args)
        {
            char[] a = { 'd', 'f', 'g', 'r', 'e' };
            char max = a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(max<a[i])
                {
                    max = a[i];
                }
            }
            Console.WriteLine("Max Is "+max);
           
        }
    }
}
