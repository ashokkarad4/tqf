using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class SumOfArrayElements
    {
        static void Main(string[] args)
        { 

            int sum = 0;
            Console.WriteLine("Enter Array Size");
            int n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter Array Elements");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = int.Parse(Console.ReadLine());
            }
            for(int i=0;i<a.Length;i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine($"Sum of array elements={sum}");
        }
    }
}
