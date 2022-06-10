using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class CountNumberEvenOdd
    {
        static void Main(string[] args)
        {
            int cEven = 0, cOdd = 0;
            Console.WriteLine("Enter the Array Size");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];
            Console.WriteLine("Enter Array Element");
            for(int i=0;i<a.Length;i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]%2==0)
                {
                    cEven++;
                }
                else
                {
                    cOdd++;
                }
            }
            Console.WriteLine("Even ="+cEven);
            Console.WriteLine("Odd ="+cOdd);

        }
    }
}
