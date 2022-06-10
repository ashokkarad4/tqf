using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.Test2
{
    class Class1
    {
        static void Main(string[] args)
        {
            int num, sum = 0;
            Console.WriteLine("Enter The Number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                int r = num % 10;
                sum = sum + r;
                num = num / 10;
            }
            Console.WriteLine(sum);

        }
    }
}
