using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class ProductOfDigit
    {
        static void Main(string[] args)
        {
            int num, temp;
            int product = 1;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            while(num!=0)
            {
                product = product * (num % 10);
                num = num / 10;
            }
            Console.WriteLine("Product Of Number="+product);
        }
    }
}
