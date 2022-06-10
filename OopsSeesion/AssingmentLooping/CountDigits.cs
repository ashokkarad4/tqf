using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingmentLooping
{
    class CountDigits
    {
        static void Main(string[] args)
        {
            int num, count = 0;
            Console.WriteLine("Enter The Number");
            num = Convert.ToInt32(Console.ReadLine());
            while (num > 0)
            {
                num = num / 10;
                int r = num % 10;
                count++;
            }
            Console.WriteLine(count);

        }
    }
    }

