using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test3
{
    class FizzBuzzQue13
    {
        static void Main(string[] args)
        {
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;
            for (int i = 1; i <= 50; i++)
            {
                if (i % 3 == 0 && i%5==0)
                {
                    
                    Console.WriteLine("fizzbuzz"+" ");
                    count1++;
                    
                }
                else if (i % 3  == 0)
                {
                    
                    Console.WriteLine("buzz"+" ");
                    count2++;
                }
                else if(i%5==0)
                {
                    
                    Console.WriteLine("Fizz"+" ");
                    count3++;
                }
                else
                {
                    Console.WriteLine(i+" ");
                }
            }
            Console.WriteLine("fizzbuzz"+count1);
            Console.WriteLine("buzz"+count2);
            Console.WriteLine("Fizz"+count3);
        }
    }
}
