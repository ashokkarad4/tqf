using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Logic
{
    
    class FibonacciSeries
    {
        static int fibbo(int n)
        {
            int a = 0, b = 1;
            int c;
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(a+" ");
                
                c = a + b;
                a = b;
                b = c;
            }
            return a;
        }
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fibo term");
            int n = int.Parse(Console.ReadLine());
           int term= fibbo(n);
            Console.WriteLine(term);
        }
    }
}
