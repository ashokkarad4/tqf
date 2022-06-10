using System;
using System.Collections.Generic;
using System.Text;

namespace OopsSeesion.AssingnmentCondiStatement
{
    class PosNegZero
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter Number");
            num = int.Parse(Console.ReadLine());
            if(num>0)
            {
                Console.WriteLine("Positive");
            }
            else if(num<0)
            {
                Console.WriteLine("Negative");
            }
            else
                Console.WriteLine("Zero");
        }
    }
}
