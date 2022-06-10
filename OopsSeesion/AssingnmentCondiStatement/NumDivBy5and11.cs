using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class NumDivBy5and11
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());

            if ((num % 5 == 0) && (num % 11 == 0))
            {
                Console.WriteLine(" Divisible by 5 and 11");
            }
            else
            {
                Console.WriteLine("Not Divisible by 5 and 11");
            }
        }
    }
}
