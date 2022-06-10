using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    class Logic1
    {
        static void Main(string[] args)
        {
            //o/p 3,7,11,15
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int sum = 0;
            for(int i=0;i<=a.Length;i=i+2)
            {
                sum = a[i] + a[i + 1];
                Console.WriteLine(sum);
            }
        }
    }
}
