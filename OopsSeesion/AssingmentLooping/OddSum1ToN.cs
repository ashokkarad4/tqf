using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class OddSum1ToN
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter Number");
            n = int.Parse(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(i%2!=0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine("Sum of Odd Number= "+sum);
        }
    }
}
